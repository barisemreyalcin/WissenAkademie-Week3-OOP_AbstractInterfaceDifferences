using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassSample
{
    public class Mathematics
    {
        public Mathematics() // Normal constructor
        {
            Pi = 7; // Alınan instance'den sonra Pi değerine ulaşılınca bu değeri alır
        }

        static Mathematics() // Static constructor ilk instance aldığında çalışır. Sonraki instance'de static constructor'a uğramaz
        {
            Pi = 3.1415;
        }

        // static field da oluşturabilirim
        public static double Pi = 3.14;

        public void ChangePi(double pi)
        {
            // Burada this.Pi olmaz static olduğu için
            Pi = pi;
        }

        public static double Sum(double x, double y)
        {
            return x + y;
        }

        public double Sums(int upperLimit, double x, double y)
        {
            double sum = 0;
            for (int i = 0; i < upperLimit; i++)
            {
                sum += Sum(x, y);
                // static bir yapıyı static olmayan bir yapıda kullanabiliriz. Ama tersi olmaz
            }
            return sum;
        }
    }
}
