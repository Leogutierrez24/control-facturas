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
        public override int Update(Factura obj)
        {
            throw new NotImplementedException();
        }

        public override int Insert(Factura obj)
        {
            throw new NotImplementedException();
        }

        public override BE.Resultado<BE.Factura> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public override List<Factura> GetAll()
        {
            throw new NotImplementedException();
        }

        public BE.Factura GetByNumero(int numero, int prestadorID)
        {
            throw new NotImplementedException();
        }

        public List<BE.Factura> GetAllByPrestador(int id)
        {
            throw new NotImplementedException();
        }
    }
}
