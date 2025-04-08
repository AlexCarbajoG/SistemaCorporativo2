using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;
using Negocio;

namespace Presentacion
{
    public partial class UsuarioSistema : Form
    {
        //conectamos con la capa negocio 
        private N_Usuario objUsuario = new N_Usuario();

        public UsuarioSistema()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                string estadoSeleccionado = cb_estado.SelectedItem?.ToString();
                if (string.IsNullOrEmpty(estadoSeleccionado) || estadoSeleccionado == "-------------")
                {
                    MessageBox.Show("Debe seleccionar un estado válido.");
                    return;
                }

                bool estadoBool = estadoSeleccionado == "ACTIVO";

                DB_USUARIO usuarioActulizado = new DB_USUARIO()
                {
                    COD_USER = txt_codigo.Text,
                    DES_USER = txt_nombre.Text,
                    EMAIL_USER = txt_email.Text,
                    CLAVE_USER = txt_clave.Text,
                    FLG_EST_USER = estadoBool,
                    FEC_ABM = DateTime.Now,
                };

                bool actualizado = objUsuario.Actualizar(usuarioActulizado);

                if (actualizado)
                {
                    MessageBox.Show("Registro actualizado correctamente.");
                    txt_codigo.Clear();
                    txt_nombre.Clear();
                    txt_email.Clear();
                    txt_clave.Clear();
                    cb_estado.SelectedItem = 0;
                    txt_fecha.Clear();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el registro.");
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Erros al actualizar" + ex.Message);
            }
        }

        private void btn_listar_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();

                List<DB_USUARIO> lista = objUsuario.Listar();

                foreach (var item in lista)
                {
                    string estadoTexto = item.FLG_EST_USER ? "Activo" : "Cesado";
                    dataGridView1.Rows.Add(item.COD_USER, item.DES_USER, item.EMAIL_USER,
                        item.CLAVE_USER, item.FLG_EST_USER, item.FEC_ABM);
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Error al cargar los datos." + ex.Message);
            }
        }

        private void btn_crearusuario_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaActual = DateTime.Now;
                txt_fecha.Text = fechaActual.ToString("yyyy-MM-dd HH:mm:ss");

                string codUsurio = txt_codigo.Text.Trim();
                if (string.IsNullOrEmpty(codUsurio))
                {
                    MessageBox.Show("No se puede obtener al Usuario");
                    return;
                }

                string estadoSeleccion = cb_estado.SelectedItem.ToString();
                if (string.IsNullOrEmpty(estadoSeleccion) || estadoSeleccion == "--------")
                {
                    MessageBox.Show("Debe seleccionar un estado");
                }

                bool estadoComboBox = estadoSeleccion == "Activo";

                DB_USUARIO nuevoUsuario = new DB_USUARIO()
                {
                    COD_USER = txt_codigo.Text,
                    DES_USER = txt_nombre.Text,
                    EMAIL_USER = txt_email.Text,
                    CLAVE_USER = txt_clave.Text,
                    FLG_EST_USER = estadoComboBox,
                    FEC_ABM = fechaActual,
                };

                bool resultado = objUsuario.Insertar(nuevoUsuario);
                if (resultado)
                {
                    MessageBox.Show("Registro agregado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txt_codigo.Clear();
                    txt_nombre.Clear();
                    txt_email.Clear();
                    txt_clave.Clear();
                    cb_estado.SelectedItem = 0;
                    txt_fecha.Clear();

                }
                else
                {
                    MessageBox.Show("Error al agregar el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                    
                
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string codigoOpcion = txt_codigo.Text.Trim();
                if (string.IsNullOrEmpty(codigoOpcion) )
                {
                    MessageBox.Show("Ingrese un código valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                }

                List<DB_USUARIO> listaUsuario = objUsuario.Listar();
                DB_USUARIO opcion = listaUsuario.FirstOrDefault(r => r.COD_USER.Trim()
                == codigoOpcion.Trim());

                if (opcion != null)
                {
                    txt_codigo.Text = opcion.COD_USER.Trim();
                    txt_nombre.Text = opcion.DES_USER.Trim();
                    txt_email.Text = opcion.EMAIL_USER.Trim();
                    txt_clave.Text = opcion.CLAVE_USER.Trim();
                    txt_fecha.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                    cb_estado.SelectedItem = opcion.FLG_EST_USER ? "Activo" : "Cesado";

                    //txt_codigo.Clear();

                }
                else
                {
                    MessageBox.Show("No se encontro el código ingresado.");
                }


            }
            catch( Exception ex ) 
            {
                MessageBox.Show("Error al buscar los datos : " + ex.Message);
            }
        }
    }
}
