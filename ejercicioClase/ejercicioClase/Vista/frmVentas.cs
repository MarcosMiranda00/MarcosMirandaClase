using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ejercicioClase.Vista;
using ejercicioClase.Model;

namespace ejercicioClase.Vista
{
    public partial class frmVentas : Form
    {
        public frmVentas()
        {
            InitializeComponent();
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            retornoid();
            CargarCombo();
        }

        void retornoid()
        {
            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                var tb_v = db.tb_venta;
                foreach (var iterardatostbventa in tb_v) 
                {
                    txtNumerodeVenta.Text = iterardatostbventa.idVenta.ToString();
                    //dtvUsuarios.Rows.Add(iterardatosTBUsuarios.Email, iterardatosTBUsuarios.Contrasena);
                }
            }
        }

        public void CargarCombo()
        {
            using (sistema_ventasEntities bd = new sistema_ventasEntities())
            {
                var clientes = bd.tb_cliente.ToList();
                cmbCliente.DataSource = clientes;
                cmbCliente.DisplayMember = "nombreCliente";
                cmbCliente.ValueMember = "iDCliente";


                var tipoDocu = bd.tb_documento.ToList();
                cmbTipoDoc.DataSource = tipoDocu;
                cmbTipoDoc.DisplayMember = "nombreDocumento";
                cmbTipoDoc.ValueMember = "iDDocumento";
                
            }

        }
    }
}
