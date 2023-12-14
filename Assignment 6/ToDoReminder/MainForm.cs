using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoReminder
{
    public partial class MainForm : Form
    {
        TaskManager manager;
        string fileName = Application.StartupPath + "\\reminders.txt";
        int selectedIndex;
        bool editMode = false;
        Task currentTask;

        public MainForm()
        {
            InitializeComponent();
            this.CenterToScreen();
            InitializePriorityTypes();
            this.currentTask = new Task();
            this.manager = new TaskManager();
        }
        private void InitializePriorityTypes()
        {
            PriorityBox.Items.AddRange(GetPriorities());
            PriorityBox.SelectedIndex = 2;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dglResult = MessageBox.Show("Sure you want to exit?", "Think twice.", MessageBoxButtons.OKCancel);
            if (dglResult == DialogResult.OK)
                Application.Exit();
        }
        private void NewMenuItem_Click(object sender, EventArgs e)
        {
            this.currentTask = new Task();
            this.manager = new TaskManager();
            listBoxInfo.Items.Clear();
            ClearAll();

        }
        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (listBoxInfo.SelectedIndex != -1)
            {
                buttonAdd.Text = "Save";
                editMode = true;
                selectedIndex = listBoxInfo.SelectedIndex;
                Task selectedTask = manager.GetTask(selectedIndex);
                // Description 
                ToDoTextBox.Text = selectedTask.Description;
                // Date and time 
                dateTimePickerBox.Value = selectedTask.DateTime;
                // Priority 
                PriorityBox.SelectedIndex = Array.IndexOf(Enum.GetValues(selectedTask.Priority.GetType()), selectedTask.Priority);
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Task task = ReadInput();
            if (manager.AddTask(task))
            {
                DisplayTask();
            }
        }
        private Task ReadInput()
        {
            if (string.IsNullOrEmpty(ToDoTextBox.Text))
            {
                MessageBox.Show("No subject? Write something, please!");
                return null;
            }
            this.currentTask.Priority = (PriorityType)Enum.Parse(typeof(PriorityType),
                    PriorityBox.SelectedItem.ToString().Replace(" ", "_"));
            this.currentTask.Description = ToDoTextBox.Text;
            this.currentTask.DateTime = dateTimePickerBox.Value;
            return currentTask;
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxInfo.SelectedIndex != -1)
            {
                int selectedIndex = listBoxInfo.SelectedIndex; 
                listBoxInfo.Items.RemoveAt(selectedIndex);
                manager.DeleteStoredTask(selectedIndex);
            }
        }
        private void ClearAll()
        {
            ToDoTextBox.Clear();
            PriorityBox.SelectedIndex = 2;
            dateTimePickerBox.Value = DateTime.Now;
        }
        private void DisplayTask()
        {
            if (editMode)
            {
                manager.SetTask(currentTask, selectedIndex);
                listBoxInfo.Items[selectedIndex] = currentTask.ToString();
                editMode = false;
                buttonAdd.Text = "Add";
            }
            else
            {
                listBoxInfo.Items.Add(currentTask.ToString());
            }
            ClearAll();
        }
        public void RetrieveFromFile()
        {
            listBoxInfo.Items.Clear();
            string[] infoStrings = manager.GetInfoStringList();
            if (infoStrings != null)
                listBoxInfo.Items.AddRange(infoStrings);
        }
        private void saveDataFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string err = "Something went wrong when saving data to file";
            bool ok = manager.WriteDataToFile(fileName);
            if (!ok)
                MessageBox.Show(err);
            else
                MessageBox.Show("Data saved to file: " + Environment.NewLine + fileName);
        }
        private void openDataFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool ok = manager.ReadDataToFile(fileName);
            if (!ok)
            {
                string errorM = "Something went wrong when opening the file";
                MessageBox.Show(errorM);
            }
            else
                RetrieveFromFile();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label8.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }
        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }
        private void PriorityBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void labelPriority_Click(object sender, EventArgs e)
        {
        }
        private void labelToDo_Click(object sender, EventArgs e)
        {
        }
        private void labelDateTime_Click(object sender, EventArgs e)
        {
        }
        private void listBoxInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void ToDoTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
        private void toolTip1_Popup_1(object sender, PopupEventArgs e)
        {

        }
        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

    }
}
