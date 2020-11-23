using Proyecto_prestamos.Visual;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_prestamos
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnNuevoPrestamo_Click(object sender, EventArgs e)
        {
            frmNuevoCliente nuevoCliente = new frmNuevoCliente();
            nuevoCliente.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmNuevoPrestamo nuevoPrestamo = new frmNuevoPrestamo();
            nuevoPrestamo.Show();
            this.Hide();

        }

        private void btnGestionPrestamos_Click(object sender, EventArgs e)
        {

        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
