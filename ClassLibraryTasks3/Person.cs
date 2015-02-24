using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTasks3
{
    public class Person
    {
        public string Name;
        public string LastName;
        public int IdNumber;
        public string Sell(string CustomerFullName, string ProductName) {
            return Name + " " +LastName+" sold to "+ CustomerFullName +" a "+ ProductName;
        }
    }
}
