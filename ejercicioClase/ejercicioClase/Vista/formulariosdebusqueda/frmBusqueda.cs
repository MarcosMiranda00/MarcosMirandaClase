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
            cargar(); 
        }

        void cargar()
        {
            using (sistema_ventasEntities bd = new sistema_ventasEntities())
            {
                var Jointablas = from tbprod in bd.producto  
                                 

                                 select new
                                 {
                                     Id = tbprod.idProducto,
                                     Email = tbprod.nombreProducto,
                                     Tipo_rol = tbprod.precioProducto
                                 };
                dtvProductos.DataSource = Jointablas.ToList();
            } 
        }

        public String id;
        public String Nombre;
        public String Precio;
        private void dtvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dtvProductos.CurrentRow.Cells[0].Value.ToString();
            Nombre = dtvProductos.CurrentRow.Cells[1].Value.ToString();
            Precio = dtvProductos.CurrentRow.Cells[2].Value.ToString();
            
        }
    }
}
