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
    public partial class Acceso : Form
    {

        private N_Acceso objAcceso = new N_Acceso();

        public Acceso()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_listar_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();

                List<DB_ACCESO> lista = objAcceso.ListarAcceso();

                foreach (var item in lista)
                {
                    dataGridView1.Rows.Add(item.COD_USER, item.COD_ALM, item.COD_OPCION,
                        item.FLG_EST_ACC, item.FEC_ABM);
                }
            }
            catch
            {
                MessageBox.Show("Error al cargar datos + ex.Message");
            }
        }

        private void txt_coduser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_codalmacen_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_codopcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void cb_estado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_fecha_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_crear_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Leer los datos del formulario
                string codUser = txt_coduser.Text.Trim();
                string codAlm = txt_codalmacen.Text.Trim();
                string estadoSeleccionado = cb_estado.SelectedItem?.ToString();
                DateTime fecha = DateTime.Now;

                // 2. Validar campos
                if (string.IsNullOrEmpty(codUser) || string.IsNullOrEmpty(codAlm) ||
                    string.IsNullOrEmpty(estadoSeleccionado) || estadoSeleccionado == "-------------")
                {
                    MessageBox.Show("Por favor, complete todos los campos y seleccione un estado válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 3. Convertir estado
                bool estadoAcceso = estadoSeleccionado == "ACTIVO";

                // 4. Crear objeto de acceso sin cod_opcion (se obtendrá automáticamente en el Insertar)
                DB_ACCESO nuevoAcceso = new DB_ACCESO()
                {
                    COD_USER = codUser,
                    COD_ALM = codAlm,
                    // COD_OPCION se asigna automáticamente en CD_Acceso
                    FLG_EST_ACC = estadoAcceso,
                    FEC_ABM = fecha
                };

                // 5. Llamar a la lógica de negocio para insertar
                bool resultado = objAcceso.Insertar(nuevoAcceso);

                if (resultado)
                {
                    MessageBox.Show("Acceso creado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpiar campos
                    txt_coduser.Clear();
                    txt_codalmacen.Clear();
                    cb_estado.SelectedIndex = 0;
                    txt_fecha.Clear(); // opcional
                }
                else
                {
                    MessageBox.Show("No se pudo crear el acceso. Asegúrate de que el usuario tenga opciones registradas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
