using System;
using System.Collections.Generic;
using System.Text;

namespace PatternMod
{
    class StandartProfile:ICalc
    {
        public void CalculateInterest(Account account)
        {
            account.Interest = account.Balance * 0.5;
        }
    }
}
