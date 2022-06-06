using MetroFramework.Forms;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Windows.Forms;


namespace RecipeBook48
{
    public partial class FormAdminPanelMain : MetroForm
    {
        internal FormWelcome form;
        internal SqlConnection connection;
        public FormAdminPanelMain(FormWelcome form)
        {
            InitializeComponent();
            this.styleManager = form.StyleManager;
            SetUpStyle(form.StyleManager);
            this.form = form;
            this.connection = form.connection;
        }

        private void FormAdminPanelMain_Load(object sender, EventArgs e)
        {
            OracleDataReader reader = SqlSelectCommands.GetAdminData(form.connection);

            int i = 0;
            while (reader.Read())
            {
                GridAdminRecipes.Rows.Add();

                for (int j = 0; j < reader.FieldCount; j++)
                {
                    GridAdminRecipes.Rows[i].Cells[j].Value = reader.GetString(j);
                }
                i++;
            }
        }

        private void GridAdminRecipeList(object sender, DataGridViewCellEventArgs e)
        {
            if (GridAdminRecipes.Columns[e.ColumnIndex].Name == "DeleteRecipe")
            {
                int recipeId = int.Parse(GridAdminRecipes.Rows[e.RowIndex].Cells[0].Value.ToString());
                SqlUpdateDeleteCommands.DeleteRecipe(form.connection, recipeId);
                GridAdminRecipes.Rows.RemoveAt(e.RowIndex);
            }
            if (GridAdminRecipes.Columns[e.ColumnIndex].Name == "EditRecipe")
            {
                int recipeId = int.Parse(GridAdminRecipes.Rows[e.RowIndex].Cells[0].Value.ToString());
                Recipe recipe = SqlSelectCommands.SelectOneRecipe(form.connection, recipeId);
                FormCreateEdit formCreate = new FormCreateEdit(this.styleManager, this, recipe);
                this.Hide();
                formCreate.Show();

            }
        }

        private void FormAdminPanelMainFormClosed(object sender, FormClosedEventArgs e)
        {
            form.Show();
        }
    }
}
