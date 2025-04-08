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
    public partial class RegionFisica : Form
    {
        //Instanciamos a la capa para poder acceder a sus metodos
        private N_RegionFisica objNegocio = new N_RegionFisica();

        public RegionFisica()
        {
            InitializeComponent();
        }

        private void RegionFisica_Load(object sender, EventArgs e)
        {
            try
            {
                N_Usuario objUsuario = new N_Usuario();
                DB_USUARIO usuario = objUsuario.ObtenerPrimerUsuario();

                if (usuario != null)
                {
                    txt_codigousuario.Text = usuario.COD_USER; // Asignar el COD_USER automáticamente
                    txt_codigousuario.ReadOnly = true; // Hacer que el usuario no pueda modificarlo
                }
                else
                {
                    MessageBox.Show("No se encontraron usuarios en la base de datos.");
                }

                // Bloquear txt_fechacreacion para que no se pueda escribir al inicio
                txt_fechacreacion.ReadOnly = true;
                txt_fechacreacion.BackColor = SystemColors.Control; // Fondo gris claro
                txt_fechacreacion.TabStop = false; // No se puede enfocar con TAB


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el usuario: " + ex.Message);
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_listar_Click(object sender, EventArgs e)
        {
            try
            {
                // Desvincular el DataGridView de cualquier DataSource
                Tabla_regionfisica.DataSource = null;
                Tabla_regionfisica.Rows.Clear(); // Limpiar filas manualmente

                // Obtener la lista de regiones físicas
                List<DB_REG_FIS> lista = objNegocio.Listar();

                // Agregar los datos manualmente a las columnas existentes
                foreach (var item in lista)
                {
                    Tabla_regionfisica.Rows.Add(item.COD_REG, item.DES_REG, item.COD_USER, item.FEC_ABM);
                }
            }
            catch (Exception ex)  
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }

        }

        private void txt_codigoregion_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaActual = DateTime.Now;
                txt_fechacreacion.Text = fechaActual.ToString("yyyy-MM-dd HH:mm:ss");

                                  string codUsuario = txt_codigousuario.Text.Trim();
                if (string.IsNullOrEmpty(codUsuario))
                {
                    MessageBox.Show("No se pudo obtener el usuario. Verifique que haya usuarios registrados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DB_REG_FIS nuevaRegion = new DB_REG_FIS()
                {
                    COD_REG = Convert.ToInt16(txt_codigo.Text),
                    DES_REG = txt_descripcion.Text,
                    COD_USER = codUsuario,  
                    FEC_ABM = Convert.ToDateTime(txt_fechacreacion.Text)

                };

                bool resultado = objNegocio.Insertar(nuevaRegion);

                if (resultado)
                {
                    MessageBox.Show("Registro agregado correctamente.","Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ListarDatos();

                    txt_codigo.Clear();
                    txt_descripcion.Clear();
                 
                    txt_fechacreacion.Clear();

                }
                else
                {
                    MessageBox.Show("Error al agregar el registro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void fechaCreacion_Click(object sender, EventArgs e)
        {

        }

        private void ListarDatos()
        {
            try
            {
                // Obtener la lista de regiones físicas
                List<DB_REG_FIS> lista = objNegocio.Listar();

                // Mostrar los datos en el DataGridView
                Tabla_regionfisica.DataSource = null; // Limpiar antes de asignar nueva data
                Tabla_regionfisica.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el código de la región ingresado
                short codigoRegion;
                if (!short.TryParse(txt_codigoregion.Text, out codigoRegion))
                {
                    MessageBox.Show("Ingrese un código de región válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Buscar la región en la lista
                List<DB_REG_FIS> lista = objNegocio.Listar();
                DB_REG_FIS region = lista.FirstOrDefault(r => r.COD_REG == codigoRegion);

                if (region != null)
                {
                    // Mostrar los datos en los campos de texto
                    txt_codigo.Text = region.COD_REG.ToString();
                    txt_descripcion.Text = region.DES_REG;
                    txt_codigousuario.Text = region.COD_USER;
                    txt_fechacreacion.Text = region.FEC_ABM.ToString("yyyy-MM-dd HH:mm:ss");

                    txt_codigoregion.Clear();

                    // Deshabilitar el botón "Agregar" y habilitar "Guardar"
                    btn_agregar.Enabled = false;
                    btn_guardar.Enabled = true;

                    // HABILITAR txt_fechacreacion para permitir su modificación
                    txt_fechacreacion.ReadOnly = false;
                    txt_fechacreacion.BackColor = SystemColors.Window; // Fondo blanco normal
                    txt_fechacreacion.TabStop = true; // Se puede enfocar con TAB



                }
                else
                {
                    MessageBox.Show("No se encontró la región con el código ingresado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar los datos: " + ex.Message);
            }

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                string codUsuario = txt_codigousuario.Text.Trim();
                if (string.IsNullOrEmpty(codUsuario))
                {
                    MessageBox.Show("No se pudo obtener el usuario. Verifique que haya usuarios registrados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtener la descripción de la región antes de actualizar
                string descripcionRegion = txt_descripcion.Text.Trim();

                // Mensaje de confirmación antes de proceder con la actualización
                DialogResult confirmacion = MessageBox.Show(
                    $"¿Está seguro que desea modificar la región: {descripcionRegion}?",
                    "Confirmación de Actualización",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmacion == DialogResult.No)
                {
                    // Si el usuario elige "No", se cancelará la actualización y se limpiarán los campos
                    txt_codigo.Clear();
                    txt_descripcion.Clear();
                    txt_fechacreacion.Clear();

                    MessageBox.Show("Actualización cancelada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Si el usuario elige "Sí", se procede con la actualización
                DB_REG_FIS regionActualizada = new DB_REG_FIS()
                {
                    COD_REG = Convert.ToInt16(txt_codigo.Text),
                    DES_REG = txt_descripcion.Text,
                    COD_USER = codUsuario,
                    FEC_ABM = Convert.ToDateTime(txt_fechacreacion.Text)
                };

                bool resultado = objNegocio.Actualizar(regionActualizada);



                if (resultado)
                {
                    MessageBox.Show("Registro actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refrescar la tabla con los datos actualizados
                    ListarDatos();

                    // Limpiar los campos de entrada
                    txt_codigo.Clear();
                    txt_descripcion.Clear();

                    txt_fechacreacion.Clear();

                    btn_agregar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Error al actualizar el registro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el código de la región ingresado
                short codigoRegion;
                if (!short.TryParse(txt_codigoregion.Text, out codigoRegion))
                {
                    MessageBox.Show("Ingrese un código de región válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Confirmación antes de eliminar
                DialogResult confirmacion = MessageBox.Show(
                    "¿Está seguro de que desea eliminar esta región?",
                    "Confirmación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirmacion == DialogResult.Yes)
                {
                    bool resultado = objNegocio.Eliminar(codigoRegion);

                    if (resultado)
                    {
                        MessageBox.Show("Registro eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Refrescar la tabla con los datos actualizados
                        ListarDatos();

                        // Limpiar el campo de búsqueda
                        txt_codigoregion.Clear();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el registro. Verifique que el código de región exista.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void txt_fechacreacion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
