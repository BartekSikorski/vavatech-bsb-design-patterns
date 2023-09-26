using NGeoHash;
using System;

namespace AdapterPattern
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Adapter Pattern!");

            RadioTest();

            DataAdapterTest();

        }

        private static void DataAdapterTest()
        {
            Connection connection = new Connection();

            // Assumes that connection is a valid SqlConnection object.  
            string queryString =
              "SELECT CustomerID, CompanyName FROM dbo.Customers";

            IDbDataAdapter adapter = new SqlDataAdapter(queryString, connection);

            DataSet customers = new DataSet();
            adapter.Fill(customers, "Customers");

            IDbDataAdapter csvAdapter = new CsvDataAdapter("customers.csv", ';');
            csvAdapter.Fill(customers, "customers");
        }

        private static void RadioTest()
        {
            ITextRadioAdapter radio = RadioAdapterFactory.Create("Hytera");
            radio.SendMessage("Hello World!", "10");
        }

    }

    


}
