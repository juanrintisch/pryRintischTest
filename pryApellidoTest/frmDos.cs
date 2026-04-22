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
            grpUno.Visible = false;
            grpDos.Visible = true;
            //this.Hide();
            //frmTres frmTres = new frmTres(); 
            //frmTres.ShowDialog();


        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Debe Ingresar un Nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
            }
            else
            {
               
                cmbLista.Items.Add((string)txtNombre.Text);
                cmbProductos.Items.Add((string)txtNombre.Text);
                MessageBox.Show("Registro exitoso", "Michelin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSiguiente.Enabled = true;
                txtNombre.Clear();
                
            }

        }

        private void cmbLista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == 13 && txtNombre.Text != "")
            {
                MessageBox.Show("Registro exitoso", "Michelin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbLista.Items.Add((string)txtNombre.Text);
                cmbProductos.Items.Add((string)txtNombre.Text);
                txtNombre.Clear();
                btnSiguiente.Enabled = true;
                
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmDos_Load(object sender, EventArgs e)
        {

        }
    }
}
