using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutofacTest
{
    public class DatabaseManager
    {
        IDatabase _database;
        public DatabaseManager(IDatabase database)
        {
            _database = database;
        }

        public void Search(string commandText)
        {
            _database.Select(commandText);
        }
    }
}
