namespace CompositePattern.DecisionTree
{
    public class MultiResponse
    {
        private Dictionary<ConsoleKey, Node> nodes = new Dictionary<ConsoleKey, Node>();
        public void AddResponse(ConsoleKey key, Node value)
        {
            nodes.Add(key, value);
        }
        
        public Node Response => nodes[Console.ReadKey().Key];
    }


}
