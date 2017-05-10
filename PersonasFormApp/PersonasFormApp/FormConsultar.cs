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

        public FormConsultar(int id)
        {
            InitializeComponent();
            ConexionBaseDatos conexionBaseDatos = new ConexionBaseDatos();            
            personaDao = new PersonaDaoImpl(conexionBaseDatos);
            loadDataTable(id);
        }

        private void loadDataTable(int id)
        {
            if (id != 0)
            {
                List<Persona> personas = personaDao.consultar(new Persona(id));
                foreach (Persona p in personas)
                {
                    dataGridViewPersonas.Rows.Add(p.Id, p.Nombre, p.Apellidos, p.Direccion, p.Edad, p.Email);
                }
            }
            else {
                List<Persona> personas = personaDao.consultarTodas();
                foreach (Persona p in personas)
                {
                    dataGridViewPersonas.Rows.Add(p.Id, p.Nombre, p.Apellidos, p.Direccion, p.Edad, p.Email);
                }
            }
            dataGridViewPersonas.Update();
        }
    }
}
