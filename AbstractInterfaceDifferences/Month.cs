using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Bir class'ta abstract method varsa class'ın önüne abstract eklenmelidir.
namespace AbstractInterfaceDifferences
{
    public abstract class Month
    {
        public Month() {
            Console.WriteLine("Abstract class representing the months of the year.");
        } 

        public void MonthCount ()
        {
            Console.WriteLine("1 year is always 12 months.");
        }

        // Derived class'larda değiştirilecek(zorunlu olanlar) methodlar abstract ile işaretlenir
        public abstract void MonthNumber();
        public abstract void MonthName();
        // Değiştirmek isteğime bağlı ise virtual ile işaretlerim. Değiştrilmesi zorunlu değildir
        public virtual void DayCount()
        {
            Console.WriteLine("30 days");
        }
    }
}
