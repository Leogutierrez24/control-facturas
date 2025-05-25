using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ServicePrestador
    {
        private static ServicePrestador instance = null;
        private readonly PrestadorMapper mapper;

        private ServicePrestador()
        {
            mapper = PrestadorMapper.GetInstance();
        }

        public static ServicePrestador GetInstance()
        {
            if (instance == null) instance = new ServicePrestador();
            return instance;
        }

        public int LoadPrestador(BE.Prestador prestador)
        {
            int result = 0;
            BE.Resultado<BE.Prestador> repeteadPrestado = mapper.SelectByName(prestador.Nombre);
            if (repeteadPrestado.Value == null)
            {
                mapper.Insert(prestador);
            }
            else result = -1;
            return result;
        }

        public List<BE.Prestador> GetAll()
        {
            return mapper.SelectAll();
        }

        public int CountPendingFacturas(BE.Prestador prestador)
        {
            int result = 0;

            if (prestador.Facturas.Count > 0)
            {
                prestador.Facturas.ForEach(factura =>
                {
                    if (factura.Estado == BE.EstadoFactura.Pendiente) result++;
                });
            }

            return result;
        }

        public int CountFacturasPorVencer(BE.Prestador prestador)
        {
            int result = 0;

            if (prestador.Facturas.Count > 0)
            {
                
            }

            return result;
        }
    }
}
