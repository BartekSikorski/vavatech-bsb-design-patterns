namespace CompositePattern;

// Concrete Component B
// Branch
public class Group : Component
{
    private List<Component> components = new List<Component>();

    public Group(string name) : base(name)
    {
    }

    public void Add(Component shape)
    {
        components.Add(shape);
    }

    public override void Render()
    {
        Console.WriteLine($"Render group {Name}");

        foreach (var component in components)
        {
            component.Render();            
        }
    }
}