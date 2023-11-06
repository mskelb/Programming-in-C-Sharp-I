using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodProject
{
    public partial class ShowRecipeForm : Form
    {
        Recipe currRecipe;
        public ShowRecipeForm(Recipe value)
        {
            currRecipe = value;
            InitializeComponent();
            GenerateText();
            this.Text += currRecipe.GetName;
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
        public void GenerateText()
        {
            if (currRecipe != null)
            {
                string instructions = GetInstructions();
                string ingredients = GetIngredients();
                textBoxRecipe.Text += "INGREDIENTS" + Environment.NewLine;
                textBoxRecipe.Text += ingredients + Environment.NewLine
                    + Environment.NewLine + "INSTRUCTIONS" + Environment.NewLine;
                textBoxRecipe.Text += instructions;
            }
        }
        private string GetIngredients()
        {
            string temp = currRecipe.GetIngredients().FirstOrDefault();
            foreach (var i in currRecipe.GetIngredients().Skip(1))
                temp += ", " + i.ToString();
            return temp;
        }
        private string GetInstructions()
        {
            return currRecipe.GetInstruction;
        }
        private void textBoxRecipe_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
