using System;
using System.Collections.Generic;

namespace RecipeBook48
{
    internal static class SqlInsertCommands
    {
        public static void InsertRecipe(Recipe recipe, SqlConnection connection)
        {
            string sqlCommand = "INSERT INTO recipes " +
                                $"VALUES (" +
                                $"P_RECIPES_ID.nextval , " +
                                $"'{recipe.RecipeName}', " +
                                $"'{recipe.RecipeAuthor}', " +
                                $"'{recipe.RecipeDifficulty}', " +
                                $"'{recipe.RecipeTime}', " +
                                $"SYSDATE, " +
                                $"'{recipe.RecipeImageURL}', " +
                                $"'{recipe.RecipeCategory}' )";

            connection.Execute(sqlCommand);
        }

        public static void InsertSteps(List<string> steps, SqlConnection connection, int recipeId)
        {
            foreach (string step in steps) {
                string sqlCommand = "INSERT INTO steps " +
                                    $"VALUES (P_STEP_ID.nextval, " +
                                    $"'{step}', " +
                                    $"{recipeId})";
                
                connection.Execute(sqlCommand);
            }
        }

        public static void InsertIngredients(List<Tuple<string, string, string>> ingredients, SqlConnection connection, int recipeId)
        {
            foreach (var ingredient in ingredients)
            {

                string sqlCommand = "INSERT INTO ingredients " +
                                    $"VALUES (P_INGREDIENTS_ID.nextval, " +
                                    $"'{ingredient.Item1}', " +
                                    $"{int.Parse(ingredient.Item2)}, " +
                                    $"'{ingredient.Item3}', " +
                                    $"{recipeId})";

                connection.Execute(sqlCommand);
            }
        }
    }
}
