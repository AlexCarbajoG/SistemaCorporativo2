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
    public partial class FamiliaDeArticulos : Form
    {

        N_FamiliaArticulo objFamilia = new N_FamiliaArticulo();

        public FamiliaDeArticulos()
        {
            InitializeComponent();
        }

        private void btnlistar_Click(object sender, EventArgs e)
        {
            try
            {
                // Limpiar DataGridView
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();

                // Obtener lista desde la capa de negocio
                N_FamiliaArticulo objNegocio = new N_FamiliaArticulo();
                List<DB_FMA_ART> lista = objNegocio.Listar();

                // Llenar DataGridView manualmente (si ya están definidas las columnas)
                foreach (var item in lista)
                {
                    dataGridView1.Rows.Add(
                        item.COD_CAT,
                        item.DES_CAT,
                        item.COD_LIN,
                        item.DES_LIN,
                        item.COD_USER,
                        item.FEC_ABM
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar Familias de Artículos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                DB_FMA_ART nuevaFamilia = new DB_FMA_ART()
                {
                    COD_CAT = txtcategoria.Text.Trim(),
                    DES_CAT = txtdescat.Text.Trim(),
                    COD_LIN = txtcodlinea.Text.Trim(),
                    DES_LIN = txtdeslinea.Text.Trim(),
                    COD_USER = cbusuario.SelectedValue.ToString(),
                    FEC_ABM = fechaActual
                };

                N_FamiliaArticulo objNegocio = new N_FamiliaArticulo();
                bool resultado = objNegocio.Insertar(nuevaFamilia);

                if (resultado)
                {
                    MessageBox.Show("Familia de artículo registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnlistar_Click(null, null); // Refrescar listado

                    // Limpiar campos
                    txtcategoria.Clear();
                    txtdescat.Clear();
                    txtcodlinea.Clear();
                    txtdeslinea.Clear();
                    cbusuario.SelectedIndex = -1;
                    txtfecha.Clear();
                }
                else
                {
                    MessageBox.Show("Error al registrar la familia de artículo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FamiliaDeArticulos_Load(object sender, EventArgs e)
        {
            try
            {
                // Cargar usuarios
                N_Usuario nUsuario = new N_Usuario();
                List<DB_USUARIO> usuarios = nUsuario.Listar();
                cbusuario.DataSource = usuarios;
                cbusuario.DisplayMember = "DES_USER";
                cbusuario.ValueMember = "COD_USER";
                cbusuario.SelectedIndex = -1;

                // Establecer fecha actual
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
    }
}
