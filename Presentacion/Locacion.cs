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
    public partial class Locacion : Form
    {

        N_Locacion objLocacion = new N_Locacion();

        public Locacion()
        {
            InitializeComponent();
        }

        private void btnlistar_Click(object sender, EventArgs e)
        {
            try
            {
                // Desvincular el DataGridView de cualquier DataSource previo
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear(); // Limpiar filas anteriores

                // Obtener lista desde la capa de negocio
                N_Locacion objNegocioLocacion = new N_Locacion();
                List<DB_LOCACION> lista = objNegocioLocacion.Listar();

                foreach (var item in lista)
                {
                    dataGridView1.Rows.Add(
                        item.FLG_DEP_CEN,
                        item.COD_LOC,
                        item.DES_LOC,
                        item.FEC_CREA,
                        item.DES_NOM_ENC,
                        item.FLG_LOC_VIR,
                        item.COD_PAIS,
                        item.COD_DPTO,
                        item.COD_CIU,
                        item.COD_BARR,
                        item.DES_DIR_LOC,
                        item.VAL_ZLOC_ALT,
                        item.VAL_ZLOC_SUP,
                        item.VAL_COB_ESP,
                        item.COD_USER,
                        item.FEC_ABM
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos de locación: " + ex.Message);
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaActual = DateTime.Now;
                txtfecha.Text = fechaActual.ToString("yyyy-MM-dd HH:mm:ss");

                if (cbusuario.SelectedValue == null || cbpais.SelectedValue == null || cbdepartamento.SelectedValue == null || cbciudad.SelectedValue == null || cbbarrio.SelectedValue == null)
                {
                    MessageBox.Show("Verifique que haya seleccionado usuario, país, departamento, ciudad y barrio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DB_LOCACION nuevaLocacion = new DB_LOCACION()
                {
                    FLG_DEP_CEN = chkDepCentral.Checked,
                    COD_LOC = txtcodigolocacion.Text.Trim(),
                    DES_LOC = txtdeslocal.Text.Trim(),
                    FEC_CREA = Convert.ToDateTime(txtfechacreacion.Text.Trim()),
                    DES_NOM_ENC = txtencargado.Text.Trim(),
                    FLG_LOC_VIR = chkLocVirtual.Checked,
                    COD_PAIS = cbpais.SelectedValue.ToString(),
                    COD_DPTO = Convert.ToInt16(cbdepartamento.SelectedValue),
                    COD_CIU = Convert.ToInt16(cbciudad.SelectedValue),
                    COD_BARR = Convert.ToInt16(cbbarrio.SelectedValue),
                    DES_DIR_LOC = txtdireccion.Text.Trim(),
                    VAL_ZLOC_ALT = Convert.ToDecimal(txtaltura.Text.Trim()),
                    VAL_ZLOC_SUP = Convert.ToDecimal(txtsuperficie.Text.Trim()),
                    VAL_COB_ESP = Convert.ToInt16(txtcobertura.Text.Trim()),
                    COD_USER = cbusuario.SelectedValue.ToString(),
                    FEC_ABM = fechaActual
                };

                N_Locacion objNegocio = new N_Locacion();
                bool resultado = objNegocio.Insertar(nuevaLocacion);

                if (resultado)
                {
                    MessageBox.Show("Locación agregada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ListarLocaciones(); // Actualiza el DataGridView

                    // Limpiar campos
                    txtcodigolocacion.Clear();
                    txtdeslocal.Clear();
                    txtfechacreacion.Clear();
                    txtencargado.Clear();
                    cbpais.SelectedIndex = -1;
                    cbdepartamento.SelectedIndex = -1;
                    cbciudad.SelectedIndex = -1;
                    cbbarrio.SelectedIndex = -1;
                    txtdireccion.Clear();
                    txtaltura.Clear();
                    txtsuperficie.Clear();
                    txtcobertura.Clear();
                    cbusuario.SelectedIndex = -1;
                    txtfecha.Clear();
                    chkDepCentral.Checked = false;
                    chkLocVirtual.Checked = false;
                }
                else
                {
                    MessageBox.Show("Error al agregar la locación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ListarLocaciones()
        {
            try
            {
                List<DB_LOCACION> lista = objLocacion.Listar();

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = lista;
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {

        }

        private void btnagregaractualizacion_Click(object sender, EventArgs e)
        {

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {

        }

        private void txtlocacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcodigolocacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void Locacion_Load(object sender, EventArgs e)
        {
            try
            {
                // Obtener el primer usuario (puedes adaptar esto para usar el usuario logueado real si lo tienes)
                N_Usuario objUsuario = new N_Usuario();
                List<DB_USUARIO> usuarios = objUsuario.Listar();

                cbusuario.DataSource = usuarios;
                cbusuario.DisplayMember = "DES_USER";
                cbusuario.ValueMember = "COD_USER";
                cbusuario.SelectedIndex = -1;

                N_UbicacionGeografica objUbigeo = new N_UbicacionGeografica();
                List<DB_UBI_GEO> ubicacionGeo = objUbigeo.Listar();
                cbpais.DataSource = ubicacionGeo;
                cbpais.DisplayMember = "DES_PAIS";
                cbpais.ValueMember = "COD_PAIS";
                cbpais.SelectedIndex = -1;

                N_UbicacionGeografica objUbigeo1 = new N_UbicacionGeografica();
                List<DB_UBI_GEO> ubicacionDpto = objUbigeo1.Listar();
                cbdepartamento.DataSource = ubicacionGeo;
                cbdepartamento.DisplayMember = "DES_DPTO";
                cbdepartamento.ValueMember = "COD_DPTO";
                cbdepartamento.SelectedIndex = -1;

                N_UbicacionGeografica objUbigeo2 = new N_UbicacionGeografica();
                List<DB_UBI_GEO> ubicacionCiu = objUbigeo2.Listar();
                cbciudad.DataSource = ubicacionGeo;
                cbciudad.DisplayMember = "DES_CIU";
                cbciudad.ValueMember = "COD_CIU";
                cbciudad.SelectedIndex = -1;

                N_UbicacionGeografica objUbigeo3 = new N_UbicacionGeografica();
                List<DB_UBI_GEO> ubicacionBarr = objUbigeo3.Listar();
                cbbarrio.DataSource = ubicacionGeo;
                cbbarrio.DisplayMember = "DES_BARR";
                cbbarrio.ValueMember = "COD_BARR";
                cbbarrio.SelectedIndex = -1;

                // Establecer la fecha actual automáticamente
                txtfecha.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                txtfecha.ReadOnly = true;
                txtfecha.BackColor = SystemColors.Control;
                txtfecha.TabStop = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el usuario: " + ex.Message);
            }
        }
    }
}
