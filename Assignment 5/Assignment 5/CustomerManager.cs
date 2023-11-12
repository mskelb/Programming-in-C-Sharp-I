using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment5
{
    internal class CustomerManager
    {
        List<Customer> customers;
        int maxNumberOfCustomers; 
        public CustomerManager(int value)
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
            // Reassign customer numbers to ensure sequential order
            if ( !(customers.Count == 0) ) 
            {
                for (int i = selectedIndex; i < customers.Count; i++)
                {
                    customers[i].CustomerID = i.ToString().PadLeft(3, '0');
                }
            }
        }
        public int NumberOfCustomers() 
        {
            return customers.Count;
        } 
        internal Customer GetStoredCustomer(int selectedIndex)
        {
            return customers[selectedIndex];
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
        internal void ReplaceCustomer(int indexToReplace, Customer editedC)
        {
            customers[indexToReplace] = editedC;
        }
    }
}
