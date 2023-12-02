using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace C.PL.Utilities
{
    public class Validates
    {
        #region Check số điện thoại
        public static bool CheckSDT(string sdt)
        {
            if (sdt.Substring(0, 1) == "0" && sdt.Length == 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
        #region Chỉ được dùng số

        #endregion
        #region Check Email
        public static bool CheckEmail(string Email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(Email, pattern);
        }

        #endregion

    }
}
