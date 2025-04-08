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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presentacion
{
    public partial class MenuSistema : Form
    {
        //CONECTAMOS CON LA CAPA NEGOCIO PAR ACCEDER A LOS METODOS
        private N_MenuSistema objUsuario = new N_MenuSistema();

        public MenuSistema()
        {
            InitializeComponent();

        }

        private void MenuSistema_Load(object sender, EventArgs e)
        {
            try
            {
                cb_estado.Items.Clear();
                cb_estado.Items.Add("-------------");
                cb_estado.Items.Add("ACTIVO");
                cb_estado.Items.Add("CESADO");
                cb_estado.SelectedIndex = 0;


            }
            catch (Exception ex)
            {
                
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaActual = DateTime.Now;
                TXTFECHA.Text = fechaActual.ToString("yyyy-MM-dd HH:mm:ss");

                string codUsuario = TXTCODIGO.Text.Trim();
                if (string.IsNullOrEmpty(codUsuario))
                {
                    MessageBox.Show("No se puede obtener el Usuario");
                    return;
                }
                
                //obtener los estado del combo designado a estado 
                string estadoSeleccionado = cb_estado.SelectedItem.ToString();
                if (string.IsNullOrEmpty (estadoSeleccionado) || estadoSeleccionado == "---------")
                {
                    MessageBox.Show("Debe seleccionar un estado valiso (Activo o Cesado)");
                    return;
                }

                bool estadoComboBox = estadoSeleccionado == "Activo";


                DB_MENU nuevoUsuario = new DB_MENU()
                {
                    COD_OPCION = TXTCODIGO.Text,
                    DES_OPCION = TXTDESCRIPCION.Text,
                    FLG_EST_OPC = estadoComboBox,
                    FEC_ABM = fechaActual
                    
                    
                };

                bool resultado = objUsuario.Insertar(nuevoUsuario);
                if (resultado)
                {
                    MessageBox.Show("Registro agregado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    TXTCODIGO.Clear();
                    TXTDESCRIPCION.Clear();
                    TXTFECHA.Clear();
                    cb_estado.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Error al agregar el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ACTUALIZAR_Click(object sender, EventArgs e)
        {

            try
            {
                string codigoOpcion = textBox5.Text.Trim();
                if (string.IsNullOrEmpty(codigoOpcion))
                {
                    MessageBox.Show("Ingrese un código valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                List<DB_MENU> listaMenu = objUsuario.ListarMenu();
                DB_MENU opcion = listaMenu.FirstOrDefault(r => r.COD_OPCION.Trim() == codigoOpcion.Trim());

                if (opcion != null)
                {
                    //mostramos los datos en los textbox
                    TXTCODIGO.Text = opcion.COD_OPCION.Trim();
                    TXTDESCRIPCION.Text = opcion.DES_OPCION;
                    TXTFECHA.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                    cb_estado.SelectedItem = opcion.FLG_EST_OPC ? "ACTIVO" : "CESADO";

                    textBox5.Clear();

                }
                else
                {
                    MessageBox.Show("No se encontrO el código ingresado.");
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Error al buscar los datos: " + ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void LISTAR_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();

                List<DB_MENU> lista = objUsuario.ListarMenu();

                foreach (var item in lista)
                {
                    string estadoTexto = item.FLG_EST_OPC ? "Activo" : "Cesado";
                    dataGridView1.Rows.Add(item.COD_OPCION, item.DES_OPCION, estadoTexto, item.FEC_ABM);
                }

            }

            catch (Exception ex)
            {
                {
                    MessageBox.Show("Error al cargar datos" + ex.Message);


                }

            }
        }

        private void cb_estado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_guardarCambios_Click(object sender, EventArgs e)
        {
            try
            {
                string estadoSeleccionado = cb_estado.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(estadoSeleccionado) || estadoSeleccionado == "-------------")
                {
                    MessageBox.Show("Debe seleccionar un estado válido.");
                    return;
                }

                bool estadoBool = estadoSeleccionado == "ACTIVO";

                DB_MENU menuActualizado = new DB_MENU()
                {
                    COD_OPCION = TXTCODIGO.Text,
                    DES_OPCION = TXTDESCRIPCION.Text,
                    FLG_EST_OPC = estadoBool,
                    FEC_ABM = DateTime.Now
                };

                bool actualizado = objUsuario.Actualizar(menuActualizado);

                if (actualizado)
                {
                    MessageBox.Show("Registro actualizado correctamente.");
                    TXTCODIGO.Clear();
                    TXTDESCRIPCION.Clear();
                    TXTFECHA.Clear();
                    cb_estado.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el registro.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
            }
        }
    }
}