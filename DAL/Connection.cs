using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Connection
    {
        private static Connection instance;

        private readonly string pathDB;
        private readonly string stringConnection;

        private SQLiteConnection _connection;

        public static Connection GetInstance()
        {
            if (instance == null) instance = new Connection();
            return instance;
        }

        private Connection()
        {
            pathDB = Path.GetFullPath(@"..\..\..\..\DAL\database\testingDB.db");
            Console.WriteLine(pathDB);
            stringConnection = $"Data Source={pathDB};Version=3;";
        }

        public void Connect()
        {
            if (File.Exists(pathDB))
            {
                _connection = new SQLiteConnection
                {
                    ConnectionString = stringConnection,
                };
                _connection.Open();
            }
            else Console.WriteLine($"The database does not exist in: {pathDB}");

        }

        public void Disconnect()
        {
            _connection.Close();
            _connection = null;
            GC.Collect();
        }

        public SQLiteParameter CreateParameter(string value, string name)
        {
            SQLiteParameter param = new SQLiteParameter
            {
                ParameterName = name,
                DbType = DbType.String,
                Value = value
            };
            return param;
        }

        public SQLiteParameter CreateParameter(int value, string name)
        {
            SQLiteParameter param = new SQLiteParameter
            {
                ParameterName = name,
                DbType = DbType.Int32,
                Value = value
            };
            return param;
        }

        public SQLiteParameter CreateParameter(float value, string name)
        {
            SQLiteParameter param = new SQLiteParameter
            {
                ParameterName = name,
                DbType = DbType.Double,
                Value = value
            };
            return param;
        }

        private SQLiteCommand CreateCommand(string query, List<SQLiteParameter> parameters = null)
        {
            SQLiteCommand command = new SQLiteCommand
            {
                Connection = _connection,
                CommandText = query,
                CommandType = CommandType.Text,
            };

            parameters?.ForEach(parameter => command.Parameters.Add(parameter));

            return command;
        }

        public DataTable Read(string query, List<SQLiteParameter> parameters = null)
        {
            SQLiteCommand command = CreateCommand(query, parameters);
            DataTable table = new DataTable();
            using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
            {
                Console.WriteLine(command.Connection.ConnectionString);
                adapter.SelectCommand = command;
                adapter.Fill(table);
                adapter.Dispose();
            }
            return table;
        }

        public int Write(string query, List<SQLiteParameter> parameters = null)
        {
            int result;
            SQLiteCommand command = CreateCommand(query, parameters);
            try
            {
                result = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                result = -1;
                Console.WriteLine(ex.Message);
            }
            return result;
        }
    }
}
