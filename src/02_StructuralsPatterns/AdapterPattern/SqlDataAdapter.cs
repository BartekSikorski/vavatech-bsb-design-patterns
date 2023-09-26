using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public interface IDbDataAdapter
    {
        void Fill(DataSet dataSet, string tableName);
    }

    public class SqlDataAdapter : IDbDataAdapter
    {
        private string queryString;
        private Connection connection;

        public SqlDataAdapter(string queryString, Connection connection)
        {
            this.queryString = queryString;
            this.connection = connection;
        }

        public void Fill(DataSet dataSet, string tableName)
        {
            Console.WriteLine($"Send {queryString}");
        }
    }

    public class CsvDataAdapter : IDbDataAdapter
    {
        private string filename;
        private char separator;

        public CsvDataAdapter(string filename, char separator)
        {
            this.filename = filename;
            this.separator = separator;
        }

        public void Fill(DataSet dataSet, string tableName)
        {
            Console.WriteLine($"Load {filename}");
        }
    }

    public class Connection
    {

    }

    public class DataSet
    {

    }
}
