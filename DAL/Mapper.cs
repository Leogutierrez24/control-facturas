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

        public abstract int Insert(T obj);
        public abstract int Update(T obj);
        public abstract BE.Resultado<T> GetById(int id);
        public abstract List<T> GetAll();
    }
}
