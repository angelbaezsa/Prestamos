using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_prestamos.Visual
{
    public partial class frmNuevoPrestamo : Form
    {
        public frmNuevoPrestamo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal menuPrincipal = new frmMenuPrincipal();
            menuPrincipal.Show();
            frmNuevoPrestamo nuevoPrestamo = new frmNuevoPrestamo();
            nuevoPrestamo.Close();
        }
    }
}
