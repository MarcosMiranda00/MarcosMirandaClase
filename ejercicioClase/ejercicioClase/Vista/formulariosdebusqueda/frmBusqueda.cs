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

namespace ejercicioClase.Vista.formulariosdebusqueda
{
    public partial class frmBusqueda : Form
    {
        public frmBusqueda()
        {
            InitializeComponent();
        }

        private void frmBusqueda_Load(object sender, EventArgs e)
        {
            filtro();
        }

        void filtro()
        {
            using (sistema_ventasEntities bd = new sistema_ventasEntities())
            {
                string nombre = txtBuscar.Text;

                var buscarprod = from tbprod in bd.producto

                                 where tbprod.nombreProducto.Contains(nombre)

                                 select new
                                 {
                                     Id = tbprod.idProducto,
                                     Email = tbprod.nombreProducto,
                                     Tipo_rol = tbprod.precioProducto
                                 };
                dtvProductos.DataSource = buscarprod.ToList();
            }

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            filtro();
        }

        private void dtvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            envio();
        }

        void envio() 
        {
            String id = dtvProductos.CurrentRow.Cells[0].Value.ToString();
            String Nombre = dtvProductos.CurrentRow.Cells[1].Value.ToString();
            String Precio = dtvProductos.CurrentRow.Cells[2].Value.ToString();

            frmMenu.v1.txtCodigoProd.Text = id;
            frmMenu.v1.txtNombredelProd.Text = Nombre;
            frmMenu.v1.txtPrecioProd.Text = Precio;

            frmMenu.v1.txtCantidad.Focus();
            this.Close();
        }

        private void dtvProductos_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                envio();
            }
        }
    }
}
