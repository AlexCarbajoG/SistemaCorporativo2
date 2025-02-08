using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Negocio;
using Entidad;


namespace Presentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            DB_USUARIO dB_USUARIO = new N_Usuario().Listar().Where(u => u.DES_USER == txt_usuario.Text && u.CLAVE_USER == txt_clave.Text).FirstOrDefault();


            Menu form = new Menu();
            form.Show();
            this.Hide();

            form.FormClosing += frm_cerrar;
        }

        private void frm_cerrar(object sender, EventArgs e)
        {
            txt_usuario.Text = "";
            txt_clave.Text = "";

            this.Show();
        }
    }
}
