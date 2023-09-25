// Zasada pojedynczej odpowiedzialności (Single-Responsibility Principle) - SRP

// Każda klasa powinna być odpowiedzialna za jedną konkretną rzecz.
// Klasa powinna mieć tylko jeden powód do zmiany.

// #1 Przykład łamiący zasadę pojedynczej odpowiedzialności

interface IValidator
{
    void Validate(string content);
}
