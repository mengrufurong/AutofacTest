using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutofacTest
{
    class Program
    {
        static void Main(string[] args)
        {
            IDatabase database = new SqlDatabase();
            DatabaseManager databaseManager = new DatabaseManager(database);
            databaseManager.Search("123");
            Console.ReadKey();
        }
    }
}
