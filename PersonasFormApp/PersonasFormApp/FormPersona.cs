using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PersonasFormApp
{
    public partial class FormPersona : Form
    {
        private MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();

        public FormPersona()
        {
            InitializeComponent();
        }

        private void initializeMySQLConnection()
        {
            builder.Server = "localhost";
            builder.Port = 3306;
            builder.UserID = "root";
            builder.Password = "root";
            builder.Database = "personas";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            MySqlConnection conn = new MySqlConnection(builder.ToString());
            MySqlCommand cmd = conn.CreateCommand();

            String nombre = txtNombre.Text;
            String apellidos = txtApellidos.Text;
            String direccion = txtDireccion.Text;
            int edad = int.Parse(txtEdad.Text);
            String email = txtEmail.Text;

            cmd.CommandText = "INSERT INTO persona (nombre, apellidos, direccion, edad, email) VALUES(?nombre, ?apellidos, ?direccion, ?edad, ?email)";

            cmd.Parameters.Add(new MySqlParameter("nombre", nombre));
            cmd.Parameters.Add(new MySqlParameter("apellidos", apellidos));
            cmd.Parameters.Add(new MySqlParameter("direccion", direccion));
            cmd.Parameters.Add(new MySqlParameter("edad", edad));
            cmd.Parameters.Add(new MySqlParameter("email", email));

            conn.Open();
            cmd.ExecuteNonQuery();

            MessageBox.Show("Se ha insertado el registro correctamente");
        }
    }
}
