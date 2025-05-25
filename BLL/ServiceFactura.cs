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

        public int Load(Factura factura, Prestador prestador)
        {
            int result = 0;
            Resultado<List<Factura>> queryResult = mapper.SelectByNumero(factura.Numero, prestador.ID);
            if (queryResult.Value != null)
            {
                if (queryResult.Value.Exists(f => f.PuntoVenta == factura.PuntoVenta))
                {
                    result = -1;
                }
            } else
            {
                mapper.Insert(factura);
            }
            return result;
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

        // Queda pendiente impactar los debitos en la base de datos.
        public OperacionDebito AddDebito(BE.Factura factura, BE.Debito debito)
        {
            OperacionDebito resultado;
            if (factura.Debitos.Count == 0) // Si no hay debitos registrados
            {
                if (debito.Monto <= factura.Monto)
                {
                    factura.Debitos.Add(debito);
                    factura.Estado = (debito.Monto == factura.Monto) ? EstadoFactura.Rechazada : EstadoFactura.Pendiente;
                    resultado = OperacionDebito.Exito;
                }
                else resultado = OperacionDebito.DebitoExcedente;
            }
            else // Si hay debitos registrados
            {
                float totalDebitado = 0;
                factura.Debitos.ForEach(item => totalDebitado += item.Monto);

                if ((totalDebitado + debito.Monto) <= factura.Monto)
                {
                    factura.Debitos.Add(debito);
                    factura.Estado = ((totalDebitado + debito.Monto) == factura.Monto) ? EstadoFactura.Rechazada : EstadoFactura.Pendiente;
                    resultado = OperacionDebito.Exito;
                }
                else resultado = OperacionDebito.DebitoExcedente;
            }
            return resultado;
        }

        // Queda pendiente impactar los pagos en la base de datos.
        public OperacionPago AddPago(BE.Factura factura, BE.Pago pago)
        {
            OperacionPago resultado;

            if (factura.Estado == EstadoFactura.Pendiente)
            {
                if (factura.Debitos.Count != 0 && factura.Pagos.Count == 0) // Si hay debitos pero no hay pagos.
                {
                    float totalDebitado = 0;
                    factura.Debitos.ForEach(d => totalDebitado += d.Monto);

                    if ((totalDebitado + pago.Monto) == factura.Monto)
                    {
                        factura.Pagos.Add(pago);
                        factura.Estado = EstadoFactura.Paga;
                        resultado = OperacionPago.Exito;
                    }
                    else resultado = OperacionPago.PagoExcedente;
                }
                else if (factura.Debitos.Count != 0 && factura.Pagos.Count != 0) // Si hay debitos y pagos.
                {
                    float totalDebitado = 0;
                    float totalPagado = 0;
                    factura.Debitos.ForEach(d => totalDebitado += d.Monto);
                    factura.Pagos.ForEach(p => totalPagado += p.Monto);

                    if ((totalDebitado + totalPagado) < factura.Monto && (totalDebitado + totalPagado + pago.Monto) <= factura.Monto)
                    {
                        factura.Pagos.Add(pago);
                        factura.Estado = (totalDebitado + totalPagado + pago.Monto) == factura.Monto ? EstadoFactura.Paga : EstadoFactura.Pendiente;
                        resultado = OperacionPago.Exito;
                    }
                    else resultado = OperacionPago.PagoExcedente;
                } else if (factura.Debitos.Count == 0 && factura.Pagos.Count != 0) // Si hay pagos pero no hay debitos.
                {
                    float totalPagado = 0;
                    factura.Pagos.ForEach(p => totalPagado += p.Monto);

                    if ((totalPagado + pago.Monto) <= factura.Monto)
                    {
                        factura.Pagos.Add(pago);
                        factura.Estado = (totalPagado + pago.Monto) == factura.Monto ? EstadoFactura.Paga : EstadoFactura.Pendiente;
                        resultado = OperacionPago.Exito;
                    }
                    else resultado = OperacionPago.PagoExcedente;
                } else // Si no hay debitos ni pagos
                {
                    factura.Pagos.Add(pago);
                    factura.Estado = pago.Monto == factura.Monto ? EstadoFactura.Paga : EstadoFactura.Pendiente;
                    resultado = OperacionPago.Exito;
                }
            } else if (factura.Estado == EstadoFactura.Paga)
            {
                resultado = OperacionPago.FacturaCancelada;
            } else
            {
                resultado = OperacionPago.FacturaRechazada;
            }

            return resultado;
        }
    }
}
