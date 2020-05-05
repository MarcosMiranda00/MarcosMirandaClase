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
                txtNumerodeVenta.Text = "1";
                foreach (var iterardatostbventa in tb_v) 
                {
                    int idVenta = iterardatostbventa.idVenta;
                    int suma = idVenta + 1;
                    txtNumerodeVenta.Text = suma.ToString();
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

                double suma = 0;
            for (int i=0; i< dtgVentas.RowCount; i++)
            {
                string datosOperar = dtgVentas.Rows[i].Cells[4].Value.ToString();
                double datosConvertidos = Convert.ToDouble(datosOperar);
                
                //suma = suma + datosConvertidos;
                suma += datosConvertidos;

                txtTotal2.Text = suma.ToString();

            }
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
                txtCantidad.Text = "1";

                txtCantidad.Select();
            }
        }

        private void btnGVenta_Click(object sender, EventArgs e)
        {
            using (sistema_ventasEntities bd = new sistema_ventasEntities())
            {
                tb_venta tb_v = new tb_venta();
                string comboTipoDoc = cmbTipoDoc.SelectedValue.ToString();
                string comboCliente = cmbCliente.SelectedValue.ToString();
                tb_v.idDocumento = Convert.ToInt32(comboTipoDoc);
                tb_v.iDCliente = Convert.ToInt32(comboCliente);
                tb_v.iDUsuario = 1;
                tb_v.totalVenta = Convert.ToDecimal(txtTotal2.Text);
                tb_v.fecha = Convert.ToDateTime(dtpFecha.Text);

                bd.tb_venta.Add(tb_v);
                bd.SaveChanges();

                detalleVenta dete = new detalleVenta();

                for (int i = 0; i < dtgVentas.RowCount; i++)
                {
                    string idProducto = dtgVentas.Rows[i].Cells[0].Value.ToString();
                    int idProductoConvertidos = Convert.ToInt32(idProducto);

                    string cantidad = dtgVentas.Rows[i].Cells[3].Value.ToString();
                    int cantidadConvertidos = Convert.ToInt32(cantidad);

                    string precio = dtgVentas.Rows[i].Cells[2].Value.ToString();
                    decimal precioConvertidos = Convert.ToDecimal(precio);

                    string total = dtgVentas.Rows[i].Cells[4].Value.ToString();
                    decimal totalConvertidos = Convert.ToDecimal(total);

                    dete.idVenta = Convert.ToInt32(txtNumerodeVenta.Text);
                    dete.idProducto = idProductoConvertidos;
                    dete.cantidad = cantidadConvertidos;
                    dete.precio = precioConvertidos;
                    dete.total = totalConvertidos;
                    bd.detalleVenta.Add(dete);
                    bd.SaveChanges();

                }


            }
                    retornoid();
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtBuscar.Text =="") 
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnBuscar.PerformClick();
                }
            }else if (e.KeyCode == Keys.Enter)
            {
                using (sistema_ventasEntities bd = new sistema_ventasEntities()) 
                {
                    producto pr = new producto();
                    int buscar = int.Parse(txtBuscar.Text);
                    pr = bd.producto.Where(idBuscar => idBuscar.idProducto == buscar).First();
                    txtCodigoProd.Text = Convert.ToString(pr.idProducto);
                    txtNombredelProd.Text = Convert.ToString(pr.nombreProducto);
                    txtPrecioProd.Text = Convert.ToString(pr.precioProducto);
                    txtCantidad.Focus();
                    txtBuscar.Text = "";
                }
            }
        }

        int intentos = 1;
        private void txtCantidad_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (intentos == 2) 
                {
                    btnAgregar.PerformClick();
                    txtCodigoProd.Text = "";
                    txtNombredelProd.Text = "";
                    txtPrecioProd.Text = "";
                    txtTotal.Text = "";
                    intentos = 0;
                    txtCantidad.Text = "1";
                    txtBuscar.Focus();
                }
                    intentos += 1;
            }
                    
        }
    }
}
