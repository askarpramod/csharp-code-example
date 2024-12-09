using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeExample
{
    /// <summary>
    /// Convert a string to title case (first letter of each word capitalized), taking a 'String input' and returning the modified string.
    /// </summary>
    public static class StringExtensions
    {
        public static string? ToTitleCase(this string? str)
        {            
                if (string.IsNullOrEmpty(str))
                    return str;

                TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
                string titleCased = textInfo.ToTitleCase(str.ToLower());

                return titleCased;
            
        }
    }
}
