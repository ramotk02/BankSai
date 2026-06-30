using AufgabeSai.Model;

namespace AufgabeSai
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            BankAccount konto = new BankAccount();

            BalanceDisplayObserver display =
                new BalanceDisplayObserver("Anzeige");

            LowBalanceDisplayObserver warnung =
                new LowBalanceDisplayObserver("Warnsystem");

            FraudDetectionObserver betrug =
                new FraudDetectionObserver("Betrugsschutz");

            // Observer anmelden
            konto.RegisterObserver(display);
            konto.RegisterObserver(warnung);
            konto.RegisterObserver(betrug);

            // Kontostand ändern
            konto.Deposit(1000);

            konto.Withdraw(100);

            konto.Withdraw(850);

            // Einen Observer abmelden
            konto.UnregisterObserver(display);
            

            konto.Deposit(200);

            Console.ReadKey();
        }
    }
}