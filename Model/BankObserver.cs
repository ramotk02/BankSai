using System;

namespace AufgabeSai.Model
{
    public abstract class BankObserver : IObserver
    {
        public string Name { get; set; }

        public BankObserver(string name)
        {
            Name = name;
        }

        public void ShowName()
        {
            Console.WriteLine("Beobachter: " + Name);
        }

        public abstract void Update(decimal kontostand);
    }
    
}