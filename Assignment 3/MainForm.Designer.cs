namespace Assignment3
{
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
            groupBox1 = new GroupBox();
            labelWeight = new Label();
            labelHeight = new Label();
            labelName = new Label();
            textBoxWeight = new TextBox();
            textBoxHeightCmFt = new TextBox();
            textBoxHeightIch = new TextBox();
            textBoxName = new TextBox();
            groupBox2 = new GroupBox();
            radioButtonImperial = new RadioButton();
            radioButtonMetrics = new RadioButton();
            groupBox3 = new GroupBox();
            textBoxFees = new TextBox();
            LabelFees = new Label();
            textBoxInterestRate = new TextBox();
            LabelInterestRate = new Label();
            textBoxPeriod = new TextBox();
            textBoxMonthly = new TextBox();
            labelPeriod = new Label();
            labelMonthlyDep = new Label();
            buttonCalBMI = new Button();
            buttonCalSav = new Button();
            groupResults = new GroupBox();
            ShowWeightInterval = new Label();
            CategoryWeightBMIColor = new Label();
            labelWeightCat = new Label();
            textBoxWeightCat = new TextBox();
            labelBMIResult = new Label();
            textBoxBMI = new TextBox();
            groupBox5 = new GroupBox();
            LabelFeesPerMonths = new Label();
            label3 = new Label();
            label2 = new Label();
            textBoxTotalFees = new TextBox();
            textBoxFinalBalance = new TextBox();
            textBoxEarned = new TextBox();
            textBoxAmount = new TextBox();
            labelFinalBalance = new Label();
            labelAmount = new Label();
            groupBoxBMRCalc = new GroupBox();
            BMR = new ListBox();
            buttonCalBMR = new Button();
            textBoxAge = new TextBox();
            label5 = new Label();
            groupBoxActivityLevel = new GroupBox();
            radioButtonExtraAct = new RadioButton();
            radioButtonVeryAct = new RadioButton();
            radioButtonMod = new RadioButton();
            radioButtonLighly = new RadioButton();
            radioButtonSeden = new RadioButton();
            groupBox4 = new GroupBox();
            radioButtonMale = new RadioButton();
            radioButtonFemale = new RadioButton();
            label1 = new Label();
            label4 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupResults.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBoxBMRCalc.SuspendLayout();
            groupBoxActivityLevel.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelWeight);
            groupBox1.Controls.Add(labelHeight);
            groupBox1.Controls.Add(labelName);
            groupBox1.Controls.Add(textBoxWeight);
            groupBox1.Controls.Add(textBoxHeightCmFt);
            groupBox1.Controls.Add(textBoxHeightIch);
            groupBox1.Controls.Add(textBoxName);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(27, 17);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(384, 201);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "BMI Calculator ";
            // 
            // labelWeight
            // 
            labelWeight.AutoSize = true;
            labelWeight.Location = new Point(11, 132);
            labelWeight.Name = "labelWeight";
            labelWeight.Size = new Size(86, 20);
            labelWeight.TabIndex = 7;
            labelWeight.Text = "Weight (Ibs)";
            // 
            // labelHeight
            // 
            labelHeight.AutoSize = true;
            labelHeight.Location = new Point(11, 93);
            labelHeight.Name = "labelHeight";
            labelHeight.Size = new Size(88, 20);
            labelHeight.TabIndex = 6;
            labelHeight.Text = "Height (ft and in)";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(11, 55);
            labelName.Name = "labelName";
            labelName.Size = new Size(49, 20);
            labelName.TabIndex = 5;
            labelName.Text = "Name";
            labelName.Click += buttonOK_Click;
            // 
            // textBoxWeight
            // 
            textBoxWeight.Location = new Point(238, 127);
            textBoxWeight.Margin = new Padding(3, 4, 3, 4);
            textBoxWeight.Name = "textBoxWeight";
            textBoxWeight.Size = new Size(121, 27);
            textBoxWeight.TabIndex = 4;
            textBoxWeight.TextChanged += textBox4_TextChanged;
            // 
            // textBoxHeightCmFt
            // 
            textBoxHeightCmFt.Location = new Point(163, 89);
            textBoxHeightCmFt.Margin = new Padding(3, 4, 3, 4);
            textBoxHeightCmFt.Name = "textBoxHeightCmFt";
            textBoxHeightCmFt.Size = new Size(95, 27);
            textBoxHeightCmFt.TabIndex = 3;
            // 
            // textBoxHeightIch
            // 
            textBoxHeightIch.Location = new Point(264, 89);
            textBoxHeightIch.Margin = new Padding(3, 4, 3, 4);
            textBoxHeightIch.Name = "textBoxHeightIch";
            textBoxHeightIch.Size = new Size(95, 27);
            textBoxHeightIch.TabIndex = 2;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(117, 51);
            textBoxName.Margin = new Padding(3, 4, 3, 4);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(243, 27);
            textBoxName.TabIndex = 0;
            textBoxName.TextChanged += textBoxName_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButtonImperial);
            groupBox2.Controls.Add(radioButtonMetrics);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(435, 43);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(179, 188);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Unit";
            // 
            // radioButtonImperial
            // 
            radioButtonImperial.AutoSize = true;
            radioButtonImperial.Location = new Point(21, 80);
            radioButtonImperial.Margin = new Padding(3, 4, 3, 4);
            radioButtonImperial.Name = "radioButtonImperial";
            radioButtonImperial.Size = new Size(135, 24);
            radioButtonImperial.TabIndex = 1;
            radioButtonImperial.TabStop = true;
            radioButtonImperial.Text = "Imperial (ft, lbs)";
            radioButtonImperial.UseVisualStyleBackColor = true;
            radioButtonImperial.CheckedChanged += radioButtonImperial_CheckedChanged;
            // 
            // radioButtonMetrics
            // 
            radioButtonMetrics.AutoSize = true;
            radioButtonMetrics.Location = new Point(21, 47);
            radioButtonMetrics.Margin = new Padding(3, 4, 3, 4);
            radioButtonMetrics.Name = "radioButtonMetrics";
            radioButtonMetrics.Size = new Size(129, 24);
            radioButtonMetrics.TabIndex = 0;
            radioButtonMetrics.TabStop = true;
            radioButtonMetrics.Text = "Metric (kg, cm)";
            radioButtonMetrics.UseVisualStyleBackColor = true;
            radioButtonMetrics.CheckedChanged += radioButtonMetrics_CheckedChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBoxFees);
            groupBox3.Controls.Add(LabelFees);
            groupBox3.Controls.Add(textBoxInterestRate);
            groupBox3.Controls.Add(LabelInterestRate);
            groupBox3.Controls.Add(textBoxPeriod);
            groupBox3.Controls.Add(textBoxMonthly);
            groupBox3.Controls.Add(labelPeriod);
            groupBox3.Controls.Add(labelMonthlyDep);
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(635, 43);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(406, 216);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Saving Plan";
            // 
            // textBoxFees
            // 
            textBoxFees.Location = new Point(238, 167);
            textBoxFees.Margin = new Padding(3, 4, 3, 4);
            textBoxFees.Name = "textBoxFees";
            textBoxFees.Size = new Size(148, 27);
            textBoxFees.TabIndex = 7;
            // 
            // LabelFees
            // 
            LabelFees.AutoSize = true;
            LabelFees.Location = new Point(17, 167);
            LabelFees.Name = "LabelFees";
            LabelFees.Size = new Size(70, 20);
            LabelFees.TabIndex = 6;
            LabelFees.Text = "Fees in %";
            LabelFees.Click += label3_Click;
            // 
            // textBoxInterestRate
            // 
            textBoxInterestRate.Location = new Point(238, 126);
            textBoxInterestRate.Margin = new Padding(3, 4, 3, 4);
            textBoxInterestRate.Name = "textBoxInterestRate";
            textBoxInterestRate.Size = new Size(148, 27);
            textBoxInterestRate.TabIndex = 5;
            // 
            // LabelInterestRate
            // 
            LabelInterestRate.AutoSize = true;
            LabelInterestRate.Location = new Point(15, 126);
            LabelInterestRate.Name = "LabelInterestRate";
            LabelInterestRate.Size = new Size(120, 20);
            LabelInterestRate.TabIndex = 4;
            LabelInterestRate.Text = "Interest rate in %";
            // 
            // textBoxPeriod
            // 
            textBoxPeriod.Location = new Point(238, 87);
            textBoxPeriod.Margin = new Padding(3, 4, 3, 4);
            textBoxPeriod.Name = "textBoxPeriod";
            textBoxPeriod.Size = new Size(148, 27);
            textBoxPeriod.TabIndex = 3;
            // 
            // textBoxMonthly
            // 
            textBoxMonthly.Location = new Point(238, 45);
            textBoxMonthly.Margin = new Padding(3, 4, 3, 4);
            textBoxMonthly.Name = "textBoxMonthly";
            textBoxMonthly.Size = new Size(148, 27);
            textBoxMonthly.TabIndex = 2;
            // 
            // labelPeriod
            // 
            labelPeriod.AutoSize = true;
            labelPeriod.Location = new Point(15, 87);
            labelPeriod.Name = "labelPeriod";
            labelPeriod.Size = new Size(99, 20);
            labelPeriod.TabIndex = 1;
            labelPeriod.Text = "Period (years)";
            // 
            // labelMonthlyDep
            // 
            labelMonthlyDep.AutoSize = true;
            labelMonthlyDep.Location = new Point(15, 49);
            labelMonthlyDep.Name = "labelMonthlyDep";
            labelMonthlyDep.Size = new Size(121, 20);
            labelMonthlyDep.TabIndex = 0;
            labelMonthlyDep.Text = "Monthly deposit ";
            // 
            // buttonCalBMI
            // 
            buttonCalBMI.BackColor = SystemColors.ControlLight;
            buttonCalBMI.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCalBMI.Location = new Point(115, 236);
            buttonCalBMI.Margin = new Padding(0);
            buttonCalBMI.Name = "buttonCalBMI";
            buttonCalBMI.Size = new Size(271, 49);
            buttonCalBMI.TabIndex = 10;
            buttonCalBMI.Text = "Calulate BMI";
            buttonCalBMI.UseVisualStyleBackColor = false;
            buttonCalBMI.Click += buttonOK_Click;
            // 
            // buttonCalSav
            // 
            buttonCalSav.BackColor = SystemColors.ControlLight;
            buttonCalSav.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCalSav.Location = new Point(713, 267);
            buttonCalSav.Margin = new Padding(3, 4, 3, 4);
            buttonCalSav.Name = "buttonCalSav";
            buttonCalSav.Size = new Size(271, 49);
            buttonCalSav.TabIndex = 12;
            buttonCalSav.Text = "Calulate Savings";
            buttonCalSav.UseVisualStyleBackColor = false;
            buttonCalSav.Click += buttonCalSav_Click;
            // 
            // groupResults
            // 
            groupResults.Controls.Add(ShowWeightInterval);
            groupResults.Controls.Add(CategoryWeightBMIColor);
            groupResults.Controls.Add(labelWeightCat);
            groupResults.Controls.Add(textBoxWeightCat);
            groupResults.Controls.Add(labelBMIResult);
            groupResults.Controls.Add(textBoxBMI);
            groupResults.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupResults.Location = new Point(27, 293);
            groupResults.Margin = new Padding(3, 4, 3, 4);
            groupResults.Name = "groupResults";
            groupResults.Padding = new Padding(3, 4, 3, 4);
            groupResults.Size = new Size(587, 252);
            groupResults.TabIndex = 13;
            groupResults.TabStop = false;
            groupResults.Text = "Results for ";
            groupResults.Enter += groupResults_Enter;
            // 
            // ShowWeightInterval
            // 
            ShowWeightInterval.AutoSize = true;
            ShowWeightInterval.Location = new Point(129, 197);
            ShowWeightInterval.Name = "ShowWeightInterval";
            ShowWeightInterval.Size = new Size(0, 20);
            ShowWeightInterval.TabIndex = 11;
            ShowWeightInterval.Click += ShowWeightIterval;
            // 
            // CategoryWeightBMIColor
            // 
            CategoryWeightBMIColor.AutoSize = true;
            CategoryWeightBMIColor.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CategoryWeightBMIColor.ForeColor = Color.YellowGreen;
            CategoryWeightBMIColor.Location = new Point(129, 164);
            CategoryWeightBMIColor.Name = "CategoryWeightBMIColor";
            CategoryWeightBMIColor.Size = new Size(0, 20);
            CategoryWeightBMIColor.TabIndex = 10;
            CategoryWeightBMIColor.Click += CategoryWeightBMIColor_Click;
            // 
            // labelWeightCat
            // 
            labelWeightCat.AutoSize = true;
            labelWeightCat.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelWeightCat.Location = new Point(11, 107);
            labelWeightCat.Name = "labelWeightCat";
            labelWeightCat.Size = new Size(120, 20);
            labelWeightCat.TabIndex = 9;
            labelWeightCat.Text = "Weight Category";
            // 
            // textBoxWeightCat
            // 
            textBoxWeightCat.BackColor = SystemColors.Control;
            textBoxWeightCat.Location = new Point(222, 103);
            textBoxWeightCat.Margin = new Padding(3, 4, 3, 4);
            textBoxWeightCat.Name = "textBoxWeightCat";
            textBoxWeightCat.Size = new Size(348, 27);
            textBoxWeightCat.TabIndex = 8;
            // 
            // labelBMIResult
            // 
            labelBMIResult.AutoSize = true;
            labelBMIResult.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelBMIResult.Location = new Point(11, 64);
            labelBMIResult.Name = "labelBMIResult";
            labelBMIResult.Size = new Size(35, 20);
            labelBMIResult.TabIndex = 7;
            labelBMIResult.Text = "BMI";
            labelBMIResult.Click += labelBMIResult_Click;
            // 
            // textBoxBMI
            // 
            textBoxBMI.BackColor = SystemColors.Control;
            textBoxBMI.Location = new Point(222, 53);
            textBoxBMI.Margin = new Padding(3, 4, 3, 4);
            textBoxBMI.Name = "textBoxBMI";
            textBoxBMI.Size = new Size(116, 27);
            textBoxBMI.TabIndex = 6;
            textBoxBMI.TextChanged += textBoxBMI_TextChanged;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(LabelFeesPerMonths);
            groupBox5.Controls.Add(label3);
            groupBox5.Controls.Add(label2);
            groupBox5.Controls.Add(textBoxTotalFees);
            groupBox5.Controls.Add(textBoxFinalBalance);
            groupBox5.Controls.Add(textBoxEarned);
            groupBox5.Controls.Add(textBoxAmount);
            groupBox5.Controls.Add(labelFinalBalance);
            groupBox5.Controls.Add(labelAmount);
            groupBox5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox5.Location = new Point(635, 324);
            groupBox5.Margin = new Padding(3, 4, 3, 4);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(3, 4, 3, 4);
            groupBox5.Size = new Size(406, 213);
            groupBox5.TabIndex = 14;
            groupBox5.TabStop = false;
            groupBox5.Text = "Future Value";
            // 
            // LabelFeesPerMonths
            // 
            LabelFeesPerMonths.AutoSize = true;
            LabelFeesPerMonths.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LabelFeesPerMonths.Location = new Point(41, 178);
            LabelFeesPerMonths.Name = "LabelFeesPerMonths";
            LabelFeesPerMonths.Size = new Size(0, 20);
            LabelFeesPerMonths.TabIndex = 12;
            LabelFeesPerMonths.Click += LabelFeesPerMonths_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 135);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 11;
            label3.Text = "Total Fees";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 101);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 10;
            label2.Text = "Final balance";
            // 
            // textBoxTotalFees
            // 
            textBoxTotalFees.BackColor = SystemColors.Control;
            textBoxTotalFees.Location = new Point(238, 132);
            textBoxTotalFees.Margin = new Padding(3, 4, 3, 4);
            textBoxTotalFees.Name = "textBoxTotalFees";
            textBoxTotalFees.Size = new Size(148, 27);
            textBoxTotalFees.TabIndex = 9;
            // 
            // textBoxFinalBalance
            // 
            textBoxFinalBalance.BackColor = SystemColors.Control;
            textBoxFinalBalance.Location = new Point(238, 98);
            textBoxFinalBalance.Margin = new Padding(3, 4, 3, 4);
            textBoxFinalBalance.Name = "textBoxFinalBalance";
            textBoxFinalBalance.Size = new Size(148, 27);
            textBoxFinalBalance.TabIndex = 8;
            // 
            // textBoxEarned
            // 
            textBoxEarned.BackColor = SystemColors.Control;
            textBoxEarned.Location = new Point(238, 65);
            textBoxEarned.Margin = new Padding(3, 4, 3, 4);
            textBoxEarned.Name = "textBoxEarned";
            textBoxEarned.Size = new Size(148, 27);
            textBoxEarned.TabIndex = 7;
            textBoxEarned.TextChanged += textBoxFinalBal_TextChanged;
            // 
            // textBoxAmount
            // 
            textBoxAmount.BackColor = SystemColors.Control;
            textBoxAmount.Location = new Point(238, 31);
            textBoxAmount.Margin = new Padding(3, 4, 3, 4);
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.Size = new Size(148, 27);
            textBoxAmount.TabIndex = 6;
            // 
            // labelFinalBalance
            // 
            labelFinalBalance.AutoSize = true;
            labelFinalBalance.Location = new Point(17, 68);
            labelFinalBalance.Name = "labelFinalBalance";
            labelFinalBalance.Size = new Size(112, 20);
            labelFinalBalance.TabIndex = 5;
            labelFinalBalance.Text = "Amount Earned";
            // 
            // labelAmount
            // 
            labelAmount.AutoSize = true;
            labelAmount.Location = new Point(17, 34);
            labelAmount.Name = "labelAmount";
            labelAmount.Size = new Size(96, 20);
            labelAmount.TabIndex = 4;
            labelAmount.Text = "Amount paid";
            labelAmount.Click += label9_Click;
            // 
            // groupBoxBMRCalc
            // 
            groupBoxBMRCalc.Controls.Add(BMR);
            groupBoxBMRCalc.Controls.Add(buttonCalBMR);
            groupBoxBMRCalc.Controls.Add(textBoxAge);
            groupBoxBMRCalc.Controls.Add(label5);
            groupBoxBMRCalc.Controls.Add(groupBoxActivityLevel);
            groupBoxBMRCalc.Controls.Add(groupBox4);
            groupBoxBMRCalc.Controls.Add(label1);
            groupBoxBMRCalc.Controls.Add(label4);
            groupBoxBMRCalc.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxBMRCalc.Location = new Point(27, 553);
            groupBoxBMRCalc.Margin = new Padding(3, 4, 3, 4);
            groupBoxBMRCalc.Name = "groupBoxBMRCalc";
            groupBoxBMRCalc.Padding = new Padding(3, 4, 3, 4);
            groupBoxBMRCalc.Size = new Size(1014, 354);
            groupBoxBMRCalc.TabIndex = 15;
            groupBoxBMRCalc.TabStop = false;
            groupBoxBMRCalc.Text = "BMR Calculator";
            groupBoxBMRCalc.Enter += groupBoxBMRCalc_Enter;
            // 
            // BMR
            // 
            BMR.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BMR.ForeColor = Color.LimeGreen;
            BMR.FormattingEnabled = true;
            BMR.ItemHeight = 20;
            BMR.Location = new Point(513, 43);
            BMR.Name = "BMR";
            BMR.Size = new Size(481, 264);
            BMR.TabIndex = 17;
            BMR.SelectedIndexChanged += BMR_SelectedIndexChanged;
            // 
            // buttonCalBMR
            // 
            buttonCalBMR.BackColor = SystemColors.ControlLight;
            buttonCalBMR.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCalBMR.Location = new Point(222, 291);
            buttonCalBMR.Margin = new Padding(0);
            buttonCalBMR.Name = "buttonCalBMR";
            buttonCalBMR.Size = new Size(271, 49);
            buttonCalBMR.TabIndex = 16;
            buttonCalBMR.Text = "Calulate BMI";
            buttonCalBMR.UseVisualStyleBackColor = false;
            buttonCalBMR.Click += buttonCalBMR_Click;
            // 
            // textBoxAge
            // 
            textBoxAge.Location = new Point(74, 211);
            textBoxAge.Margin = new Padding(3, 4, 3, 4);
            textBoxAge.Name = "textBoxAge";
            textBoxAge.Size = new Size(102, 27);
            textBoxAge.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 214);
            label5.Name = "label5";
            label5.Size = new Size(39, 20);
            label5.TabIndex = 14;
            label5.Text = "Age:";
            // 
            // groupBoxActivityLevel
            // 
            groupBoxActivityLevel.Controls.Add(radioButtonExtraAct);
            groupBoxActivityLevel.Controls.Add(radioButtonVeryAct);
            groupBoxActivityLevel.Controls.Add(radioButtonMod);
            groupBoxActivityLevel.Controls.Add(radioButtonLighly);
            groupBoxActivityLevel.Controls.Add(radioButtonSeden);
            groupBoxActivityLevel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxActivityLevel.Location = new Point(205, 43);
            groupBoxActivityLevel.Margin = new Padding(3, 4, 3, 4);
            groupBoxActivityLevel.Name = "groupBoxActivityLevel";
            groupBoxActivityLevel.Padding = new Padding(3, 4, 3, 4);
            groupBoxActivityLevel.Size = new Size(299, 244);
            groupBoxActivityLevel.TabIndex = 13;
            groupBoxActivityLevel.TabStop = false;
            groupBoxActivityLevel.Text = "Weekly activity level";
            // 
            // radioButtonExtraAct
            // 
            radioButtonExtraAct.AutoSize = true;
            radioButtonExtraAct.Location = new Point(21, 187);
            radioButtonExtraAct.Margin = new Padding(3, 4, 3, 4);
            radioButtonExtraAct.Name = "radioButtonExtraAct";
            radioButtonExtraAct.Size = new Size(251, 24);
            radioButtonExtraAct.TabIndex = 4;
            radioButtonExtraAct.TabStop = true;
            radioButtonExtraAct.Text = "Extra active (hard exercise or job)";
            radioButtonExtraAct.UseVisualStyleBackColor = true;
            // 
            // radioButtonVeryAct
            // 
            radioButtonVeryAct.AutoSize = true;
            radioButtonVeryAct.Location = new Point(21, 152);
            radioButtonVeryAct.Margin = new Padding(3, 4, 3, 4);
            radioButtonVeryAct.Name = "radioButtonVeryAct";
            radioButtonVeryAct.Size = new Size(153, 24);
            radioButtonVeryAct.TabIndex = 3;
            radioButtonVeryAct.TabStop = true;
            radioButtonVeryAct.Text = "Very active (6 to 7)";
            radioButtonVeryAct.UseVisualStyleBackColor = true;
            // 
            // radioButtonMod
            // 
            radioButtonMod.AutoSize = true;
            radioButtonMod.Location = new Point(21, 117);
            radioButtonMod.Margin = new Padding(3, 4, 3, 4);
            radioButtonMod.Name = "radioButtonMod";
            radioButtonMod.Size = new Size(201, 24);
            radioButtonMod.TabIndex = 2;
            radioButtonMod.TabStop = true;
            radioButtonMod.Text = "Moderately active (4 to 5)";
            radioButtonMod.UseVisualStyleBackColor = true;
            // 
            // radioButtonLighly
            // 
            radioButtonLighly.AutoSize = true;
            radioButtonLighly.Location = new Point(21, 82);
            radioButtonLighly.Margin = new Padding(3, 4, 3, 4);
            radioButtonLighly.Name = "radioButtonLighly";
            radioButtonLighly.Size = new Size(169, 24);
            radioButtonLighly.TabIndex = 1;
            radioButtonLighly.TabStop = true;
            radioButtonLighly.Text = "Lightly active (1 to 3)";
            radioButtonLighly.UseVisualStyleBackColor = true;
            // 
            // radioButtonSeden
            // 
            radioButtonSeden.AutoSize = true;
            radioButtonSeden.Location = new Point(21, 48);
            radioButtonSeden.Margin = new Padding(3, 4, 3, 4);
            radioButtonSeden.Name = "radioButtonSeden";
            radioButtonSeden.Size = new Size(230, 24);
            radioButtonSeden.TabIndex = 0;
            radioButtonSeden.TabStop = true;
            radioButtonSeden.Text = "Sedentary (little to no activity)";
            radioButtonSeden.UseVisualStyleBackColor = true;
            radioButtonSeden.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(radioButtonMale);
            groupBox4.Controls.Add(radioButtonFemale);
            groupBox4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox4.Location = new Point(11, 43);
            groupBox4.Margin = new Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 4, 3, 4);
            groupBox4.Size = new Size(179, 145);
            groupBox4.TabIndex = 12;
            groupBox4.TabStop = false;
            groupBox4.Text = "Gender";
            // 
            // radioButtonMale
            // 
            radioButtonMale.AutoSize = true;
            radioButtonMale.Location = new Point(21, 81);
            radioButtonMale.Margin = new Padding(3, 4, 3, 4);
            radioButtonMale.Name = "radioButtonMale";
            radioButtonMale.Size = new Size(63, 24);
            radioButtonMale.TabIndex = 1;
            radioButtonMale.TabStop = true;
            radioButtonMale.Text = "Male";
            radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemale
            // 
            radioButtonFemale.AutoSize = true;
            radioButtonFemale.Location = new Point(21, 48);
            radioButtonFemale.Margin = new Padding(3, 4, 3, 4);
            radioButtonFemale.Name = "radioButtonFemale";
            radioButtonFemale.Size = new Size(78, 24);
            radioButtonFemale.TabIndex = 0;
            radioButtonFemale.TabStop = true;
            radioButtonFemale.Text = "Female";
            radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(129, 198);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.YellowGreen;
            label4.Location = new Point(129, 165);
            label4.Name = "label4";
            label4.Size = new Size(0, 23);
            label4.TabIndex = 10;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1065, 939);
            Controls.Add(groupBoxBMRCalc);
            Controls.Add(groupBox5);
            Controls.Add(groupResults);
            Controls.Add(buttonCalSav);
            Controls.Add(buttonCalBMI);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "MainForm";
            Text = "BMI Calculator";
            Load += MainForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupResults.ResumeLayout(false);
            groupResults.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBoxBMRCalc.ResumeLayout(false);
            groupBoxBMRCalc.PerformLayout();
            groupBoxActivityLevel.ResumeLayout(false);
            groupBoxActivityLevel.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBoxHeightIch;
        private TextBox textBoxName;
        private TextBox textBoxHeightCmFt;
        private TextBox textBoxWeight;
        private Label labelName;
        private Label labelWeight;
        private Label labelHeight;
        private GroupBox groupBox2;
        private RadioButton radioButtonMetrics;
        private RadioButton radioButtonImperial;
        private GroupBox groupBox3;
        private TextBox textBoxPeriod;
        private TextBox textBoxMonthly;
        private Label labelPeriod;
        private Label labelMonthlyDep;
        private Button buttonCalBMI;
        private Button buttonCalSav;
        private GroupBox groupResults;
        private Label labelWeightCat;
        private TextBox textBoxWeightCat;
        private Label labelBMIResult;
        private TextBox textBoxBMI;
        private GroupBox groupBox5;
        private TextBox textBoxEarned;
        private TextBox textBoxAmount;
        private Label labelFinalBalance;
        private Label labelAmount;
        private Label ShowWeightInterval;
        private Label CategoryWeightBMIColor;
        private TextBox textBoxFees;
        private Label LabelFees;
        private TextBox textBoxInterestRate;
        private Label LabelInterestRate;
        private Label label2;
        private TextBox textBoxTotalFees;
        private TextBox textBoxFinalBalance;
        private Label label3;
        private Label LabelFeesPerMonths;
        private GroupBox groupBoxBMRCalc;
        private GroupBox groupBox4;
        private RadioButton radioButtonMale;
        private RadioButton radioButtonFemale;
        private Label label1;
        private Label label4;
        private GroupBox groupBoxActivityLevel;
        private RadioButton radioButtonExtraAct;
        private RadioButton radioButtonVeryAct;
        private RadioButton radioButtonMod;
        private RadioButton radioButtonLighly;
        private RadioButton radioButtonSeden;
        private TextBox textBoxAge;
        private Label label5;
        private ListBox BMR;
        private Button buttonCalBMR;
    }
}