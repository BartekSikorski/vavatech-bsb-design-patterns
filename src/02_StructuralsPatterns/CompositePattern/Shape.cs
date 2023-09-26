namespace CompositePattern;

// Abstract Component
public abstract class Component
{
    public string Name { get; set; }
    public abstract void Render();

    protected Component(string name)
    {
        Name = name;
    }
}


// Concrete Component A
// Leaf
public class Shape : Component
{
    public Shape(string name) : base(name)
    {
    }

    public override void Render()
    {
        Console.WriteLine($"Render shape {Name}");
    }
}

public class Document : Component
{
    public Document(string name) : base(name)
    {
    }

    public override void Render()
    {
        Console.WriteLine($"Render document {Name}");
    }
}