using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Employee
    {
        public delegate void UpdatePasswordDelegate(string password);
        public event UpdatePasswordDelegate UpdatePasswordEvent;

        private string password;
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                this.password = value;
                if(UpdatePasswordEvent != null)
                {
                    UpdatePasswordEvent(password);
                }
            }
        }

       
    }
}
