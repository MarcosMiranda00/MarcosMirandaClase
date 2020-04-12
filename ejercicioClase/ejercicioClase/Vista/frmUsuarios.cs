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

namespace ejercicioClase.Vista
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }
        tb_usuarios user = new tb_usuarios();

        void cargardatos()
        {
            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                //var tb_usuarios = db.tb_usuarios;
                //foreach(var iterardatosTBUsuarios in tb_usuarios)
                //{
                //dtvUsuarios.Rows.Add(iterardatosTBUsuarios.Email, iterardatosTBUsuarios.Contrasena);
                //}



                dtvUsuarios.DataSource = db.tb_usuarios.ToList();
            }
        }

        void limpiardatos()
        {
            txtUsuario.Text = "";
            txtContrasena.Text = "";
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            cargardatos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {


                user.Email = txtUsuario.Text;
                user.Contrasena = txtContrasena.Text;

                db.tb_usuarios.Add(user);
                db.SaveChanges();
            }
            cargardatos();
            limpiardatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                String Id = dtvUsuarios.CurrentRow.Cells[0].Value.ToString();

                user = db.tb_usuarios.Find(int.Parse(Id));
                db.tb_usuarios.Remove(user);
                db.SaveChanges();
            }
            cargardatos();
            limpiardatos();
        }

        private void dtvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String Email = dtvUsuarios.CurrentRow.Cells[1].Value.ToString();
            String Contra = dtvUsuarios.CurrentRow.Cells[2].Value.ToString();
            txtUsuario.Text = Email;
            txtContrasena.Text = Contra;

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                String Id = dtvUsuarios.CurrentRow.Cells[0].Value.ToString();
                int idC = int.Parse(Id);
                user = db.tb_usuarios.Where(VerificarId => VerificarId.Id == idC).First();
                user.Email = txtUsuario.Text;
                user.Contrasena = txtContrasena.Text;
                db.Entry(user).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

            }
            cargardatos();
            limpiardatos();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            cargardatos();
        }
    }
}
