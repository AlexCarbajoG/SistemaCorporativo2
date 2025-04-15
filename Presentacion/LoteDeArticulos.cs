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
    public partial class LoteDeArticulos : Form
    {
        public LoteDeArticulos()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnlistar_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Clear();
                dataGridView1.DataSource = null;

                N_Articulo negocio = new N_Articulo();
                List<DB_ARTICULO> lista = negocio.Listar(); // Asegúrate de implementar este método si no lo tienes aún.

                foreach (var art in lista)
                {
                    dataGridView1.Rows.Add(
                        art.COD_ART, art.COD_UNICO, art.COD_PADRE,
                        art.DES_ART, art.COD_FABRICANTE, art.CAR_UND_VTAP,
                        art.CAR_UND_VTAS, art.CAR_UND_VTAS,art.VAL_NCOMP_VTAS,
                        art.CAR_UND_COMPACK, art.COD_CAT, art.COD_LIN,
                        art.COD_MAR, art.COD_PRV, art.VAL_TAS_IVA,
                        art.VAL_PUM_UMO, art.VAL_CUN_UMO, art.VAL_SSG_ESP,
                        art.VAL_STK_EXP, art.VAL_VTA_MIN, art.FLG_ORIGEN,
                        art.FLG_VTA_LIBRE, art.FLG_ART_CTR, art.FLG_ART_FRA,
                        art.FLG_CAD_FRIO, art.FLG_ART_INA, art.FLG_INH_VTA,
                        art.FLG_INH_VTA, art.FLG_INH_COM, art.CAR_ADICIONAL,
                        art.COD_USER, art.FEC_ABM
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar artículos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoteDeArticulos_Load(object sender, EventArgs e)
        {
            try
            {
                // Cargar usuarios
                N_Usuario nUser = new N_Usuario();
                cbusuario.DataSource = nUser.Listar();
                cbusuario.DisplayMember = "DES_USER";
                cbusuario.ValueMember = "COD_USER";
                cbusuario.SelectedIndex = -1;

                // Fabricantes
                N_Fabricante nFab = new N_Fabricante();
                cbfabricante.DataSource = nFab.Listar();
                cbfabricante.DisplayMember = "COD_FABRICANTE";
                cbfabricante.ValueMember = "COD_FABRICANTE";
                cbfabricante.SelectedIndex = -1;

                // Categoría y línea
                N_FamiliaArticulo nFam = new N_FamiliaArticulo();
                cbcodcat.DataSource = nFam.Listar();
                cbcodcat.DisplayMember = "DES_CAT";
                cbcodcat.ValueMember = "COD_CAT";
                cbcodcat.SelectedIndex = -1;

                cbcodlin.DataSource = nFam.Listar();
                cbcodlin.DisplayMember = "DES_LIN";
                cbcodlin.ValueMember = "COD_LIN";
                cbcodlin.SelectedIndex = -1;

                // Marca
                N_MarcaArticulo nMarca = new N_MarcaArticulo();
                cbcodmar.DataSource = nMarca.Listar();
                cbcodmar.DisplayMember = "DES_MAR";
                cbcodmar.ValueMember = "COD_MAR";
                cbcodmar.SelectedIndex = -1;

                // Proveedor
                N_Proveedor nProv = new N_Proveedor();
                cbcodprv.DataSource = nProv.Listar();
                cbcodprv.DisplayMember = "COD_PRV";
                cbcodprv.ValueMember = "COD_PRV";
                cbcodprv.SelectedIndex = -1;

                // Fecha
                // Cargar fecha actual en el TextBox y bloquear edición
                txtfecha.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                txtfecha.ReadOnly = true;
                txtfecha.BackColor = SystemColors.Control;
                txtfecha.TabStop = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            try
            {
                

                DB_ARTICULO nuevo = new DB_ARTICULO()
                {
                    COD_ART = txtcodart.Text.Trim(),
                    COD_UNICO = txtcodunico.Text.Trim(),
                    COD_PADRE = txtcodpadre.Text.Trim(),
                    DES_ART = txtdesart.Text.Trim(),
                    COD_FABRICANTE = cbfabricante.SelectedValue.ToString(),
                    CAR_UND_VTAP = txtvtap.Text.Trim(),
                    CAR_UND_VTAS = txtncomp.Text.Trim(),

                    VAL_NCOMP_VTAS = short.TryParse(txtvtas.Text, out short valVtas) ? valVtas : (short)0,

                    CAR_UND_COMPACK = decimal.TryParse(txtundcompack.Text, out decimal compack) ? compack : 0,

                    COD_CAT = cbcodcat.SelectedValue.ToString(),
                    COD_LIN = cbcodlin.SelectedValue.ToString(),
                    COD_MAR = cbcodmar.SelectedValue.ToString(),
                    COD_PRV = cbcodprv.SelectedValue.ToString(),

                    VAL_TAS_IVA = decimal.TryParse(txtiva.Text, out decimal iva) ? iva : 0,

                    
                    VAL_PUM_UMO = decimal.TryParse(txtpum.Text, out decimal pum) ? pum : 0,
                    VAL_CUN_UMO = decimal.TryParse(txtcun.Text, out decimal cun) ? cun : 0,
                    VAL_SSG_ESP = decimal.TryParse(txtssg.Text, out decimal ssg) ? ssg : 0,
                    VAL_STK_EXP = decimal.TryParse(txtstk.Text, out decimal stk) ? stk : 0,
                    VAL_VTA_MIN = decimal.TryParse(txtvta.Text, out decimal vtaMin) ? vtaMin : 0,

                    FLG_ORIGEN = checkBox1.Checked,
                    FLG_VTA_LIBRE = checkBox2.Checked,
                    FLG_ART_CTR = checkBox3.Checked,
                    FLG_ART_FRA = checkBox4.Checked,
                    FLG_CAD_FRIO = checkBox5.Checked,
                    FLG_ART_INA = checkBox6.Checked,
                    FLG_INH_VTA = checkBox7.Checked,
                    FLG_INH_COM = checkBox8.Checked,
                    CAR_ADICIONAL = txtadicional.Text.Trim(),
                    COD_USER = cbusuario.SelectedValue.ToString(),
                    FEC_ABM = DateTime.Now
                };

                N_Articulo negocio = new N_Articulo();
                bool resultado = negocio.Insertar(nuevo);

                if (resultado)
                {
                    MessageBox.Show("Artículo registrado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnlistar_Click(null, null);

                    // Limpiar campos de texto
                    txtcodart.Clear();
                    txtcodunico.Clear();
                    txtcodpadre.Clear();
                    txtdesart.Clear();
                    txtvtap.Clear();
                    txtncomp.Clear();
                    txtvtas.Clear();
                    txtundcompack.Clear();
                    txtiva.Clear();
                    txtpum.Clear();
                    txtcun.Clear();
                    txtssg.Clear();
                    txtstk.Clear();
                    txtvta.Clear();
                    txtadicional.Clear();

                    // Reiniciar ComboBox
                    cbfabricante.SelectedIndex = -1;
                    cbcodcat.SelectedIndex = -1;
                    cbcodlin.SelectedIndex = -1;
                    cbcodmar.SelectedIndex = -1;
                    cbcodprv.SelectedIndex = -1;
                    cbusuario.SelectedIndex = -1;

                    // Desmarcar CheckBoxes
                    checkBox1.Checked = false; // FLG_ORIGEN
                    checkBox2.Checked = false; // FLG_VTA_LIBRE
                    checkBox3.Checked = false; // FLG_ART_CTR
                    checkBox4.Checked = false; // FLG_ART_FRA
                    checkBox5.Checked = false; // FLG_CAD_FRIO
                    checkBox6.Checked = false; // FLG_ART_INA
                    checkBox7.Checked = false; // FLG_INH_VTA
                    checkBox8.Checked = false; // FLG_INH_COM

                    // Limpiar fecha
                    txtfecha.Clear();

                }
                else
                {
                    MessageBox.Show("Error al registrar el artículo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
