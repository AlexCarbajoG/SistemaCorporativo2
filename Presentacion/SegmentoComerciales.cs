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
    public partial class SegmentoComerciales : Form
    {
        N_SegmentosComerciales objSegentosCom = new N_SegmentosComerciales();

        public SegmentoComerciales()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnlistar_Click(object sender, EventArgs e)
        {
            try
            {
                // Limpiar el DataGridView
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();

                // Obtener la lista desde la capa de negocio
                N_SegmentosComerciales objNegocioSegmento = new N_SegmentosComerciales();
                List<DB_SEG_COM> lista = objNegocioSegmento.Listar();

                // Llenar el DataGridView con los datos
                foreach (var item in lista)
                {
                    dataGridView1.Rows.Add(
                        item.COD_SEG,
                        item.DES_SEG,
                        item.COD_SSEG,
                        item.DES_SSEG,
                        item.COD_USER,
                        item.FEC_ABM
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar los segmentos comerciales: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SegmentoComerciales_Load(object sender, EventArgs e)
        {
            try
            {
                // Cargar usuarios en el ComboBox
                N_Usuario objNegocioUsuario = new N_Usuario();
                List<DB_USUARIO> listaUsuarios = objNegocioUsuario.Listar();

                cbusuario.DataSource = listaUsuarios;
                cbusuario.DisplayMember = "DES_USER";
                cbusuario.ValueMember = "COD_USER";
                cbusuario.SelectedIndex = -1;

                // Cargar fecha actual en el TextBox y bloquear edición
                txtfecha.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                txtfecha.ReadOnly = true;
                txtfecha.BackColor = SystemColors.Control;
                txtfecha.TabStop = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos iniciales: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar selección de usuario
                if (cbusuario.SelectedValue == null)
                {
                    MessageBox.Show("Seleccione un usuario.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DateTime fechaActual = DateTime.Now;
                txtfecha.Text = fechaActual.ToString("yyyy-MM-dd HH:mm:ss");

                // Crear objeto
                DB_SEG_COM nuevoSegmento = new DB_SEG_COM()
                {
                    COD_SEG = txtcodseg.Text.Trim(),
                    DES_SEG = txtdesseg.Text.Trim(),
                    COD_SSEG = txtsubseg.Text.Trim(),
                    DES_SSEG = txtsubsegdes.Text.Trim(),
                    COD_USER = cbusuario.SelectedValue.ToString(),
                    FEC_ABM = fechaActual
                };

                // Insertar a través de la capa de negocio
                N_SegmentosComerciales objNegocio = new N_SegmentosComerciales();
                bool resultado = objNegocio.Insertar(nuevoSegmento);

                if (resultado)
                {
                    MessageBox.Show("Segmento comercial agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListarSegmentos(); // Actualiza el DataGridView

                    // Limpiar campos
                    txtcodseg.Clear();
                    txtdesseg.Clear();
                    txtsubseg.Clear();
                    txtsubsegdes.Clear();
                    cbusuario.SelectedIndex = -1;
                    txtfecha.Clear();
                }
                else
                {
                    MessageBox.Show("Error al agregar el segmento comercial.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarSegmentos()
        {
            try
            {
                List<DB_SEG_COM> lista = objSegentosCom.Listar();

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = lista;

            }
            catch(Exception ex) 
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }



    }
}
