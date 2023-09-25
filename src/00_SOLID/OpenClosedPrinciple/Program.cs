// Zasada otwarte – zamknięte (Open/Closed Principle) - OCP

// Każda klasa powinna być otwarta na rozbudowę ale zamknięta na modyfikacje.
// Oznacza to, że taka klasa pozwala na rozszerzenie swojego zachowania
// bez modyfikowania kodu źródłowego.

// Przykład łamiący zasadę otwarte – zamknięte
ITaxCalculator standardCalculator = new StandardTaxCalculator();
ITaxCalculator progressiveCalculator = new ProgressiveTaxCalculator();

decimal standardTax = standardCalculator.CalculateTax(60_000);
decimal progressiveTax = standardCalculator.CalculateTax(60_000);

Console.WriteLine($"Standard Tax: {standardTax}");
Console.WriteLine($"Progressive Tax: {progressiveTax}");

