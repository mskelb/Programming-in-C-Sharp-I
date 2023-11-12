using System;
using System.Collections.Immutable;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.DataFormats;

namespace Assignment5
{
    public partial class ContactForm : Form
    {
        Contact contact;
        readonly CountryCodes countryCodes = new();
        string errorMessage = "";
        // Bool to signal if minimal requirements are fullfilled
        bool minReqNames; 
        bool minReqCity;
        bool everythingsOK; 
        int index = 1; 
        public const string regexMobile1 = @"^\d{2,14}$"; // Allows 2 to 14 consecutive digits in string
        public const string regexMobile2 = @"^\+\d{1,3} \(\d\) \d{2,14}$"; // Allows format "+XX (0) XXX..."
        public const string prefix3 = @"^\d{5}(?:[-\s]\d{4})?$"; // Allows format "217 49", "21749" and "21749-6789"
        public const string regex = @"^[^@\s]+@[^@\s]+\.(com|net|org|nu|se)$"; 

        public ContactForm(Contact conct, string addOrEdit)
        {
            this.CenterToScreen();
            contact = conct;
            InitializeComponent();
            InitializeCountries();
            ShowCustomer();
            this.Text = addOrEdit;
        }
        private void InitializeCountries()
        {
            comboBoxCountry.Items.AddRange(GetCountries());
        }
        #region Buttons 
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            everythingsOK = true;
            SaveContactInfo(); 
            bool minRequirementsOK = CheckMinRequirements();
            if (minRequirementsOK)
            {
                AddLandCode();
                DialogResult = DialogResult.OK;
                ClearAll();
                this.Close();
            }
            else 
            {
                MessageBox.Show("Can't save contact info due to:" + Environment.NewLine + errorMessage);
                CenterToScreen();
                errorMessage = ""; 
                index = 1; 
            }
                 
        }
        #endregion
        #region Help functions  
        private void AddLandCode()
        {
            string temp = countryCodes.GetCountryCode(contact.Country);
            string p = contact.Mobile.Personal;
            string b = contact.Mobile.Office;
            if (!String.IsNullOrEmpty(p) && !p.StartsWith("+"))
                contact.Mobile.Personal = "+" + temp + " (0) " + p[1..];
            if (!String.IsNullOrEmpty(b) && !b.StartsWith("+"))
                contact.Mobile.Office = "+" + temp + " (0) " + b[1..];
        }
        public Contact GetContact()
        {
            return this.contact;
        }
        private void ShowCustomer()
        {
            textBoxFirstName.Text = contact.FistName;
            textBoxLastName.Text = contact.LastName;
            textBoxPrivateMobile.Text = contact.Mobile.Personal;
            textBoxBusinessMobile.Text = contact.Mobile.Office;
            textBoxPrivateEmail.Text = contact.Mail.Personal;
            textBoxBusinessEmail.Text = contact.Mail.Office;
            textBoxStreet.Text = contact.Address.Street;
            textBoxZipCode.Text = contact.Address.ZipCode;
            textBoxCity.Text = contact.Address.City;
            comboBoxCountry.SelectedItem = contact.Country;
        }
        private void SaveContactInfo()
        {
            ReadAddress(); 
            ReadMobiles();
            ReadMail();
            ReadNames(); 
        }
        private void ClearAll()
        {
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            textBoxPrivateMobile.Clear();
            textBoxBusinessMobile.Clear();
            textBoxBusinessEmail.Clear();
            textBoxPrivateEmail.Clear();
            textBoxStreet.Clear();
            textBoxZipCode.Clear();
            textBoxCity.Clear();
            comboBoxCountry.SelectedItem = null;
        }
        #endregion
        #region Functions to add or update contact info (Mobile, Address etc.) 
        private void ReadAddress()
        {
            if (CheckInputText(textBoxCity.Text, "City")) 
            { 
                minReqCity = true;
                contact.Address.City = textBoxCity.Text;
            }
            if (textBoxStreet.Text != contact.Address.Street & CheckStreetAddressWithNumber(textBoxStreet.Text))
                contact.Address.Street = textBoxStreet.Text;
            
            if (textBoxZipCode.Text != contact.Address.City & CheckZipCode(textBoxZipCode.Text))
                contact.Address.ZipCode = textBoxZipCode.Text;
        }
        public void ReadMobiles()
        {
            if (textBoxBusinessMobile.Text != contact.Mobile.Office & CheckMobile(textBoxBusinessMobile.Text, "Business"))
                contact.Mobile.Office = textBoxBusinessMobile.Text;
         
            if (textBoxPrivateMobile.Text != contact.Mobile.Personal & CheckMobile(textBoxPrivateMobile.Text, "Private"))
                contact.Mobile.Personal = textBoxPrivateMobile.Text;
        }
        private void ReadMail()
        {
            if (textBoxPrivateEmail.Text != contact.Mail.Personal & CheckMail(textBoxPrivateEmail.Text, "Private"))
                contact.Mail.Personal = textBoxPrivateEmail.Text;
           
            if (textBoxBusinessEmail.Text != contact.Mail.Office & CheckBusinessMail(textBoxBusinessEmail.Text))
                contact.Mail.Office = textBoxBusinessEmail.Text;
        }
        private void ReadNames()
        {
            string firstname = textBoxFirstName.Text; 
            string lastname = textBoxLastName.Text;
            if (firstname != contact.FistName & CheckInputText(firstname, "First name"))
            {
                contact.FistName = firstname;
            }
            if (lastname != contact.LastName & CheckInputText(lastname, "Last name")) 
            {
                contact.LastName = lastname;
            }
        }
        #endregion
        #region Functions to retrive data from textBox fields ("getters")
        private bool CheckStreetAddressWithNumber(string address)
        {
            // Regular expression pattern to match a street address with a street number
            string pattern = @"^[\p{L}\s]+[0-9]+$"; // Matches one or more letters or spaces, followed by one or more digits at the end of the string

            if (!Regex.IsMatch(address, pattern) & !String.IsNullOrEmpty(address))
            {
                errorMessage += index + ". " + " Street must contain both street and street number."
                    + Environment.NewLine;
                index++;
                everythingsOK &= false;
                return false;
            }
            else
                return true; 
        }
        private bool CheckInputText(string input, string extraText)
        {
            // Define a regular expression pattern to match digits (numbers)
            string pattern = @"\d";
            // Use Regex.IsMatch to check if the input string contains digits
            if (Regex.IsMatch(input, pattern) & !String.IsNullOrEmpty(input))
            {
                // Special case for City, since there must always be a given City 
                if (extraText == "City")
                    minReqCity = false;
                errorMessage += index + ". " + extraText + " field contains digits."
                    + Environment.NewLine;
                index++;
                everythingsOK &= false;
                return false;
            }
            else if (extraText == "City" && String.IsNullOrEmpty(input))
            {
                errorMessage += index + ". " + "The city field is empty. Min requirements not fullfilled. "
                    + Environment.NewLine;
                index++;
                minReqCity = false;
                return false; 
            }
            // Both an empty textBox field (except City) and string in correct format is OK 
            else 
                return true;
        }
        private bool CheckBusinessMail(string email)
        {
            bool formatOK = CheckMail(email, "Business");
            bool valid = true; 
            if (formatOK & !String.IsNullOrEmpty(email))
            {
                // List of known non--business email domains or free email providers
                // is provided in txt file "FreeDomains"
                string projectFolder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
                string fileName = "FreeDomains.txt";

                // Combine the directory path and file name to get the full file path
                string filePath = Path.Combine(projectFolder, fileName);

                // Define the string to search for
                string[] parts = email.Split('@');
                string searchString = parts[1]; //for example: gmail.com

                string[] lines = File.ReadAllLines(filePath);
                // Iterate through each line and search for the string
                for (int lineNumber = 0; lineNumber < lines.Length; lineNumber++)
                {
                    if (lines[lineNumber].Equals(searchString))
                    {
                        errorMessage += index + ". " + "Business mail is not in correct format. Since "
                           + searchString + " is not a valid business domain. It's a free domain."
                           + Environment.NewLine;
                        index++;
                        everythingsOK &= false;
                        // It is not a business email
                        valid = false; 
                    }
                }
            }
            return valid; 
        }
        private bool CheckMobile(string input, string sort)
        {
            // Check if given mobile nr is in the form 0702501632 or
            // +46 (0) 702501632 or null (invalid)
            if (!Regex.IsMatch(input, regexMobile1) && !Regex.IsMatch(input, regexMobile2) & !String.IsNullOrEmpty(input))
            {
                errorMessage += index + ". " + sort + " mobile is not in the correct format. " +
                        "Should be in the format 0702501632 or +46 (0) 0702... Land code will be added " +
                        "automatically if necessary." + Environment.NewLine;
                index++;
                everythingsOK &= false;
                return false;
            }
            else
                return true; 
        }
        public bool CheckZipCode(string zipCode)
        {
            // Regular expression pattern for 5-digit or 9-digit ZIP codes or the field if empty 
            if (!Regex.IsMatch(zipCode, prefix3) & !String.IsNullOrEmpty(zipCode))
            {
                errorMessage += index + ". " + "Zip code is not in the right format. " +
                    "Should be 5 or 9 digits (US)." + Environment.NewLine;
                index++;
                everythingsOK &= false;
                return false;
            }
            else
                return true; 
        }
        public bool CheckMail(string email, string text)
        {
            if (!Regex.IsMatch(email, regex, RegexOptions.IgnoreCase) & !String.IsNullOrEmpty(email))
            {
                errorMessage += index + ". " + text + " mail is not in correct format. Try again."
                    + Environment.NewLine;
                index++;
                everythingsOK &= false;
                return false;
            }
            else
                return true; // Email format OK 
        }
        #endregion
        #region Functions to check if data that has been retrieved from textBox fields is valid 
        private bool CheckMinRequirements()
        {
            minReqNames = !String.IsNullOrEmpty(contact.FistName) || !String.IsNullOrEmpty(contact.LastName);
            if (!minReqNames)
                errorMessage += index + ". " + "At least one name should be filled with valid name. Try again."
                    + Environment.NewLine; 
            return CheckCountry() & minReqCity & minReqNames & everythingsOK;
        }
        private bool CheckCountry()
        {
            if (comboBoxCountry.SelectedItem == null)
            {
                errorMessage += index + ". " + "No country has been selected. " +
                    "Please choose country." + Environment.NewLine;
                index++;
                return false; 
            }
            else 
            {
                this.contact.Country = comboBoxCountry.SelectedItem.ToString();
                return true;
            }
        }
        #endregion
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
