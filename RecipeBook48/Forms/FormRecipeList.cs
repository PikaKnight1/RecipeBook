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
using System.Net;
using System.IO;


namespace RecipeBook48
{
    public partial class FormRecipeList : MetroForm
    {
        Size tileSize = new Size(256, 144);
        FormWelcome form;
        List<Recipe> recipes;

        public FormRecipeList(MetroStyleManager manager, FormWelcome form)
        {
            InitializeComponent();
            SetUpStyle(manager);
            this.form = form;
        }
        private void ThisFormLoad(object sender, EventArgs e)
        {
            recipes = SqlSelectCommands.SelectRecipesDefault(form.connection);
            LoadRecipes(recipes);
        }

        private void LoadRecipes(List<Recipe> recipes)
        {
            MainPanel.Controls.Clear();

            foreach (var recipe in recipes)
            {

                MetroTile tile = new MetroTile();
                tile.Text = recipe.RecipeName;
                tile.Name = recipe.RecipeID.ToString();
                tile.UseTileImage = true;
                tile.Click += ButtonRecipeClick;
                tile.StyleManager = styleManager;
                tile.Size = tileSize;
                tile.TileImage = RecipeImages.LoadImageFromURL(recipe.RecipeImageURL, tileSize);

                MainPanel.Controls.Add(tile);

                MainPanel.Refresh();
            }

        }

        private void ButtonRecipeClick(object sender, EventArgs e)
        {
            try
            {
                if (sender is MetroTile tile)
                {
                    var recipe = recipes.Where(i => i.RecipeID.ToString().Equals(tile.Name));
                    FormRecipeView formRecipeView = new FormRecipeView(this.styleManager, this, recipe.Last(), form.connection);
                    formRecipeView.Show();
                }
                this.Hide();
            }
            catch { };
        }

        private void ButtonRandomClick(object sender, EventArgs e)
        {
            FormRecipeView frw = new FormRecipeView(this.styleManager, this, SqlSelectCommands.SelectRandomRecipe(form.connection), form.connection);
            frw.Show();
            this.Hide();
        }

        private void TextBoxSearchClick(object sender, EventArgs e)
        {
            TextBoxSearch.SelectAll();
        }

        private void ThisFormClosing(object sender, FormClosingEventArgs e)
        {
            form.Show();
        }

        private void ButtonSortClick(object sender, EventArgs e)
        {
            //1, sprawdzam co wciśnięte
            var checkedSort = PanelSort.Controls.OfType<MetroRadioButton>().FirstOrDefault(r => r.Checked);
            var checkedTime = PanelTime.Controls.OfType<MetroRadioButton>().FirstOrDefault(r => r.Checked);
            var checkedDifficulty = PanelDifficulty.Controls.OfType<MetroRadioButton>().FirstOrDefault(r => r.Checked);
            var checkedCategory = PanelCategories.Controls.OfType<MetroRadioButton>().FirstOrDefault(r => r.Checked);

            //2. przekazuję wciśnięte i wyszukiwane dalej i niech się inna metoda tym martwi, chcę tylko listę przepisów
            recipes = SqlSelectCommands.SelectRecipesFiltered(form.connection, 
                                                             (checkedSort.Tag ?? string.Empty).ToString(), 
                                                             TextBoxSearch.Text, 
                                                             (checkedTime.Tag ?? string.Empty).ToString(), 
                                                             (checkedDifficulty.Tag ?? string.Empty).ToString(), 
                                                             (checkedCategory.Tag ?? string.Empty).ToString());

            LoadRecipes(recipes);
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            ButtonSortClick(sender, e);
        }
    }
}
