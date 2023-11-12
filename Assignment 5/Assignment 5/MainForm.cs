using System.Drawing;
using System.Security.Cryptography.Pkcs;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Assignment5;

public partial class MainForm : Form
{
    Customer currentCustomer;
    CustomerManager manager;
    int customerID = -1;
    int maxNumberOfCustomers = 3;
    String stdDetails = "{0,-15}{1,-15}{2,-15}{3,-15}";

    public MainForm()
    {
        InitializeComponent();
        this.CenterToScreen();
        // Create an initial Customer object 
        this.currentCustomer = new Customer(customerID);
        // Create a list of Customers that is handled by a "Customer Manager"  
        manager = new CustomerManager(maxNumberOfCustomers);
    }
    #region Functions for adding or editing or deleting existing cutomer 
    private void buttonAdd_Click(object sender, EventArgs e)
    {
        if (!manager.IsFull())
        {
            customerID += 1;
            currentCustomer = new Customer(customerID);
            using ContactForm addForm = new(currentCustomer.GetContact(), "Add new customer");
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                currentCustomer.AddContact(addForm.GetContact());
                manager.AddCustomerToManager(currentCustomer);
                AddCustomerInformation();
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
            if (manager.NumberOfCustomers() == 0)
                customerID = 0;
            else 
            {
                for (int i = selectedIndex; i < manager.NumberOfCustomers(); i++)
                {
                    DispalyCustomerUpdate(i);
                }
            }
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
            using ContactForm selected = new(selectedCustomer.GetContact(), "Edit customer " + selectedCustomer.GetName());
            if (selected.ShowDialog() == DialogResult.OK)
            {
                selectedCustomer.AddContact(selected.GetContact());
                manager.ReplaceCustomer(selectedIndex, selectedCustomer);
                DisplayEditedCustomerInfo(selectedIndex);
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
            textBoxContactInfo.Text = manager.GetStoredCustomer(selectedIndex).GetContactInfo();
        }
    }
    private void DispalyCustomerUpdate(int i)
    {

        string strOut = String.Format(stdDetails,
            manager.GetStoredCustomer(i).CustomerID,
            manager.GetStoredCustomer(i).GetName(),
            manager.GetStoredCustomer(i).GetContact().Mobile.Office,
            manager.GetStoredCustomer(i).GetContact().Mail.Office);
        listBoxIdName.Items[i] = strOut;
    }
    //Display/add customer contact information in ListBoxIdName
    // efter editing an existing customer 
    private void DisplayEditedCustomerInfo(int i)
    {
        string strOut = String.Format(stdDetails, 
            currentCustomer.CustomerID, 
            currentCustomer.GetName(),
            currentCustomer.GetContact().Mobile.Office, 
            currentCustomer.GetContact().Mail.Office);
        listBoxIdName.Items[i] = strOut;
    }
    // Display customer contact information after adding a 
    // new customer 
    private void AddCustomerInformation()
    {
        string strOut = String.Format(stdDetails,
            currentCustomer.CustomerID,
            currentCustomer.GetName(),
            currentCustomer.GetContact().Mobile.Office,
            currentCustomer.GetContact().Mail.Office); 
        listBoxIdName.Items.Add(strOut);
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

    private void MainForm_Load(object sender, EventArgs e)
    {

    }
}
