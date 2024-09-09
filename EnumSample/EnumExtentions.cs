using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EnumSample
{
    // static ile, ilgili class'ı instance almadan kullanabiliyorum (Console, Math gibi classlar)
    public static class EnumExtentions
    {
        public static string GetDisplayName(this Enum enumValue)
        {
            string displayName = enumValue.GetType().GetMember(enumValue.ToString()).FirstOrDefault().GetCustomAttribute<DisplayAttribute>()?.GetName() ?? enumValue.ToString();

            //string displayName = enumValue.GetType().GetMember(enumValue.ToString()).FirstOrDefault().GetCustomAttribute<DisplayAttribute>()?.GetName();
            //if(string.IsNullOrEmpty(displayName))
            //    displayName = enumValue.ToString(); // Display name özelliğim diğer renklerde yok diye onlar için

            return displayName;
        }
    }
}
