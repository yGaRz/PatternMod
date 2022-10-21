using System;
using System.Collections.Generic;
using System.Text;

namespace PatternMod
{
    public class Account
    {
        // баланс учетной записи
        public double Balance { get; set; }

        // процентная ставка
        public double Interest { get; set; }

        public new string ToString()
        {
            return $"Balance ={Balance}, Interest=  {Interest}";
        }
    }
}
