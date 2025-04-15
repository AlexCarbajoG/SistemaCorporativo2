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
    public partial class Persona : Form
    {

        N_Persona objPersonas = new N_Persona();

        public Persona()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
                    }

        private void btnlistar_Click(object sender, EventArgs e)
        {
            try
            {
                // Limpiar DataGridView
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();

                // Obtener lista desde la capa de negocio
                N_Persona objNegocioPersona = new N_Persona();
                List<DB_PERSONA> lista = objNegocioPersona.Listar();

                // Llenar el DataGridView
                foreach (var item in lista)
                {
                    dataGridView1.Rows.Add(
                        item.COD_PER,
                        item.DES_PER,
                        item.FLG_PER_JUR,
                        item.FLG_SEX_PER,
                        item.COD_PAIS,
                        item.COD_DPTO,
                        item.COD_CIU,
                        item.COD_BARR,
                        item.DES_DIR,
                        item.NRO_RUC,
                        item.EMAIL_EMP,
                        item.EMP_TELF1,
                        item.EMP_TELF2,
                        item.WWW_URL,
                        item.COD_USER,
                        item.FEC_ABM
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar personas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Persona_Load(object sender, EventArgs e)
        {
            try
            {
                // 1. Cargar usuarios
                N_Usuario nUsuario = new N_Usuario();
                List<DB_USUARIO> usuarios = nUsuario.Listar();
                cbusuario.DataSource = usuarios;
                cbusuario.DisplayMember = "DES_USER";
                cbusuario.ValueMember = "COD_USER";
                cbusuario.SelectedIndex = -1;

                // 2. Cargar datos de ubicación desde DB_UBI_GEO (suponiendo que hay múltiples registros)
                N_UbicacionGeografica nUbigeo = new N_UbicacionGeografica();
                List<DB_UBI_GEO> ubigeos = nUbigeo.Listar();

                cbpais.DataSource = ubigeos;
                cbpais.DisplayMember = "DES_PAIS";
                cbpais.ValueMember = "COD_PAIS";
                cbpais.SelectedIndex = -1;

                cbdepartamento.DataSource = ubigeos;
                cbdepartamento.DisplayMember = "DES_DPTO";
                cbdepartamento.ValueMember = "COD_DPTO";
                cbdepartamento.SelectedIndex = -1;

                cbciudad.DataSource = ubigeos;
                cbciudad.DisplayMember = "DES_CIU";
                cbciudad.ValueMember = "COD_CIU";
                cbciudad.SelectedIndex = -1;

                cbbarrio.DataSource = ubigeos;
                cbbarrio.DisplayMember = "DES_BARR";
                cbbarrio.ValueMember = "COD_BARR";
                cbbarrio.SelectedIndex = -1;

                // 3. Fecha automática
                txtfecha.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                txtfecha.ReadOnly = true;
                txtfecha.BackColor = SystemColors.Control;
                txtfecha.TabStop = false;


                chklist.Items.Add("M"); // Masculino
                chklist.Items.Add("F"); // Femenino
                chklist.CheckOnClick = true; // Permitir clic directo
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
                // Validar usuario
                if (cbusuario.SelectedValue == null)
                {
                    MessageBox.Show("Seleccione un usuario válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar datos de ubicación
                if (cbpais.SelectedValue == null || cbdepartamento.SelectedValue == null || cbciudad.SelectedValue == null || cbbarrio.SelectedValue == null)
                {
                    MessageBox.Show("Complete los campos de ubicación geográfica.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtener fecha actual
                DateTime fechaActual = DateTime.Now;
                txtfecha.Text = fechaActual.ToString("yyyy-MM-dd HH:mm:ss");

                // Crear objeto
                DB_PERSONA persona = new DB_PERSONA()
                {
                    COD_PER = txtcodigo.Text.Trim(),
                    DES_PER = txtnombre.Text.Trim(),
                    FLG_PER_JUR = chkjuridico.Checked,

                    FLG_SEX_PER = chklist.CheckedItems[0].ToString() == "M", // true = masculino, false = femenino (asumiendo radio buttons)
                    COD_PAIS = cbpais.SelectedValue.ToString(),
                    COD_DPTO = Convert.ToInt16(cbdepartamento.SelectedValue),
                    COD_CIU = Convert.ToInt16(cbciudad.SelectedValue),
                    COD_BARR = Convert.ToInt16(cbbarrio.SelectedValue),
                    DES_DIR = txtdireccion.Text.Trim(),
                    NRO_RUC = txtruc.Text.Trim(),
                    EMAIL_EMP = txtemail.Text.Trim(),
                    EMP_TELF1 = txttelf1.Text.Trim(),
                    EMP_TELF2 = txttelf2.Text.Trim(),
                    WWW_URL = txtweb.Text.Trim(),
                    COD_USER = cbusuario.SelectedValue.ToString(),
                    FEC_ABM = fechaActual


                };

                // Guardar en base de datos
                N_Persona nPersona = new N_Persona();
                bool resultado = nPersona.Insertar(persona);

                if (resultado)
                {
                    MessageBox.Show("Persona registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListarPersonas(); // Refresca el DataGridView

                    // Limpiar campos
                    txtcodigo.Clear();
                    txtnombre.Clear();
                    chkjuridico.Checked = false;
                    for (int i = 0; i < chklist.Items.Count; i++)
                    {
                        chklist.SetItemChecked(i, false);
                    }
                    cbpais.SelectedIndex = -1;
                    cbdepartamento.SelectedIndex = -1;
                    cbciudad.SelectedIndex = -1;
                    cbbarrio.SelectedIndex = -1;
                    txtdireccion.Clear();
                    txtruc.Clear();
                    txtemail.Clear();
                    txttelf1.Clear();
                    txttelf2.Clear();
                    txtweb.Clear();
                    cbusuario.SelectedIndex = -1;
                    txtfecha.Clear();
                }
                else
                {
                    MessageBox.Show("Error al registrar la persona.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarPersonas()
        {
            try
            {
                List<DB_PERSONA> lista = objPersonas.Listar();

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = lista;
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }

        }


        private void chkSexo_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int i = 0; i < chklist.Items.Count; i++)
            {
                if (i != e.Index)
                {
                    chklist.SetItemChecked(i, false);
                }
            }
        }








    }
}
