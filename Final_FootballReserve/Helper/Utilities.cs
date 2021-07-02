using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_FootballReserve.Helper
{
    class Utilities
    {
        public static bool NotEmpty(string[] arr)
        {
            foreach (var a in arr)
            {
                if (string.IsNullOrWhiteSpace(a))
                {
                    return false;
                }
            }
            return true;
        }
    }
}

