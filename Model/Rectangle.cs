using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Rectangle
    {
        public int sideA;
        public int sideB;
        public int CalculateArea() {
            var area = sideA * sideB;
            return area;
        }
        public int CalculatePerimeter()
        {
            var perimetar = 2*(sideA + sideB);
            return perimetar;
        }
        public double CalculateDiagonal() {
            var diagonal = Math.Sqrt(sideA*sideA + sideB*sideB);
            return diagonal;
        }
        public double LongerSide()
        {
            if (sideA>sideB)
            {
                return sideA;
            }
            else
            {
                return sideB;
            }
        }
    }
}
