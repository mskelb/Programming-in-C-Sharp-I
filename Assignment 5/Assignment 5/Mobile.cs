using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class Mobile
    {
        private string mobile;
        private string business; 
        public Mobile() 
        {
        }
        public void SetMobile (string mobile)
        {
            this.mobile = mobile;   
        }  
        public string GetMobile() 
        {
            return this.mobile;
        }
        public void SetBusiness(string business) 
        {
            this.business = business;
        }
        public string GetBusiness() 
        {
            return this.business;
        }
    }
}
