using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferramentas.Utilities
{
    class Str2IntArray
    {
        internal static int[] Numerize(string str)
        {
            int[] nums = new int[str.Length];
            int iter = 0;

            foreach (char c in str)
            {
                nums[iter] = ((int)Char.GetNumericValue(c));
                iter++;
            }

            return nums;
        }
    }
}
