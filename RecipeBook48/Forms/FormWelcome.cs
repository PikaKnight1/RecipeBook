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
using MetroFramework;

namespace RecipeBook48
{
    public partial class FormWelcome : MetroForm
    {
        internal SqlConnection connection;
        public FormWelcome(MetroStyleManager manager)
        {
            InitializeComponent();
            SetUpStyle(manager);

            JsonSerializing.ReadSqlSettings(ref connection);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
             if(!connection.TestSqlConnection())
            {
                MetroMessageBox.Show(this, "Wystąpił błąd podczas łączenia z bazą! Sprawdź ustawienia.", "Test połączenia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TileRecipeListClick(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            FormRecipeList form = new FormRecipeList(this.styleManager, this);

            form.Show();
            this.Hide();

            this.Cursor = Cursors.Default;
        }

        private void TileRandomRecipeClick(object sender, EventArgs e)
        {
            FormRecipeView frw = new FormRecipeView(this.styleManager, this, SqlSelectCommands.SelectRandomRecipe(connection), connection);
            frw.Show();
            this.Hide();
        }

        private void TileSetUpClick(object sender, EventArgs e)
        {
            FormSettings form = new FormSettings(this.styleManager, this);
            form.Show();
            this.Hide();
        }

        private void TileAddRecipeClick(object sender, EventArgs e)
        {
            FormCreateEdit form = new FormCreateEdit(this.styleManager, this);
            form.Show();
            this.Hide();
        }
    }
}
