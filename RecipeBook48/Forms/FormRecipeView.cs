using MetroFramework.Components;
using MetroFramework.Forms;

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RecipeBook48
{
    public partial class FormRecipeView : MetroForm
    {
        MetroForm backForm;
        Recipe recipe;
        SqlConnection connection;

        public FormRecipeView(MetroStyleManager manager, MetroForm form, Recipe recipe, SqlConnection connection)
        {
            InitializeComponent();
            SetUpStyle(manager);
            this.backForm = form;
            this.recipe = recipe;
            this.connection = connection;
        }

        private void ThisFormLoad(object sender, EventArgs e)
        {
            LabelAuthorText.Text = this.recipe.RecipeAuthor;
            LabelCategoryText.Text = this.recipe.RecipeCategory;
            string difficulty = this.recipe.RecipeDifficulty;
            
            LabelDifficultyText.Text = difficulty;
            LabelTimeText.Text = this.recipe.RecipeTime.ToString() + " minut";

            this.Text = recipe.RecipeName;

            PictureRecipe.Image = RecipeImages.LoadImageFromURL(recipe.RecipeImageURL, PictureRecipe.Size);

            List<string> recipeSteps = SqlSelectCommands.SelectRecipeSteps(connection, recipe.RecipeID);

            for (int i = 1; i <= recipeSteps.Count; i++)
            {
                TextBoxSteps.AppendText($"{i}. " + recipeSteps[i-1] + Environment.NewLine);
            }

            List<Tuple<string, string, string>> recipeIngredients = SqlSelectCommands.SelectRecipeIngredients(connection, recipe.RecipeID);

            for (int i = 0; i < recipeIngredients.Count; i++)
            {
                TextBoxIngredients.AppendText(recipeIngredients[i].Item3 + " " + recipeIngredients[i].Item2 + " - ");
                TextBoxIngredients.AppendText(recipeIngredients[i].Item1 + Environment.NewLine);
            }
        }

        private void ThisFormClosing(object sender, FormClosingEventArgs e)
        {
            backForm.Show();
        }
    }
}
