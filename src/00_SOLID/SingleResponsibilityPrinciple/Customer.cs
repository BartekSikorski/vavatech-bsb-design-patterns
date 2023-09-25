// Zasada pojedynczej odpowiedzialności (Single-Responsibility Principle) - SRP

// Każda klasa powinna być odpowiedzialna za jedną konkretną rzecz.
// Klasa powinna mieć tylko jeden powód do zmiany.


using System.Reflection;

class Customer
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string City { get; set; }
    public string PostCode { get; set; }
    public string Street { get; set; }
    public string Email { get; set; }    
}

// Przykład #3
public class User
{
    public string Username { get; set; }
    public string HashedPassword { get; set; }
}
public class Authentication
{   
    // Perform user login
    public void Login(string username, string password)
    {
    }

    // User logout
    public void Logout()
    {
    }
}

public class Registration
{
    //Register a user
    public void RegisterUser(User user)
    {
    }   
}