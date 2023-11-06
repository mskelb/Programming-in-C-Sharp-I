using System.Drawing;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Assignment5;

public partial class MainForm : Form
{
    Customer currentCustomer;
    customerManager manager;
    int customerID = 0;
    int maxNumberOfCustomers = 2;
    String stdDetails = "{0, -20}{1,-20}{2, -20}{3, -20}";

    public MainForm()
    {
        InitializeComponent();
        this.CenterToScreen();
        // Create an initial Customer object 
        this.currentCustomer = new Customer(customerID);
        // Create a list of Customers that is handled by a "Customer Manager"  
        manager = new customerManager(maxNumberOfCustomers);
    }
    #region Functions for adding or editing or deleting existing cutomer 
    private void buttonAdd_Click(object sender, EventArgs e)
    {
        if (!manager.IsFull())
        {
            customerID += 1;
            currentCustomer = new Customer(customerID);
            using (ContactForm addForm = new ContactForm(currentCustomer.GetContact(), "Add new customer"))
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    currentCustomer.AddContact(addForm.GetContact());
                    manager.AddCustomerToManager(currentCustomer);
                    DisplayCustomerInformation();
                }
            }
        }
        else
        {
            MessageBox.Show("Oops! To many customers stored. Can't add another one.");
        }
    }
    private void buttonDelete_Click(object sender, EventArgs e)
    {
        if (listBoxIdName.SelectedIndex != -1)
        {
            int selectedIndex = listBoxIdName.SelectedIndex; 
            listBoxIdName.Items.RemoveAt(selectedIndex);
            manager.DeleteStoredCustomer(selectedIndex);
        }
        ClearContactInformation();
        listBoxIdName.SelectedIndex = -1;
    }
    private void buttonEdit_Click(object sender, EventArgs e)
    {
        if (listBoxIdName.SelectedIndex != -1)
        {
            // Get index of selected item in ListBoxIdName
            int selectedIndex = listBoxIdName.SelectedIndex;
            Customer selectedCustomer = manager.GetStoredCustomer(selectedIndex);
            using (ContactForm selected = new ContactForm(selectedCustomer.GetContact(), "Edit customer " + selectedCustomer.GetName()))
            {
                if (selected.ShowDialog() == DialogResult.OK)
                {
                    selectedCustomer.AddContact(selected.GetContact());
                    manager.ReplaceCustomer(selectedIndex, selectedCustomer);
                    DisplayEditedCustomerInfo(selectedIndex);
                }
            }
        }
        ClearContactInformation();
        listBoxIdName.SelectedIndex = -1;
    }
    #endregion
    #region HELP FUNCTIONS 
    private void ClearContactInformation()
    {
        textBoxContactInfo.Text = string.Empty;
    }
    //Display selected item(customer) from listBoxIdName in textBoxContactInfo
    private void listBoxIdName_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (listBoxIdName.SelectedIndex != -1)
        {
            int selectedIndex = listBoxIdName.SelectedIndex;
            //textBoxContactInfo.Text = manager.GetStoredCustomer(selectedIndex).GetContactInfo();
        }
    }
    //Display/add customer contact information in ListBoxIdName
    // efter editing an existing customer 
    private void DisplayEditedCustomerInfo(int i)
    {
        listBoxIdName.Items[i] = String.Format(stdDetails, currentCustomer.GetID(), currentCustomer.GetName(),
                 currentCustomer.GetContact().Mail.Office, currentCustomer.GetContact().Mail.Personal);
    }
    // Display customer contact information after adding a 
    // new customer 
    private void DisplayCustomerInformation()
    {
        listBoxIdName.Items.Add(String.Format(stdDetails, currentCustomer.GetID(), currentCustomer.GetName(),
                 currentCustomer.GetContact().Mobile.Office, currentCustomer.GetContact().Mail.Personal));
    }
    #endregion
    #region UNUSED 
    private void textBoxContactInfo_TextChanged(object sender, EventArgs e)
    {

    }
    // Display customer information in the right box
    private void buttonShow_Click(object sender, EventArgs e)
    {

    }
    #endregion
}
