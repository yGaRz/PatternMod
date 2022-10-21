using System;
using System.Collections.Generic;
using System.Text;

namespace PatternMod
{
    class Caclculator
    {
        public void Calculate(ICalc calcProfile,Account acc)
        {
            calcProfile.CalculateInterest(acc);
        }
    }
}
