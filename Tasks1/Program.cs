using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Threading.Tasks;

namespace Tasks1
{
    class Program
    {
        static void Main(string[] args)
        {
            Human Ilche = new Human();
            Ilche.FirstName = "Ilche";
            Ilche.LastName = "Ivanovski";
            Console.WriteLine(Ilche.GetFullName());
        }
    }
}
