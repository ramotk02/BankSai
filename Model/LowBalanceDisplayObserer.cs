using System;
using AufgabeSai.Model;

namespace AufgabeSai.Model
{
    public class LowBalanceDisplayObserver : BankObserver
    {
        public LowBalanceDisplayObserver(string name) : base(name)
        {
        }

        public override void Update(decimal kontostand)
        {
            if (kontostand < 100)
            {
                Console.WriteLine(Name + ": Warnung: Ihr Kontostand ist niedrig!");
            }
            else
            {
                Console.WriteLine(Name + ": Ihr Kontostand ist ausreichend.");
            }
        }
    }
}