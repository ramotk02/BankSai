# AufgabeSai - Bank Account Observer Pattern

## Description

**AufgabeSai** is a simple C# console application that demonstrates the **Observer Design Pattern** using a bank account example.

The project shows how different observers can react automatically when the bank account balance changes after a deposit or withdrawal.

## Project Goal

The goal of this project is to understand how the Observer Pattern works in a simple and practical way.

In this application:

- `BankAccount` is the subject being observed.
- Observers are registered to the bank account.
- When the account balance changes, all registered observers are notified.
- Each observer reacts differently depending on its responsibility.

## Technologies Used

- C#
- .NET 8
- Console Application
- Object-Oriented Programming
- Observer Design Pattern

## Project Structure

```text
AufgabeSai/
├── Program.cs
├── AufgabeSai.csproj
└── Model/
    ├── BankAccount.cs
    ├── IObserver.cs
    ├── BankObserver.cs
    ├── BalanceDisplayObserver.cs
    ├── LowBalanceDisplayObserver.cs
    └── FraudDetectionObserver.cs
```

## Main Classes

### BankAccount

The `BankAccount` class represents the bank account.

It stores the current balance and manages the list of observers.

Main methods:

- `RegisterObserver()` adds a new observer.
- `UnregisterObserver()` removes an observer.
- `NotifyObservers()` informs all observers about the current balance.
- `Deposit()` adds money to the account.
- `Withdraw()` removes money from the account if enough balance is available.

### IObserver

`IObserver` is an interface that defines the method every observer must implement.

```csharp
void Update(decimal kontostand);
```

This method is called whenever the account balance changes.

### BankObserver

`BankObserver` is an abstract class that implements `IObserver`.

It contains a `Name` property and forces every child class to implement its own `Update()` method.

### BalanceDisplayObserver

This observer displays the current account balance.

Example:

```text
Anzeige: Kontostand = 900 €
```

### LowBalanceDisplayObserver

This observer checks if the account balance is low.

If the balance is under 100 €, it shows a warning message.

Example:

```text
Warnsystem: Warnung: Ihr Kontostand ist niedrig!
```

### FraudDetectionObserver

This observer detects suspicious withdrawals.

If a withdrawal is greater than or equal to 500 €, it displays a fraud warning.

Example:

```text
Betrugsschutz: Verdächtige Abhebung erkannt! Betrag: 850 €
```

## How the Program Works

In `Program.cs`, three observers are created and registered to the bank account:

```csharp
BalanceDisplayObserver display = new BalanceDisplayObserver("Anzeige");
LowBalanceDisplayObserver warnung = new LowBalanceDisplayObserver("Warnsystem");
FraudDetectionObserver betrug = new FraudDetectionObserver("Betrugsschutz");

konto.RegisterObserver(display);
konto.RegisterObserver(warnung);
konto.RegisterObserver(betrug);
```

After that, the account balance is changed using deposits and withdrawals:

```csharp
konto.Deposit(1000);
konto.Withdraw(100);
konto.Withdraw(850);
konto.UnregisterObserver(display);
konto.Deposit(200);
```

Each time the balance changes, all registered observers are notified automatically.

## Example Output

```text
Einzahlung: 1000 €
Anzeige: Kontostand = 1000 €
Warnsystem: Ihr Kontostand ist ausreichend.
Betrugsschutz: Betrugsüberwachung gestartet.

Abhebung: 100 €
Anzeige: Kontostand = 900 €
Warnsystem: Ihr Kontostand ist ausreichend.

Abhebung: 850 €
Anzeige: Kontostand = 50 €
Warnsystem: Warnung: Ihr Kontostand ist niedrig!
Betrugsschutz: Verdächtige Abhebung erkannt! Betrag: 850 €

Einzahlung: 200 €
Warnsystem: Ihr Kontostand ist ausreichend.
```

## How to Run the Project

1. Open the project in Visual Studio, Rider, or another C# IDE.
2. Make sure .NET 8 is installed.
3. Open the solution file:

```text
AufgabeSai.sln
```

4. Run the project.

You can also run it from the terminal:

```bash
dotnet run --project AufgabeSai/AufgabeSai.csproj
```

## Design Pattern Explanation

This project uses the **Observer Pattern**.

The Observer Pattern is useful when one object changes and other objects need to react automatically.

In this project:

- The bank account is the subject.
- The display, warning system, and fraud detection system are observers.
- When the balance changes, the observers receive the new balance.

This makes the program easier to extend because new observers can be added without changing the main `BankAccount` logic.

## Author

Omar Taky
