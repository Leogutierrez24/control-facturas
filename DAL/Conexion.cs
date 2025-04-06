using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Conexion
    {
        private static Conexion instance;

        public static Conexion ObtenerInstancia()
        {
            if (instance == null) instance = new Conexion();
            return instance;
        }

        private Conexion()
        {

        }
    }
}
