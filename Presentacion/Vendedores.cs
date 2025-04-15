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
    public partial class Vendedores : Form
    {

        N_Vendedor objVendedor = new N_Vendedor();

        public Vendedores()
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
                N_Vendedor objNegocioVendedor = new N_Vendedor();
                List<DB_VENDEDOR> lista = objNegocioVendedor.Listar();

                // Agregar filas al DataGridView
                foreach (var item in lista)
                {
                    dataGridView1.Rows.Add(
                        item.COD_VEN,
                        item.COD_TRA,
                        item.FLG_INH_MOV,
                        item.FEC_ABM
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar vendedores: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Vendedores_Load(object sender, EventArgs e)
        {
            try
            {
                // 1. Cargar trabajadores (COD_TRA)
                N_Trabajador nTrabajador = new N_Trabajador();
                List<DB_TRABAJADOR> trabajadores = nTrabajador.Listar();

                cbtrabajador.DataSource = trabajadores;
                cbtrabajador.DisplayMember = "COD_TRA";
                cbtrabajador.ValueMember = "COD_TRA";
                cbtrabajador.SelectedIndex = -1;

                // 2. Fecha actual
                txtfecha.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                txtfecha.ReadOnly = true;
                txtfecha.BackColor = SystemColors.Control;
                txtfecha.TabStop = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar formulario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar selección de trabajador
                if (cbtrabajador.SelectedValue == null)
                {
                    MessageBox.Show("Seleccione un trabajador válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtener la fecha actual
                DateTime fechaActual = DateTime.Now;
                txtfecha.Text = fechaActual.ToString("yyyy-MM-dd HH:mm:ss");

                // Crear objeto vendedor
                DB_VENDEDOR nuevoVendedor = new DB_VENDEDOR()
                {
                    COD_VEN = txtcodvendedor.Text.Trim(),
                    COD_TRA = cbtrabajador.SelectedValue.ToString(),
                    FLG_INH_MOV = chkestado.Checked,
                    FEC_ABM = fechaActual
                };

                // Insertar
                N_Vendedor objNegocio = new N_Vendedor();
                bool resultado = objNegocio.Insertar(nuevoVendedor);

                if (resultado)
                {
                    MessageBox.Show("Vendedor agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListarVendedores(); // Método para refrescar el DataGridView

                    // Limpiar campos
                    txtcodvendedor.Clear();
                    cbtrabajador.SelectedIndex = -1;
                    chkestado.Checked = false;
                    txtfecha.Clear();
                }
                else
                {
                    MessageBox.Show("Error al agregar el vendedor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarVendedores()
        {
            try
            {
                List<DB_VENDEDOR> lista = objVendedor.Listar();

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = lista;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la cargad e datos " + ex.Message);
            }
        }


    }

}
