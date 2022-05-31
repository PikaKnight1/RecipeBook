using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Components;

namespace RecipeBook48
{
    public partial class FormWelcome : MetroForm
    {
        public FormWelcome(MetroStyleManager manager)
        {
            InitializeComponent();
            SetUpStyle(manager);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }


        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            FormRecipeList form = new FormRecipeList(this.styleManager, this);

            form.Show();
            this.Hide();

            this.Cursor = Cursors.Default;
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            FormRecipeView frw = new FormRecipeView(this.styleManager, this);
            frw.Show();
        }

        private void TileSetUp_Click(object sender, EventArgs e)
        {
            FormSettings form = new FormSettings(this.styleManager, this);
            form.Show();
            this.Hide();
        }

        private void FormWelcome_FormClosing(object sender, FormClosingEventArgs e)
        {
        
        }
    }
}
