using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WpfRegex.Controller
{
    public class ValidatesCustom
    {
        public static bool ValidEmail(string email)
        {
            var emailPattern = @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*"
                     + "@"
                     + @"((([\w]+([-\w]*[\w]+)*\.)+[a-zA-Z]{2,4})|"
                     + @"((([01]?[0-9]{1,2}|2[0-4][0-9]|25[0-5]).){3}[01]?[0-9]{1,2}|2[0-4][0-9]|25[0-5]))\z";

            Regex regexmail = new Regex(emailPattern);
            return regexmail.IsMatch(email);
        }

        public static bool ValidPhone(string telefone)
        {
            var phonePattern = @"^(?<countryCode>[\+][1-9]{1}[0-9]{0,2}\s)?(?<areaCode>0?[1-9]\d{0,4})(?<number>\s[1-9][\d]{5,12})(?<extension>\sx\d{0,4})?$";

            Regex regexphone = new Regex(phonePattern);
            return regexphone.IsMatch(telefone);
        }
    }
}
