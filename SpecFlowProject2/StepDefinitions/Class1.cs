using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject2.StepDefinitions
{
    public class Login
    {
        private int uid;
        public int userid
        {
            get { return uid; }
            set
            {
                if (value == 1)
                {
                    uid = value;
                }
                else
                {
                    Console.WriteLine("Invalid ID....");
                }
            }
        }
        private string Pass;
        public string password
        {
            get { return Pass; }
            set
            {
                if (value == "Aneesh22")
                {
                    Pass = value;
                }
                else
                {
                    Console.WriteLine("Invalid Password....");
                }
            }
        }
    }
}
