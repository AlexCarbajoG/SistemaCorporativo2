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
    public partial class Fabricantes : Form
    {
        public Fabricantes()
        {
            InitializeComponent();
        }

        private void btnlistar_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();

                N_Fabricante negocio = new N_Fabricante();
                List<DB_FABRICANTE> lista = negocio.Listar();

                foreach (var item in lista)
                {
                    dataGridView1.Rows.Add(item.COD_FABRICANTE, item.COD_PER, item.FEC_ABM);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar fabricantes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Fabricantes_Load(object sender, EventArgs e)
        {
            try
            {
                N_Persona nPersona = new N_Persona();
                List<DB_PERSONA> personas = nPersona.Listar();
                cbpersona.DataSource = personas;
                cbpersona.DisplayMember = "DES_PER";
                cbpersona.ValueMember = "COD_PER";
                cbpersona.SelectedIndex = -1;

                txtfecha.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                txtfecha.ReadOnly = true;
                txtfecha.BackColor = SystemColors.Control;
                txtfecha.TabStop = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbpersona.SelectedValue == null)
                {
                    MessageBox.Show("Seleccione una persona válida.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DateTime fechaActual = DateTime.Now;
                txtfecha.Text = fechaActual.ToString("yyyy-MM-dd HH:mm:ss");

                DB_FABRICANTE nuevo = new DB_FABRICANTE()
                {
                    COD_FABRICANTE = txtfabvricante.Text.Trim(),
                    COD_PER = cbpersona.SelectedValue.ToString(),
                    FEC_ABM = fechaActual
                };

                N_Fabricante negocio = new N_Fabricante();
                bool resultado = negocio.Insertar(nuevo);

                if (resultado)
                {
                    MessageBox.Show("Fabricante registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnlistar_Click(null, null);

                    txtfabvricante.Clear();
                    cbpersona.SelectedIndex = -1;
                    txtfecha.Clear();
                }
                else
                {
                    MessageBox.Show("Error al registrar el fabricante.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
