using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrilojenieAIS
{
    internal class Database
    {
        NpgsqlConnection connection = new NpgsqlConnection("server=localhost; port=5555; database=StudyBase; user id=postgres; password=123;");

        public void OpenConnection()
        {
            connection.Open();
        }
        public DataTable ExecuteCommand(string sql)
        {
            try
            {
                NpgsqlCommand command = new NpgsqlCommand(sql, connection);
                NpgsqlDataReader reader = command.ExecuteReader();
                DataTable dt = new DataTable();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                command.Dispose();
                return dt;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void CloseConnection()
        {
            connection.Close();
        }
    }
}
