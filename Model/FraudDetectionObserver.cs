using System;

namespace AufgabeSai.Model
{
    public class FraudDetectionObserver : BankObserver
    {
        private decimal letzterKontostand;
        private bool ersterUpdate = true;

        public FraudDetectionObserver(string name) : base(name)
        {
        }

        public override void Update(decimal kontostand)
        {
            if (ersterUpdate == false)
            {
                decimal differenz = letzterKontostand - kontostand;

                if (differenz >= 500)
                {
                    Console.WriteLine(Name +
                                      ": Verdächtige Abhebung erkannt! Betrag: " +
                                      differenz + " €");
                }
            }
            else
            {
                Console.WriteLine(Name + ": Betrugsüberwachung gestartet.");
                ersterUpdate = false;
            }

            letzterKontostand = kontostand;
        }
    }
}