using System;
using System.Text.RegularExpressions;

namespace Assignment5
{
    public partial class ContactForm : Form
    {
        Contact contact;
        CountryCodes countryCodes = new CountryCodes();
        public const string prefix = @"^\d{2,14}$";
        public const string prefix2 = @"^\+\d{1,3} \(\d\) \d{2,14}$"; // Allows format "+ (0) XXX..."
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
        public Contact GetContact()
        {
            return this.contact;
        }
        private void ShowCustomer()
        {
            // In the case of editing an existing customer 
            // show their contact info in the textBoxes
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
        #region Buttons 
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            bool minReqOK = CheckMinRequirements();
            if (minReqOK)
            {
                SaveContactInfo();
                DialogResult = DialogResult.OK;
                ClearAll();
                this.Close();
            }
        }
        #endregion
        private void SaveContactInfo()
        {
            ReadAddress(); 
            ReadMobiles();
            ReadMail();
            ReadNames(); 
        }
        #region Functions to add or update contact info (Mobile, Address etc.) 
        private void ReadAddress()
        {
            string city = GetInfo(textBoxBusinessMobile.Text, "Business");
            string street = GetInfo(textBoxBusinessMobile.Text, "Private");
            string zipCode = GetZipCode(); 
            Address adrs = new Address();
            this.contact.Address.ReplaceAddress(adrs);
        }
        public void ReadMobiles()
        {
            string business = GetMobile(textBoxBusinessMobile.Text, "Business");
            string personal = GetMobile(textBoxBusinessMobile.Text, "Private");
            Mobile mobile = new Mobile(business, personal);
            this.contact.Mobile.ReplaceMobile(mobile);
        }
        private void ReadMail()
        {
            string personal = textBoxPrivateEmail.Text;
            string business = UpdateBusiness(textBoxBusinessEmail.Text); 

            if ( String.IsNullOrEmpty(personal) | !CheckMail(personal, "Private") ) 
            {
                personal = ""; 
            }
            Mail mail = new Mail(business, personal);
            this.contact.Mail.ReplaceMail(mail);
        }
        private void ReadNames()
        {
            
        }
        public string UpdateBusiness(string email)
        {
            bool business = CheckMail(email, "Business");
            string temp = email;
            if (business)
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
                                // It is not a business email
                                temp = "";
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
                temp = "";
            }
            return temp;
        }
        #endregion
        #region Functions to retrive data from textBox fields ("getters") 
        public string GetMobile(string input, string sort)
        {
            // Check if given mobile nr is in the form 0702501632 or
            // +46 (0) 702501632 or null (invalid)
            string text = input;
            string country = comboBoxCountry.SelectedItem.ToString();
            string temp1 = countryCodes.GetCountryCode(country);
            if (!Regex.IsMatch(input, prefix) && !Regex.IsMatch(input, prefix2) | String.IsNullOrEmpty(input))
            {
                MessageBox.Show(sort + " mobile is not in the correct format. " +
                    "Should be in the format 0702501632 or +46 (0) 0702... Land code will be added automatically if necessary.");
                text = "";                                      
            }
            else if (!input.StartsWith("+"))
            {
                text = "+" + temp1 + " (0) " + input[1..];
            }
            return text;
        }
        private string GetInfo(string text, string v)
        {
            return "HEJ";
        }
        public string GetZipCode()
        {
            string zipCode = textBoxZipCode.Text;
            // Regular expression pattern for 5-digit or 9-digit ZIP codes 
            if (!Regex.IsMatch(zipCode, prefix3))
            {
                MessageBox.Show("Zip code is not in the right format. Should be 5 or 9 digits (US).");
                zipCode = "";
            }
            return zipCode;
        }
        #endregion
        #region Functions to check if data that has been retrieved from textBox fields is valid 
        private bool CheckMinRequirements()
        {
            bool cityOK = CheckInputText(textBoxCity.Text, "City name");
            bool namesOK = CheckInputText(textBoxFirstName.Text, "First name") |
                                CheckInputText(textBoxLastName.Text, "Last name");
            bool allOK = cityOK & namesOK & CheckCountry(); 

            return (allOK );
        }
        private bool CheckCountry()
        {
            bool countryCheck = true;
            if (comboBoxCountry.SelectedItem == null)
            {
                MessageBox.Show("No country has been selected. Please choose country.");
                countryCheck = false;
            }
            else
                this.contact.Country = comboBoxCountry.SelectedItem.ToString();
            return countryCheck;
        }
        public bool CheckInputText(string text, string extraText)
        {
            bool textCheck = true;
            bool nums = ContainNumbers(text);
            if (nums)
            {
                MessageBox.Show("The " + extraText + " field contains numbers. Try again.");
                textCheck = false;
            }
            else if (String.IsNullOrEmpty(text))
            {
                textCheck = false;
                if (extraText.Equals("City name"))
                    MessageBox.Show("The " + extraText + " field is empty. Try again.");
            }
            return textCheck;
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
            if (!Regex.IsMatch(email, regex, RegexOptions.IgnoreCase))
            {
                MessageBox.Show(text + " mail is not in correct format. Try again.");
                return false;
            }
            if (String.IsNullOrEmpty(email))
                return false;
            else
                return true; // Email format OK 
        } 
        #endregion
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
