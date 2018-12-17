using FilmsApp.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmsApp.Classes.SQL
{
    class SqlManipul
    {
        public string ConnectionString { get; private set; }
        private static SqlManipul instance;
        private SqlManipul() { ConnectionString = Settings.Default.MovieDBConnectionString; }

        public static SqlManipul GetInstance()
        {
            if (instance == null)
                instance = new SqlManipul();
            return instance;
        }


    }
}
