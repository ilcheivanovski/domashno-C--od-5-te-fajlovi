using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasks4Library2;
namespace Tasks4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region task 1 polimorfizam
            Animal Cat = new Animal();
            Dog Bleki = new Dog();
            var BlekiDescribe = "Bleki says: "+Bleki.Describe();
            var CatDescribe = "The Cat says: "+Cat.Describe();
            Console.WriteLine(CatDescribe);
            Console.WriteLine(BlekiDescribe);
            #endregion
            #region task 2 abstraktni klasi, polimorfizam
            Rectangle rectangle = new Rectangle();
            Square square = new Square();
            var RectangleDescribe = rectangle.Describe();
            var SquareleDescribe = square.Describe();
            Console.WriteLine(RectangleDescribe);
            Console.WriteLine(SquareleDescribe);
            #endregion
            #region task 3
            Person Weko = new Person();
            Weko.FirstName = "Wekoslav";
            Weko.LastName = "Stefanovski";
            var WekoFullName = Weko.FirstName + " "+Weko.LastName;
            Console.WriteLine(WekoFullName);
            #endregion
        }
    }
}
