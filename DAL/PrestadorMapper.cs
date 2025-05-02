using BE;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
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
            SQLiteParameter puntoVentaParam = (obj.PuntoVenta != 0) ? _con.CreateParameter(obj.PuntoVenta, "puntoVenta") : null;

            string variables = "nombre";

            List<SQLiteParameter> paramList = new List<SQLiteParameter>
            {
                nombreParam,
            };

            if (puntoVentaParam != null)
            {
                paramList.Add(puntoVentaParam);
                variables += ", punto_venta";
            }

            string query = $"INSERT INTO prestadores ({variables}) VALUES (@nombre, @puntoVenta);";
            result = _con.Write(query, paramList);
            return result;
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
