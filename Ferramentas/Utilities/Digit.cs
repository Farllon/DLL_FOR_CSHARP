using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferramentas.Utilities
{
    class Digit
    {
        internal static readonly int[] _firstArrayMultiplier = { 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        internal static readonly int[] _secondArrayMultiplier = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

        internal static int getDigit(string cpf, int digitPos, string foundedDigit = "")
        {
            string cpfForManipulation = cpf.Substring(0, cpf.Length - 2);

            string reversedCPF = digitPos == 1 ? ReverseString.Reverse(cpfForManipulation) :
                                                 ReverseString.Reverse(cpfForManipulation + foundedDigit);

            int[] numerizedCPF = Str2IntArray.Numerize(reversedCPF);

            int[] map = digitPos == 1 ? Map.MapArray(numerizedCPF, _firstArrayMultiplier) :
                                        Map.MapArray(numerizedCPF, _secondArrayMultiplier);
            
            int remainder = Remainder.getRemainder(map);

            int digit = remainder >= 2 ? 11 - remainder : 0;

            return digit;
        }
    }
}
