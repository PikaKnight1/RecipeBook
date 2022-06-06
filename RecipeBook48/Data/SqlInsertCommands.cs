using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;


namespace RecipeBook48
{
    internal static class SqlInsertCommands
    {
        public static void InsertRecipe(Recipe recipe, SqlConnection connection)
        {
            string sqlCommand = "INSERT INTO recipes " +
                                $"VALUES (P_RECIPES_ID.nextval , '{recipe.RecipeName}', '{recipe.RecipeAuthor}', '{recipe.RecipeDifficulty}', '{recipe.RecipeTime}', SYSDATE, '{recipe.RecipeImageURL}', '{recipe.RecipeCategory}' )";

            OracleConnection connect = connection.GetConnection();
            connect.Open();
            OracleCommand command = connect.CreateCommand();
            command.CommandText = sqlCommand;
            command.ExecuteNonQuery();
            connect.Close();

        }

        public static void InsertSteps(List<string> steps, SqlConnection connection, int recipeId)
        {
            OracleConnection connect = connection.GetConnection();
            connect.Open();

            foreach (string step in steps) {

                string sqlCommand = "INSERT INTO steps " +
                                    $"VALUES (P_STEP_ID.nextval, '{step}', {recipeId})";

                OracleCommand command = connect.CreateCommand();
                command.CommandText = sqlCommand;
                command.ExecuteNonQuery();
            }
            connect.Close();
        }

        public static void InsertIngredients(List<Tuple<string, string, string>> ingredients, SqlConnection connection, int recipeId)
        {
            OracleConnection connect = connection.GetConnection();
            connect.Open();

            foreach (var ingredient in ingredients)
            {

                string sqlCommand = "INSERT INTO ingredients " +
                                    $"VALUES (P_INGREDIENTS_ID.nextval, '{ingredient.Item1}', {int.Parse(ingredient.Item2)}, '{ingredient.Item3}', {recipeId})";

                OracleCommand command = connect.CreateCommand();
                command.CommandText = sqlCommand;
                command.ExecuteNonQuery();
            }
            connect.Close();
        }
    }
}
