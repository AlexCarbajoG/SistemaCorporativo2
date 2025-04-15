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
    public partial class Proveedores : Form
    {

        N_Proveedor objProveedor = new N_Proveedor();

        public Proveedores()
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
                N_Proveedor objNegocio = new N_Proveedor();
                List<DB_PROVEEDOR> lista = objNegocio.Listar();

                // Llenar el DataGridView
                foreach (var item in lista)
                {
                    dataGridView1.Rows.Add(
                        item.COD_PRV,
                        item.COD_PER,
                        item.FLG_INH_MOV,
                        item.VAL_TIE_ATC,
                        item.VAL_CMN_UMO,
                        item.COD_USER,
                        item.FEC_ABM
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar proveedores: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            try
            {
                // Cargar combo de usuarios
                N_Usuario objUsuario = new N_Usuario();
                List<DB_USUARIO> usuarios = objUsuario.Listar();
                cbusuario.DataSource = usuarios;
                cbusuario.DisplayMember = "DES_USER";
                cbusuario.ValueMember = "COD_USER";
                cbusuario.SelectedIndex = -1;

                // Cargar combo de personas
                N_Persona objPersona = new N_Persona();
                List<DB_PERSONA> personas = objPersona.Listar();
                cbpersona.DataSource = personas;
                cbpersona.DisplayMember = "DES_PER";
                cbpersona.ValueMember = "COD_PER";
                cbpersona.SelectedIndex = -1;

                // Configurar campo de fecha actual
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
                // Validar selección de persona y usuario
                if (cbpersona.SelectedValue == null || cbusuario.SelectedValue == null)
                {
                    MessageBox.Show("Seleccione una persona y un usuario válidos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtener fecha actual
                DateTime fechaActual = DateTime.Now;
                txtfecha.Text = fechaActual.ToString("yyyy-MM-dd HH:mm:ss");

                // Crear objeto proveedor
                DB_PROVEEDOR proveedor = new DB_PROVEEDOR()
                {
                    COD_PRV = txtproveedor.Text.Trim(),
                    COD_PER = cbpersona.SelectedValue.ToString(),
                    FLG_INH_MOV = chkestado.Checked,
                    VAL_TIE_ATC = Convert.ToInt16(txtcompra.Text.Trim()),
                    VAL_CMN_UMO = Convert.ToDecimal(txtcompraminima.Text.Trim()),
                    COD_USER = cbusuario.SelectedValue.ToString(),
                    FEC_ABM = fechaActual
                };

                // Insertar en la base de datos
                N_Proveedor negocio = new N_Proveedor();
                bool resultado = negocio.Insertar(proveedor);

                if (resultado)
                {
                    MessageBox.Show("Proveedor registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Actualizar lista
                    listarProveedores();

                    // Limpiar campos
                    txtproveedor.Clear();
                    cbpersona.SelectedIndex = -1;
                    chkestado.Checked = false;
                    txtcompra.Clear();
                    txtcompraminima.Clear();
                    cbusuario.SelectedIndex = -1;
                    txtfecha.Clear();
                }
                else
                {
                    MessageBox.Show("Error al registrar proveedor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listarProveedores()
        {
            try
            {
                List<DB_PROVEEDOR> list = objProveedor.Listar();

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos " + ex.Message);
            }

        }

    }
}
