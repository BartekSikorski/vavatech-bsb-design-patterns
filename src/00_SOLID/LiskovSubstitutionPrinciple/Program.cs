// Zasada podstawiania Liskov (Liskov Substitution Principle) - LSP  
// Zasada Liskov mówi o tym, że obiekt klasy pochodnej może być używany zamiennie
// w miejscu obiektu klasy bazowej, nie wprowadzając nieoczekiwanych zachowań.

// Przykład łamiący zasadę podstawiania Liskov

Document doc1 = new PDFDocument();
Document doc2 = new TextDocument();

Document doc = doc2;

doc.Print();  // Output: "Printing a PDF document..."

if (doc.CanEdit())
    doc.Edit(); 

class Document
{
    public virtual void Print()
    {
        Console.WriteLine("Printing a document...");
    }

    public virtual bool CanEdit()
    {
        return false;
    }

    public virtual void Edit()
    {
        Console.WriteLine("Editing a document...");
    }
}

class PDFDocument : Document
{
    public override void Print()
    {
        Console.WriteLine("Printing a PDF document...");
    }

    public void Encrypt()
    {
        Console.WriteLine("Encrypting a PDF document...");
    }

    public override void Edit()
    {
        throw new NotSupportedException();
    }
}

class TextDocument : Document
{
    public override bool CanEdit()
    {
        return true;
    }

    public override void Print()
    {
        Console.WriteLine("Printing a text document...");
    }

    


}