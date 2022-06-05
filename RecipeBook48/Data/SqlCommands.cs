﻿using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBook48
{
    internal class SqlCommands
    {
        public static List<Recipe> SelectRecipesDefault(SqlConnection connection)
        {
            return SelectRecipes(connection);
        }

        public static Recipe SelectRandomRecipe(SqlConnection connection)
        {
            return SelectRecipes(connection, 1, optionalOrderByOptions: " ORDER BY dbms_random.value").First();
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
            return list;
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
    }
}