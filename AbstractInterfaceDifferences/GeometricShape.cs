using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterfaceDifferences
{
    public abstract class GeometricShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public abstract string CalcArea();
        public abstract void CalcPerimeter();
    }
}
