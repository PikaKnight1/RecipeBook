using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBook48
{
    public class Recipe
    {
        public int RecipeID { get; private set; }
        public string RecipeName { get; private set; }
        public string RecipeImageURL { get; private set; }
        public string RecipeDifficulty { get; private set; }
        public int RecipeTime { get; private set; }
        public string RecipeAuthor { get; private set; }
        public string RecipeCategory { get; private set; }

        public Recipe(int recipeID, string recipeName, string recipeImageURL, string recipeDifficulty, int recipeTime, string recipeAuthor, string recipeCategory)
        {
            this.RecipeID = recipeID;
            this.RecipeName = recipeName;
            this.RecipeImageURL = recipeImageURL;
            this.RecipeDifficulty = recipeDifficulty;
            this.RecipeTime = recipeTime;
            this.RecipeAuthor = recipeAuthor;
            this.RecipeCategory = recipeCategory;
        }

        public Recipe(string recipeName, string recipeImageURL, string recipeDifficulty, int recipeTime, string recipeAuthor, string recipeCategory) :
            this(-1, recipeName, recipeImageURL, recipeDifficulty, recipeTime, recipeAuthor, recipeCategory)
        {      
        }
    }
}
