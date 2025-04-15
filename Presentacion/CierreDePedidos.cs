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
    public partial class CierreDePedidos : Form
    {
        public CierreDePedidos()
        {
            InitializeComponent();
        }

        private void CierreDePedidos_Load(object sender, EventArgs e)
        {
            try
            {
                // Artículos
                N_Articulo nArticulo = new N_Articulo();
                cbarticulo.DataSource = nArticulo.Listar();
                cbarticulo.DisplayMember = "DES_ART";
                cbarticulo.ValueMember = "COD_ART";
                cbarticulo.SelectedIndex = -1;

                // Usuarios
                N_Usuario nUsuario = new N_Usuario();
                cbusuario.DataSource = nUsuario.Listar();
                cbusuario.DisplayMember = "DES_USER";
                cbusuario.ValueMember = "COD_USER";
                cbusuario.SelectedIndex = -1;

                // Pedidos (cabecera)
                N_PedidoCabecera nPedidoCab = new N_PedidoCabecera();
                cbpedido.DataSource = nPedidoCab.Listar();
                cbpedido.DisplayMember = "DOC_NRO_PED";
                cbpedido.ValueMember = "DOC_NRO_PED";
                cbpedido.SelectedIndex = -1;

               
                // Establecer la fecha actual automáticamente
                txtfecha.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                txtfecha.ReadOnly = true;
                txtfecha.BackColor = SystemColors.Control;
                txtfecha.TabStop = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar combos: " + ex.Message);
            }
        }

        private void btnlistar_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();

                N_PedidoDetalle objNegocio = new N_PedidoDetalle();
                List<HB_PED_DET> lista = objNegocio.Listar();

                foreach (var item in lista)
                {
                    dataGridView1.Rows.Add(
                        item.DOC_NRO_PED,
                        item.NRO_LINEA,
                        item.COD_ART,
                        item.FEC_ENT_MER,
                        item.VAL_VTA_UND,
                        item.VAL_BONV_UND,
                        item.VAL_MON_UMO,
                        item.VAL_CVT_UMO,
                        item.VAL_IVA_UMO,
                        item.VAL_ENT_UND,
                        item.VAL_SAL_UND,
                        item.COD_USER,
                        item.FEC_ABM
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar detalles de pedido: " + ex.Message);
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            try
            {
                HB_PED_DET nuevo = new HB_PED_DET()
                {
                    DOC_NRO_PED = cbpedido.SelectedValue.ToString(),
                    NRO_LINEA = short.Parse(txtlinea.Text),
                    COD_ART = cbarticulo.SelectedValue.ToString(),
                    FEC_ENT_MER = DateTime.Parse(txtfechaentrega.Text),
                    VAL_VTA_UND = decimal.Parse(txtvntunidad.Text),
                    VAL_BONV_UND = decimal.Parse(txtbonificacxion.Text),
                    VAL_MON_UMO = decimal.Parse(txtmonto.Text),
                    VAL_CVT_UMO = decimal.Parse(txtcosto.Text),
                    VAL_IVA_UMO = decimal.Parse(txtiva.Text),
                    VAL_ENT_UND = decimal.Parse(txtentradaunidades.Text),
                    VAL_SAL_UND = decimal.Parse(txtsalidasunidades.Text),
                    COD_USER = cbusuario.SelectedValue.ToString(),
                    FEC_ABM = DateTime.Now
                };

                N_PedidoDetalle negocio = new N_PedidoDetalle();
                bool resultado = negocio.Insertar(nuevo);

                if (resultado)
                {
                    MessageBox.Show("Detalle agregado correctamente");
                    btnlistar_Click(null, null);

                    // Limpiar campos
                    txtlinea.Clear();
                    cbarticulo.SelectedIndex = -1;
                    cbpedido.SelectedIndex = -1;
                    txtfechaentrega.Clear();
                    txtvntunidad.Clear();
                    txtbonificacxion.Clear();
                    txtmonto.Clear();
                    txtcosto.Clear();
                    txtiva.Clear();
                    txtentradaunidades.Clear();
                    txtsalidasunidades.Clear();
                    cbusuario.SelectedIndex = -1;
                    txtfecha.Clear();
                }
                else
                {
                    MessageBox.Show("Error al agregar el detalle");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
