using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeNameCheck
{
    static class Extensions
    {
        public static bool HasDigit(this string str)
        {
            foreach (var ch in str)
            {
                if (char.IsDigit(ch))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
