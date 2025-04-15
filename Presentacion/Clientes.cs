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
    public partial class Clientes : Form
    {

        N_Cliente objCliente = new N_Cliente();

        public Clientes()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Limpiar el DataGridView
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();

                // Obtener datos de cliente
                N_Cliente negocio = new N_Cliente();
                List<DB_CLIENTE> lista = negocio.Listar();

                foreach (var item in lista)
                {
                    dataGridView1.Rows.Add(
                        item.COD_CLI,
                        item.COD_PER,
                        item.COD_GRP_EMP,
                        item.COD_VEN,
                        item.COD_SEG,
                        item.COD_SSEG,
                        item.FLG_INH_MOV,
                        item.FEC_ABM
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar clientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            try
            {
                // Cargar personas
                N_Persona nPersona = new N_Persona();
                cbcodpersona.DataSource = nPersona.Listar();
                cbcodpersona.DisplayMember = "COD_PER";
                cbcodpersona.ValueMember = "COD_PER";
                cbcodpersona.SelectedIndex = -1;

                // Cargar vendedores
                N_Vendedor nVendedor = new N_Vendedor();
                cbvendedor.DataSource = nVendedor.Listar();
                cbvendedor.DisplayMember = "COD_VEN";
                cbvendedor.ValueMember = "COD_VEN";
                cbvendedor.SelectedIndex = -1;

                // Cargar segmentos comerciales
                N_SegmentosComerciales nSegmento = new N_SegmentosComerciales();
                cbsegmento.DataSource = nSegmento.Listar();
                cbsegmento.DisplayMember = "COD_SEG"; // o usa una combinación si necesitas mostrar algo más
                cbsegmento.ValueMember = "COD_SEG";
                cbsegmento.SelectedIndex = -1;

                sbsubsegmento.DataSource = nSegmento.Listar();
                sbsubsegmento.DisplayMember = "COD_SSEG";
                sbsubsegmento.ValueMember = "COD_SSEG";
                sbsubsegmento.SelectedIndex = -1;

                // Fecha actual
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Validaciones básicas
                if (cbcodpersona.SelectedValue == null || cbvendedor.SelectedValue == null ||
                    cbsegmento.SelectedValue == null || sbsubsegmento.SelectedValue == null)
                {
                    MessageBox.Show("Complete todos los campos obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtener la fecha actual
                DateTime fechaActual = DateTime.Now;
                txtfecha.Text = fechaActual.ToString("yyyy-MM-dd HH:mm:ss");

                // Crear el objeto cliente
                DB_CLIENTE nuevoCliente = new DB_CLIENTE()
                {
                    COD_CLI = txtcodcliente.Text.Trim(),
                    COD_PER = cbcodpersona.SelectedValue.ToString(),
                    COD_GRP_EMP = txtempresa.Text.Trim(), // Este campo es opcional (nullable)
                    COD_VEN = cbvendedor.SelectedValue.ToString(),
                    COD_SEG = cbsegmento.SelectedValue.ToString(),
                    COD_SSEG = sbsubsegmento.SelectedValue.ToString(),
                    FLG_INH_MOV = chkestado.Checked,
                    FEC_ABM = fechaActual
                };

                // Insertar en base de datos
                N_Cliente nCliente = new N_Cliente();
                bool resultado = nCliente.Insertar(nuevoCliente);

                if (resultado)
                {
                    MessageBox.Show("Cliente agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listarClientes(); // Refrescar lista

                    // Limpiar campos
                    txtcodcliente.Clear();
                    cbcodpersona.SelectedIndex = -1;
                    cbvendedor.SelectedIndex = -1;
                    cbsegmento.SelectedIndex = -1;
                    sbsubsegmento.SelectedIndex = -1;
                    txtempresa.Clear();
                    chkestado.Checked = false;
                    txtfecha.Clear();
                }
                else
                {
                    MessageBox.Show("Error al agregar cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listarClientes()
        {
            try
            {
                List<DB_CLIENTE> list = objCliente.Listar();

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos" + ex.Message);
            }

        }




    }
}
