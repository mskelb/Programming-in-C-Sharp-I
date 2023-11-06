namespace Assignment5;

partial class MainForm
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
        listBoxIdName = new ListBox();
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        label4 = new Label();
        label5 = new Label();
        textBoxContactInfo = new TextBox();
        buttonAdd = new Button();
        buttonDelete = new Button();
        buttonEdit = new Button();
        SuspendLayout();
        // 
        // listBoxIdName
        // 
        listBoxIdName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        listBoxIdName.FormattingEnabled = true;
        listBoxIdName.ItemHeight = 37;
        listBoxIdName.Location = new Point(37, 102);
        listBoxIdName.Margin = new Padding(4, 2, 4, 2);
        listBoxIdName.Name = "listBoxIdName";
        listBoxIdName.Size = new Size(1064, 596);
        listBoxIdName.TabIndex = 0;
        listBoxIdName.Click += buttonShow_Click;
        listBoxIdName.SelectedIndexChanged += listBoxIdName_SelectedIndexChanged;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        label1.ForeColor = Color.CornflowerBlue;
        label1.Location = new Point(65, 45);
        label1.Margin = new Padding(4, 0, 4, 0);
        label1.Name = "label1";
        label1.Size = new Size(43, 37);
        label1.TabIndex = 1;
        label1.Text = "ID";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        label2.ForeColor = Color.CornflowerBlue;
        label2.Location = new Point(230, 45);
        label2.Margin = new Padding(4, 0, 4, 0);
        label2.Name = "label2";
        label2.Size = new Size(349, 37);
        label2.TabIndex = 2;
        label2.Text = "Name (surname, first name) ";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        label3.ForeColor = Color.CornflowerBlue;
        label3.Location = new Point(665, 45);
        label3.Margin = new Padding(4, 0, 4, 0);
        label3.Name = "label3";
        label3.Size = new Size(169, 37);
        label3.TabIndex = 3;
        label3.Text = "Office phone";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        label4.ForeColor = Color.CornflowerBlue;
        label4.Location = new Point(901, 45);
        label4.Margin = new Padding(4, 0, 4, 0);
        label4.Name = "label4";
        label4.Size = new Size(144, 37);
        label4.TabIndex = 4;
        label4.Text = "Office mail";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        label5.ForeColor = Color.CornflowerBlue;
        label5.Location = new Point(1228, 45);
        label5.Margin = new Padding(4, 0, 4, 0);
        label5.Name = "label5";
        label5.Size = new Size(255, 37);
        label5.TabIndex = 5;
        label5.Text = "Contact information";
        // 
        // textBoxContactInfo
        // 
        textBoxContactInfo.BackColor = SystemColors.Menu;
        textBoxContactInfo.Enabled = false;
        textBoxContactInfo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        textBoxContactInfo.ForeColor = SystemColors.HotTrack;
        textBoxContactInfo.Location = new Point(1129, 102);
        textBoxContactInfo.Margin = new Padding(4, 2, 4, 2);
        textBoxContactInfo.Multiline = true;
        textBoxContactInfo.Name = "textBoxContactInfo";
        textBoxContactInfo.Size = new Size(435, 618);
        textBoxContactInfo.TabIndex = 6;
        textBoxContactInfo.TextChanged += textBoxContactInfo_TextChanged;
        // 
        // buttonAdd
        // 
        buttonAdd.BackColor = SystemColors.ButtonFace;
        buttonAdd.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
        buttonAdd.Location = new Point(97, 734);
        buttonAdd.Margin = new Padding(4, 2, 4, 2);
        buttonAdd.Name = "buttonAdd";
        buttonAdd.Size = new Size(249, 58);
        buttonAdd.TabIndex = 7;
        buttonAdd.Text = "Add";
        buttonAdd.UseVisualStyleBackColor = false;
        buttonAdd.Click += buttonAdd_Click;
        // 
        // buttonDelete
        // 
        buttonDelete.BackColor = SystemColors.ButtonFace;
        buttonDelete.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
        buttonDelete.Location = new Point(611, 734);
        buttonDelete.Margin = new Padding(4, 2, 4, 2);
        buttonDelete.Name = "buttonDelete";
        buttonDelete.Size = new Size(249, 58);
        buttonDelete.TabIndex = 8;
        buttonDelete.Text = "Delete";
        buttonDelete.UseVisualStyleBackColor = false;
        buttonDelete.Click += buttonDelete_Click;
        // 
        // buttonEdit
        // 
        buttonEdit.BackColor = SystemColors.ButtonFace;
        buttonEdit.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
        buttonEdit.Location = new Point(354, 734);
        buttonEdit.Margin = new Padding(4, 2, 4, 2);
        buttonEdit.Name = "buttonEdit";
        buttonEdit.Size = new Size(249, 58);
        buttonEdit.TabIndex = 9;
        buttonEdit.Text = "Edit ";
        buttonEdit.UseVisualStyleBackColor = false;
        buttonEdit.Click += buttonEdit_Click;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(13F, 32F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1610, 843);
        Controls.Add(buttonEdit);
        Controls.Add(buttonDelete);
        Controls.Add(buttonAdd);
        Controls.Add(textBoxContactInfo);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(listBoxIdName);
        ForeColor = Color.CornflowerBlue;
        Margin = new Padding(4, 2, 4, 2);
        Name = "MainForm";
        Text = "Customer Registry by ";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private ListBox listBoxIdName;
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private Label label5;
    private TextBox textBoxContactInfo;
    private Button buttonAdd;
    private Button buttonDelete;
    private Button buttonEdit;
}
