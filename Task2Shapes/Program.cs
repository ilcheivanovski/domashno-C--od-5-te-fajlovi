using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Task2Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            #region task 2 and 3 and Bonus Bonus
            Square square = new Square();
            square.sideA = 12;
            Rectangle rectangle = new Rectangle();
            rectangle.sideA = 9;
            rectangle.sideB = 12;
            Console.WriteLine("{0} {1} {2} {3} {4}", "The area of square is: ", square.CalculateArea(), " and ",  "The Perimetar of the square is: ", square.CalculatePerimetar());
            Console.WriteLine("The Area of Rectangle is: {0}The Perimetar of Rectangle: {1}The Diagonal of the Rectangle is: {2}The Longer side of the Rectangle is: {3}", rectangle.CalculateArea()+"\n", rectangle.CalculatePerimeter() + "\n", rectangle.LongerSide() + "\n", rectangle.CalculateDiagonal());
            //BONUS
            PrintArea(10, rectangle);
            //BONUS BONUS
            BiggerPerimeter(square, rectangle);
            #endregion
        }
        #region task bonus bonus
        public static void PrintArea(int n, Rectangle rectangle)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("The area is: "+rectangle.CalculateArea());
            }
        }
        public static void BiggerPerimeter(Square square, Rectangle rectangle)
        {
            if (square.CalculatePerimetar() > rectangle.CalculatePerimeter())
            {
                Console.WriteLine("The bigger Perimetar has the Square and is: " + square.CalculatePerimetar());
            }
            else
            {
                Console.WriteLine("The bigger Perimetar has the Square and is: " + rectangle.CalculatePerimeter());
            }
        }
        #endregion

    }
}
