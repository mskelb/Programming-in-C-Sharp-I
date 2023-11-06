namespace FoodProject
{
    partial class ShowRecipeForm
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
            textBoxRecipe = new TextBox();
            buttonClose = new Button();
            SuspendLayout();
            // 
            // textBoxRecipe
            // 
            textBoxRecipe.Location = new Point(12, 23);
            textBoxRecipe.Multiline = true;
            textBoxRecipe.Name = "textBoxRecipe";
            textBoxRecipe.Size = new Size(479, 472);
            textBoxRecipe.TabIndex = 0;
            textBoxRecipe.TextChanged += textBoxRecipe_TextChanged;
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(204, 501);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(94, 29);
            buttonClose.TabIndex = 1;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // ShowRecipeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 538);
            Controls.Add(buttonClose);
            Controls.Add(textBoxRecipe);
            Name = "ShowRecipeForm";
            Text = "Cooking instructions for ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxRecipe;
        private Button buttonClose;
    }
}