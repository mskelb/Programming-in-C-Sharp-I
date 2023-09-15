namespace FoodProject
{
    partial class FormEditRecipe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxAddNewRecipe = new GroupBox();
            buttonCancel = new Button();
            label4 = new Label();
            listBoxIngredients = new ListBox();
            label3 = new Label();
            buttonSaveRecipe = new Button();
            textBoxInstructions = new TextBox();
            textBoxName = new TextBox();
            comboBoxCategory = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            groupBoxAddNewRecipe.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxAddNewRecipe
            // 
            groupBoxAddNewRecipe.Controls.Add(buttonCancel);
            groupBoxAddNewRecipe.Controls.Add(label4);
            groupBoxAddNewRecipe.Controls.Add(listBoxIngredients);
            groupBoxAddNewRecipe.Controls.Add(label3);
            groupBoxAddNewRecipe.Controls.Add(buttonSaveRecipe);
            groupBoxAddNewRecipe.Controls.Add(textBoxInstructions);
            groupBoxAddNewRecipe.Controls.Add(textBoxName);
            groupBoxAddNewRecipe.Controls.Add(comboBoxCategory);
            groupBoxAddNewRecipe.Controls.Add(label2);
            groupBoxAddNewRecipe.Controls.Add(label1);
            groupBoxAddNewRecipe.Location = new Point(12, 13);
            groupBoxAddNewRecipe.Margin = new Padding(3, 4, 3, 4);
            groupBoxAddNewRecipe.Name = "groupBoxAddNewRecipe";
            groupBoxAddNewRecipe.Padding = new Padding(3, 4, 3, 4);
            groupBoxAddNewRecipe.Size = new Size(484, 518);
            groupBoxAddNewRecipe.TabIndex = 5;
            groupBoxAddNewRecipe.TabStop = false;
            groupBoxAddNewRecipe.Text = "Edit recipe ";
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(231, 472);
            buttonCancel.Margin = new Padding(3, 4, 3, 4);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(101, 33);
            buttonCancel.TabIndex = 10;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 320);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 9;
            label4.Text = "Ingredients";
            // 
            // listBoxIngredients
            // 
            listBoxIngredients.FormattingEnabled = true;
            listBoxIngredients.ItemHeight = 20;
            listBoxIngredients.Location = new Point(124, 320);
            listBoxIngredients.Margin = new Padding(3, 4, 3, 4);
            listBoxIngredients.Name = "listBoxIngredients";
            listBoxIngredients.Size = new Size(339, 144);
            listBoxIngredients.TabIndex = 8;
            listBoxIngredients.SelectedIndexChanged += listBoxIngredients_SelectedIndexChanged;
            listBoxIngredients.DoubleClick += listBoxIngredients_DoubleClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 114);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 7;
            label3.Text = "Instructions";
            // 
            // buttonSaveRecipe
            // 
            buttonSaveRecipe.Location = new Point(124, 472);
            buttonSaveRecipe.Margin = new Padding(3, 4, 3, 4);
            buttonSaveRecipe.Name = "buttonSaveRecipe";
            buttonSaveRecipe.Size = new Size(101, 33);
            buttonSaveRecipe.TabIndex = 6;
            buttonSaveRecipe.Text = "Save";
            buttonSaveRecipe.UseVisualStyleBackColor = true;
            buttonSaveRecipe.Click += buttonSaveRecipe_Click;
            // 
            // textBoxInstructions
            // 
            textBoxInstructions.Location = new Point(124, 114);
            textBoxInstructions.Margin = new Padding(3, 4, 3, 4);
            textBoxInstructions.Multiline = true;
            textBoxInstructions.Name = "textBoxInstructions";
            textBoxInstructions.Size = new Size(339, 198);
            textBoxInstructions.TabIndex = 5;
            textBoxInstructions.TextChanged += textBoxInstructions_TextChanged;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(124, 43);
            textBoxName.Margin = new Padding(3, 4, 3, 4);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(339, 27);
            textBoxName.TabIndex = 4;
            textBoxName.Text = " ";
            textBoxName.TextChanged += textBoxName_TextChanged;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Items.AddRange(new object[] { "Meats", "Pasta", "Pizza", "Fish", "Seafood", "Soup", "Stew", "Vegan", "Vegitarian", "Vegitarian_Dairy_Egg", "Other" });
            comboBoxCategory.Location = new Point(124, 78);
            comboBoxCategory.Margin = new Padding(3, 4, 3, 4);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(339, 28);
            comboBoxCategory.TabIndex = 2;
            comboBoxCategory.SelectedIndexChanged += comboBoxCategory_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 78);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 1;
            label2.Text = "Category";
            label2.Click += label2_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 46);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 0;
            label1.Text = "Name of recipe";
            // 
            // FormEditRecipe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 565);
            Controls.Add(groupBoxAddNewRecipe);
            Name = "FormEditRecipe";
            Text = "Edit recipe ";
            groupBoxAddNewRecipe.ResumeLayout(false);
            groupBoxAddNewRecipe.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxAddNewRecipe;
        private Button buttonSaveRecipe;
        private TextBox textBoxInstructions;
        private TextBox textBoxName;
        private ComboBox comboBoxCategory;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private ListBox listBoxIngredients;
        private Button buttonCancel;
    }
}