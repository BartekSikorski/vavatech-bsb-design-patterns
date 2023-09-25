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
                        IVisitCalculator visitCalculator =  VisitCalculatorFactory.Create(visitType);

                        Visit visit = new Visit(duration);

                        decimal totalAmount = visitCalculator.CalculateCost(visit);

                        Console.ForegroundColor = ConsoleColorFactory.Create(totalAmount);

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
