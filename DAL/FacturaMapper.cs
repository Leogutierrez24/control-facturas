using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FacturaMapper : Mapper<BE.Factura>
    {
        private static FacturaMapper instance = null;

        private FacturaMapper()
        {

        }

        public static FacturaMapper GetInstance()
        {
            if (instance == null) instance = new FacturaMapper();
            return instance;
        }

        public override int Update(Factura obj)
        {
            throw new NotImplementedException();
        }

        public override int Insert(Factura obj)
        {
            throw new NotImplementedException();
        }

        public override BE.Resultado<BE.Factura> SelectById(int id)
        {
            throw new NotImplementedException();
        }

        public override List<Factura> SelectAll()
        {
            throw new NotImplementedException();
        }

        public BE.Factura SelectByNumero(int numero, int prestadorID)
        {
            throw new NotImplementedException();
        }

        public List<BE.Factura> SelectAllByPrestador(int id)
        {
            throw new NotImplementedException();
        }
    }
}
