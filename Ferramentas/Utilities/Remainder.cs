using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferramentas.Utilities
{
    class Remainder
    {
        internal static int getRemainder(int[] array)
        {
            int remainder = 0;

            remainder = AcmSum.Sum(array) % 11;

            return remainder;
        }
    }
}
