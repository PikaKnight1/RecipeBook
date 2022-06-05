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
        public SqlConnection connection;
        public FormWelcome(MetroStyleManager manager)
        {
            InitializeComponent();
            SetUpStyle(manager);

            JsonSerializing.ReadSqlSettings(ref connection);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
              //todo
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
            FormRecipeView frw = new FormRecipeView(this.styleManager, this, new Recipe());
            frw.Show();
        }

        private void TileSetUp_Click(object sender, EventArgs e)
        {
            FormSettings form = new FormSettings(this.styleManager, this);
            form.Show();
            this.Hide();
        }

        private void TileAddRecipe_Click(object sender, EventArgs e)
        {
            FormCreateEdit form = new FormCreateEdit(this.styleManager, this);
            form.Show();
            this.Hide();
        }
    }
}
