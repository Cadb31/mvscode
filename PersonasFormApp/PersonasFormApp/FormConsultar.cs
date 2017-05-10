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
    public partial class FormConsultar : Form
    {
        private PersonaDao personaDao;

        public FormConsultar()
        {
            InitializeComponent();
            ConexionBaseDatos conexionBaseDatos = new ConexionBaseDatos();
            personaDao = new PersonaDaoImpl(conexionBaseDatos);
            loadDataTable();
        }

        private void loadDataTable()
        {
            List<Persona> personas = personaDao.consultarTodas();

            foreach (Persona p in personas)
            {
                dataGridViewPersonas.Rows.Add(p.Id, p.Nombre, p.Apellidos, p.Direccion, p.Edad, p.Email);
            }

            dataGridViewPersonas.Update();
        }
    }
}
