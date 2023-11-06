using System.Windows.Forms;

namespace FoodProject
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            comboBoxChooseCategory = new ComboBox();
            buttonAddIngredients = new Button();
            groupBoxAddNewRecipe = new GroupBox();
            buttonAddRecipe = new Button();
            textBoxWriteRecipe = new TextBox();
            textBoxAddRecipe = new TextBox();
            labelStoredName = new Label();
            labelNoOfIngredients = new Label();
            labelStoredcat = new Label();
            buttonEdit = new Button();
            buttonClearSection = new Button();
            buttonDelete = new Button();
            labelDoubleClick = new Label();
            listBoxRecipeStored = new ListBox();
            button1 = new Button();
            groupBoxAddNewRecipe.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 61);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 0;
            label1.Text = "Name of recipe";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 115);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 1;
            label2.Text = "Category";
            // 
            // comboBoxChooseCategory
            // 
            comboBoxChooseCategory.FormattingEnabled = true;
            comboBoxChooseCategory.Items.AddRange(new object[] { "Meats", "Pasta", "Pizza", "Fish", "Seafood", "Soup", "Stew", "Vegan", "Vegitarian", "Vegitarian_Dairy_Egg", "Other" });
            comboBoxChooseCategory.Location = new Point(114, 109);
            comboBoxChooseCategory.Margin = new Padding(3, 4, 3, 4);
            comboBoxChooseCategory.Name = "comboBoxChooseCategory";
            comboBoxChooseCategory.Size = new Size(246, 28);
            comboBoxChooseCategory.TabIndex = 2;
            // 
            // buttonAddIngredients
            // 
            buttonAddIngredients.Location = new Point(367, 107);
            buttonAddIngredients.Margin = new Padding(3, 4, 3, 4);
            buttonAddIngredients.Name = "buttonAddIngredients";
            buttonAddIngredients.Size = new Size(137, 31);
            buttonAddIngredients.TabIndex = 3;
            buttonAddIngredients.Text = "Add ingredients";
            buttonAddIngredients.UseVisualStyleBackColor = true;
            buttonAddIngredients.Click += buttonAddIngredients_Click;
            // 
            // groupBoxAddNewRecipe
            // 
            groupBoxAddNewRecipe.Controls.Add(buttonAddRecipe);
            groupBoxAddNewRecipe.Controls.Add(textBoxWriteRecipe);
            groupBoxAddNewRecipe.Controls.Add(textBoxAddRecipe);
            groupBoxAddNewRecipe.Controls.Add(buttonAddIngredients);
            groupBoxAddNewRecipe.Controls.Add(comboBoxChooseCategory);
            groupBoxAddNewRecipe.Controls.Add(label2);
            groupBoxAddNewRecipe.Controls.Add(label1);
            groupBoxAddNewRecipe.Location = new Point(14, 12);
            groupBoxAddNewRecipe.Margin = new Padding(3, 4, 3, 4);
            groupBoxAddNewRecipe.Name = "groupBoxAddNewRecipe";
            groupBoxAddNewRecipe.Padding = new Padding(3, 4, 3, 4);
            groupBoxAddNewRecipe.Size = new Size(533, 453);
            groupBoxAddNewRecipe.TabIndex = 4;
            groupBoxAddNewRecipe.TabStop = false;
            groupBoxAddNewRecipe.Text = "Add new recipe";
            // 
            // buttonAddRecipe
            // 
            buttonAddRecipe.Location = new Point(25, 403);
            buttonAddRecipe.Margin = new Padding(3, 4, 3, 4);
            buttonAddRecipe.Name = "buttonAddRecipe";
            buttonAddRecipe.Size = new Size(480, 31);
            buttonAddRecipe.TabIndex = 6;
            buttonAddRecipe.Text = "Add recipe";
            buttonAddRecipe.UseVisualStyleBackColor = true;
            buttonAddRecipe.Click += buttonAddRecipe_Click;
            // 
            // textBoxWriteRecipe
            // 
            textBoxWriteRecipe.Location = new Point(25, 148);
            textBoxWriteRecipe.Margin = new Padding(3, 4, 3, 4);
            textBoxWriteRecipe.Multiline = true;
            textBoxWriteRecipe.Name = "textBoxWriteRecipe";
            textBoxWriteRecipe.Size = new Size(479, 247);
            textBoxWriteRecipe.TabIndex = 5;
            // 
            // textBoxAddRecipe
            // 
            textBoxAddRecipe.Location = new Point(166, 57);
            textBoxAddRecipe.Margin = new Padding(3, 4, 3, 4);
            textBoxAddRecipe.Name = "textBoxAddRecipe";
            textBoxAddRecipe.Size = new Size(339, 27);
            textBoxAddRecipe.TabIndex = 4;
            textBoxAddRecipe.Text = " ";
            // 
            // labelStoredName
            // 
            labelStoredName.AccessibleRole = AccessibleRole.Equation;
            labelStoredName.AutoSize = true;
            labelStoredName.Location = new Point(579, 45);
            labelStoredName.Name = "labelStoredName";
            labelStoredName.Size = new Size(49, 20);
            labelStoredName.TabIndex = 6;
            labelStoredName.Text = "Name";
            // 
            // labelNoOfIngredients
            // 
            labelNoOfIngredients.AutoSize = true;
            labelNoOfIngredients.Location = new Point(893, 45);
            labelNoOfIngredients.Name = "labelNoOfIngredients";
            labelNoOfIngredients.RightToLeft = RightToLeft.Yes;
            labelNoOfIngredients.Size = new Size(128, 20);
            labelNoOfIngredients.TabIndex = 7;
            labelNoOfIngredients.Text = "No. of ingredients";
            // 
            // labelStoredcat
            // 
            labelStoredcat.AutoSize = true;
            labelStoredcat.Location = new Point(762, 45);
            labelStoredcat.Name = "labelStoredcat";
            labelStoredcat.Size = new Size(69, 20);
            labelStoredcat.TabIndex = 8;
            labelStoredcat.Text = "Category";
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(682, 403);
            buttonEdit.Margin = new Padding(3, 4, 3, 4);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(91, 31);
            buttonEdit.TabIndex = 9;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonClearSection
            // 
            buttonClearSection.Location = new Point(893, 403);
            buttonClearSection.Margin = new Padding(3, 4, 3, 4);
            buttonClearSection.Name = "buttonClearSection";
            buttonClearSection.Size = new Size(106, 31);
            buttonClearSection.TabIndex = 10;
            buttonClearSection.Text = "Clear section";
            buttonClearSection.UseVisualStyleBackColor = true;
            buttonClearSection.Click += buttonClearSection_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(779, 403);
            buttonDelete.Margin = new Padding(3, 4, 3, 4);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(106, 31);
            buttonDelete.TabIndex = 11;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // labelDoubleClick
            // 
            labelDoubleClick.AutoSize = true;
            labelDoubleClick.ForeColor = Color.Turquoise;
            labelDoubleClick.Location = new Point(618, 445);
            labelDoubleClick.Name = "labelDoubleClick";
            labelDoubleClick.Size = new Size(347, 20);
            labelDoubleClick.TabIndex = 13;
            labelDoubleClick.Text = "Double click or click ’Show’ for cooking instructions";
            // 
            // listBoxRecipeStored
            // 
            listBoxRecipeStored.FormattingEnabled = true;
            listBoxRecipeStored.ItemHeight = 20;
            listBoxRecipeStored.Location = new Point(560, 69);
            listBoxRecipeStored.Margin = new Padding(3, 4, 3, 4);
            listBoxRecipeStored.Name = "listBoxRecipeStored";
            listBoxRecipeStored.Size = new Size(471, 324);
            listBoxRecipeStored.TabIndex = 5;
            listBoxRecipeStored.DoubleClick += buttonShow_Click;
            // 
            // button1
            // 
            button1.Location = new Point(585, 403);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(91, 31);
            button1.TabIndex = 14;
            button1.Text = "Show";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonShow_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 489);
            Controls.Add(button1);
            Controls.Add(labelDoubleClick);
            Controls.Add(buttonDelete);
            Controls.Add(buttonClearSection);
            Controls.Add(buttonEdit);
            Controls.Add(labelStoredcat);
            Controls.Add(labelNoOfIngredients);
            Controls.Add(labelStoredName);
            Controls.Add(listBoxRecipeStored);
            Controls.Add(groupBoxAddNewRecipe);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMain";
            Text = "Recipe Book for ";
            groupBoxAddNewRecipe.ResumeLayout(false);
            groupBoxAddNewRecipe.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboBoxChooseCategory;
        private Button buttonAddIngredients;
        private GroupBox groupBoxAddNewRecipe;
        private TextBox textBoxAddRecipe;
        private Button buttonAddRecipe;
        private TextBox textBoxWriteRecipe;
        private Label labelStoredName;
        private Label labelNoOfIngredients;
        private Label labelStoredcat;
        private Button buttonEdit;
        private Button buttonClearSection;
        private Button buttonDelete;
        private Label labelDoubleClick;
        private ListBox listBoxRecipeStored;
        private Button button1;
    }
}