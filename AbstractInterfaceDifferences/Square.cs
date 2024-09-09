using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterfaceDifferences
{
    public class Square : GeometricShape
    {
        public Square(double edgeLength) { 
            this.Height = this.Width = edgeLength; // this kullanmasam da olur
        }

        public override string CalcArea()
        {
            return $"Area of the square: {Math.Pow(Width, 2)}";
            //return $"Area of the square: {Math.Pow(Height, 2)}";
            //return $"Area of the square: {Height * Width}";
        }

        public override void CalcPerimeter()
        {
            Console.WriteLine($"Perimeter of the square: {4 * Width}");
        }
    }
}
