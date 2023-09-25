using System;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Singleton Pattern!");

            // ConfigManagerTest();

            LoadBalancerTest();

            Console.ReadKey();
        }

        private static void ConfigManagerTest()
        {
            ConfigManager configManager = ConfigManager.Instance;
            configManager.Set("name", "Marcin");

            ConfigManager other = ConfigManager.Instance;
            var name = other.Get("name");

            if (ReferenceEquals(configManager, other))
            {
                Console.WriteLine("The same instance");
            }
            else
            {
                Console.WriteLine("Not the same instance");
            }

            Console.WriteLine(name);
        }


        private static void LoadBalancerTest()
        {
            Task.Run(() => LoadBalanceRequestTest(15));
            Task.Run(() => LoadBalanceRequestTest(15));
            Task.Run(() => LoadBalanceRequestTest(15));
            Task.Run(() => LoadBalanceRequestTest(15));
        }

        private static void LoadBalanceRequestTest(int numberOfRequests)
        {
            LoadBalancer loadBalancer = LoadBalancer.Instance;

            for (int i = 0; i < numberOfRequests; i++)
            {
                Server server = loadBalancer.NextServer;
                Console.WriteLine($"Send request to: {server.Name} {server.IP}");
            }
        }

        

        
    }




  
}
