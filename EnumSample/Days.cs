using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumSample
{
    //internal class Days
    //{
    //}

    // Uygulamamda kullanacağım ön tanımlı listelerimi bu enum yapısı içerisinde kullanıyorum
    public enum Days
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    public enum Colors
    {
        [Display(Name = "Red and Yellow")]
        RedAndYellow,
        Red,
        Green,
        Blue,
        Yellow,
        Orange,
        White,
        Black
    }

    // Default int fakat değiştirebilirim (Ama int'in alt kategorisindeki veri tipleri olmalı. long, decimal, string vs olmaz)
    public enum RGB : byte
    {
        Red = 2, Green = 4, Blue = 8
    }
}
