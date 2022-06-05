using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBook48
{
    public class Recipe
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
        public string RecipeCategory { get; private set; }

        public Recipe(int recipeID, string recipeName, string recipeImageURL, Difficulty recipeDifficulty, int recipeTime, string recipeAuthor, string recipeCategory)
        {
            this.RecipeID = recipeID;
            this.RecipeName = recipeName;
            this.RecipeImageURL = recipeImageURL;
            this.RecipeDifficulty = (int)recipeDifficulty;
            this.RecipeTime = recipeTime;
            this.RecipeAuthor = recipeAuthor;
            this.RecipeCategory = recipeCategory;
        }

        public Recipe():
            this(-1, "NoName", "NoURL", Difficulty.EASY, -1, "NoAuthor", "NoCat")
        {
        }

        public static List<Recipe> LoadTopRecipes()
        {
            List<Recipe> recipes = new List<Recipe>();

            for (int i = 0; i < 30; i++)
            {
                Recipe recipe = new Recipe(i, "Przepis {i}", @"https://zjedzciastko.pl/wp-content/uploads/2019/01/ciastka_z_maslem_orzechowym-750x497.jpg", Difficulty.EASY, 60, "pika", "Pierwsza");
                recipes.Add(recipe);
            }

            return recipes;
        }


    }
}
