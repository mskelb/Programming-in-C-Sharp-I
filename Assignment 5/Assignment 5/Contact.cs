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
        private string firstname;
        private string lastname;
        private string country; 
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
                this.address.Street + Environment.NewLine + this.address.ZipCode + " " + this.address.City +
                Environment.NewLine + this.country + Environment.NewLine + Environment.NewLine
                + "Emails" + Environment.NewLine + " Private " + this.mail.Personal + Environment.NewLine
                + " Mobile " + this.mobile. + Environment.NewLine + Environment.NewLine +
                "Phone numbers " + Environment.NewLine + " Private" + this.homePhone + Environment.NewLine
                + " Business " + this.mobile;
            return contc;

        }
        public string GetFullName ()
        {
            return (lastname.ToUpper() + ", " + firstname);
        }
        #endregion
    }
}
