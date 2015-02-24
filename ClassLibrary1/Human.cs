using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Human
    {
        public string FirstName;
        public string LastName;
        public string GetFullName() {
            var fullname = FirstName + " " + LastName;
            return fullname;
        }
    }
}
