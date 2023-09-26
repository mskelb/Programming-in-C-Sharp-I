using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FoodProject
{
    public partial class FormEditRecipe : Form
    {
        Recipe currRecipe;
        public FormEditRecipe(Recipe recipe)
        {
            currRecipe = recipe;
            this.Name += currRecipe.GetName;
            InitializeComponent();
            GenerateInformation();
        }
        private void GenerateInformation()
        {
            textBoxName.Text = currRecipe.GetName;
            comboBoxCategory.SelectedItem = currRecipe.GetFoodCategory().ToString();
            textBoxInstructions.Text = currRecipe.GetInstruction;
            foreach (string i in currRecipe.GetIngredients())
                listBoxIngredients.Items.Add(i);
        }
        private void buttonSaveRecipe_Click(object sender, EventArgs e)
        {
            Save();
            ClearAll();
            DialogResult = DialogResult.OK;
            this.Close();
        }
        private void ClearAll()
        {
            textBoxName.Clear();
        }
        private void Save()
        {
            currRecipe.SetFoodCat(SetFoodCategory());
            bool nameOK = !(String.IsNullOrEmpty(textBoxName.Text));
            bool textOK = !(String.IsNullOrEmpty(textBoxInstructions.Text));
            bool everythingsOK = nameOK && textOK;
            if (!nameOK)
            {
                MessageBox.Show("The name field of the recipe is empty. Try again.");
            }
            if (!textOK)
            {
                MessageBox.Show("The instructions field is empty. Try again.");
            }
            else
            {
                // Update recipe name 
                currRecipe.SetName(textBoxName.Text);
                string instructions = textBoxInstructions.Text.Trim();
                // Update cooking instructions
                currRecipe.SetIntruction(instructions);
                // Update ingredients
                List<string> temp = ListBoxItemsToList();
                currRecipe.ReplaceIngredientsList(temp);
            }
        }
        private List<string> ListBoxItemsToList()
        {
            // Create a List<string> to store the ListBox items
            List<string> itemList = new List<string>();

            // Iterate through ListBox items and add them to the list
            foreach (var item in listBoxIngredients.Items)
            {
                if (item != null) // Check for null items if needed
                {
                    itemList.Add(item.ToString());
                }
            }
            return itemList;
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private FoodCategory SetFoodCategory()
        {
            if (comboBoxCategory.SelectedItem == null)
            {
                MessageBox.Show("No food category chosen. Category 'Other' is set to default.");
                return FoodCategory.Other;
            }
            else
                return (FoodCategory)Enum.Parse(typeof(FoodCategory), comboBoxCategory.SelectedItem.ToString());
        }
        public Recipe GetRecipe()
        {
            return currRecipe;
        }
        private void listBoxIngredients_DoubleClick(object sender, EventArgs e)
        {
            // Double click to edit an existing ingredient 
            if (listBoxIngredients.SelectedIndex != -1)
            {
                int selectedIndex = listBoxIngredients.SelectedIndex;
                string selectedText = listBoxIngredients.SelectedItem.ToString();
                using (EditForm editForm = new EditForm(selectedText))
                {
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        listBoxIngredients.Items[selectedIndex] = editForm.editedText;
                    }
                }
            }
        }
    }
}
