using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoReminder
{
    internal class Task
    {
        PriorityType priority;
        string description;
        DateTime dateTime;

        public Task()
        {
            priority = PriorityType.Normal; 
        }
        public Task(DateTime taskDate) :
            this(taskDate, string.Empty, PriorityType.Normal)
        {
        }
        public Task(DateTime taskDate, string descr) :
            this(taskDate, descr, PriorityType.Normal)
        {
        }
        public Task(DateTime taskDate, PriorityType prio) :
            this(taskDate, string.Empty, prio)
        {
        }
        public Task(DateTime dateTime, string descr, PriorityType priority)
        {
            this.priority = priority;
            this.description = descr;
            this.dateTime = dateTime;
        }
        public string Description
        {
            get { return description; }
            set
            {
                description = value;
            }
        }

        public PriorityType Priority
        {
            get { return priority; }
            set { priority = value; }
        }

        public DateTime DateTime
        {
            get { return dateTime;  }
            set { dateTime = value;  }
        }

        public override string ToString()
        {
            string txtout = String.Format("{0,-20} {1,10}  {2,-16}  {3,-20}",
                dateTime.ToLongDateString(), GetTimeString(), GetPriorityString(), Description);
            return txtout; 
        }
        internal string GetTimeString()
        {
            return dateTime.ToShortTimeString(); 
        }
        internal string GetPriorityString()
        {
            return priority.ToString().Replace("_", " ");
        }

    }
    
}
