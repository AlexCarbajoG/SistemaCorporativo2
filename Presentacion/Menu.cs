using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Menu : Form
    {
        
        public Menu()
        {
            InitializeComponent();
        }

        private void MostrarFormularioEnPanel(Form form)
        {
            panel_controlador.Controls.Clear();

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            panel_controlador.Controls.Add(form);
            panel_controlador.Tag = form;
            form.Show();
        }

        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void regionFisicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarFormularioEnPanel(new RegionFisica());
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_ubicacion_Click(object sender, EventArgs e)
        {
            MostrarFormularioEnPanel(new UbicacionGeografica());
        }

        private void segmentosComercialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarFormularioEnPanel(new SegmentoComerciales());
        }

        private void marcasDeArtículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarFormularioEnPanel(new MarcasDeArticulos());
        }

        private void familiaDeArtículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarFormularioEnPanel(new FamiliaDeArticulos());
        }

        private void localToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarFormularioEnPanel(new Local());
        }

        private void almacenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarFormularioEnPanel(new Almacenes());
        }

        private void personaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarFormularioEnPanel(new Persona());
        }

        private void vendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarFormularioEnPanel(new Vendedores());
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarFormularioEnPanel(new Clientes());
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarFormularioEnPanel(new Proveedores());
        }

        private void fabricantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarFormularioEnPanel(new Fabricantes());
        }

        private void mestroDeArtículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarFormularioEnPanel(new MaestroDeArticulos());
        }

        private void loteDeArtículoasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarFormularioEnPanel(new LoteDeArticulos());
        }
    }
}
