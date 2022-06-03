using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Common_Library.ValidationFunctions
{
    public class ValidationFunctions
    {
        public static int ValidateName(String name)
        {
            if (String.IsNullOrWhiteSpace(name))
            {
                return 1;
            }
            if (!name.All(c => Char.IsLetter(c) || c == ' '))
            {
                return 2;
            }

            return 0;
            // 0 - helyes név
            // 1 - üres vagy whitespace-ből álló mező
            // 2 - tartalmaz különleges karaktert
        }

        public static int ValidateTAJ(String taj)
        {
            int r = 0;

            if (String.IsNullOrWhiteSpace(taj))
            {
                return 1;
            }

            var regexItem = new Regex(@"\d{3}\s\d{3}\s\d{3}");

            if (!regexItem.IsMatch(taj))
            {
                return 2;
            }

            return 0;
            // 0 - helyes TAJ
            // 1 - üres TAJ mező
            // 2 - helytelen formátum
        }
    }
}
