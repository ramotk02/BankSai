using System;
using System.Collections.Generic;

namespace AufgabeSai.Model
{
    public class BankAccount
    {
        private decimal kontostand;
        private List<IObserver> beobachter = new List<IObserver>();

        public void RegisterObserver(IObserver observer)
        {
            beobachter.Add(observer);
        }

        public void UnregisterObserver(IObserver observer)
        {
            beobachter.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (IObserver observer in beobachter)
            {
                observer.Update(kontostand);
            }
        }

        public void Deposit(decimal betrag)
        {
            kontostand = kontostand + betrag;

            Console.WriteLine("\nEinzahlung: " + betrag + " €");
            NotifyObservers();
        }

        public void Withdraw(decimal betrag)
        {
            if (betrag <= kontostand)
            {
                kontostand = kontostand - betrag;

                Console.WriteLine("\nAbhebung: " + betrag + " €");
                NotifyObservers();
            }
            else
            {
                Console.WriteLine("Nicht genug Geld auf dem Konto.");
            }
        }
    }
}