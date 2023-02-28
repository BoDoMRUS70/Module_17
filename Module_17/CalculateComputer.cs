using Module_17_Patterns.Modes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_17_Patterns
{
    class CalculateComputer
    {
        public void PerformCalculation(ICalculateMode calculateMode, Account account)
        {
            calculateMode.Calculate(account);
        }
    }
}
