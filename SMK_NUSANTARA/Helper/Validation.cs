using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMK_NUSANTARA.Helper
{
    public static class Validation
    {
        public static bool validationString(List<string> strgs)
        {
            foreach(string str in strgs)
            {
                if (String.IsNullOrEmpty(str))
                {
                    return false;
                }
            }
                return true;
        }
    }
}
