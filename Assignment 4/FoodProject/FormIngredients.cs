using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FoodProject
{
    public partial class FormIngredients : Form
    {
        List<string> ingredients;
        int maxNumberOfIngredients;
        public FormIngredients(int max, List<string> ingr)
        {
            maxNumberOfIngredients = max;
            ingredients = ingr;
            InitializeComponent();
        }
        public List<string> GetIngredients()
        {
            return ingredients;
        }

        #region Adding an ingredient 
        private void buttonAddIngredient_Click(object sender, EventArgs e)
        {
            string ingredient = textBoxIngredientText.Text;
            if (ingredients.Count == maxNumberOfIngredients)
            {
                MessageBox.Show("Max number of igredients has been reached or no ingredient text.");
            }
            else
            {
                listBoxIngredients.Items.Add(ingredient);
                ingredients.Add(ingredient);
            }
            textBoxIngredientText.Clear();
        }

        private void buttonOKIngredient_Click(object sender, EventArgs e)
        {
            // Press button OK which saves the ingredients to the currect recipe
            DialogResult = DialogResult.OK;
            this.Close();
        }
        private void buttonCandelIngredient_Click(object sender, EventArgs e)
        {
            // Press Cancel button without saving the ingedients 
            this.Close();
        }

        private void buttonEditIngredient_Click(object sender, EventArgs e)
        {
            // Press Edit button to edit an existing ingredient 
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
        private void buttonDeleteIngredient_Click(object sender, EventArgs e)
        {
            // Press Delete button to edit an existing ingredient 
            if (listBoxIngredients.SelectedIndex != -1)
            {
                int selectedIndex = listBoxIngredients.SelectedIndex;
                listBoxIngredients.Items.RemoveAt(selectedIndex);
                ingredients.RemoveAt(selectedIndex);
            }
        }
        #endregion
        private void textBoxListOfIngredientsBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void listBoxIngredients_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxIngredientText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
