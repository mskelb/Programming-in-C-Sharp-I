using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public class Customer
    {
        //public string firstName, lastName, mobile, business,
        // emailBuissness, emailPrivate, street, city,
        // zipCode, country; 
        string idCustomer; 
        Contact contact;
        public Customer(int id)
        {
            // Generate empty customer with ID XXX
            this.idCustomer = id.ToString().PadLeft(3, '0');
            contact = new Contact(); 
        }
        public void AddContact(Contact c)
        {
            this.contact = c; 
        }
        public Contact GetContact() 
        {
            return this.contact;
        }
        #region Getters and Setters 
        public String GetName()
        {
            return (lastName.ToUpper() + ", " + firstName);
        }
        public String GetContactInfo() 
        {
            string contc = this.firstName + " " + this.lastName + Environment.NewLine + 
                this.street + Environment.NewLine + this.zipCode + " " + this.city + 
                Environment.NewLine +  this.country + Environment.NewLine + Environment.NewLine 
                + "Emails" + Environment.NewLine + " Private " + this.emailPrivate + Environment.NewLine
                + " Mobile " + this.emailBuissness + Environment.NewLine + Environment.NewLine +
                "Phone numbers "+ Environment.NewLine + " Private" + this.homePhone + Environment.NewLine
                + " Business " + this.mobile;
            return contc; 

        }
        public void GenerateContactInfo()
        {
            contact = new Contact();
        }
        internal void SetCountry(string c)
        {
            country = c;
        }
        public string GetCountry()
        {
            return country;
        }
        public string GetID()
        {
            return idCustomer;
        }
        public string GetMobile() 
        {
            return mobile; 
        }
        #endregion
    }
}
