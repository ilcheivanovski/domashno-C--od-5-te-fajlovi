using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks4Library2
{
    public class Square :Shape
    {
        public int SideA;
        public override string Describe()
        {
            return "I am a Square";
        }
        public override int CalculateArea()
        {
            return SideA * SideA;
        }
    }
}
