using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova02_LP_B
{
    class TextBoxHelper
    {
        public bool validateInput(string input)
        {
            double n;
            return !String.IsNullOrWhiteSpace(input) && double.TryParse(input, out n);
        }
    }
}
