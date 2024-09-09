using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterfaceDifferences
{
    public class AbstractDecember : Month
    {
        public AbstractDecember()
        { // Constructor
            Console.WriteLine("December Class Initialized");
        }

        // Zorunlu
        public override void MonthName()
        {
            Console.WriteLine("December");
        }

        public override void MonthNumber()
        {
            Console.WriteLine("12th month of the year");
        }
        // Zorunlu

        // Opsiyonel - İhtiyaca göre
        public override void DayCount()
        {
            Console.WriteLine("31 days");
        }
        // Opsiyonel - İhtiyaca göre

        // Override etmeden base'deki ile aynı isimde bir method da kullanabilirim
        //public void DayCount()
        //{
        //    Console.WriteLine("31 days");
        //}

    }
}
