using Ferramentas.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferramentas
{
    public static class CPFValidator
    {
        public static bool Validate(string cpf)
        {
            if (cpf.Length != 11) return false;

            string firstDigit = Digit.getDigit(cpf, 1).ToString();
            string secondDigit = Digit.getDigit(cpf, 2, firstDigit).ToString();

            bool valid = cpf[9].ToString()== firstDigit &&
                         cpf[10].ToString() == secondDigit ?
                         true : false;

            return valid;
        }
    }
}
