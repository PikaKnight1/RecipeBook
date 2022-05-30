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
            FormRecipeList form = new FormRecipeList(this.styleManager, this);
            form.Show();
            this.Hide();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {

        }
    }
}
