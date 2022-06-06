using MetroFramework.Components;
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
        readonly FormAdminPanelMain formAdmin;
        readonly Recipe loadingRecipe;
        public FormCreateEdit(MetroStyleManager manager, FormWelcome form)
        {
            InitializeComponent();
            SetUpStyle(manager);

            this.form = form;
            ButtonSend.Click += new System.EventHandler(this.ButtonSendClick);
        }
        public FormCreateEdit(MetroStyleManager manager, FormAdminPanelMain form, Recipe recipe)
        {
            InitializeComponent();
            SetUpStyle(manager);
            this.formAdmin = form;
            this.ButtonSend.Click += new System.EventHandler(this.ButtonSendClickUpdate);
            this.Text = "Edytuj przepis";
            this.loadingRecipe = recipe;
            LoadRecipe(recipe);
        }
        private void LoadRecipe(Recipe recipe)
        {
            this.TextBoxAuthor.Text = recipe.RecipeAuthor;
            this.TextBoxRecName.Text = recipe.RecipeName;
            this.TextBoxPhoto.Text = recipe.RecipeImageURL;
            switch (recipe.RecipeDifficulty)
            {
                case "Łatwy":
                    this.RadioBtnEasy.Checked = true;
                    break;
                case "Średni":
                    this.RadioBtnMed.Checked = true;
                    break;
                case "Trudny":
                    this.RadioBtnHard.Checked = true;
                    break;
            }

            this.TextBoxTime.Text = recipe.RecipeTime.ToString();
            this.ComboBoxCategory.SelectedIndex = this.ComboBoxCategory.Items.IndexOf(recipe.RecipeCategory);

            List<string> recipeSteps = SqlSelectCommands.SelectRecipeSteps(formAdmin.connection, recipe.RecipeID);
            List<Tuple<string, string, string>> recipeIng = SqlSelectCommands.SelectRecipeIngredients(formAdmin.connection, recipe.RecipeID);

            foreach (var step in recipeSteps)
            {
                GridSteps.Rows.Add();
                GridSteps.Rows[GridSteps.Rows.Count - 1].Cells[0].Value = step;
            }

            foreach (var tuple in recipeIng)
            {
                GridIng.Rows.Add();
                GridIng.Rows[GridIng.Rows.Count - 1].Cells[0].Value = tuple.Item1;
                GridIng.Rows[GridIng.Rows.Count - 1].Cells[1].Value = tuple.Item3;
                GridIng.Rows[GridIng.Rows.Count - 1].Cells[2].Value = tuple.Item2;
            }
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
                List<string> steps = GetSteps();

                List<Tuple<string, string, string>> ingredients = GetIngredients();

                SqlInsertCommands.InsertRecipe(recipe, form.connection);
                int lastId = SqlSelectCommands.GetLastRecipeId(form.connection);
                SqlInsertCommands.InsertSteps(steps, form.connection, lastId);
                SqlInsertCommands.InsertIngredients(ingredients, form.connection, lastId);

                this.Close();
            }
        }
        private void ButtonSendClickUpdate(object sender, EventArgs e)
        {
            if (VerifyEverything())
            {
                Recipe recipe = new Recipe(loadingRecipe.RecipeID, TextBoxRecName.Text, TextBoxPhoto.Text, GetSelectedItemDifficulty(), int.Parse(TextBoxTime.Text), TextBoxAuthor.Text, ComboBoxCategory.SelectedItem.ToString());
                List<string> steps = GetSteps();

                List<Tuple<string, string, string>> ingredients = GetIngredients();

                SqlUpdateDeleteCommands.UpdateRecipe(formAdmin.connection, recipe);
                SqlUpdateDeleteCommands.DeleteStepsAndIngredients(formAdmin.connection, recipe.RecipeID);
                SqlInsertCommands.InsertSteps(steps, formAdmin.connection, recipe.RecipeID);
                SqlInsertCommands.InsertIngredients(ingredients, formAdmin.connection, recipe.RecipeID);

                this.Close();
            }
        }
        private List<string> GetSteps()
        {
            List<string> steps = new List<string>();

            foreach (DataGridViewRow rows in GridSteps.Rows)
            {
                foreach (DataGridViewCell cell in rows.Cells)
                {
                    steps.Add((string)cell.Value);
                }
            }
            return steps;
        }
        private List<Tuple<string, string, string>> GetIngredients()
        {
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

            return ingredients;
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
            if (form is null)
            {
                formAdmin.Show();
            }
            else
            {
                form.Show();
            }
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
