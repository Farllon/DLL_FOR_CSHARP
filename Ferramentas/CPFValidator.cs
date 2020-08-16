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
            if (cpf.Length != 11) throw new Exception("CPF não condiz com o tamanho real");

            List<string> originalDigits = new List<string>();
            List<int> generatedDigits = new List<int>();
 
            originalDigits.Add(cpf[9].ToString());
            originalDigits.Add(cpf[10].ToString());

            generatedDigits.Add(Digit.getDigit(cpf, 1));
            generatedDigits.Add(Digit.getDigit(cpf, 2, generatedDigits[0].ToString()));

            bool valid = originalDigits[0] == generatedDigits[0].ToString() &&
                         originalDigits[1] == generatedDigits[1].ToString() ?
                         true : false;

            return valid;
        }
    }
}
