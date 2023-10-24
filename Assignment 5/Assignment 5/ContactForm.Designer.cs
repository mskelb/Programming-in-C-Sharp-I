using System.Globalization;

namespace Assignment5
{
    partial class ContactForm
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

            base.Dispose(disposing)
        }

        #region Windows Form Designer generated code

        /// <summary>8
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            textBoxLastName = new TextBox();
            textBoxFirstName = new TextBox();
            groupBox2 = new GroupBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            textBoxEmailPrivate = new TextBox();
            textBoxEmailBuss = new TextBox();
            textBoxBusinessMobile = new TextBox();
            textBoxPrivateMobile = new TextBox();
            groupBox3 = new GroupBox();
            comboBoxCountry = new ComboBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            textBoxZipCode = new TextBox();
            textBoxCity = new TextBox();
            textBoxStreet = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            buttonSave = new Button();
            buttonDone = new Button();
            buttonCancel = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBoxLastName);
            groupBox1.Controls.Add(textBoxFirstName);
            groupBox1.Location = new Point(33, 23);
            groupBox1.Margin = new Padding(4, 2, 4, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 2, 4, 2);
            groupBox1.Size = new Size(893, 224);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 128);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(122, 32);
            label2.TabIndex = 6;
            label2.Text = "Last name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 70);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(125, 32);
            label1.TabIndex = 5;
            label1.Text = "First name";
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(193, 128);
            textBoxLastName.Margin = new Padding(4, 2, 4, 2);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(673, 39);
            textBoxLastName.TabIndex = 1;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(193, 66);
            textBoxFirstName.Margin = new Padding(4, 2, 4, 2);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(673, 39);
            textBoxFirstName.TabIndex = 0;
            textBoxFirstName.TextChanged += textBoxFirstName_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(textBoxEmailPrivate);
            groupBox2.Controls.Add(textBoxEmailBuss);
            groupBox2.Controls.Add(textBoxBusinessMobile);
            groupBox2.Controls.Add(textBoxPrivateMobile);
            groupBox2.Location = new Point(33, 286);
            groupBox2.Margin = new Padding(4, 2, 4, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 2, 4, 2);
            groupBox2.Size = new Size(893, 333);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Private mail";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(50, 253);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(138, 32);
            label6.TabIndex = 10;
            label6.Text = "Private mail";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 191);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(157, 32);
            label5.TabIndex = 9;
            label5.Text = "Business mail";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 131);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(186, 32);
            label4.TabIndex = 8;
            label4.Text = "Business mobile";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 71);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(167, 32);
            label3.TabIndex = 7;
            label3.Text = "Private mobile";
            // 
            // textBoxEmailPrivate
            // 
            textBoxEmailPrivate.Location = new Point(193, 250);
            textBoxEmailPrivate.Margin = new Padding(4, 2, 4, 2);
            textBoxEmailPrivate.Name = "textBoxEmailPrivate";
            textBoxEmailPrivate.Size = new Size(673, 39);
            textBoxEmailPrivate.TabIndex = 5;
            // 
            // textBoxEmailBuss
            // 
            textBoxEmailBuss.Location = new Point(193, 188);
            textBoxEmailBuss.Margin = new Padding(4, 2, 4, 2);
            textBoxEmailBuss.Name = "textBoxEmailBuss";
            textBoxEmailBuss.Size = new Size(673, 39);
            textBoxEmailBuss.TabIndex = 4;
            // 
            // textBoxBusinessMobile
            // 
            textBoxBusinessMobile.Location = new Point(193, 128);
            textBoxBusinessMobile.Margin = new Padding(4, 2, 4, 2);
            textBoxBusinessMobile.Name = "textBoxBusinessMobile";
            textBoxBusinessMobile.Size = new Size(673, 39);
            textBoxBusinessMobile.TabIndex = 3;
            // 
            // textBoxPrivateMobile
            // 
            textBoxPrivateMobile.Location = new Point(193, 68);
            textBoxPrivateMobile.Margin = new Padding(4, 2, 4, 2);
            textBoxPrivateMobile.Name = "textBoxPrivateMobile";
            textBoxPrivateMobile.Size = new Size(673, 39);
            textBoxPrivateMobile.TabIndex = 2;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(comboBoxCountry);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(textBoxZipCode);
            groupBox3.Controls.Add(textBoxCity);
            groupBox3.Controls.Add(textBoxStreet);
            groupBox3.Location = new Point(33, 657);
            groupBox3.Margin = new Padding(4, 2, 4, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 2, 4, 2);
            groupBox3.Size = new Size(893, 316);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Address";
            // 
            // comboBoxCountry
            // 
            comboBoxCountry.BackColor = SystemColors.Menu;
            comboBoxCountry.FormattingEnabled = true;
            comboBoxCountry.Location = new Point(193, 247);
            comboBoxCountry.Margin = new Padding(4, 2, 4, 2);
            comboBoxCountry.Name = "comboBoxCountry";
            comboBoxCountry.Size = new Size(673, 40);
            comboBoxCountry.Sorted = true;
            comboBoxCountry.TabIndex = 11;
            comboBoxCountry.SelectedIndexChanged += comboBoxCountry_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(85, 250);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(99, 32);
            label10.TabIndex = 14;
            label10.Text = "Country";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(82, 192);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(107, 32);
            label9.TabIndex = 13;
            label9.Text = "Zip code";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(130, 132);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(55, 32);
            label8.TabIndex = 12;
            label8.Text = "City";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(110, 68);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(76, 32);
            label7.TabIndex = 11;
            label7.Text = "Street";
            // 
            // textBoxZipCode
            // 
            textBoxZipCode.Location = new Point(193, 190);
            textBoxZipCode.Margin = new Padding(4, 2, 4, 2);
            textBoxZipCode.Name = "textBoxZipCode";
            textBoxZipCode.Size = new Size(673, 39);
            textBoxZipCode.TabIndex = 5;
            // 
            // textBoxCity
            // 
            textBoxCity.Location = new Point(193, 130);
            textBoxCity.Margin = new Padding(4, 2, 4, 2);
            textBoxCity.Name = "textBoxCity";
            textBoxCity.Size = new Size(673, 39);
            textBoxCity.TabIndex = 4;
            // 
            // textBoxStreet
            // 
            textBoxStreet.Location = new Point(193, 66);
            textBoxStreet.Margin = new Padding(4, 2, 4, 2);
            textBoxStreet.Name = "textBoxStreet";
            textBoxStreet.Size = new Size(673, 39);
            textBoxStreet.TabIndex = 3;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(115, 1009);
            buttonSave.Margin = new Padding(4, 2, 4, 2);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(254, 62);
            buttonSave.TabIndex = 5;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(377, 1009);
            buttonDone.Margin = new Padding(4, 2, 4, 2);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(254, 62);
            buttonDone.TabIndex = 6;
            buttonDone.Text = "I'm done";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(639, 1009);
            buttonCancel.Margin = new Padding(4, 2, 4, 2);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(254, 62);
            buttonCancel.TabIndex = 7;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // ContactForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(969, 1092);
            Controls.Add(buttonCancel);
            Controls.Add(buttonDone);
            Controls.Add(buttonSave);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 2, 4, 2);
            Name = "ContactForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        private object[] GetCountries()
        {
            // Create a CultureInfo array containing all countries
            CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.SpecificCultures);

            // Create a SortedSet to store unique country names
            SortedSet<string> countryNames = new SortedSet<string>();

            foreach (CultureInfo culture in cultures)
            {
                RegionInfo region = new RegionInfo(culture.Name);
                string countryName = region.EnglishName;

                // Add the country name to the SortedSet if it's not already there
                if (!countryNames.Contains(countryName))
                {
                    countryNames.Add(countryName);
                }

            }
            return countryNames.Select(x => x as object).ToArray();
        }



        #endregion

        private GroupBox groupBox1;
        private TextBox textBoxLastName;
        private TextBox textBoxFirstName;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox textBoxEmailPrivate;
        private TextBox textBoxEmailBuss;
        private TextBox textBoxBusinessMobile;
        private TextBox textBoxPrivateMobile;
        private TextBox textBoxZipCode;
        private TextBox textBoxCity;
        private TextBox textBoxStreet;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label6;
        private Label label5;
        private System.Windows.Forms.Timer timer1;
        private ComboBox comboBoxCountry;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Button buttonSave;
        private Button buttonDone;
        private Button buttonCancel;
    }
}