using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ejercicioClase.Model;
using ejercicioClase.Reportes;

namespace ejercicioClase.ConsultasRpt
{
    public partial class frmrptProductos : Form
    {
        public frmrptProductos()
        {
            InitializeComponent();
        }

        private void frmrptProductos_Load(object sender, EventArgs e)
        {
            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                rptProductos rptpr = new rptProductos();
                rptpr.SetDataSource(db.producto.ToList());
                crpProducto.ReportSource = rptpr;
            }

        }
    }
}
