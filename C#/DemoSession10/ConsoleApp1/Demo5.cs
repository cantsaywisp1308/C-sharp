using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Demo5
    {
        public void Run()
        {
            Employee employee = new Employee();
            
            employee.UpdatePasswordEvent += SendEmail;
            employee.UpdatePasswordEvent += SendSMS;
            employee.Password = "abc";
        }

        private void SendSMS(string password)
        {
            Debug.WriteLine("Change password: Send SMS!");
        }

        private void SendEmail(string password)
        {
            Debug.WriteLine("Change password: Send Email!");
        }
    }
}
