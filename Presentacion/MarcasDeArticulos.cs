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
    public partial class MarcasDeArticulos : Form
    {
        public MarcasDeArticulos()
        {
            InitializeComponent();
        }

        private void btnlistar_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();

                N_MarcaArticulo negocio = new N_MarcaArticulo();
                List<DB_MAR_ART> lista = negocio.Listar();

                foreach (var item in lista)
                {
                    dataGridView1.Rows.Add(item.COD_MAR, item.DES_MAR, item.COD_USER, item.FEC_ABM);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar marcas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MarcasDeArticulos_Load(object sender, EventArgs e)
        {
            try
            {
                N_Usuario nUsuario = new N_Usuario();
                List<DB_USUARIO> usuarios = nUsuario.Listar();
                cbusuario.DataSource = usuarios;
                cbusuario.DisplayMember = "DES_USER";
                cbusuario.ValueMember = "COD_USER";
                cbusuario.SelectedIndex = -1;

                txtfecha.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                txtfecha.ReadOnly = true;
                txtfecha.BackColor = SystemColors.Control;
                txtfecha.TabStop = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el formulario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbusuario.SelectedValue == null)
                {
                    MessageBox.Show("Seleccione un usuario válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DateTime fechaActual = DateTime.Now;
                txtfecha.Text = fechaActual.ToString("yyyy-MM-dd HH:mm:ss");

                DB_MAR_ART marca = new DB_MAR_ART()
                {
                    COD_MAR = txtmarca.Text.Trim(),
                    DES_MAR = txtdesmarca.Text.Trim(),
                    COD_USER = cbusuario.SelectedValue.ToString(),
                    FEC_ABM = fechaActual
                };

                N_MarcaArticulo objNegocio = new N_MarcaArticulo();
                bool resultado = objNegocio.Insertar(marca);

                if (resultado)
                {
                    MessageBox.Show("Marca registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnlistar_Click(null, null);

                    txtmarca.Clear();
                    txtdesmarca.Clear();
                    cbusuario.SelectedIndex = -1;
                    txtfecha.Clear();
                }
                else
                {
                    MessageBox.Show("Error al registrar la marca.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
