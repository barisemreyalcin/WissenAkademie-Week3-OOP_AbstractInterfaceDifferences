using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterfaceDifferences
{
    public class Rectangle : GeometricShape
    {
        public override string CalcArea()
        {
            return $"Area of the rectangle: {Width * Height}";
        }

        public override void CalcPerimeter()
        {
            Console.WriteLine($"Perimeter of the rectangle: {2 * (Width + Height)}");
        }
    }
}
