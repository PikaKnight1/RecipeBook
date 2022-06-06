using MetroFramework;
using MetroFramework.Components;
using MetroFramework.Forms;

using System;
using System.Windows.Forms;

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

        private void ThisFormLoad(object sender, EventArgs e)
        {
            if (!connection.TestSqlConnection())
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
            FormRecipeView form = new FormRecipeView(this.styleManager, this, SqlSelectCommands.SelectRandomRecipe(connection), connection);
            form.Show();
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
