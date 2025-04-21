using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ServiceFactura
    {
        private readonly DAL.FacturaMapper mapper;
        private static ServiceFactura instance = null;

        private ServiceFactura() 
        { 
            mapper = DAL.FacturaMapper.GetInstance();
        }

        public static ServiceFactura GetInstance()
        {
            if (instance == null)
            {
                instance = new ServiceFactura();
            }
            return instance;
        }

        public int Load(BE.Factura factura, BE.Prestador prestador)
        {
            int resultado = 0;
            Factura facturaRepetida = mapper.SelectByNumero(factura.Numero, prestador.ID);
            if (facturaRepetida.ID != 0)
            {
                resultado = -1;
            } else
            {
                mapper.Insert(factura);
            }
            return resultado;
        }

        public List<BE.Factura> FindAllByPrestador(BE.Prestador prestador)
        {
            List<BE.Factura> facturas = mapper.SelectAllByPrestador(prestador.ID);
            return facturas;
        }

        public Resultado<BE.Factura> FindById(int id)
        {
            return mapper.SelectById(id);
        }

        public OperacionDebito AddDebito(BE.Factura factura, BE.Debito debito)
        {
            OperacionDebito resultado;
            if (factura.Debitos.Count == 0)
            {
                if (factura.Monto >= debito.Monto)
                {
                    factura.Debitos.Add(debito);
                    resultado = OperacionDebito.Exito;
                }
                else resultado = OperacionDebito.SaldoNegativo;
            }
            else if (factura.Debitos.Find(item => item.ID == debito.ID) == null)
            {
                float totalDebitado = 0;
                factura.Debitos.ForEach(item => totalDebitado += item.Monto);

                if (factura.Monto >= (totalDebitado + debito.Monto))
                {
                    factura.Debitos.Add(debito);
                    resultado = OperacionDebito.Exito;
                }
                else resultado = OperacionDebito.SaldoNegativo;
            }
            else resultado = OperacionDebito.DebitoRepetido;
            return resultado;
        }

        public OperacionPago AddPago(BE.Factura factura, BE.Pago pago)
        {
            OperacionPago resultado;
            if (factura.Pagos.Count == 0)
            {
                factura.Pagos.Add(pago);
                if (factura.Monto < pago.Monto) resultado = OperacionPago.SaldoFavor;
                else resultado = OperacionPago.Exito;
            }
            else if (factura.Pagos.Find(item => item.ID == pago.ID) == null)
            {
                float totalPagado = 0;
                factura.Pagos.ForEach(item => totalPagado += item.Monto);
                if (factura.Monto < (totalPagado + pago.Monto)) resultado = OperacionPago.SaldoFavor;
                else resultado = OperacionPago.Exito;
                factura.Pagos.Add(pago);
            }
            else resultado = OperacionPago.PagoRepetido;
            return resultado;
        }
    }
}
