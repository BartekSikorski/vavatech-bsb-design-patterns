﻿// TODO: Refaktor

Ticket ticket = new Ticket { MovieName = "Akademia pana Kleksa", ReleaseYear = 1983 };

ticket.Reserve(1, 'A');

ticket.CalculatePrice(20);

ticket.PrintTicket();
ticket.SendByEmail("example@example.com");

public class Ticket
{
    public string MovieName { get; set; }
    public int ReleaseYear { get; set; }

    public string Place { get; set; }

    public decimal Price { get; set; }    

    public void PrintTicket()
    {
        Console.WriteLine($"Movie: {MovieName} {ReleaseYear}, Place: {Place}");
    }

    public void SendByEmail(string emailAddress)
    {
        Console.WriteLine($"Ticket Movie: {MovieName} {ReleaseYear}, Place: {Place} sent to {emailAddress}");
    }

    public void GenerateRandomPlace()
    {
        Random random = new Random();
        int row = random.Next(1, 11); // Random row between 1 and 10
        char seat = (char)random.Next('A', 'J'); // Random seat between A and J

        Place = $"{seat}{row}";
    }

    public void Reserve(int row, char seat)
    {
        Place = $"{seat}{row}";
    }

    public void CalculatePrice(decimal basePrice)
    {
        if (DateTime.Now.DayOfWeek == DayOfWeek.Monday)
        {
            Price = basePrice * 0.8m; // Apply 20% discount for Monday
        }
        else
        {
            Price = basePrice;
        }
    }
}