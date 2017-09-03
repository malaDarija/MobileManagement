using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MobileManagement.Data.Helper
{
    public static class StringHelper
    {
        public static bool IsValidEmail(this string email)
        {
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                               @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                                @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(email))
                return (true);
            else
                return (false);
        }

        public static bool IsValidPrice(this string price)
        {
            string strRegex = @"^[0-9]+,[0-9]{0,2}$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(price))
                return (true);
            else
                return (false);
        }
    }
}
