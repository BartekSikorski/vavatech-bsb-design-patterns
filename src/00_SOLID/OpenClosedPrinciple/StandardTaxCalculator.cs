// Zasada otwarte – zamknięte (Open/Closed Principle) - OCP

// Każda klasa powinna być otwarta na rozbudowę ale zamknięta na modyfikacje.
// Oznacza to, że taka klasa pozwala na rozszerzenie swojego zachowania
// bez modyfikowania kodu źródłowego.

// Przykład łamiący zasadę otwarte – zamknięte



public class StandardTaxCalculator : ITaxCalculator
{
    public decimal CalculateTax(decimal income)
    {
        return income * 0.2m; // Standard tax rate of 20%
    }
}

