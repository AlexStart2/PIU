using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Validations
    {
        private const int MAX_LENGTH = 50;
        private const int MIN_LENGTH = 2;
        private const string TOO_LONG = "Campul trebuie sa contina maxim 50 de caractere";
        private const string TOO_SHORT = "Campul trebuie sa contina minim 2 caractere";


        static public void LengthStringValidation(string str)
        {
            str = str.Trim();
            if (str.Length >= MAX_LENGTH)
            {
                throw new Exception(TOO_LONG);
            }
            if(str.Length < MIN_LENGTH)
            {
                throw new Exception(TOO_SHORT);
            }
        }
    }
}
