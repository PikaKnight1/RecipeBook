﻿using MetroFramework.Components;
using MetroFramework.Forms;
using MetroFramework.Controls;

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RecipeBook48
{
    public partial class FormCreateEdit : MetroForm
    {
        readonly FormWelcome form;
        public FormCreateEdit(MetroStyleManager manager, FormWelcome form)
        {
            InitializeComponent();
            SetUpStyle(manager);

            this.form = form;
        }

        private void ButtonAddIngriedent(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(TextBoxIngName.Text) && !String.IsNullOrWhiteSpace(TextBoxIngValue.Text))
            {
                GridIng.Rows.Add(TextBoxIngName.Text, TextBoxIngValue.Text, GetSelectedItemIngType());
                TextBoxIngValue.Text = "";
                TextBoxIngName.Text = "";
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Conajmniej jedna informacja jest pusta. Uzupełnij obie!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private string GetSelectedItemIngType()
        {
            var radioBtnChecked = PanelIngType.Controls.OfType<MetroRadioButton>().FirstOrDefault(r => r.Checked);
            return radioBtnChecked.Text;
        }

        private string GetSelectedItemDifficulty()
        {
            var radioBtnChecked = PanelDifficulty.Controls.OfType<MetroRadioButton>().FirstOrDefault(r => r.Checked);
            return radioBtnChecked.Text;
        }

        private void TextBoxClick(object sender, EventArgs e)
        {
            if (sender is MetroTextBox b)
            {
                b.SelectAll();
            }
        }
        private void TextBoxPhotoTextChanged(object sender, EventArgs e)
        {
            Image image = RecipeImages.LoadImageFromURL(TextBoxPhoto.Text, PictureBoxPhoto.Size);
            PictureBoxPhoto.Image = image;
            this.Refresh();
        }

        private void ButtonAddStepClick(object sender, EventArgs e)
        {
            GridSteps.Rows.Add(TextBoxStep.Text);
            TextBoxStep.Text = "";
        }

        private void ButtonSendClick(object sender, EventArgs e)
        {
            if (VerifyEverything())
            {
                Recipe recipe = new Recipe(TextBoxRecName.Text, TextBoxPhoto.Text, GetSelectedItemDifficulty(), int.Parse(TextBoxTime.Text), TextBoxAuthor.Text, ComboBoxCategory.SelectedItem.ToString());
                List<string> steps = new List<string>();

                foreach(DataGridViewRow rows in GridSteps.Rows)
                {
                    foreach (DataGridViewCell cell in rows.Cells)
                    {
                        steps.Add((string)cell.Value);
                    }
                }

                List<Tuple<string, string, string>> ingredients = new List<Tuple<string, string, string>>();
                foreach (DataGridViewRow rows in GridIng.Rows)
                {
                    if (rows.Cells[0].Value != null
                        && rows.Cells[1].Value != null
                        && rows.Cells[2].Value != null)
                    {
                        ingredients.Add(Tuple.Create((string)rows.Cells[0].Value, (string)rows.Cells[1].Value, (string)rows.Cells[2].Value));
                    }
                }

                SqlInsertCommands.InsertRecipe(recipe, form.connection);
                int lastId = SqlSelectCommands.GetLastRecipeId(form.connection);
                SqlInsertCommands.InsertSteps(steps, form.connection, lastId);
                SqlInsertCommands.InsertIngredients(ingredients, form.connection, lastId);

                this.Close();
            }
        }

        private bool VerifyEverything()
        {
            StringBuilder errorString = new StringBuilder();

            if (String.IsNullOrWhiteSpace(TextBoxRecName.Text))
            {
                errorString.AppendLine("Nie ustawiono nazwy przepisu.");
            }

            if (String.IsNullOrWhiteSpace(TextBoxAuthor.Text))
            {
                errorString.AppendLine("Nie ustawiono autora przepisu.");
            }

            if (String.IsNullOrWhiteSpace(TextBoxTime.Text))
            {
                errorString.AppendLine("Nie ustawiono czasu przygotowywania potrawy.");
            }

            if (ComboBoxCategory.SelectedIndex == -1)
            {
                errorString.AppendLine("Nie wybrano kategorii.");
            }

            if (String.IsNullOrWhiteSpace(TextBoxPhoto.Text))
            {
                errorString.AppendLine("Nie dodano linku do zdjęcia.");
            }

            if (!RecipeImages.TestImageURL(TextBoxPhoto.Text))
            {
                errorString.AppendLine("Niepoprawne zdjęcie");
            }

            if (!int.TryParse(TextBoxTime.Text, out int time))
            {
                errorString.AppendLine($"Zły format czasu - wprowadź liczbę całkowitą mniejszą od {int.MaxValue}");
            }
            else
            {
                if (time <= 0)
                {
                    errorString.AppendLine($"Zły format czasu - czas nie może być krótszy od 0");
                }
            }

            ErrorLabel.Text = errorString.ToString();
            return errorString.ToString().Length == 0;
        }

        private void FormCreateEditFormClosing(object sender, FormClosingEventArgs e)
        {
            form.Show();
        }

        private void TextBoxTimeTextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(TextBoxTime.Text, "[^0-9]"))
            {
                MetroFramework.MetroMessageBox.Show(this, "To nie liczba!", "Ostrzeżenie");
                TextBoxTime.Text = "";
            }
        }

        private void TextBoxIngValueTextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(TextBoxIngValue.Text, "[^0-9]"))
            {
                MetroFramework.MetroMessageBox.Show(this, "To nie liczba!", "Ostrzeżenie");
                TextBoxIngValue.Text = "";
            }
        }
    }
}
