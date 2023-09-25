// Zasada pojedynczej odpowiedzialności (Single-Responsibility Principle) - SRP

// Każda klasa powinna być odpowiedzialna za jedną konkretną rzecz.
// Klasa powinna mieć tylko jeden powód do zmiany.

// #1 Przykład łamiący zasadę pojedynczej odpowiedzialności

class EmailValidator : IValidator
{
    public void Validate(string content)
    {
        ValidateEmail(content);
    }

    private static void ValidateEmail(string email)
    {
        if (!email.Contains("@") || !email.Contains("."))
        {
            throw new FormatException("Email address is a invalid format!");
        }
    }
}
