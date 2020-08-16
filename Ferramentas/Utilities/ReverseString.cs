using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferramentas.Utilities
{
    class ReverseString
    {
        internal static string Reverse(string str)
        {
            char[] stringArray = str.ToCharArray();
            Array.Reverse(stringArray);
            return new string(stringArray);
        }
    }
}
