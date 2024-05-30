using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UberNew.Utility
{
    internal class Validations
    {
        public static bool IsValidEmail(string email)
        {
            // Regular expression pattern for email validation
            string pattern = @"^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$";

            // Check if the email matches the pattern
            return Regex.IsMatch(email, pattern);
        }
    }
}
