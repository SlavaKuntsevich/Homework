using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure_
{
    public class Triangle : Figure
    {
        double sideFirst;
        double sideSecond;
        double sideThird;
        public Triangle(double sideFirst, double sideSecond, double sideThird)
        {
            this.sideFirst = sideFirst;
            this.sideSecond = sideSecond;
            this.sideThird = sideThird;
        }
        public override double Perimeter()
        {
            return sideFirst + sideSecond + sideThird;
        }
        public override double Square()
        {
            double halfPerimeter = (sideFirst + sideSecond + sideThird)/2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - sideFirst) * (halfPerimeter - sideSecond) * (halfPerimeter - sideThird));
        }
    }
}
