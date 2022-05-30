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
    public partial class FormRecipeList : MetroForm
    {
        FormWelcome form;

        public FormRecipeList(MetroStyleManager manager, FormWelcome form)
        {
            InitializeComponent();
            SetUpStyle(manager);

            this.form = form;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                MetroButton butt = new MetroButton();
                butt.BackgroundImage = Image.FromFile(@"C:\Users\pikak\Pictures\img.png");
                butt.Size = new Size(256, 144);
                butt.BackgroundImageLayout = ImageLayout.Stretch;
                butt.Click += Butt_Click;

                flowLayoutPanel1.Controls.Add(butt);
            }

        }

        private void Butt_Click(object sender, EventArgs e)
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
