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
            InUpPersona inUpPersona = new InUpPersona();
            inUpPersona.Show();
        }

        private void salirMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
