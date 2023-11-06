using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodProject
{
    public class Recipe
    {
        string name;
        string instructions;
        int lastIndexOfIngrArray = 0;
        int maxNumOfIngredients = 0;
        List<string> ingredientsRecipe;
        FoodCategory category = new FoodCategory();

        #pragma warning disable CS8618
        public Recipe(int max) 
        {
            maxNumOfIngredients = max;
            ingredientsRecipe = new List<string>();
        }
        #region getters and setters
        public string GetName { get { return name; } }
        public void SetName(string value) 
        { 
            name = value;
        }
        public string GetInstruction { get { return this.instructions; } }
        public void SetIntruction(string value)
        {
            instructions = value;
        }
        public void SetFoodCat(FoodCategory value) 
        { 
            category = value;  
        }
        public FoodCategory GetFoodCategory() 
        { 
            return category; 
        }
        public void SetMaxNrOfIngredients(int max ) 
        {
            maxNumOfIngredients = max;
        }
        public int GetNrOfIngredients() 
        {
            return ingredientsRecipe.Count;
        }
        // Add an ingredient to current recipe 
        public void AddIngredientsToRecipe(List<string> recipes)
        {
            if (recipes.Count <= maxNumOfIngredients)
                ingredientsRecipe = recipes;
            else
                MessageBox.Show("List of recipies larger than max.");
        }
        // Check if it is possible to add an ingredient to current recipe
        internal List<string> GetIngredients()
        {
            return ingredientsRecipe;
        }

        internal void ReplaceIngredientsList(List<string> value)
        {
            ingredientsRecipe = value;
        }
        #endregion
    }
}
