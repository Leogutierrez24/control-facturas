using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public abstract class Mapper<T>
    {
        private readonly Conexion conexion;

        public Mapper()
        {
            conexion = Conexion.ObtenerInstancia();
        }

        public abstract int Insertar(T obj);
        public abstract int Actualizar(T obj);
        public abstract T ObtenerPorID(int id);
        public abstract List<T> ObtenerTodos();
    }
}
