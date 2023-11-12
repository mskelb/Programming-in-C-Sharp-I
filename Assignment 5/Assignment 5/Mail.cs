using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public class Mail
    {
        private string personal = "";
        private string office = "";

        public Mail()
        {
        }
        public Mail(string workMail) 
            : this(workMail, string.Empty)
        {
        }
        public void ReplaceMail(Mail theOther)
        {
            this.personal = theOther.personal;
            this.office = theOther.office;
        }
        public Mail(string workMail, string personalMail)
        {
            this.office = workMail;
            this.personal = personalMail;
        }
        #region Getters and Setters 
        public string Personal
        {
            get { return personal; }
            set { personal = value; }
        }
        public string Office
        {
            get { return office; }
            set { office = value; }
        }
        #endregion
        public override string ToString()
        {
            string strOut = "Emails:" + Environment.NewLine;
            strOut += string.Format(" {0,-10} {1, -10}", "Private ", personal) + Environment.NewLine;
            strOut += string.Format(" {0,-10} {1, -10}", "Business ", office);

            return strOut;
        }
    }

}

