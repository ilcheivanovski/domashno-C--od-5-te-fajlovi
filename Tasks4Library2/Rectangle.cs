using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks4Library2
{
    public class Rectangle :Shape
    {
        public int SideA;
        public int SideB;
        public override int CalculateArea() {
            return SideA * SideB;
        }
        public override string Describe()
        {
            return "I am a Rectangle";
        }
    }
}
