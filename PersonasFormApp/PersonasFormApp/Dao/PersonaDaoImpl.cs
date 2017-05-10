using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PersonasFormApp
{
    class PersonaDaoImpl : PersonaDao
    {
        ConexionBaseDatos conexionBaseDatos;

        public PersonaDaoImpl(ConexionBaseDatos conexionBaseDatos) {
            this.conexionBaseDatos = conexionBaseDatos;
        }
        
        bool PersonaDao.actualizar(Persona personaActual, Persona personaNueva)
        {
            throw new NotImplementedException();
        }

        bool PersonaDao.consultar(Persona persona)
        {
            throw new NotImplementedException();
        }

        bool PersonaDao.consultarTodas()
        {
            throw new NotImplementedException();
        }

        bool PersonaDao.eliminar(Persona persona)
        {
            throw new NotImplementedException();
        }

        bool PersonaDao.insertar(Persona persona)
        {            
            MySqlCommand cmd = conexionBaseDatos.Connection.CreateCommand();

            cmd.CommandText = "INSERT INTO persona (nombre, apellidos, direccion, edad, email) VALUES(?nombre, ?apellidos, ?direccion, ?edad, ?email)";

            cmd.Parameters.Add(new MySqlParameter("nombre", persona.Nombre));
            cmd.Parameters.Add(new MySqlParameter("apellidos", persona.Apellidos));
            cmd.Parameters.Add(new MySqlParameter("direccion", persona.Direccion));
            cmd.Parameters.Add(new MySqlParameter("edad", persona.Edad));
            cmd.Parameters.Add(new MySqlParameter("email", persona.Email));

            conexionBaseDatos.Connection.Open();
            cmd.ExecuteNonQuery();
            return true;
        }
    }
}
