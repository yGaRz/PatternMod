using System;

namespace PatternMod
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account();
            account1.Balance = 250000;
            account1.Interest = 0.11;

            Caclculator calc = new Caclculator();
            calc.Calculate(new SalaryProfile(), account1);
            Console.WriteLine(account1.ToString());


            Account account2 = new Account();
            account2.Balance = 5000;
            account2.Interest = 0.07;
            calc.Calculate(new StandartProfile(), account2);
            Console.WriteLine(account2.ToString());
        }
    }
}
