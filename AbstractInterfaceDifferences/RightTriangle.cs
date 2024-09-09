using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterfaceDifferences
{
    public class RightTriangle : GeometricShape
    {
        public override string CalcArea()
        {
            return $"Area of the right triangle: {Width * Height * 0.5}";
        }

        public override void CalcPerimeter()
        {
            double hypotenuse = Math.Sqrt(Math.Pow(Height, 2) + Math.Pow(Width, 2));
            Console.WriteLine($"Perimeter of the right triangle: {hypotenuse + Height + Width}");
        }
    }
}
