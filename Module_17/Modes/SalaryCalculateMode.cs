using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_17_Patterns.Modes
{
    public class SalaryCalculateMode : ICalculateMode
    {
        public void Calculate(Account account)
        {
            // расчет процентной ставки зарплатного аккаунта по правилам банка
            account.Interest = account.Balance * 0.5;
        }
    }
}
