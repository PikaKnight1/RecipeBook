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
            recipes = Recipe.LoadTopRecipes();
            
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
                    FormRecipeView formRecipeView = new FormRecipeView(this.styleManager, this, recipe.Last());
                    formRecipeView.Show();
                }
                this.Hide();
            }
            catch { };
        }

        private void ButtonRandomClick(object sender, EventArgs e)
        {

            Random random = new Random();
            int i = random.Next(0, 14);

            if (styleManager.Theme == MetroFramework.MetroThemeStyle.Dark)
            {
                styleManager.Theme = MetroFramework.MetroThemeStyle.Light;
                styleManager.Style = (MetroFramework.MetroColorStyle)i;
            }
            else
            {
                styleManager.Theme = MetroFramework.MetroThemeStyle.Dark;
                styleManager.Style = (MetroFramework.MetroColorStyle)i;
            }
            this.Refresh();
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

        }
    }
}
