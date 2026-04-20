using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryApellidoTest
{
    public partial class frmDos : Form
    {
        public frmDos()
        {
            InitializeComponent();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            frmTres frmTres = new frmTres(); 
            frmTres.ShowDialog();

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Debe Ingresar un Nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
            }
            else if (cmbLista.Text == "")
            {
                MessageBox.Show("Debe Seleccionar un Producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbLista.Focus();
            }
            else
            {
                MessageBox.Show("Registro exitoso", "Michelin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSiguiente.Enabled = true;
            }

        }

        private void cmbLista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
