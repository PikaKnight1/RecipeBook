using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Components;
using MetroFramework.Forms;

namespace RecipeBook48
{
    public partial class FormCreateEdit : MetroForm
    {
        MetroForm form;
        public FormCreateEdit(MetroStyleManager manager, MetroForm form)
        {
            InitializeComponent();
            SetUpStyle(manager);

            this.form = form;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            GridIng.Rows.Add(TextBoxIngValue.Text, TextBoxIngName.Text, getSelectedItem());
            TextBoxIngValue.Text = "";
            TextBoxIngName.Text = "";
        }

        private string getSelectedItem()
        {
            if (RadioBtnTypeG.Checked) return RadioBtnTypeG.Text;
            if (RadioBtnTypeKG.Checked) return RadioBtnTypeKG.Text;
            if (RadioBtnTypeML.Checked) return RadioBtnTypeML.Text;
            if (RadioBtnTypeL.Checked) return RadioBtnTypeL.Text;
            if (RadioBtnTypeSZKL.Checked) return RadioBtnTypeSZKL.Text;
            if (RadioBtnTypeLYZ.Checked) return RadioBtnTypeLYZ.Text;
            if (RadioBtnTypeSZCZ.Checked) return RadioBtnTypeSZCZ.Text;
            if (RadioBtnTypeSZT.Checked) return RadioBtnTypeSZT.Text;

            return "nie zaznaczono jednostkki";
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            GridIng.SelectedRows.Clear();
        }

        private void TextBoxRecipeNameClick(object sender, EventArgs e)
        {
            TextBoxRecName.SelectAll();
        }

        private void TextBoxTimeClick(object sender, EventArgs e)
        {
            TextBoxTime.SelectAll();
        }

        private void TextBoxPhotoClick(object sender, EventArgs e)
        {
            TextBoxPhoto.SelectAll();
        }

        private void TextBoxPhotoTextChanged(object sender, EventArgs e)
        {
            Image image = RecipeImages.LoadImageFromURL(TextBoxPhoto.Text, PictureBoxPhoto.Size);
            PictureBoxPhoto.Image = image;
            this.Refresh();
        }

        private void TextBoxAddIng(object sender, EventArgs e)
        {
            TextBoxPhoto.SelectAll();
        }

        private void TextBoxIngValueClick(object sender, EventArgs e)
        {
            TextBoxIngValue.SelectAll();
        }

        private void TextBoxMakingClick(object sender, EventArgs e)
        {
            TextBoxStep.SelectAll();
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
                //sql wysłanie na serwer
                //this.Close();

                foreach(DataGridViewRow rows in GridSteps.Rows)
                {
                    foreach (DataGridViewCell cell in rows.Cells)
                    {
                        ErrorLabel.Text += cell.Value;
                    }
                }
            }
        }

        private bool VerifyEverything()
        {
            StringBuilder errorString = new StringBuilder();

            if (String.IsNullOrWhiteSpace(TextBoxRecName.Text))
            {
                errorString.AppendLine("Nie ustawiono nazwy przepisu.");
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

            if (RecipeImages.TestImageURL(TextBoxPhoto.Text))
            {
                errorString.AppendLine("Niepoprawne zdjęcie");
            }

            ErrorLabel.Text = errorString.ToString();
            return errorString.ToString().Length == 0;
        }

        private void FormCreateEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.Show();
        }
    }
}
