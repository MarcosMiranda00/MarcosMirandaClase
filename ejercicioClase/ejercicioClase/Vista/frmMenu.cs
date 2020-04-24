using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicioClase.Vista
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void uSUARIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios usu = new frmUsuarios();
            usu.MdiParent = this;
            usu.Show();
        }

        private void rOLESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRoles ro1 = new frmRoles();
            ro1.MdiParent = this;
            ro1.Show();
        }

        private void cONTROLToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public static frmVentas v1 = new frmVentas();
        private void venderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.MdiParent = this;
            v1.Show();
        }
    }
}
