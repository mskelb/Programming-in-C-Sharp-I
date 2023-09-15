using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodProject
{
    class RecipeManager
    {
        Recipe[] recipes;
        int currentIndex = 0;
        int maxIndex;
        public RecipeManager(int maxNrOfRecipes)
        {
            recipes = new Recipe[maxNrOfRecipes];
            maxIndex = maxNrOfRecipes - 1;
        }
        public void AddRecipeToManager(Recipe recipe)
        {
            recipes[currentIndex] = recipe;
            currentIndex++;
        }
        public bool IsFull()
        {
            if (currentIndex > maxIndex)
            {
                MessageBox.Show("Max number of recipes reached. Cant add another one. Delete current recipe to add a new recipe.");
                return true;
            }
            else
                return false;
        }
        public string GetRecipeStoredInstruction(int index) 
        {
            return recipes[index].GetInstruction;  
        }
        public void SetRecipeInstruction(string instructions, int index) 
        {
            recipes[index].SetIntruction(instructions);
        }
        internal void DeleteStoredRecipe(int indexToRemove)
        {
            // Delete stored recipe 
            MessageBox.Show("Index to remove " + indexToRemove);
            MessageBox.Show("Number of recipes before removing is " + recipes.Length);
            if (indexToRemove >= 0 && indexToRemove <= maxIndex)
            {
                // Check if the index is within the bounds of the array
                if (indexToRemove >= 0 && indexToRemove < recipes.Length)
                {
                    // Shift elements to the left to remove the element
                    for (int i = indexToRemove; i < recipes.Length - 1; i++)
                    {
                        recipes[i] = recipes[i + 1];
                    }

                    // Set the last element to null to remove it
                    recipes[recipes.Length - 1] = null;
                    currentIndex--; 
                }
            }
            MessageBox.Show("Number of recipes after removing is " + recipes.Length);
        }
        public Recipe GetStoredRecipe(int index) 
        {
            return recipes[index];
        }
        public void ReplaceRecipe(int index, Recipe recipe)
        {
            recipes[index] = recipe;        
        }
        public IEnumerable<Recipe> GetAllRecipes()
        {
            IEnumerable<Recipe> enumerableNumbers = recipes;
            return recipes; 
        }
    }


}
