using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBook48
{
    internal static class SqlSelectCommands
    {
        public static List<Recipe> SelectRecipesDefault(SqlConnection connection)
        {
            return SelectRecipes(connection);
        }

        public static Recipe SelectRandomRecipe(SqlConnection connection)
        {
            return SelectRecipes(connection, 1, optionalOrderByOptions: " ORDER BY dbms_random.value").First();
        }

        public static List<Recipe> SelectRecipesFiltered(SqlConnection connection, string orderByItem = "", string whereLike = "", params string[] where)
        {
            List<Recipe> recipes = new List<Recipe>();

            StringBuilder whereClause = new StringBuilder();

            int counter = 0;
            for(int i = 0; i < where.Length; i++)
            {
                if (!string.IsNullOrWhiteSpace(where[i]) && !where[i].Equals("Dowolny"))
                {
                    if (counter == 0)
                    {
                        counter++;
                        whereClause.Append(" WHERE ");
                        whereClause.Append(" " + where[i] + " ");

                    }
                    else if (counter > 0)
                    {
                        whereClause.Append(" AND ");
                        whereClause.Append(where[i]);
                    }
                }
            }

            if (whereLike.Length > 0)
            {
                whereClause.Append(" AND ");
                whereClause.Append($" recipeName LIKE '%{whereLike}%'");
            }

            return SelectRecipes(connection, optionalWhereOptions: whereClause.ToString(), optionalOrderByOptions: orderByItem);
        }

        private static List<Recipe> SelectRecipes(SqlConnection connection, int maxAmount = 100, string optionalWhereOptions = "", string optionalOrderByOptions = " ORDER BY recipeUploadTime ")
        {
            string sqlMainCommand = "SELECT recipeId, recipeName, recipeUrl, recipeDifficulty, recipeTime, authorName, recipeCategory " +
                                    "FROM recipes " +
                                    optionalWhereOptions +
                                    optionalOrderByOptions;

            string sqlCommand = "SELECT * FROM ( " + sqlMainCommand + $" ) WHERE ROWNUM <= {maxAmount} ";

            var list = new List<Recipe>();

            OracleDataReader reader = connection.GetReader(sqlCommand);

            while (reader.Read())
            {
                int i = 0;
                Recipe recipe = new Recipe(int.Parse(reader.GetString(i++)), reader.GetString(i++), reader.GetString(i++), reader.GetString(i++), int.Parse(reader.GetString(i++)), reader.GetString(i++), reader.GetString(i++));
                list.Add(recipe);
            }

            return list;
        }


        public static List<string> SelectRecipeSteps(SqlConnection connection, int recipeId)
        {
            var list = new List<String>();
            string sqlCommand = "SELECT steptext " +
                                "FROM steps " +
                               $"WHERE recipes_recipeID = {recipeId} " + 
                                "ORDER BY stepId";

            OracleDataReader reader = connection.GetReader(sqlCommand);

            while (reader.Read())
            {
                list.Add(reader.GetString(0));
            }
            reader.Close();
            return list;
        }

        public static List<Tuple<string, string, string>> SelectRecipeIngredients(SqlConnection connection, int recipeId)
        {
            var list = new List<Tuple<string, string, string>>();
            string sqlCommand = "SELECT ingName, ingType, ingValue " +
                                "FROM ingredients " +
                               $"WHERE recipes_recipeId = {recipeId}" +
                                "ORDER BY ingredientId";

            OracleDataReader reader = connection.GetReader(sqlCommand);

            while (reader.Read())
            {
                Tuple<string, string, string> tuple = Tuple.Create(reader.GetString(0), reader.GetString(1), reader.GetString(2));
                list.Add(tuple);
            }
            reader.Close();

            return list;
        }

        public static int GetLastRecipeId(SqlConnection connection)
        {
            Recipe rec = SelectRecipes(connection, 1, optionalOrderByOptions: " ORDER BY recipeId DESC").First();
            return rec.RecipeID;
        }

    }
}
