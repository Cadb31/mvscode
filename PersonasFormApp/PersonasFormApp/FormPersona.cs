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
    public partial class FormPersona : Form
    {

        public FormPersona()
        {
            InitializeComponent();
        }

        private void insertarMenuItem_Click(object sender, EventArgs e)
        {
            FormInUpPersona inUpPersona = new FormInUpPersona();
            inUpPersona.Show();
        }

        private void salirMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void consultarMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultar consultar = new FormConsultar();
            consultar.Show();
        }
    }
}
