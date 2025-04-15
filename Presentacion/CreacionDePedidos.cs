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
    public partial class CreacionDePedidos : Form
    {
        public CreacionDePedidos()
        {
            InitializeComponent();
        }

        private void CreacionDePedidos_Load(object sender, EventArgs e)
        {
            try
            {
                // Cargar combo de Clientes
                N_Cliente nCliente = new N_Cliente();
                cbcliente.DataSource = nCliente.Listar();
                cbcliente.DisplayMember = "COD_CLI";
                cbcliente.ValueMember = "COD_CLI";
                cbcliente.SelectedIndex = -1;

                // Cargar combo de Vendedores
                N_Vendedor nVendedor = new N_Vendedor();
                cbvendedor.DataSource = nVendedor.Listar();
                cbvendedor.DisplayMember = "COD_VEN";
                cbvendedor.ValueMember = "COD_VEN";
                cbvendedor.SelectedIndex = -1;

                // Cargar combo de Locación
                N_Locacion nLoc = new N_Locacion();
                cblocacion.DataSource = nLoc.Listar();
                cblocacion.DisplayMember = "COD_LOC";
                cblocacion.ValueMember = "COD_LOC";
                cblocacion.SelectedIndex = -1;

                // Cargar combo de Usuario
                N_Usuario nUsuario = new N_Usuario();
                cbusuario.DataSource = nUsuario.Listar();
                cbusuario.DisplayMember = "COD_USER";
                cbusuario.ValueMember = "COD_USER";
                cbusuario.SelectedIndex = -1;

                // Fecha actual
                txtfecha.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                txtfecha.ReadOnly = true;
                txtfecha.BackColor = SystemColors.Control;
                txtfecha.TabStop = false;
                // Fecha de Creación
                txtfechacreacion.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                txtfechacreacion.ReadOnly = true;
                txtfechacreacion.BackColor = SystemColors.Control;
                txtfechacreacion.TabStop = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar: " + ex.Message);
            }
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
                N_PedidoCabecera objNegocio = new N_PedidoCabecera();
                List<HB_PED_CAB> lista = objNegocio.Listar();

                // Llenar el DataGridView con los datos
                foreach (var item in lista)
                {
                    dataGridView1.Rows.Add(
                        item.COD_LOC,
                        item.DOC_NRO_PED,
                        item.COD_CLI,
                        item.FEC_MOV.ToString("yyyy-MM-dd HH:mm:ss"),
                        item.COD_VEN,
                        item.NRO_RUC,
                        item.DOC_REF,
                        item.TXT_OBSERVACION,
                        item.FLG_EST_PED,
                        item.COD_USER,
                        item.FEC_ABM.ToString("yyyy-MM-dd HH:mm:ss")
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar los pedidos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbusuario.SelectedValue == null || cbcliente.SelectedValue == null || cbvendedor.SelectedValue == null || cblocacion.SelectedValue == null)
                {
                    MessageBox.Show("Complete todos los campos obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DateTime fechaActual = DateTime.Now;
                txtfecha.Text = fechaActual.ToString("yyyy-MM-dd HH:mm:ss");

                HB_PED_CAB pedido = new HB_PED_CAB()
                {
                    COD_LOC = cblocacion.SelectedValue.ToString(),
                    DOC_NRO_PED = txtpedido.Text.Trim(),
                    COD_CLI = cbcliente.SelectedValue.ToString(),
                    FEC_MOV = fechaActual,
                    COD_VEN = cbvendedor.SelectedValue.ToString(),
                    NRO_RUC = txtruc.Text.Trim(),
                    DOC_REF = txtdoccliente.Text.Trim(),
                    TXT_OBSERVACION = txtobservaciones.Text.Trim(),
                    FLG_EST_PED = chkestado.Checked,
                    COD_USER = cbusuario.SelectedValue.ToString(),
                    FEC_ABM = fechaActual
                };

                N_PedidoCabecera objNegocio = new N_PedidoCabecera();
                bool resultado = objNegocio.Insertar(pedido);

                if (resultado)
                {
                    MessageBox.Show("Pedido registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnlistar_Click(null, null);

                    // Limpiar campos
                    cblocacion.SelectedIndex = -1;
                    txtpedido.Clear();
                    cbcliente.SelectedIndex = -1;
                    txtfechacreacion.Clear();
                    cbvendedor.SelectedIndex = -1;
                    txtruc.Clear();
                    txtdoccliente.Clear();
                    txtobservaciones.Clear();
                    chkestado.Checked = false;
                    cbusuario.SelectedIndex = -1;
                    txtfecha.Clear();
                }
                else
                {
                    MessageBox.Show("Error al registrar el pedido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
