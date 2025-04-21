using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Connection
    {
        private static Connection instance;

        public static Connection ObtenerInstancia()
        {
            if (instance == null) instance = new Connection();
            return instance;
        }

        private Connection()
        {

        }
    }
}
