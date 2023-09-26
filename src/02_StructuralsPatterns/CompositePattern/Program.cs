using CompositePattern.DecisionTree;

namespace CompositePattern;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Are you developer?");

        // TreeTest();

        FormTest();

    }

    private static void TreeTest()
    {
        Group root = new Group("root");

        root.Add(new Shape("a"));
        root.Add(new Shape("b"));

        Group group = new Group("subfolder");
        group.Add(new Shape("c"));
        group.Add(new Shape("d"));
        group.Add(new Shape("e"));

        group.Add(new Document("doc1"));

        root.Add(group);

        root.Render();
    }

    private static void FormTest()
    {
        Decision d1 = new Decision("Welcome on Design Pattern in C# Course!");
        Decision d2 = new Decision("Have a nice day.");
        Decision d3 = new Decision("The Course is not for you.");
        Question q2 = new Question("Do you know C#?", d1, d3);
        Question q1 = new Question("Are you developer?", q2, d2);

        Node form = q1;

        form.Render();
                 
    }

    public static bool Response => Console.ReadKey().Key == ConsoleKey.Y;

}
