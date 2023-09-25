// Zasada otwarte – zamknięte (Open/Closed Principle) - OCP

// Każda klasa powinna być otwarta na rozbudowę ale zamknięta na modyfikacje.
// Oznacza to, że taka klasa pozwala na rozszerzenie swojego zachowania
// bez modyfikowania kodu źródłowego.

// Przykład łamiący zasadę otwarte – zamknięte



public class ProgressiveTaxCalculator : ITaxCalculator
{
    private decimal incomeLimit;

    public ProgressiveTaxCalculator(decimal incomeLimit = 50_000)
    {
        this.incomeLimit = incomeLimit;
    }

    public decimal CalculateTax(decimal income)
    {
        if (income <= incomeLimit)        // Magic Numbers
        {
            return income * 0.1m; // 10% tax for income up to 50000
        }
        else
        {
            return income * 0.3m; // 30% tax for income above 50000
        }
    }
}

