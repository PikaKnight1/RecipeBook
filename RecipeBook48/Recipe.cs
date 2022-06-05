using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBook48
{
    internal class Recipe
    {
        public enum Difficulty
        {
            EASY,
            MEDIUM,
            HARD
        }
        public int RecipeID { get; private set; }
        public string RecipeName { get; private set; }
        public string RecipeImageURL { get; private set; }
        public int RecipeDifficulty { get; private set; }
        public int RecipeTime { get; private set; }
        public string RecipeAuthor { get; private set; }

        public Recipe(int recipeID, string recipeName, string recipeImageURL, Difficulty recipeDifficulty, int recipeTime, string recipeAuthor)
        {
            RecipeID = recipeID;
            RecipeName = recipeName;
            RecipeImageURL = recipeImageURL;
            RecipeDifficulty = (int)recipeDifficulty;
            RecipeTime = recipeTime;
            RecipeAuthor = recipeAuthor;
        }

        public Recipe():
            this(-1, "NoName", "NoURL", Difficulty.EASY, -1, "NoAuthor")
        {
        }

        public static List<Recipe> LoadTopRecipes()
        {
            List<Recipe> recipes = new List<Recipe>();

            for (int i = 0; i < 30; i++)
            {
                Recipe recipe = new Recipe(i, "Przepis {i}", @"https://polpharma.pl/wp-content/uploads/2019/08/cookies.jpg", Difficulty.EASY, 60, "pika");
                recipes.Add(recipe);
            }

            return recipes;
        }


    }
}
