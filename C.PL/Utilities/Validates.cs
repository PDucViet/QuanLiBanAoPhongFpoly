using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    }
}
