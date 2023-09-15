namespace FoodProject
{
    partial class FormIngredients
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
            groupBox1 = new GroupBox();
            listBoxIngredients = new ListBox();
            buttonAddIngredient = new Button();
            buttonEditIngredient = new Button();
            buttonDeleteIngredient = new Button();
            textBoxIngredientText = new TextBox();
            buttonOKIngredient = new Button();
            buttonCandelIngredient = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonCandelIngredient);
            groupBox1.Controls.Add(listBoxIngredients);
            groupBox1.Controls.Add(buttonOKIngredient);
            groupBox1.Controls.Add(buttonAddIngredient);
            groupBox1.Controls.Add(buttonEditIngredient);
            groupBox1.Controls.Add(buttonDeleteIngredient);
            groupBox1.Controls.Add(textBoxIngredientText);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(501, 419);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ingredient";
            // 
            // listBoxIngredients
            // 
            listBoxIngredients.FormattingEnabled = true;
            listBoxIngredients.ItemHeight = 20;
            listBoxIngredients.Location = new Point(16, 72);
            listBoxIngredients.Margin = new Padding(3, 4, 3, 4);
            listBoxIngredients.Name = "listBoxIngredients";
            listBoxIngredients.Size = new Size(367, 304);
            listBoxIngredients.TabIndex = 7;
            listBoxIngredients.SelectedIndexChanged += listBoxIngredients_SelectedIndexChanged;
            // 
            // buttonAddIngredient
            // 
            buttonAddIngredient.Location = new Point(400, 68);
            buttonAddIngredient.Name = "buttonAddIngredient";
            buttonAddIngredient.Size = new Size(94, 29);
            buttonAddIngredient.TabIndex = 6;
            buttonAddIngredient.Text = "Add";
            buttonAddIngredient.UseVisualStyleBackColor = true;
            buttonAddIngredient.Click += buttonAddIngredient_Click;
            // 
            // buttonEditIngredient
            // 
            buttonEditIngredient.Location = new Point(400, 103);
            buttonEditIngredient.Name = "buttonEditIngredient";
            buttonEditIngredient.Size = new Size(94, 29);
            buttonEditIngredient.TabIndex = 5;
            buttonEditIngredient.Text = "Edit";
            buttonEditIngredient.UseVisualStyleBackColor = true;
            buttonEditIngredient.Click += buttonEditIngredient_Click;
            // 
            // buttonDeleteIngredient
            // 
            buttonDeleteIngredient.Location = new Point(400, 139);
            buttonDeleteIngredient.Name = "buttonDeleteIngredient";
            buttonDeleteIngredient.Size = new Size(94, 29);
            buttonDeleteIngredient.TabIndex = 4;
            buttonDeleteIngredient.Text = "Delete";
            buttonDeleteIngredient.UseVisualStyleBackColor = true;
            buttonDeleteIngredient.Click += buttonDeleteIngredient_Click;
            // 
            // textBoxIngredientText
            // 
            textBoxIngredientText.Location = new Point(16, 35);
            textBoxIngredientText.Name = "textBoxIngredientText";
            textBoxIngredientText.Size = new Size(367, 27);
            textBoxIngredientText.TabIndex = 2;
            textBoxIngredientText.TextChanged += textBoxIngredientText_TextChanged;
            // 
            // buttonOKIngredient
            // 
            buttonOKIngredient.Location = new Point(78, 383);
            buttonOKIngredient.Name = "buttonOKIngredient";
            buttonOKIngredient.Size = new Size(94, 29);
            buttonOKIngredient.TabIndex = 2;
            buttonOKIngredient.Text = "OK";
            buttonOKIngredient.UseVisualStyleBackColor = true;
            buttonOKIngredient.Click += buttonOKIngredient_Click;
            // 
            // buttonCandelIngredient
            // 
            buttonCandelIngredient.Location = new Point(178, 383);
            buttonCandelIngredient.Name = "buttonCandelIngredient";
            buttonCandelIngredient.Size = new Size(94, 29);
            buttonCandelIngredient.TabIndex = 3;
            buttonCandelIngredient.Text = "Cancel";
            buttonCandelIngredient.UseVisualStyleBackColor = true;
            buttonCandelIngredient.Click += buttonCandelIngredient_Click;
            // 
            // FormIngredients
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 443);
            Controls.Add(groupBox1);
            Name = "FormIngredients";
            Text = "Add Ingredients to Recipe ";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private TextBox textBoxIngredientText;
        private Button buttonAddIngredient;
        private Button buttonEditIngredient;
        private Button buttonDeleteIngredient;
        private Button buttonOKIngredient;
        private Button buttonCandelIngredient;
        private ListBox listBoxIngredients;
    }
}