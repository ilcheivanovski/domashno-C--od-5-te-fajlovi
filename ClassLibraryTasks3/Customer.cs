using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTasks3
{
    public class Customer
    {
        public string Name;
        public string LastName;
        public string CustomerFullName()
        {
            return Name +" "+ LastName;
        }
    }
}
