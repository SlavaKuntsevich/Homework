using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure_
{
    public class Circle : Figure
    {
        double Radius;
        public Circle(double radius)
        {
            Radius = radius;
        }
        public override double Perimeter() => 2 * 3.14 * Radius;
        public override double Square() => 3.14 * (Radius*Radius);
        

    }
}
