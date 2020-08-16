using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferramentas.Utilities
{
    class AcmSum
    {
        internal static int Sum(int[] numbers)
        {
            int total = 0;
            foreach (int n in numbers)
            {
                total += n;
            }
            return total;
        }
    }
}
