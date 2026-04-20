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
    public partial class frmTres : Form
    {
        public frmTres()
        {
            InitializeComponent();
        }

        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmTres_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (cmbProducto.Text == "")
            {
                MessageBox.Show("Debe Seleccionar un Producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbProducto.Focus();
            }
            
        }
    }
}
