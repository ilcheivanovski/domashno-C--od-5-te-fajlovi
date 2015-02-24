using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryTasks3;

namespace Tasks3
{
    class Program
    {
        static void Main(string[] args)
        {
            //task 1 od tretiot fajl ооp - task 3 metodata e dolu pod static void
            Shapes square = new Shapes();
            square.Name = "Kvadrat";
            Console.WriteLine(Shapes.PrintShapeName(square.Name));
            //task 2
            Console.WriteLine(Calculator.Sum(4, 5));
            //Calculator num4 = new Calculator(); не можи да се инстацира објект од статичка класа.
            Console.WriteLine(Calculator.SquareRoot(144));
            //task 3
            Square square1 = new Square();
            Rectangle rectangle = new Rectangle();
            square1.Name = "Square";
            rectangle.Name = "Rectangle";
            square1.SideLength = 12;
            rectangle.SideA = 7;
            rectangle.SideB =8;
            Shape triangle = new Shape();//it has properties Name
            #region task 4
            //task 4
            Baker Space = new Baker();
            Seller Ilche = new Seller();
            Ilche.Name = "Ilche";
            Ilche.LastName = "Ivanovski";
            Customer Mitko = new Customer();
            Mitko.Name = "Mitko";
            Mitko.LastName = "Cakalov";
            Customer Mende = new Customer();
            Mende.Name = "Mende";
            Mende.LastName = "Paunovski";
            Product Burek = new Product();
            Burek.Name = "Burek";
            var CustomerFullName = Mitko.CustomerFullName();
            var CustomerFullName1 = Mende.CustomerFullName();
            var ProductName = Burek.Name;
            Console.WriteLine(Ilche.Sell(CustomerFullName, ProductName));
            Console.WriteLine(Ilche.Sell(CustomerFullName1, ProductName));
            #endregion

        }
    }
}
