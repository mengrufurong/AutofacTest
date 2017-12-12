using Autofac;
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
            var builder = new ContainerBuilder();
            var sss= builder.RegisterType<DatabaseManager>();
            builder.RegisterType<SqlDatabase>().As<IDatabase>();
            using(var container = builder.Build())
            {

            }
            Console.ReadKey();
        }
    }
}
