using System;

namespace AufgabeSai.Model
{
    public class BalanceDisplayObserver : BankObserver
    {
        public BalanceDisplayObserver(string name) : base(name)
        {
        }

        public override void Update(decimal kontostand)
        {
            Console.WriteLine(Name + ": Kontostand = " + kontostand + " €");
        }
    }
}