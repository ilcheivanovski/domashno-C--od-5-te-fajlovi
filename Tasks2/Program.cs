using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Tasks2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 2 od fajl 2
            Human Ilche = new Human();
            Ilche.FirstName = "Ilche";
            Ilche.LastName = "Ivanovski";
            Ilche.MiddleName = "Dobre";
            Console.WriteLine(Ilche.PrintWelcomeMessage());
            Console.WriteLine(Ilche.IsFullNameLongerThanMaxLentgh(13));
            #endregion
            #region task 3, 4
            Ilche.Contry = "Makedonija";
            #endregion
            Console.WriteLine(Ilche.Contry);

        }
    }
}
