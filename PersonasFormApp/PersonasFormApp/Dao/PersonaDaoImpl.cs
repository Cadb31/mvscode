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

        public PersonaDaoImpl(ConexionBaseDatos conexionBaseDatos)
        {
            this.conexionBaseDatos = conexionBaseDatos;
        }

        bool PersonaDao.actualizar(Persona personaActual, Persona personaNueva)
        {
            MySqlCommand cmd = conexionBaseDatos.Connection.CreateCommand();

            cmd.CommandText = "UPDATE persona SET nombre = ?nombre, apellidos = ?apellidos, direccion = ?direccion, edad = ?edad, email = ?email WHERE id = ?id";

            cmd.Parameters.Add(new MySqlParameter("nombre", personaNueva.Nombre));
            cmd.Parameters.Add(new MySqlParameter("apellidos", personaNueva.Apellidos));
            cmd.Parameters.Add(new MySqlParameter("direccion", personaNueva.Direccion));
            cmd.Parameters.Add(new MySqlParameter("edad", personaNueva.Edad));
            cmd.Parameters.Add(new MySqlParameter("email", personaNueva.Email));
            cmd.Parameters.Add(new MySqlParameter("id", personaActual.Id));

            conexionBaseDatos.Connection.Open();
            cmd.ExecuteNonQuery();

            return true;
        }

        List<Persona> PersonaDao.consultar(Persona persona)
        {
            MySqlCommand cmd = conexionBaseDatos.Connection.CreateCommand();
            cmd.CommandText = "SELECT id, nombre, apellidos, direccion, edad, email FROM persona WHERE id = ?id";
            conexionBaseDatos.Connection.Open();
            cmd.Parameters.Add(new MySqlParameter("id", persona.Id));
            MySqlDataReader dataReader = cmd.ExecuteReader();

            List<Persona> personas = new List<Persona>();

            while (dataReader.Read())
            {
                personas.Add(new Persona(dataReader.GetInt16("id"),
                                        dataReader.GetString("nombre"),
                                        dataReader.GetString("apellidos"),
                                        dataReader.GetString("direccion"),
                                        dataReader.GetInt16("edad"),
                                        dataReader.GetString("email")));
            }

            return personas;
        }

        List<Persona> PersonaDao.consultarTodas()
        {
            MySqlCommand cmd = conexionBaseDatos.Connection.CreateCommand();
            cmd.CommandText = "SELECT id, nombre, apellidos, direccion, edad, email FROM persona";
            conexionBaseDatos.Connection.Open();
            MySqlDataReader dataReader = cmd.ExecuteReader();

            List<Persona> personas = new List<Persona>();

            while (dataReader.Read())
            {
                personas.Add(new Persona(dataReader.GetInt16("id"),
                                        dataReader.GetString("nombre"),
                                        dataReader.GetString("apellidos"),
                                        dataReader.GetString("direccion"),
                                        dataReader.GetInt16("edad"),
                                        dataReader.GetString("email")));
            }

            return personas;
        }

        bool PersonaDao.eliminar(Persona persona)
        {
            MySqlCommand cmd = conexionBaseDatos.Connection.CreateCommand();

            cmd.CommandText = "DELETE FROM persona WHERE id = ?id";

            cmd.Parameters.Add(new MySqlParameter("id", persona.Id));
            conexionBaseDatos.Connection.Open();
            cmd.ExecuteNonQuery();

            return true;
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
