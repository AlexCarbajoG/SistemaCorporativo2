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
    public partial class UbicaionGeogrfica : Form
    {

        N_UbicacionGeografica objNegocioUbigeo = new N_UbicacionGeografica();



        public UbicaionGeogrfica()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void txtpais_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdespais_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdpto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdesdpto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtciudad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdesciu_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbarrio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdesbarrio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtidioma_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcontinente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtregion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtlatitud_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtlongitud_TextChanged(object sender, EventArgs e)
        {

        }

        private void UbicaionGeogrfica_Load(object sender, EventArgs e)
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

                N_RegionFisica objRegion = new N_RegionFisica();
                List<DB_REG_FIS> regiones = objRegion.Listar();
                cbregion.DataSource = regiones;
                cbregion.DisplayMember = "DES_REG";
                cbregion.ValueMember = "COD_REG";
                cbregion.SelectedIndex = -1;

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

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtfecha_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlistar_Click(object sender, EventArgs e)
        {
            try
            {
                // Desvincular el DataGridView de cualquier DataSource previo
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear(); // Limpiar filas anteriores

                // Obtener lista desde la capa de negocio
                
                List<DB_UBI_GEO> lista = objNegocioUbigeo.Listar();

                foreach (var item  in lista)
                {
                    dataGridView1.Rows.Add(item.COD_PAIS,
                                            item.DES_PAIS,
                                            item.COD_DPTO,
                                            item.DES_DPTO,
                                            item.COD_CIU,
                                            item.DES_CIU,
                                            item.COD_BARR,
                                            item.DES_BARR,
                                            item.CAR_IDIOMA,
                                            item.DES_CON,
                                            item.COD_REG,
                                            item.UBI_LATITUD,
                                            item.UBI_LONGITUD,
                                            item.COD_USER,
                                            item.FEC_ABM);
                                            }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos de Ubigeo: " + ex.Message);
            }

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaActual = DateTime.Now;
                txtfecha.Text = fechaActual.ToString("yyyy-MM-dd HH:mm:ss");

                if (cbusuario.SelectedValue == null)
                {
                    MessageBox.Show("Seleccione un usuario válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string codUsuario = cbusuario.SelectedValue.ToString();


                DB_UBI_GEO nuevaUbicacion = new DB_UBI_GEO()
                {
                    COD_PAIS = txtpais.Text.Trim(),
                    DES_PAIS = txtdespais.Text.Trim(),
                    COD_DPTO = Convert.ToInt16(txtdpto.Text.Trim()),
                    DES_DPTO = txtdesdpto.Text.Trim(),
                    COD_CIU = Convert.ToInt16(txtciudad.Text.Trim()),
                    DES_CIU = txtdesciu.Text.Trim(),
                    COD_BARR = Convert.ToInt16(txtbarrio.Text.Trim()),
                    DES_BARR = txtdesbarrio.Text.Trim(),
                    CAR_IDIOMA = txtidioma.Text.Trim(),
                    DES_CON = txtcontinente.Text.Trim(),
                    COD_REG = Convert.ToInt16(cbregion.SelectedValue),
                    UBI_LATITUD = txtlatitud.Text.Trim(),
                    UBI_LONGITUD = txtlongitud.Text.Trim(),
                    COD_USER = codUsuario,
                    FEC_ABM = fechaActual
                };

                N_UbicacionGeografica objNegocio = new N_UbicacionGeografica();
                bool resultado = objNegocio.Insertar(nuevaUbicacion);

                if (resultado)
                {
                    MessageBox.Show("Ubicación agregada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ListarUbiGeo();// Método que actualiza el DataGridView

                    // Limpiar campos del formulario
                    txtpais.Clear();
                    txtdespais.Clear();
                    txtdpto.Clear();
                    txtdesdpto.Clear();
                    txtciudad.Clear();
                    txtdesciu.Clear();
                    txtbarrio.Clear();
                    txtdesbarrio.Clear();
                    txtidioma.Clear();
                    txtcontinente.Clear();
                    cbregion.Items.Clear();
                    txtlatitud.Clear();
                    txtlongitud.Clear();
                    txtfecha.Clear();
                    cbusuario.Items.Clear();
                }
                else
                {
                    MessageBox.Show("Error al agregar la ubicación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ListarUbiGeo()
        {
            try
            {
                List<DB_UBI_GEO> lista = objNegocioUbigeo.Listar();

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

        private void btnguardaractualizacion_Click(object sender, EventArgs e)
        {

        }

        private void eliminar_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbusuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbregion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
