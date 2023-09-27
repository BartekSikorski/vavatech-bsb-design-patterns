
// TODO: Dodaj obliczanie kosztu wydruku do starej drukarki

using LegacyPrinterExcercise;
using System.Reflection;

bool legacy = true;

string document = "Hello World!";
int copies = 3;

IPrinterAdapter printer = PrinterAdapterFactory.Create(PrinterTypeMapper.Map(legacy));

printer = new CounterPrinterProxy(new PrinterProxy(printer));

printer.Print(document, copies);

printer.Print(document, copies);
printer.Print(document, copies);





public class CounterPrinterProxy : IPrinterAdapter
{
    private readonly IPrinterAdapter printer;

    public int Counter { get; private set; }

    public CounterPrinterProxy(IPrinterAdapter printer)
    {
        this.printer = printer;
    }

    public void Print(string document, int copies = 1)
    {
        printer.Print(document, copies);

        Counter += copies;
    }
}

public class PrinterProxy : IPrinterAdapter
{
    decimal _costPerCopy; // Cost of 0.10 zł per copy

    // Real subject
    private readonly IPrinterAdapter printer;

    public PrinterProxy(IPrinterAdapter printerAdapter, decimal costPerCopy = 0.1m)
    {
        this.printer = printerAdapter;
        _costPerCopy = costPerCopy;
    }

    public void Print(string document, int copies = 1)
    {
        printer.Print(document, copies);

        var cost = CalculateCost(copies);
        Console.WriteLine($"{cost:C2}");
    }

    private decimal CalculateCost(int copies)
    {
        // Calculate total cost based on the number of copies and cost per copy
        return copies * _costPerCopy;
    }
}


public interface IPrinterAdapter
{
    void Print(string document, int copies = 1);
}

public class Printer : IPrinterAdapter
{
    public void Print(string document, int copies = 1)
    {
        for (int copy = 1; copy <= copies; copy++)
        {
            Console.WriteLine($"Printer is printing: {document}");
        }
    }
}


// Nie zmieniaj kodu tej starej klasy!

public class LegacyPrinterAdapter : IPrinterAdapter
{
    private readonly LegacyPrinter printer;

    public LegacyPrinterAdapter()
    {
        printer = new LegacyPrinter();
    }
    public void Print(string document, int copies = 1)
    {
        for (int i = 0; i < copies; i++)
        {
            printer.PrintDocument(document);
        }
    }
}

public class LegacyPrinter
{
    public void PrintDocument(string document)
    {
        Console.WriteLine($"Legacy Printer is printing: {document}");
    }
}

public enum PrinterType
{
    Legacy,
    Modern,
    Color
}