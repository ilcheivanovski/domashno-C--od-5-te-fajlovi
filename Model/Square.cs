using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Square
    {
        public int sideA;
        public int CalculateArea() {
            return sideA * sideA;
        }
        public int CalculatePerimetar() {
            return 4 * sideA;
        }
    }
}
