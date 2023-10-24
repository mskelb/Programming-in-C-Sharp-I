using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Text.RegularExpressions;
using System.Web;
using System.Security.Cryptography;
using System.Diagnostics.Metrics;
using System.DirectoryServices.ActiveDirectory;
using System.Security.Policy;
using System.IO;

namespace Assignment5
{
    public partial class ContactForm : Form
    {
        Contact contact;
        bool itsOK, editmode = false;
        CountryCodes countryCodes = new CountryCodes();
        public const string prefix = @"^\d{2,14}$";
        public const string prefix2 = @"^\+\d{1,3} \(\d\) \d{2,14}$";
        public const string prefix3 = @"^\d{5}(?:[-\s]\d{4})?$"; // Allows "217 49", "21749" and "21749-6789"
        public const string regex = @"^[^@\s]+@[^@\s]+\.(com|net|org|nu|se)$";

        public ContactForm(Contact c, string addOrEdit)
        {
            this.CenterToScreen();
            contact = c;
            InitializeComponent();
            InitializeCountries();
            ShowCustomer();
            this.Text = addOrEdit;
        }
        private void InitializeCountries()
        {
            comboBoxCountry.Items.AddRange(GetCountries());
        }

        internal Contact GetContact()
        {
            return contact;
        }
        public void AddAddress()
        {

        }
        private void ShowCustomer()
        {
            // In the case of editing a existing customer 
            // show their contact info in the textBoxes
            textBoxFirstName.Text = contact.FistName; 
            textBoxLastName.Text = contact.LastName;
            textBoxPrivateMobile.Text = contact.Mobile;
            textBoxBusinessMobile.Text = customer.business;
            textBoxEmailBuss.Text = customer.emailBuissness;
            textBoxEmailPrivate.Text = customer.emailPrivate;
            textBoxStreet.Text = customer.street;
            textBoxZipCode.Text = customer.zipCode;
            textBoxCity.Text = customer.city;
            comboBoxCountry.SelectedItem = customer.country;
        }

        #region Buttons 
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            // To exit is only OK if the costumer information is complete 
            if (itsOK)
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Check minimal requirements: "The user should at least provide a first
            // name, or a last name, city and country."
            if (CheckMinRequirements())
            {
                AddContactInfo();
                SaveContactInformation();
                GiveOK(); // Give OK to Exit contact form
            }
        }
        #endregion
        private bool CheckMinRequirements()
        {
            bool cityOK = CheckData(textBoxCity.Text, "City name ");
            bool namesOK = CheckData(textBoxFirstName.Text, "First name ") |
                                CheckData(textBoxLastName.Text, "Last name ");
            return (cityOK & namesOK & CheckCountry());
        }

        private void AddContactInfo()
        {
            // First, convert mobile and home number to format +XX (0) 702 50 16,
            // if it's not already done 
            // (1) Add private mobile 
            // (2) Add bussiness mobile 
            // (3) Add firstname
            // (4) Add lastname 
            // (5) Add City 
            // (6) Add Street 
            // (7) Add ZipCode 
            string temp1 = countryCodes.GetCountryCode(comboBoxCountry.SelectedItem.ToString());
            if (!textBoxPrivateMobile.Text.StartsWith("+"))
            {
                string temp2 = textBoxPrivateMobile.Text;
                textBoxPrivateMobile.Text = "+" + temp1 + " (0) " + temp2[1..];
            }
            if (!textBoxBusinessMobile.Text.StartsWith("+"))
            {
                string temp3 = textBoxBusinessMobile.Text;
                textBoxBusinessMobile.Text = "+" + temp1 + " (0) " + temp3[1..];
            }

            customer.firstName = textBoxFirstName.Text;
            customer.lastName = textBoxLastName.Text;
            customer.mobile = textBoxPrivateMobile.Text;
            customer.business = textBoxBusinessMobile.Text;
            customer.emailBuissness = textBoxEmailBuss.Text;
            customer.emailPrivate = textBoxEmailPrivate.Text;
            customer.street = textBoxStreet.Text;
            customer.zipCode = textBoxZipCode.Text;
            customer.city = textBoxCity.Text;
        }

        private void GiveOK()
        {
            itsOK = true;
        }

        private void SaveContactInformation()
        {
            customer.GetContact().AddAddress();
            customer = textBoxFirstName.Text;
            customer.lastName = textBoxLastName.Text;
            customer.mobile = textBoxPrivateMobile.Text;
            customer.business = textBoxBusinessMobile.Text;
            customer.emailBuissness = textBoxEmailBuss.Text;
            customer.emailPrivate = textBoxEmailPrivate.Text;
            customer.street = textBoxStreet.Text;
            customer.zipCode = textBoxZipCode.Text;
            customer.city = textBoxCity.Text;
        }

        #region Check data of different types 
        public bool CheckZipCode(string zipCode)
        {
            // Regular expression pattern for 5-digit or 9-digit ZIP codes 
            if (!Regex.IsMatch(zipCode, prefix3))
                MessageBox.Show("Zip code is not in the right format. Should be 5 or 9 digits (US).");
            return Regex.IsMatch(zipCode, prefix3);
        }

        private bool CheckCountry()
        {
            if (comboBoxCountry.SelectedItem == null)
            {
                MessageBox.Show("No country has been selected. Please choose country.");
                //comboBoxCountry.SelectedItem = "Sweden";
                return false;
            }
            else
                return true;
            //customer.country = comboBoxCountry.SelectedItem.ToString();
        }

        public bool CheckData(string textBoxstring, string additionalText)
        {
            bool dataCheck = true;
            bool numbers = ContainNumbers(textBoxstring);
            if (numbers | String.IsNullOrEmpty(textBoxstring))
            {
                MessageBox.Show(additionalText + "is incorrect or empty. Try again.");
                dataCheck = false;
            }
            return dataCheck;
        }

        public void AddText(string textBoxstring, string additionalText)
        {
            bool dataCheck = true;
            bool numbers = ContainNumbers(textBoxstring);
            if (numbers | String.IsNullOrEmpty(textBoxstring))
            {
                MessageBox.Show(additionalText + "is incorrect or empty. Try again.");
                dataCheck = false;
            }
            return dataCheck;
        }

        static bool ContainNumbers(string input)
        {
            // Define a regular expression pattern to match digits (numbers)
            string pattern = @"\d";
            // Use Regex.IsMatch to check if the input string contains digits
            return Regex.IsMatch(input, pattern);
        }

        public bool CheckMail(string email, string text)
        {
            if (!Regex.IsMatch(email, regex, RegexOptions.IgnoreCase) | String.IsNullOrEmpty(email))
            {
                MessageBox.Show(text + " mail is not in correct format. Try again.");
                return false;
            }
            else
                return true; // Email format OK 
        }

        public bool CheckBusiness(string email)
        {
            bool business = true;
            if (CheckMail(email, "Business"))
            {
                // Define the directory and file name
                // List of known non--business email domains or free email providers
                // is provided in txt file "FreeDomains"
                string projectFolder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
                string fileName = "FreeDomains.txt";

                // Combine the directory path and file name to get the full file path
                string filePath = Path.Combine(projectFolder, fileName);

                // Define the string to search for
                string[] parts = email.Split('@');
                string searchString = parts[1]; //for example: gmail.com

                // Check if the file exists
                if (File.Exists(filePath))
                {
                    // Try reading file 
                    try
                    {
                        // Read all lines from the file
                        string[] lines = File.ReadAllLines(filePath);

                        // Iterate through each line and search for the string
                        for (int lineNumber = 0; lineNumber < lines.Length; lineNumber++)
                        {
                            if (lines[lineNumber].Equals(searchString))
                            {
                                MessageBox.Show("Business mail is not in correct format. Since "
                                + searchString + " is not a valid business domain. It's a free domain.");
                                business = false; // It is not a business email
                            }
                        }
                    }
                    // Error reading file 
                    catch (IOException e)
                    {
                        MessageBox.Show($"Error reading the file: {e.Message}");
                    }
                }
                else
                    MessageBox.Show($"File not found: {filePath}");
            }
            else
            {
                business = false;
            }
            return business;
        }
        public bool CheckMobile(string number, string t)
        {   // Check if given mobile nr is in the form 0702501632 or
            // +46 (0) 702501632 
            if (!Regex.IsMatch(number, prefix) && !Regex.IsMatch(number, prefix2) | String.IsNullOrEmpty(number))
            {
                MessageBox.Show(t + " mobile is not correct format or null. " +
                    "Should be in the format 0702501632. Land code will be added later.");
                return false;
            }
            else
                return true;
        }
        #endregion 
        private void ClearAllTextBoxes()
        {
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            textBoxPrivateMobile.Clear();
            textBoxBusinessMobile.Clear();
            textBoxEmailBuss.Clear();
            textBoxEmailPrivate.Clear();
            textBoxStreet.Clear();
            textBoxZipCode.Clear();
            textBoxCity.Clear();
            comboBoxCountry.SelectedItem = null;
        }
        #region NOT USED 
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBoxFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        #endregion



    }
}
