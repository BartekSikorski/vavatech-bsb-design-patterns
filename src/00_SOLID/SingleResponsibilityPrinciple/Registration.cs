// Zasada pojedynczej odpowiedzialności (Single-Responsibility Principle) - SRP

// Każda klasa powinna być odpowiedzialna za jedną konkretną rzecz.
// Klasa powinna mieć tylko jeden powód do zmiany.


public class Registration
{
    public void Register(Student student)
    {
        // Register a student
        // Perform validation and save to DB
        Console.WriteLine("Registering the student");
    }
}
