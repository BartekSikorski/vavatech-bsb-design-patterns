namespace CompositePattern.DecisionTree
{

    // Concrete Component A
    public class Question : Node
    {
        public Node PositiveResponse { get; }
        public Node NegativeReponse { get; }

        public Question(string content, Node positiveResponse, Node negativeReponse)
            : base(content)
        {
            PositiveResponse = positiveResponse;
            NegativeReponse = negativeReponse;
        }

        public override void Render()
        {
            Console.Write(Content);

            if (Response)
            {
                PositiveResponse.Render();
            }
            else
            {
                NegativeReponse.Render();
            }
        }

        public static bool Response => Console.ReadKey().Key == ConsoleKey.Y;
    }


}
