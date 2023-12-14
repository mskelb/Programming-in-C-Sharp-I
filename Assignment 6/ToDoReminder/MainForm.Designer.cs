using System.Globalization;
using System.Windows.Forms;

namespace ToDoReminder
{
    partial class MainForm
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
        private object[] GetPriorities()
        {
            SortedSet<string> prio = new SortedSet<string>();

            // Get all enum values and add them to the list
            foreach (PriorityType value in Enum.GetValues(typeof(PriorityType)))
            {
                prio.Add(value.ToString().Replace("_", " "));
            }

            return prio.Select(x => x as object).ToArray();
        }
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            PriorityBox = new ComboBox();
            dateTimePickerBox = new DateTimePicker();
            listBoxInfo = new ListBox();
            buttonChange = new Button();
            buttonDelete = new Button();
            buttonAdd = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ToDoTextBox = new TextBox();
            groupBox1 = new GroupBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            toolTip1 = new ToolTip(components);
            label8 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            hejToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            openDataFileToolStripMenuItem = new ToolStripMenuItem();
            saveDataFileToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // PriorityBox
            // 
            PriorityBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            PriorityBox.FormattingEnabled = true;
            PriorityBox.Location = new Point(418, 48);
            PriorityBox.Margin = new Padding(3, 4, 3, 4);
            PriorityBox.Name = "PriorityBox";
            PriorityBox.Size = new Size(186, 28);
            PriorityBox.TabIndex = 0;
            PriorityBox.SelectedIndexChanged += PriorityBox_SelectedIndexChanged;
            // 
            // dateTimePickerBox
            // 
            dateTimePickerBox.CustomFormat = " yyyy-MM-dd  hh:mm";
            dateTimePickerBox.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerBox.Format = DateTimePickerFormat.Custom;
            dateTimePickerBox.Location = new Point(142, 48);
            dateTimePickerBox.Margin = new Padding(3, 4, 3, 4);
            dateTimePickerBox.Name = "dateTimePickerBox";
            dateTimePickerBox.Size = new Size(208, 24);
            dateTimePickerBox.TabIndex = 1;
            toolTip1.SetToolTip(dateTimePickerBox, "Click to open calender for date, write in time here.");
            dateTimePickerBox.ValueChanged += dateTimePicker_ValueChanged;
            // 
            // listBoxInfo
            // 
            listBoxInfo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxInfo.FormattingEnabled = true;
            listBoxInfo.ItemHeight = 20;
            listBoxInfo.Location = new Point(20, 58);
            listBoxInfo.Margin = new Padding(3, 4, 3, 4);
            listBoxInfo.Name = "listBoxInfo";
            listBoxInfo.Size = new Size(865, 184);
            listBoxInfo.TabIndex = 2;
            listBoxInfo.SelectedIndexChanged += listBoxInfo_SelectedIndexChanged;
            // 
            // buttonChange
            // 
            buttonChange.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonChange.Location = new Point(71, 441);
            buttonChange.Margin = new Padding(3, 4, 3, 4);
            buttonChange.Name = "buttonChange";
            buttonChange.Size = new Size(116, 29);
            buttonChange.TabIndex = 3;
            buttonChange.Text = "Change";
            buttonChange.UseVisualStyleBackColor = true;
            buttonChange.Click += buttonChange_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDelete.Location = new Point(193, 441);
            buttonDelete.Margin = new Padding(3, 4, 3, 4);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(116, 29);
            buttonDelete.TabIndex = 4;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAdd.Location = new Point(142, 126);
            buttonAdd.Margin = new Padding(3, 4, 3, 4);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(116, 29);
            buttonAdd.TabIndex = 5;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(89, 95);
            label1.Name = "label1";
            label1.Size = new Size(47, 18);
            label1.TabIndex = 6;
            label1.Text = "To do";
            label1.Click += labelToDo_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(29, 55);
            label2.Name = "label2";
            label2.Size = new Size(104, 18);
            label2.TabIndex = 7;
            label2.Text = "Date and Time";
            label2.Click += labelDateTime_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(356, 53);
            label3.Name = "label3";
            label3.Size = new Size(54, 18);
            label3.TabIndex = 8;
            label3.Text = "Priority";
            label3.Click += labelPriority_Click;
            // 
            // ToDoTextBox
            // 
            ToDoTextBox.Location = new Point(142, 92);
            ToDoTextBox.Name = "ToDoTextBox";
            ToDoTextBox.Size = new Size(613, 27);
            ToDoTextBox.TabIndex = 9;
            ToDoTextBox.TextChanged += ToDoTextBox_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(listBoxInfo);
            groupBox1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(29, 162);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(929, 266);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "To Do";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(571, 34);
            label7.Name = "label7";
            label7.Size = new Size(83, 18);
            label7.TabIndex = 6;
            label7.Text = "Description";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(422, 34);
            label6.Name = "label6";
            label6.Size = new Size(54, 18);
            label6.TabIndex = 5;
            label6.Text = "Priority";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(294, 34);
            label5.Name = "label5";
            label5.Size = new Size(41, 18);
            label5.TabIndex = 4;
            label5.Text = "Hour";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(20, 34);
            label4.Name = "label4";
            label4.Size = new Size(39, 18);
            label4.TabIndex = 3;
            label4.Text = "Date";
            // 
            // toolTip1
            // 
            toolTip1.Popup += toolTip1_Popup_1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1186, 752);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 7;
            label8.Text = "label8";
            label8.Click += label8_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(986, 27);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { hejToolStripMenuItem, toolStripSeparator2, openDataFileToolStripMenuItem, saveDataFileToolStripMenuItem, toolStripSeparator1, exitToolStripMenuItem });
            toolStripMenuItem1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(41, 23);
            toolStripMenuItem1.Text = "File";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // hejToolStripMenuItem
            // 
            hejToolStripMenuItem.Name = "hejToolStripMenuItem";
            hejToolStripMenuItem.Size = new Size(169, 24);
            hejToolStripMenuItem.Text = "New     Ctrl+N";
            hejToolStripMenuItem.Click += NewMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(166, 6);
            // 
            // openDataFileToolStripMenuItem
            // 
            openDataFileToolStripMenuItem.Name = "openDataFileToolStripMenuItem";
            openDataFileToolStripMenuItem.Size = new Size(169, 24);
            openDataFileToolStripMenuItem.Text = "Open data file";
            openDataFileToolStripMenuItem.Click += openDataFileToolStripMenuItem_Click;
            // 
            // saveDataFileToolStripMenuItem
            // 
            saveDataFileToolStripMenuItem.Name = "saveDataFileToolStripMenuItem";
            saveDataFileToolStripMenuItem.Size = new Size(169, 24);
            saveDataFileToolStripMenuItem.Text = "Save data file ";
            saveDataFileToolStripMenuItem.Click += saveDataFileToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(166, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(169, 24);
            exitToolStripMenuItem.Text = "Exit       Alt+F4";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(49, 23);
            helpToolStripMenuItem.Text = "Help";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(986, 483);
            Controls.Add(label8);
            Controls.Add(groupBox1);
            Controls.Add(buttonChange);
            Controls.Add(ToDoTextBox);
            Controls.Add(buttonDelete);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonAdd);
            Controls.Add(dateTimePickerBox);
            Controls.Add(PriorityBox);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = "ToDo Reminder by Molly Skelbye";
            Load += MainForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox PriorityBox;
        private DateTimePicker dateTimePickerBox;
        private ListBox listBoxInfo;
        private Button buttonChange;
        private Button buttonDelete;
        private Button buttonAdd;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox ToDoTextBox;
        private GroupBox groupBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private ToolTip toolTip1;
        private Label label8;
        private System.Windows.Forms.Timer timer1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem hejToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem openDataFileToolStripMenuItem;
        private ToolStripMenuItem saveDataFileToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
    }
}