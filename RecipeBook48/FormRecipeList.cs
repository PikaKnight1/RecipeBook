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

        public FormRecipeList(MetroStyleManager manager, FormWelcome form)
        {
            InitializeComponent();
            SetUpStyle(manager);

            this.form = form;
        }

        bool wrongURL()
        {
            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Recipe> recipes = Recipe.LoadTopRecipes();
            

            foreach (var recipe in recipes)
            {
                Image image = Image.Load
                MetroTile tile = new MetroTile();
                tile.Text = recipe.RecipeName;
                tile.UseTileImage = true;
                WebClient web = new WebClient();

                var webImage = web.DownloadData(recipe.RecipeImageURL);
                var streamImage = new MemoryStream(webImage);
                var downloadedImage = Bitmap.FromStream(streamImage);
                var image = (Image)new Bitmap(downloadedImage, new Size(256,144));

                // Image image = (Image)bmpImage;

                //    Image.FromStream(streamImage);
                // Image image = (Image)(new Bitmap(Image.FromFile(recipe.RecipeImageURL), new Size(256, 144)));

                tile.TileImage = downloadedImage;
                tile.Click += ButtonClick;
                tile.StyleManager = styleManager;

                flowLayoutPanel1.Controls.Add(tile);

                flowLayoutPanel1.Refresh();
            }
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            form.Show();
            this.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
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

        private void TextBoxSearch_Click(object sender, EventArgs e)
        {
            TextBoxSearch.SelectAll();
        }

        private void FormMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.Show();
        }
    }
}
