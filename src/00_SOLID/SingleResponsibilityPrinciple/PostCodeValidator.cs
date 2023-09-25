// Zasada pojedynczej odpowiedzialności (Single-Responsibility Principle) - SRP

// Każda klasa powinna być odpowiedzialna za jedną konkretną rzecz.
// Klasa powinna mieć tylko jeden powód do zmiany.

// #1 Przykład łamiący zasadę pojedynczej odpowiedzialności

class PostCodeValidator : IValidator
{
    public void Validate(string content)
    {
        ValidatePostCode(content);
    }

    private static void ValidatePostCode(string postcode)
    {
        if (postcode.Length != 5)
        {
            throw new FormatException("Post code is a invalid format!");
        }
    }
}
