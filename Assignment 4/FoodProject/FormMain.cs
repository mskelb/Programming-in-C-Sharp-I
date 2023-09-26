using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FoodProject
{

    public partial class FormMain : Form
    {
        int maxNumOfIngredients = 2;
        RecipeManager recipeManager;
        int maxNumOfRecipes = 2;
        Recipe currRecipe;
        String stdDetails = "{0, -40}{1,-40}{2, -40}";
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public FormMain()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            InitializeComponent();
            InitializeComponentGUI();
            // Create a Recipe Manager 
            recipeManager = new RecipeManager(maxNumOfRecipes);
            // Create first (empty) recipe and place in currentRecipe
            currRecipe = new Recipe(maxNumOfIngredients);
        }
        private void InitializeComponentGUI()
        {
            this.CenterToScreen();
        }
        #region ADDING A RECIPE
        private void buttonAddRecipe_Click(object sender, EventArgs e)
        {
            currRecipe.SetFoodCat(SetFoodCategory());
            bool nameOK = !(String.IsNullOrEmpty(textBoxAddRecipe.Text));
            bool textOK = !(String.IsNullOrEmpty(textBoxWriteRecipe.Text));
            bool everythingsOK = nameOK && textOK;
            if (!nameOK)
            {
                MessageBox.Show("The name field of the recipe is empty. Try again.");
            }
            if (!textOK)
            {
                MessageBox.Show("The instructions field is empty. Try again.");
            }
            else if (everythingsOK)
            {
                if (!recipeManager.IsFull())
                {
                    // Get and set recipes name 
                    string recipeName = textBoxAddRecipe.Text.Trim();
                    currRecipe.SetName(recipeName);
                    // Get and set instructions for the specific recipe
                    string instructions = textBoxWriteRecipe.Text.Trim();
                    currRecipe.SetIntruction(instructions);
                    recipeManager.AddRecipeToManager(currRecipe);
                    DisplayRecipe();
                }
            }
            // After adding (or not adding) our new recipe to
            // recipe manager, clear currentRecipe
            currRecipe = new Recipe(maxNumOfIngredients);
            ClearAllTextBoxes();
        }
        private void ClearAllTextBoxes()
        {
            textBoxAddRecipe.Clear();
            textBoxWriteRecipe.Clear();
            comboBoxChooseCategory.SelectedItem = null;
        }
        private void DisplayRecipe()
        {
            listBoxRecipeStored.Items.Add(String.Format(stdDetails, currRecipe.GetName.ToString(),
                currRecipe.GetFoodCategory().ToString(), currRecipe.GetNrOfIngredients().ToString()));
        }
        // Try get the FoodCategory for the specific recipe 
        // If no category is choose, we pick the default
        // "Other" as the FoodCategory 
        private FoodCategory SetFoodCategory()
        {
            if (comboBoxChooseCategory.SelectedItem == null)
            {
                MessageBox.Show("No food category chosen. Category 'Other' is set to default.");
                return FoodCategory.Other;
            }
            else
                return (FoodCategory)Enum.Parse(typeof(FoodCategory), comboBoxChooseCategory.SelectedItem.ToString());
        }
        #endregion
        #region ADD INGREDIENTS TO RECIPE 
        private void buttonAddIngredients_Click(object sender, EventArgs e)
        {
            // Create FormIngredients object 
            // Pass current recipe object to FormIngredients object  
            using (FormIngredients addForm = new FormIngredients(maxNumOfIngredients, currRecipe.GetIngredients()))
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    currRecipe.AddIngredientsToRecipe(addForm.GetIngredients());
                }
            }
        }
        #endregion
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listBoxRecipeStored.SelectedIndex != -1)
            {
                int selectedIndex = listBoxRecipeStored.SelectedIndex;
                Recipe selectedRecipe = recipeManager.GetStoredRecipe(selectedIndex);
                using (FormEditRecipe selected = new FormEditRecipe(selectedRecipe))
                {
                    if (selected.ShowDialog() == DialogResult.OK)
                    {
                        recipeManager.ReplaceRecipe(selectedIndex, selected.GetRecipe());    
                    }
                }
                DisplayEditedRecipe(selectedIndex);
            }
        }
        private void DisplayEditedRecipe(int i)
        {
            listBoxRecipeStored.Items[i] = (String.Format(stdDetails, recipeManager.GetStoredRecipe(i).GetName.ToString(),
                recipeManager.GetStoredRecipe(i).GetFoodCategory().ToString(), recipeManager.GetStoredRecipe(i).GetNrOfIngredients().ToString()));
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxRecipeStored.SelectedIndex != -1)
            {
                int selectedIndex = listBoxRecipeStored.SelectedIndex;
                // Also delete the recipe from ListBoxRecipeStored  
                listBoxRecipeStored.Items.RemoveAt(selectedIndex);
                // Delete stored recipe
                recipeManager.DeleteStoredRecipe(selectedIndex);
            }
        }
        private void buttonShow_Click(object sender, EventArgs e)
        {
            if (listBoxRecipeStored.SelectedIndex != -1)
            {
                int selectedIndex = listBoxRecipeStored.SelectedIndex;
                Recipe selectedRecipe = recipeManager.GetStoredRecipe(selectedIndex);
                using (ShowRecipeForm selected = new ShowRecipeForm(selectedRecipe))
                {
                    if (selected.ShowDialog() == DialogResult.OK)
                    {
                        return;
                    }
                }
            }
        }
        private void buttonClearSection_Click(object sender, EventArgs e)
        {
            // Clear all stored recipies 
            listBoxRecipeStored.Items.Clear();
            recipeManager = new RecipeManager(maxNumOfRecipes);
        }
    }
}