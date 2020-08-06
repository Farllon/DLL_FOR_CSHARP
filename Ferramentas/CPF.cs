using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferramentas
{
    public class CPF
    {
        internal static readonly int[] ARRAY1 = { 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        internal static readonly int[] ARRAY2 = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

        internal static string Reverse (string str)
        {
            char[] stringArray = str.ToCharArray();
            Array.Reverse(stringArray);
            return new string(stringArray);
        }

        internal static object Numerize (string str)
        {
            int[] nums = new int[str.Length];
            int iter = 0;

            foreach (char c in str)
            {
                if (Char.IsNumber(c) == false)
                {
                    return false;
                }

                nums[iter] = ((int)Char.GetNumericValue(c));

                iter++;
            }

            return nums;
        }

        internal static int Sum (int[] numbers)
        {
            int total = 0;
            foreach(int n in numbers)
            {
                total += n;
            }
            return total;
        }

        internal static object Map (params int[][] values)
        {
            if ((values.Length != 2) || (values[0].Length != values[1].Length)) return false;

            int[] nums = new int[values[0].Length];

            for (int iterator = 0; iterator < values[0].Length; iterator++)
            {
                nums[iterator] = values[0][iterator] * values[1][iterator];
            }

            return nums;
        }

        internal static int getDigit (int remainder)
        {
            int firstDigit = 0;

            if (remainder >= 2)
            {
                firstDigit = 11 - remainder;
            }

            else
            {
                firstDigit = 0;
            }

            return firstDigit;
        }

        internal static object getRemainder (string cpf, int digit = 1)
        {
            int remainder = 0;

            cpf = CPF.Reverse(cpf);

            var cpfNumerize = CPF.Numerize(cpf);

            if (cpfNumerize.GetType() != typeof(System.Int32[]))
            {
                return false;
            }

            var mapping1 = CPF.Map((int[])cpfNumerize, CPF.ARRAY1);
            var mapping2 = CPF.Map((int[])cpfNumerize, CPF.ARRAY2);

            if (digit == 1)
            {
                if (mapping1.GetType() != typeof(System.Int32[]))
                {
                    return false;
                }

                remainder = CPF.Sum((int[])mapping1) % 11;
            }

            else if (digit == 2)
            {
                if (mapping2.GetType() != typeof(System.Int32[]))
                {
                    return false;
                }

                remainder = CPF.Sum((int[])mapping2) % 11;
            }

            return remainder;
        }

        public static bool Validate (string cpf)
        {
            if (cpf.Length > 11 || cpf.Length < 11) return false;

            string original = cpf;

            cpf = cpf.Substring(0, cpf.Length - 2);

            var remainder = CPF.getRemainder(cpf, 1);

            if (remainder.GetType() != typeof(System.Int32)) 
                return false;

            int firstDigit = CPF.getDigit((int)remainder);

            remainder = CPF.getRemainder(cpf + firstDigit.ToString(), 2);

            if (remainder.GetType() != typeof(System.Int32))
                return false;

            int secondDigit = CPF.getDigit((int)remainder);

            if ((int)Char.GetNumericValue(original[9]) == firstDigit &&
                (int)Char.GetNumericValue(original[10]) == secondDigit)
            {
                return true;
            }

            else return false;
        }
    }
}
