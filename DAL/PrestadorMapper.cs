using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PrestadorMapper : Mapper<BE.Prestador>
    {
        private static PrestadorMapper instance = null;

        private PrestadorMapper()
        {

        }

        public static PrestadorMapper GetInstance()
        {
            if (instance == null) instance = new PrestadorMapper();
            return instance;
        }

        public override List<Prestador> SelectAll()
        {
            throw new NotImplementedException();
        }

        public override Resultado<Prestador> SelectById(int id)
        {
            throw new NotImplementedException();
        }

        public override int Insert(Prestador obj)
        {
            throw new NotImplementedException();
        }

        public override int Update(Prestador obj)
        {
            throw new NotImplementedException();
        }

        public Resultado<BE.Prestador> SelectByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
