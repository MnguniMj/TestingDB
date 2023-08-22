using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingDB
{
    internal class Connector
    {

        public static string ConnString(string path)
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + path + @"Database1.mdf;Integrated Security=True";
        }
    }
}
