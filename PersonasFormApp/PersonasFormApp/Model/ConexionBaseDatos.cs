using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PersonasFormApp
{
    class ConexionBaseDatos
    {
        private MySqlConnectionStringBuilder builder;
        private MySqlConnection connection;

        public  ConexionBaseDatos()
        {
            builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.Port = 3306;
            builder.UserID = "root";
            builder.Password = "root";
            builder.Database = "personas";
            connection = new MySqlConnection(builder.ToString());
        }

        public MySqlConnectionStringBuilder Builder { get => builder;}
        public MySqlConnection Connection { get => connection;}
    }
}
