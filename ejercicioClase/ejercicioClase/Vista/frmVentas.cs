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
using ejercicioClase.Vista.formulariosdebusqueda;
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBusqueda busqueda = new frmBusqueda();
            busqueda.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                calculo();
            }
            catch (Exception ex)
            {

            }
            dtgVentas.Rows.Add(txtCodigoProd.Text,txtNombredelProd.Text,txtPrecioProd.Text,txtCantidad.Text,txtTotal.Text);
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            calculo();
        }

        void calculo()
        {
            try
            {
                double precioProd;
                double cantidad;
                double total;

                precioProd = double.Parse(txtPrecioProd.Text);
                cantidad = Convert.ToDouble(txtCantidad.Text);

                total = precioProd * cantidad;
                txtTotal.Text = total.ToString();
            }
            catch (Exception ex)
            {
                txtCantidad.Text = "0";
                MessageBox.Show("No puedes operar datos menores a 0");
            }
        }
    }
}
