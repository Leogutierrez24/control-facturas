using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public abstract class Mapper<T>
    {
        protected readonly Connection _con;

        public Mapper()
        {
            _con = Connection.GetInstance();
        }

        public abstract int Insert(T obj);
        public abstract int Update(T obj);
        public abstract BE.Resultado<T> SelectById(int id);
        public abstract List<T> SelectAll();
    }
}
