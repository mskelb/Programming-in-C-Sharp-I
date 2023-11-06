namespace FoodProject
{
    partial class EditForm
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
            textBox1 = new TextBox();
            label1 = new Label();
            buttonOK = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(14, 37);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(281, 27);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 13);
            label1.Name = "label1";
            label1.Size = new Size(216, 20);
            label1.TabIndex = 1;
            label1.Text = "Please write the new ingredient";
            label1.Click += label1_Click;
            // 
            // buttonOK
            // 
            buttonOK.Location = new Point(54, 72);
            buttonOK.Margin = new Padding(3, 4, 3, 4);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(86, 31);
            buttonOK.TabIndex = 2;
            buttonOK.Text = "Save";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += saveButton_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(146, 72);
            buttonCancel.Margin = new Padding(3, 4, 3, 4);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(86, 31);
            buttonCancel.TabIndex = 3;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(316, 123);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOK);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "EditForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit your ingredient";
            Load += ChangeText_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Button buttonOK;
        private Button buttonCancel;
    }
}