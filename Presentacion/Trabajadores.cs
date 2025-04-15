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
    public partial class Trabajadores : Form
    {

        N_Trabajador objTrabajador = new N_Trabajador();

        public Trabajadores()
        {
            InitializeComponent();
        }

        private void btnlistar_Click(object sender, EventArgs e)
        {
            try
            {
                // Limpiar el DataGridView
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();

                // Obtener lista desde la capa de negocio
                N_Trabajador objNegocioTrabajador = new N_Trabajador();
                List<DB_TRABAJADOR> lista = objNegocioTrabajador.Listar();

                // Mostrar cada trabajador en una fila
                foreach (var item in lista)
                {
                    dataGridView1.Rows.Add(
                        item.COD_TRA,
                        item.COD_PER,
                        item.FLG_INH_MOV,
                        item.FEC_ABM
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar trabajadores: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Trabajadores_Load(object sender, EventArgs e)
        {
            try
            {
                // Cargar personas (COD_PER)
                N_Persona nPersona = new N_Persona();
                List<DB_PERSONA> personas = nPersona.Listar();
                cbpersona.DataSource = personas;
                cbpersona.DisplayMember = "DES_PER";    // o "COD_PER" si prefieres mostrar el código
                cbpersona.ValueMember = "COD_PER";
                cbpersona.SelectedIndex = -1;


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

        private void btnagregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar selección de persona
                if (cbpersona.SelectedValue == null)
                {
                    MessageBox.Show("Seleccione una persona válida.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtener la fecha actual
                DateTime fechaActual = DateTime.Now;
                txtfecha.Text = fechaActual.ToString("yyyy-MM-dd HH:mm:ss");

                // Crear nuevo objeto trabajador
                DB_TRABAJADOR nuevoTrabajador = new DB_TRABAJADOR()
                {
                    COD_TRA = txtcodtrabajador.Text.Trim(),
                    COD_PER = cbpersona.SelectedValue.ToString(),
                    FLG_INH_MOV = chkestado.Checked, // checkbox para movimiento inhabilitado
                    FEC_ABM = fechaActual
                };

                // Insertar en base de datos
                N_Trabajador nTrabajador = new N_Trabajador();
                bool resultado = nTrabajador.Insertar(nuevoTrabajador);

                if (resultado)
                {
                    MessageBox.Show("Trabajador agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListarTrabajadores(); // Refrescar grid

                    // Limpiar campos
                    txtcodtrabajador.Clear();
                    cbpersona.SelectedIndex = -1;
                    chkestado.Checked = false;
                    
                    txtfecha.Clear();
                }
                else
                {
                    MessageBox.Show("Error al agregar trabajador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ListarTrabajadores()
        {
            try
            {
                List<DB_TRABAJADOR> lista = objTrabajador.Listar();

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = lista;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos" + ex.Message);
            }
        }





    }
}
