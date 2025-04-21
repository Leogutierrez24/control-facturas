using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DebitoMapper : Mapper<BE.Debito>
    {
        private static DebitoMapper instance = null;

        private DebitoMapper() { }

        public static DebitoMapper GetInstance()
        {
            if (instance == null) instance = new DebitoMapper();
            return instance;
        }

        public override int Insert(Debito obj)
        {
            throw new NotImplementedException();
        }

        public override List<Debito> SelectAll()
        {
            throw new NotImplementedException();
        }

        public override Resultado<Debito> SelectById(int id)
        {
            throw new NotImplementedException();
        }

        public override int Update(Debito obj)
        {
            throw new NotImplementedException();
        }
    }
}
