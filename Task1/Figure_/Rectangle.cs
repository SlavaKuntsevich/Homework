using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure_
{
    public class Rectangle : Figure
    {
        double sideA;
        double sideB;
        public Rectangle(double sideA, double sideB)
        {
            this.sideA = sideA;
            this.sideB = sideB;
        }
        public override double Perimeter() => 2 * (sideA + sideB);
        public override double Square() => sideA * sideB;
    }
}
