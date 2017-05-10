using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonasFormApp
{
    public partial class FormInUpPersona : Form
    {
        private static String VOID = "";
        private PersonaDao personaDao;

        public FormInUpPersona()
        {
            InitializeComponent();
            ConexionBaseDatos conexionBaseDatos = new ConexionBaseDatos();
            personaDao = new PersonaDaoImpl(conexionBaseDatos);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            String nombre = txtNombre.Text;
            String apellidos = txtApellidos.Text;
            String direccion = txtDireccion.Text;
            int edad = int.Parse(txtEdad.Text);
            String email = txtEmail.Text;

            Persona persona = new Persona(nombre, apellidos, direccion, edad, email);

            if (personaDao.insertar(persona))
            {
                MessageBox.Show("Se ha insertado la persona en base de datos correctamente");
                clearText();
            }
            else
            {
                MessageBox.Show("No se ha podido insertar la persona en base de datos");
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            clearText();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearText()
        {
            txtNombre.Text = VOID;
            txtApellidos.Text = VOID;
            txtDireccion.Text = VOID;
            txtEdad.Text = VOID;
            txtEmail.Text = VOID;
        }
    }
}
