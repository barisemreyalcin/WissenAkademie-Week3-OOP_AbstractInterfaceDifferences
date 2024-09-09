using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterfaceDifferences
{
    public class November : IMonth
    {
        public string MonthName { get; set; }
        public int DayCount { get; set; }
        public int MonthNumber { get; set; }
    }
}
