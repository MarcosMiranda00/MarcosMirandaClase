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
using ejercicioClase.Vista;

namespace ejercicioClase
{
    public partial class Logueo : Form
    {
        public Logueo()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                var lista = from usuario in db.tb_usuarios
                            where usuario.Email == txtUsuario.Text
                            && usuario.Contrasena == txtContrasena.Text
                            select usuario;

                if (lista.Count() > 0)
                {
                    frmMenu menu = new frmMenu();
                    menu.Show();                    
                }
                else
                {
                    MessageBox.Show("El usuario es incorrecto");
                }

                


            }
           
        }
    }
}
