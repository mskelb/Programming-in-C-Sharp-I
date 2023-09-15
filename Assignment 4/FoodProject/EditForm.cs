using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodProject
{
    public partial class EditForm : Form
    {
        public string editedText { get; private set; }
        public EditForm(string current)
        {
            InitializeComponent();
            textBox1.Text = current;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            editedText = textBox1.Text;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ChangeText_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        internal string GetChangedText()
        {
            throw new NotImplementedException();
        }
    }
}
