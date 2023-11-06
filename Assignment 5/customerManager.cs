using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class customerManager
    {
        List<Customer> customers;
        int maxNumberOfCustomers; 
        public customerManager(int value)
        {
            // Creating a list of customers
            customers = new List<Customer>();
            maxNumberOfCustomers = value;
        }
        internal void AddCustomerToManager(Customer c)
        {
            customers.Add(c);   
        }

        internal void DeleteStoredCustomer(int selectedIndex)
        {
            customers.RemoveAt(selectedIndex);
            MessageBox.Show("After deleting customer, there is "
                + customers.Count + " customers left. Max is: " + maxNumberOfCustomers);
        }

        internal Customer GetStoredCustomer(int selectedIndex)
        {
            return customers.ElementAt(selectedIndex);
        }
        internal bool IsFull()
        {
            if( customers.Count == maxNumberOfCustomers )
            {
                return true; 
            }
            else 
                return false;
        }
        internal void ReplaceCustomer(int selectedIndex, Customer c)
        {
            customers.Insert(selectedIndex,c);
        }
    }
}
