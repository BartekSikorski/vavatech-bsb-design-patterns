using System;

namespace SimpleFactoryPattern
{


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Factory Method Pattern!");

            VisitCalculateAmountTest();
        }



        private static void VisitCalculateAmountTest()
        {
            while (true)
            {
                Console.Write("Podaj rodzaj wizyty: (N)FZ (P)rywatna (F)irma: ");
                string visitType = Console.ReadLine();

                Console.Write("Podaj czas wizyty w minutach: ");
                if (double.TryParse(Console.ReadLine(), out double minutes))
                {
                    TimeSpan duration = TimeSpan.FromMinutes(minutes);

                    try
                    {
                        Visit visit = VisitFactory.Create(visitType, duration);

                        decimal totalAmount = visit.CalculateCost();

                        if (totalAmount == 0)
                            Console.ForegroundColor = ConsoleColor.Green;
                        else
                           if (totalAmount >= 200)
                            Console.ForegroundColor = ConsoleColor.Red;
                        else
                            Console.ForegroundColor = ConsoleColor.White;

                        Console.WriteLine($"Total amount {totalAmount:C2}");

                        

                    }
                    catch (NotSupportedException ex)                   
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(ex.Message);
                    }

                    finally
                    {
                        Console.ResetColor();
                    }
                }
            }

        }
    }
}
