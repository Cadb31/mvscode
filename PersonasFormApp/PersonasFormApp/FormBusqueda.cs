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
    public partial class FormBusqueda : Form
    {
        private int id;
        private char opc;

        public FormBusqueda(char opc)
        {
            this.opc = opc;
            InitializeComponent();
        }

        public int Id { get => id; set => id = value; }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                id = int.Parse(txtId.Text);
                switch (opc) {
                    case 'C':
                        FormConsultar consultar = new FormConsultar(id);
                        consultar.Show();
                        this.Close();

                        break;
                    case 'A':
                        FormInUpPersona personaA = new FormInUpPersona();
                        personaA.Show();
                        this.Close();
                        break;
                    case 'E':
                        FormInUpPersona personaE = new FormInUpPersona();
                        personaE.Show();
                        this.Close();
                        break;
                }
            }
            catch (Exception)
            {
                FormConsultar consultar = new FormConsultar(0);
                consultar.Show();
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
