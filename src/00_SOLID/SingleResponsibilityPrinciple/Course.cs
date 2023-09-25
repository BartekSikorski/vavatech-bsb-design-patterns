// Zasada pojedynczej odpowiedzialności (Single-Responsibility Principle) - SRP

// Każda klasa powinna być odpowiedzialna za jedną konkretną rzecz.
// Klasa powinna mieć tylko jeden powód do zmiany.


public class Course
{
    public string Title { get; set; }
    public DateTime From { get; set; }
    public DateTime To { get; set; }
}
