using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBook48
{
    internal class SqlUpdateDeleteCommands
    {
        public static void DeleteRecipe(SqlConnection connection, int id)
        {
            string sqlDeleteRecipe = $"DELETE FROM recipes WHERE recipeId = {id}";

            DeleteStepsAndIngredients(connection, id);
            connection.Execute(sqlDeleteRecipe);
        }

        public static void DeleteStepsAndIngredients(SqlConnection connection, int id)
        {
            string sqlDeleteSteps = $"DELETE FROM steps WHERE recipes_recipeId = {id}";
            string sqlDeleteIngredients = $"DELETE FROM ingredients WHERE recipes_recipeId = {id}";

            connection.Execute(sqlDeleteSteps);
            connection.Execute(sqlDeleteIngredients);
        }

        public static void UpdateRecipe(SqlConnection connection, Recipe recipe)
        {
            string sqlUpdateSteps = $" UPDATE recipes " +
                                    $" SET recipeName = '{recipe.RecipeName}', " +
                                    $" authorName = '{recipe.RecipeAuthor}', " +
                                    $" recipeDifficulty = '{recipe.RecipeDifficulty}', " +
                                    $" recipeTime = {recipe.RecipeTime}, " +
                                    $" recipeUrl = '{recipe.RecipeImageURL}', " +
                                    $" recipeCategory = '{recipe.RecipeCategory}' " +
                                    $" WHERE recipeId = {recipe.RecipeID}";

            connection.Execute(sqlUpdateSteps);

        }
    }
}
