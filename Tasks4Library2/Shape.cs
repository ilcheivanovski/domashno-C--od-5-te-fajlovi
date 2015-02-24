using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks4Library2
{
    public abstract class Shape
    {
        public abstract int CalculateArea();
        public virtual string Describe()
        {
            return "I am a Shape";
        }
    }
}
