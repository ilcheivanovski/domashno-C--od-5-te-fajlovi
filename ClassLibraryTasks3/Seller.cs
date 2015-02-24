using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTasks3
{
    public class Seller :Person
    {
        public string FullNameSeller() {
            return Name +" " + LastName;
        }
    }
}
