using BE;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

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

        private BE.Prestador MapPrestador(DataRow row)
        {
            BE.Prestador p = new Prestador
            {
                ID = int.Parse(row["id"].ToString()),
                Nombre = row["nombre"].ToString(),
                PuntoVenta = int.Parse(row["punto_venta"].ToString())
            };
            return p;
        }

        public override List<BE.Prestador> SelectAll()
        {
            List<BE.Prestador> list = new List<BE.Prestador>();

            string query = "SELECT * FROM prestadores;";
            _con.Connect();
            DataTable table = _con.Read(query);
            _con.Disconnect();

            foreach (DataRow row in table.Rows)
            {
                BE.Prestador p = new BE.Prestador
                {
                    ID = int.Parse(row["id"].ToString()),
                    Nombre = row["nombre"].ToString(),
                    PuntoVenta = int.Parse(row["punto_venta"].ToString())
                };
                list.Add(p);
            }

            return list;
        }

        public override Resultado<Prestador> SelectById(int id)
        {
            throw new NotImplementedException();
        }

        public override int Insert(Prestador obj)
        {
            int result;
            SQLiteParameter nombreParam = _con.CreateParameter(obj.Nombre, "nombre");
            SQLiteParameter puntoVentaParam = _con.CreateParameter(obj.PuntoVenta, "puntoVenta");

            string query = $"INSERT INTO prestadores (nombre, punto_venta) VALUES (@nombre, @puntoVenta);";
            _con.Connect();
            result = _con.Write(query, new List<SQLiteParameter> { nombreParam, puntoVentaParam });
            _con.Disconnect();
            return result;
        }

        public override int Update(Prestador obj)
        {
            throw new NotImplementedException();
        }

        public Resultado<BE.Prestador> SelectByName(string name)
        {
            Resultado<BE.Prestador> result;
            SQLiteParameter nombreParam = _con.CreateParameter(name, "nombre");
            string query = "SELECT * FROM prestadores WHERE nombre=@nombre;";

            _con.Connect();
            DataTable data = _con.Read(query, new List<SQLiteParameter> { nombreParam });
            _con.Disconnect();

            if (data.Rows.Count > 0)
            {
                BE.Prestador prestador = MapPrestador(data.Rows[0]);
                result = new Resultado<BE.Prestador>(true, prestador);
            } else
            {
                result = new Resultado<BE.Prestador>(false, null);
            }
            return result;
        }
    }
}
