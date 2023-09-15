using BMI_Calculator;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Web;
using static System.Net.Mime.MediaTypeNames;

namespace Assignment3
{
    public partial class MainForm : Form
    {
        private string name = "Unknown";
        private BMICalculator bmiCalc = new BMICalculator();
        private SavingCalculator savingCalc = new SavingCalculator();
        private BMRCalculator bmrCalc = new BMRCalculator();

        public MainForm()
        {
            InitializeComponent();
            InitializeComponentGUI();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }
        private void InitializeComponentGUI()
        {
            this.Text += " Molly Skelbye";
            labelName.Text = "Name";
        }
        #region BMI
        private void UpdateHeightText()
        {
            if (radioButtonMetrics.Checked)
            {
                labelHeight.Text = "Height (cm)";
                labelWeight.Text = "Weight (kg)";
                textBoxHeightIch.Visible = false;
            }
            else
            {
                labelHeight.Text = "Height (ft and in)";
                labelWeight.Text = "Weight (Ibs)";
                textBoxHeightIch.Visible = true;
            }
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            ReadUnit();
            bool allright = ReadInputBMI();
            if (allright)
            {
                //Calculate and dispaly results
                CalculateDisplayResults();

            }
        }
        private void CalculateDisplayResults()
        {
            double bmi = bmiCalc.CalculateBMI();
            textBoxBMI.Text = bmi.ToString("f2");
            textBoxWeightCat.Text = bmiCalc.WeightCategory();
            GenerateTextInterval();

        }
        // (1) Generate the Text: "{WeightCategory} weight should be between x and y {unit}" 
        // (2) Generate the Text: "{WeightCategory} BMI is between x and y " 
        private void GenerateTextInterval()
        {
            CategoryWeightBMIColor.Text = "Normal BMI is between 18.50 and 24.9";
            Tuple<string, string> lista;

            if (bmiCalc.GetUnitType() == UnitTypes.Metric)
            {
                lista = CalculateWeightIntervalMetrics(bmiCalc.GetHeight());
                ShowWeightInterval.Text = string.Format("Normal weight should be between {0} and {1} kg", lista.Item1, lista.Item2);
            }
            else
            {
                lista = CalculateWeightIntervalImperial(bmiCalc.GetHeight());
                ShowWeightInterval.Text = string.Format("Normal weight should be between {0} and {1} lbs", lista.Item1, lista.Item2);
            }
        }
        //Calculate the normal min weight and max weight for BMI Normal Weight (in Metric or Imperial)
        private Tuple<string, string> CalculateWeightIntervalMetrics(double value)
        {
            double height = bmiCalc.GetHeight() * bmiCalc.GetHeight();
            string min = (18.5 * height).ToString("f2");
            string max = (24.9 * height).ToString("f2");
            Tuple<string, string> temp = new Tuple<string, string>(min, max);
            return temp;
        }

        private Tuple<string, string> CalculateWeightIntervalImperial(double value)
        {
            double height = bmiCalc.GetHeight() * bmiCalc.GetHeight();
            string min = ((18.5 * height) / (703.0)).ToString("f2");
            string max = ((24.9 * height) / (703.0)).ToString("f2");
            Tuple<string, string> temp = new Tuple<string, string>(min, max);
            return temp;
        }

        private bool ReadInputBMI()
        {
            ReadName();
            bool heightOK = ReadHeight();
            bool weightOK = ReadWeight();


            return heightOK && weightOK;
        }

        private void ReadUnit()
        {
            if (radioButtonMetrics.Checked)
                bmiCalc.SetUnitType(UnitTypes.Metric);
            else
                bmiCalc.SetUnitType(UnitTypes.Imperial);
        }

        private void ReadName()
        {
            name = textBoxName.Text.Trim();
            groupResults.Text = "Results for " + name;
        }
        private bool ReadHeight()
        {
            double height = 0.0;
            double inches = 0.0;

            bool everythingsOK = double.TryParse(textBoxHeightCmFt.Text, out height);
            if (!everythingsOK)
            {
                MessageBox.Show("Invalid value for cm or ft. Try again.", "Error.");
            }
            if (radioButtonImperial.Checked)
            {
                everythingsOK = everythingsOK && double.TryParse(textBoxHeightIch.Text, out inches);
                if (!everythingsOK)
                {
                    MessageBox.Show("Invalid value for inches. Try again.", "Error.");
                }

            }
            //cm to m, ft to inch
            if (bmiCalc.GetUnitType() == UnitTypes.Metric)
            {
                height = height / 100.0; //cm to meter
                bmrCalc.SetHeight(height);
            }
            else
            {
                height = height * 12.0 + inches; // ft to inches
                bmrCalc.SetHeight(height * 2.54); // inches to cm 
            }
            bmiCalc.SetHeight(height);

            return everythingsOK;

        }
        private bool ReadWeight()
        {
            double weight = 0.0;

            bool everythingsOK = double.TryParse(textBoxWeight.Text, out weight);
            if (!everythingsOK)
            {
                MessageBox.Show("Invalid value for weight. Try again.", "Error.");
            }

            bmiCalc.SetWeight(weight);
            if (radioButtonImperial.Checked)
            {
                bmrCalc.SetWeight(weight * 0.45359237); //lbs to kg 
            }
            else
                bmrCalc.SetWeight(weight);

            return everythingsOK;

        }

        private void radioButtonMetrics_CheckedChanged(object sender, EventArgs e)
        {
            UpdateHeightText();
        }

        private void radioButtonImperial_CheckedChanged(object sender, EventArgs e)
        {
            UpdateHeightText();
        }
        #endregion
        #region Savings
        private void buttonCalSav_Click(object sender, EventArgs e)
        {
            bool allright = ReadSavingInput();
            if (allright)
            {
                //Calculate savings and dispaly results
                CalculateDisplayResultsSavings();

            }
        }
        private void CalculateDisplayResultsSavings()
        {
            double savings = savingCalc.CalculateSaving();

            textBoxEarned.Text = (savings - savingCalc.GetAmountPaid()).ToString("f2");
            textBoxAmount.Text = savingCalc.GetAmountPaid().ToString("f2");
            textBoxFinalBalance.Text = savings.ToString("f2");
            textBoxTotalFees.Text = savingCalc.GetFees().ToString("f2");
            string months = ((savingCalc.GetFees() / savingCalc.GetPeriod()) / 12).ToString("f2");
            LabelFeesPerMonths.Text = string.Format("(That is {0} per month over {1} years in fees.)", months, savingCalc.GetPeriod());
        }

        private bool ReadSavingInput()
        {
            int monthly = 0;
            int period = 0;
            double rate = 0.0;
            double feesRate = 0.0;

            bool everythingsOK = int.TryParse(textBoxMonthly.Text, out monthly);
            everythingsOK = everythingsOK && int.TryParse(textBoxPeriod.Text, out period)
                && double.TryParse(textBoxInterestRate.Text, out rate) && double.TryParse(textBoxFees.Text, out feesRate);
            if (!everythingsOK)
            {
                MessageBox.Show("Invalid value for Monthly deposit or Period (years). Try again.", "Error.");
            }
            else if (monthly < 0 || period < 0 || rate < 0.0 || feesRate < 0.0)
            {
                MessageBox.Show("Minus value for Monthly deposit or Period (years). Try again.", "Error.");
                everythingsOK = false;
            }
            else
            {
                savingCalc.SetMonthlyDeposit(monthly);
                savingCalc.SetPeriod(period);
                savingCalc.SetNumOfMonth(period * 12);
                savingCalc.SetInterestRate((rate / 100) / 12);
                savingCalc.SetFeesRate((feesRate / 100) / 12);
            }
            return everythingsOK;
        }
        #endregion
        #region BMR
        private void buttonCalBMR_Click(object sender, EventArgs e)
        {
            ReadActivityLevel();
            ReadGender();
            bool allright = ReadAge();
            if (allright)
            {
                //Calculate BMR
                CalculateBMRResults();
            }
        }
        private void CalculateBMRResults()
        {
            double bmr = bmrCalc.CalculateBMR();
            double maintainWeight = bmr * bmrCalc.GetActivityLevel();
            string value = "";
            BMR.Items.Add("BMR results for " + name);
            BMR.Items.Add(" ");
            BMR.Items.Add(" ");
            value = bmr.ToString("f1");
            BMR.Items.Add("Your BMR (calories a day) \t\t\t" + value);
            BMR.Items.Add("Calories to maintain weight per week \t\t" + (maintainWeight).ToString("f1"));
            BMR.Items.Add("Calories to lose 0.5 kg per week \t\t" + (maintainWeight - 500).ToString("f1"));
            BMR.Items.Add("Calories to lose 1.0 kg per week \t\t" + (maintainWeight - 1000).ToString("f1"));
            BMR.Items.Add("Calories to gain 0.5 kg per week \t\t" + (maintainWeight + 500).ToString("f1"));
            BMR.Items.Add("Calories to gain 1.0 kg per week \t\t" + (maintainWeight + 1000).ToString("f1"));
            BMR.Items.Add(" ");

        }
        private bool ReadAge()
        {
            int age = 0;
            bool everythingsOK = int.TryParse(textBoxAge.Text, out age);
            if (!everythingsOK)
                MessageBox.Show("Invalid value for age. Try again.", "Error.");
            else
                bmrCalc.SetAge(age);
            return everythingsOK;
        }
        private void ReadActivityLevel()
        {
            if (radioButtonSeden.Checked)
                bmrCalc.SetActivityLevel(1.2);
            else if (radioButtonLighly.Checked)
                bmrCalc.SetActivityLevel(1.375);
            else if (radioButtonMod.Checked)
                bmrCalc.SetActivityLevel(1.550);
            else if (radioButtonVeryAct.Checked)
                bmrCalc.SetActivityLevel(1.725);
            else
                bmrCalc.SetActivityLevel(1.9);
        }
        private void ReadGender()
        {
            if (radioButtonFemale.Checked)
                bmrCalc.SetGender(UnitTypes.Female);
            else
                bmrCalc.SetGender(UnitTypes.Male);
        }
        private void BMR_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        #endregion
        #region NOT USED 
        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }
        private void groupBoxBMRCalc_Enter(object sender, EventArgs e)
        {
        }
        private void textBoxHeightIch_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBoxBMI_TextChanged(object sender, EventArgs e)
        {

        }
        private void groupResults_Enter(object sender, EventArgs e)
        {

        }
        private void labelBMIResult_Click(object sender, EventArgs e)
        {

        }
        private void CategoryWeightBMIColor_Click(object sender, EventArgs e)
        {

        }
        private void ShowWeightIterval(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void label9_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void textBoxFinalBal_TextChanged(object sender, EventArgs e)
        {

        }
        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }
        private void LabelFeesPerMonths_Click(object sender, EventArgs e)
        {

        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
        #endregion


    }
}