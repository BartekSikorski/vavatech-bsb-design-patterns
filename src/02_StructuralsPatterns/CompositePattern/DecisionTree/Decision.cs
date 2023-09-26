namespace CompositePattern.DecisionTree
{
    // Concrete Component B
    // Leaf
    public class Decision : Node
    {
        public Decision(string content) : base(content)
        {
        }

        public override void Render()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Content);
            Console.ResetColor();
        }
    }


}
