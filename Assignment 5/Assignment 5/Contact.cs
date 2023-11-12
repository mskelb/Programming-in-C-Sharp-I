using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment5
{
    public class Contact
    {
        string twoNewLines = Environment.NewLine + Environment.NewLine;
        private string firstname = ""; 
        private string lastname = "";
        private string country = ""; 
        private Mail mail;
        private Mobile mobile;
        private Address address;  
        public Contact() 
        {
            mail = new Mail();  
            mobile = new Mobile();
            address = new Address();
        }
        #region Getters and setters 
        public Address Address
        {
            get { return address; }
            set { address = value; }
        }
        public Mobile Mobile
        {
            get { return mobile; }
            set { mobile = value; }
        }
        public Mail Mail   
        {
            get { return mail; }   
            set { mail = value; }  
        }
        public string Country
        {
            get { return country; }
            set { country = value; }
        }
        public string FistName
        {
            get { return firstname; }
            set { firstname = value; }
        }
        public string LastName
        {
            get { return lastname; }
            set { lastname = value; }
        }
        public String GetContactInfo()
        {
            string contc = this.firstname + " " + this.lastname + Environment.NewLine +
                address.ToString() + twoNewLines + mail.ToString() + twoNewLines + mobile.ToString(); 
            return contc;

        }
        public string GetFullName ()
        {
            return (lastname.ToUpper() + ", " + firstname.ToUpper());
        }
        #endregion
    }
}
