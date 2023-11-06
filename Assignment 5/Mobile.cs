using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public class Mobile
    {
        private string personal = "";
        private string office = "";
        public Mobile()
        {
        }
        public Mobile(string workMobile)
            : this(workMobile, string.Empty)
        {
        }
        public void ReplaceMobile(Mobile theOther)
        {
            this.personal = theOther.personal;
            this.office = theOther.office;
        }
        public Mobile(string workMobile, string personalMobile)
        {
            this.office = workMobile;
            this.personal = personalMobile;
        }
        #region Getters and Setters 
        public string Personal
        {
            //private mail
            get { return personal; }
            set { personal = value; }
        }
        public string Office
        {
            //private mail
            get { return office; }
            set { office = value; }
        }
        #endregion
    }
}
