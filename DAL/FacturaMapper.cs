using BE;
using BE.exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Globalization;

namespace DAL
{
    public class FacturaMapper : Mapper<BE.Factura>
    {
        private static FacturaMapper instance = null;

        private readonly PrestadorMapper prestadorMapper;

        private readonly List<BE.Prestador> prestadoresList = new List<BE.Prestador>();

        private FacturaMapper()
        {
            prestadorMapper = PrestadorMapper.GetInstance();
            prestadoresList = prestadorMapper.SelectAll();
        }

        public static FacturaMapper GetInstance()
        {
            if (instance == null) instance = new FacturaMapper();
            return instance;
        }

        private Factura MapFactura(DataRow row)
        {
            Factura factura;
            factura = new Factura
            {
                ID = int.Parse(row["id"].ToString()),
                PuntoVenta = int.Parse(row["punto_venta"].ToString()),
                Numero = int.Parse(row["numero"].ToString()),
                FechaCreacion = DateTime.ParseExact(row["fecha_creacion"].ToString(), "yyyy-MM-dd", CultureInfo.InvariantCulture),
                FechaRecepcion = DateTime.ParseExact(row["fecha_recepcion"].ToString(), "yyyy-MM-dd", CultureInfo.InvariantCulture),
                Monto = float.Parse(row["monto"].ToString()),
                Observacion = row["observaciones"].ToString(),
                Prestador = prestadoresList.Find(p => p.ID == int.Parse(row["id_prestador"].ToString()))
            };
            return factura;
        }

        private List<Factura> MapFacturas(DataTable data)
        {
            List<Factura> facturas = new List<Factura>();
            foreach (DataRow row in data.Rows)
            {
                Factura factura = new BE.Factura
                {
                    ID = int.Parse(row["id"].ToString()),
                    PuntoVenta = int.Parse(row["punto_venta"].ToString()),
                    Numero = int.Parse(row["numero"].ToString()),
                    FechaCreacion = DateTime.ParseExact(row["fecha_creacion"].ToString(), "yyyy-MM-dd", CultureInfo.InvariantCulture),
                    FechaRecepcion = DateTime.ParseExact(row["fecha_recepcion"].ToString(), "yyyy-MM-dd", CultureInfo.InvariantCulture),
                    Monto = float.Parse(row["monto"].ToString()),
                    Observacion = row["observaciones"].ToString(),
                    Prestador = prestadoresList.Find(p => p.ID == int.Parse(row["id_prestador"].ToString()))
                };
                facturas.Add(factura);
            }
            return facturas;
        }

        public override int Update(Factura obj)
        {
            throw new NotImplementedException();
        }

        public override int Insert(Factura obj)
        {
            SQLiteParameter prestadorIDParam = _con.CreateParameter(obj.Prestador.ID, "prestadorID");
            SQLiteParameter puntoVentaParam = _con.CreateParameter(obj.PuntoVenta, "puntoVenta");
            SQLiteParameter numeroParam = _con.CreateParameter(obj.Numero, "numero");
            SQLiteParameter fechaCreacionParam = _con.CreateParameter(obj.FechaCreacion.ToString("yyyy-MM-dd"), "fechaCreacion");
            SQLiteParameter fechaRecepcionParam = _con.CreateParameter(obj.FechaRecepcion.ToString("yyyy-MM-dd"), "fechaRecepcion");
            SQLiteParameter fechaVencimientoParam = _con.CreateParameter(obj.FechaVencimiento.ToString("yyyy-MM-dd"), "fechaVencimiento");
            SQLiteParameter montoParam = _con.CreateParameter(obj.Monto, "monto");
            SQLiteParameter observacionesParam = _con.CreateParameter(obj.Observacion, "observaciones");
            SQLiteParameter estadoIDParam = _con.CreateParameter(0, "estado");
            List<SQLiteParameter> parametersList = new List<SQLiteParameter>
            {
                prestadorIDParam,
                puntoVentaParam,
                numeroParam,
                fechaCreacionParam,
                fechaRecepcionParam,
                fechaVencimientoParam,
                montoParam,
                observacionesParam,
                estadoIDParam
            };

            string query = "INSERT INTO facturas (id_prestador, punto_venta, numero, fecha_creacion, fecha_recepcion, monto, observaciones, estado, fecha_vencimiento) VALUES (@prestadorID, @puntoVenta, @numero, @fechaCreacion, @fechaRecepcion, @monto, @observaciones, @estado, @fechaVencimiento);";

            bool isDuplicate = Exists(new List<SQLiteParameter> { prestadorIDParam, puntoVentaParam, numeroParam });

            if (!isDuplicate)
            {
                _con.Connect();
                _con.Write(query, parametersList);
                _con.Disconnect();
            }
            else throw new DuplicateFacturaException();
            return 0;
        }

        public override BE.Resultado<BE.Factura> SelectById(int id)
        {
            BE.Resultado<BE.Factura> result;
            SQLiteParameter idParam = this._con.CreateParameter(id, "idParam");
            string query = $"SELECT * FROM facturas WHERE id=@idParam;";
            _con.Connect();
            DataTable data = _con.Read(query, new List<SQLiteParameter> { idParam });
            _con.Disconnect();

            if (data.Rows.Count > 0)
            {
                BE.Factura factura = MapFactura(data.Rows[0]);
                result = new Resultado<Factura>(true, factura);
            } else result = new Resultado<Factura>(false, null);
            return result;
        }

        public override List<Factura> SelectAll()
        {
            throw new NotImplementedException();
        }

        public Resultado<List<Factura>> SelectByPuntoDeVenta(int puntoDeVenta)
        {
            List<Factura> facturasList;
            Resultado<List<Factura>> result;
            SQLiteParameter puntoDeVentaParam = _con.CreateParameter(puntoDeVenta, "puntoDeVenta");
            string query = "SELECT * FROM facturas WHERE punto_venta=@puntoDeVenta";

            _con.Connect();
            DataTable data = _con.Read(query, new List<SQLiteParameter> { puntoDeVentaParam });
            _con.Disconnect();

            if (data.Rows.Count > 0)
            {
                facturasList = MapFacturas(data);
                result = new Resultado<List<Factura>>(true, facturasList);
            } else result = new Resultado<List<Factura>>(false, null);

            return result;
        }

        public Resultado<List<Factura>> SelectByNumero(int numero)
        {
            List<Factura> facturasList;
            Resultado<List<Factura>> result;
            SQLiteParameter numeroParam = _con.CreateParameter(numero, "numero");
            string query = "SELECT * FROM facturas WHERE numero=@numero";

            _con.Connect();
            DataTable data = _con.Read(query, new List<SQLiteParameter> { numeroParam });
            _con.Disconnect();

            if (data.Rows.Count > 0)
            {
                facturasList = MapFacturas(data);
                result = new Resultado<List<Factura>>(true, facturasList);
            }
            else result = new Resultado<List<Factura>>(false, null);

            return result;
        }

        public Resultado<List<Factura>> SelectByMonto(float monto)
        {
            List<Factura> facturasList;
            Resultado<List<Factura>> result;
            SQLiteParameter montoParam = _con.CreateParameter(monto, "monto");
            string query = "SELECT * FROM facturas WHERE monto=@monto";

            _con.Connect();
            DataTable data = _con.Read(query, new List<SQLiteParameter> { montoParam });
            _con.Disconnect();

            if (data.Rows.Count > 0)
            {
                facturasList = MapFacturas(data);
                result = new Resultado<List<Factura>>(true, facturasList);
            }
            else result = new Resultado<List<Factura>>(false, null);

            return result;
        }

        public Resultado<List<Factura>> SelectByPrestador(string prestadorName)
        {
            throw new NotImplementedException();
        }

        public Resultado<List<Factura>> SelectByEstado(int estado)
        {
            List<Factura> facturasList;
            Resultado<List<Factura>> result;
            SQLiteParameter estadoParam = _con.CreateParameter(estado, "estado");
            string query = "SELECT * FROM facturas WHERE estado=@estado";

            _con.Connect();
            DataTable data = _con.Read(query, new List<SQLiteParameter> { estadoParam });
            _con.Disconnect();

            if (data.Rows.Count > 0)
            {
                facturasList = MapFacturas(data);
                result = new Resultado<List<Factura>>(true, facturasList);
            }
            else result = new Resultado<List<Factura>>(false, null);

            return result;
        }

        public Resultado<List<Factura>> SelectByNumero(int numero, int prestadorID)
        {
            List<Factura> facturasList;
            Resultado<List<Factura>> result;
            SQLiteParameter numeroParam = _con.CreateParameter(numero, "numero");
            SQLiteParameter prestadorIDParam = _con.CreateParameter(prestadorID, "prestadorID");
            string query = "SELECT * FROM facturas WHERE numero=@numero AND id_prestador=@prestadorID;";

            _con.Connect();
            DataTable data = _con.Read(query, new List<SQLiteParameter> { numeroParam, prestadorIDParam });
            _con.Disconnect();

            facturasList = MapFacturas(data);
            
            if (facturasList.Count > 0)
            {
                result = new Resultado<List<Factura>>(true, facturasList);
            } else result = new Resultado<List<Factura>>(false, null);

            return result;
        }

        public Resultado<List<Factura>> SelectVencidas()
        {
            List<Factura> facturasList;
            Resultado<List<Factura>> result;

            string query = "SELECT * FROM facturas WHERE numero=@numero AND id_prestador=@prestadorID;";

            _con.Connect();
            DataTable data = _con.Read(query);
            _con.Disconnect();

            facturasList = MapFacturas(data);

            if (facturasList.Count > 0)
            {
                result = new Resultado<List<Factura>>(true, facturasList);
            }
            else result = new Resultado<List<Factura>>(false, null);

            return result;
        }

        public Resultado<List<Factura>> SelectByFechaRecepcion(DateTime fechaRecepcion)
        {
            List<Factura> facturasList;
            Resultado<List<Factura>> result;
            SQLiteParameter fechaRecepcionParam = _con.CreateParameter(fechaRecepcion.ToShortDateString(), "fechaRecepcion");
            string query = "SELECT * FROM facturas WHERE fecha_recepcion=@fechaRecepcion";

            _con.Connect();
            DataTable data = _con.Read(query, new List<SQLiteParameter> { fechaRecepcionParam });
            _con.Disconnect();

            if (data.Rows.Count > 0)
            {
                facturasList = MapFacturas(data);
                result = new Resultado<List<Factura>>(true, facturasList);
            }
            else result = new Resultado<List<Factura>>(false, null);

            return result;
        }

        /// <summary>
        /// Check if the Factura exists.
        /// </summary>
        /// <returns><c>true</c> if the factura exists; otherwise, <c>false</c>.</returns>
        public bool Exists(List<SQLiteParameter> parametersList)
        {
            string query = "SELECT 1 FROM facturas WHERE id_prestador=@prestadorID AND punto_venta=@puntoVenta AND numero=@numero;";

            _con.Connect();
            int result = _con.CheckDuplicate(query, parametersList);
            _con.Disconnect();

            return result == 1;
        }

        public List<BE.Factura> SelectAllByPrestador(int id)
        {
            throw new NotImplementedException();
        }
    }
}
