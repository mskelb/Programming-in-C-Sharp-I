using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public class Customer
    {
        private string idCustomer;
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

        internal string GetName()
        {
            return contact.GetFullName();
        }

        internal string GetContactInfo()
        {
            return contact.GetContactInfo();
        }
        #region Getters and Setters 
        public string CustomerID
        {
            get {  return idCustomer; }
            set { idCustomer = value; }

        }
        #endregion
    }
}
