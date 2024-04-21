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

        static public bool LengthStringValidation(string str)
        {
            str = str.Trim();
            if (str.Length >= MAX_LENGTH || str.Length == 0)
            {
                return false;
            }
            return true;
        }
    }
}
