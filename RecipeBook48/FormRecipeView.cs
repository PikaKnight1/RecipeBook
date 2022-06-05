using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using MetroFramework.Forms;
using MetroFramework.Components;

namespace RecipeBook48
{
    public partial class FormRecipeView : MetroForm
    {
        MetroForm backForm;
        Recipe recipe;

        public FormRecipeView(MetroStyleManager manager, MetroForm form, Recipe recipe)
        {
            InitializeComponent();
            SetUpStyle(manager);
            this.backForm = form;
            this.recipe = recipe;
        }

        private void ThisFormLoad(object sender, EventArgs e)
        {
            LabelAuthorText.Text = this.recipe.RecipeAuthor;
            LabelCategoryText.Text = this.recipe.RecipeCategory;
            string difficulty;
            switch (this.recipe.RecipeDifficulty)
            {
                case 0:
                    difficulty = "Łatwe";
                    break;
                case 1:
                    difficulty = "Średnie";
                    break;
                case 2:
                    difficulty = "Trudne";
                    break;
                default:
                    difficulty = "Wystąpił błąd...";
                   break;
            }

            LabelDifficultyText.Text = difficulty;
            LabelTimeText.Text = this.recipe.RecipeTime.ToString() + " minut";


            this.Text = recipe.RecipeName;

            PictureRecipe.Image = RecipeImages.LoadImageFromURL(recipe.RecipeImageURL, PictureRecipe.Size);


            for (int i = 0; i < 100; i++)
            {
                TextBoxIngredients.AppendText("Siemanko, witaj w mojej aplikacji, to tylko test tekstowy yyyy tekst testowy xD");
                TextBoxIngredients.AppendText(Environment.NewLine);
                TextBoxMaking.AppendText("Siemanko, witaj w mojej aplikacji, to tylko test tekstowy yyyy tekst testowy xD");
                TextBoxMaking.AppendText(Environment.NewLine);
            }
        }

        private void ThisFormClosing(object sender, FormClosingEventArgs e)
        {
            backForm.Show();
        }
    }
}
