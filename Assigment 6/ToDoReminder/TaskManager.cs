using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoReminder
{
    internal class TaskManager
    {

        private List<Task> tasks;

        public TaskManager() 
        {
            tasks = new List<Task>();
        }

        public bool AddTask(Task task) 
        {
            if (task != null)
            {
                tasks.Add(task);
                return true; 
            }
            else
                return false; 
        }
        public Task GetTask(int index) 
        { 
            return tasks[index]; 
        }
        public void SetTask(Task t, int index)
        {
            tasks[index] = t;
        }
        public void DeleteStoredTask(int selectedIndex) 
        {
            tasks.RemoveAt(selectedIndex);
        }
        public bool WriteDataToFile(string fileName) 
        {
            FileManager fileManager = new FileManager();
            return FileManager.SaveTaskListToFile(tasks, fileName); 
        }
        public bool ReadDataToFile(string fileName) 
        {
            FileManager fileManager = new FileManager();
            return fileManager.ReadTaskListFrFile(tasks, fileName); 
        }
        public string[] GetInfoStringList() 
        {
            string[] infoStrings = new string[tasks.Count]; 
            for(int i = 0; i < infoStrings.Length; i++) 
            {
                infoStrings[i] = tasks[i].ToString();
            }
            return infoStrings;
        }
    }
}
