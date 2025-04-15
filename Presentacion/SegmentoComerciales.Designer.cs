namespace Presentacion
{
    partial class SegmentoComerciales
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcodseg = new System.Windows.Forms.TextBox();
            this.txtdesseg = new System.Windows.Forms.TextBox();
            this.txtsubseg = new System.Windows.Forms.TextBox();
            this.txtsubsegdes = new System.Windows.Forms.TextBox();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.btnlistar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.cbusuario = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(184, 278);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(641, 300);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "COD_SEG";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "DES_SEG";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "COD_SSEG";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "DES_SSEG";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "COD_USER";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "FEC_ABM";
            this.Column6.Name = "Column6";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "COD SEG COM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "DES SEG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "COD SUBSEG";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(527, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "DES SUBSEG";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(527, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "USUSARIO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(527, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "FECHA";
            // 
            // txtcodseg
            // 
            this.txtcodseg.Location = new System.Drawing.Point(254, 78);
            this.txtcodseg.Name = "txtcodseg";
            this.txtcodseg.Size = new System.Drawing.Size(208, 20);
            this.txtcodseg.TabIndex = 7;
            // 
            // txtdesseg
            // 
            this.txtdesseg.Location = new System.Drawing.Point(254, 117);
            this.txtdesseg.Name = "txtdesseg";
            this.txtdesseg.Size = new System.Drawing.Size(208, 20);
            this.txtdesseg.TabIndex = 8;
            // 
            // txtsubseg
            // 
            this.txtsubseg.Location = new System.Drawing.Point(254, 154);
            this.txtsubseg.Name = "txtsubseg";
            this.txtsubseg.Size = new System.Drawing.Size(208, 20);
            this.txtsubseg.TabIndex = 9;
            // 
            // txtsubsegdes
            // 
            this.txtsubsegdes.Location = new System.Drawing.Point(618, 83);
            this.txtsubsegdes.Name = "txtsubsegdes";
            this.txtsubsegdes.Size = new System.Drawing.Size(208, 20);
            this.txtsubsegdes.TabIndex = 10;
            // 
            // txtfecha
            // 
            this.txtfecha.Location = new System.Drawing.Point(618, 157);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(208, 20);
            this.txtfecha.TabIndex = 12;
            // 
            // btnlistar
            // 
            this.btnlistar.Location = new System.Drawing.Point(199, 208);
            this.btnlistar.Name = "btnlistar";
            this.btnlistar.Size = new System.Drawing.Size(106, 47);
            this.btnlistar.TabIndex = 13;
            this.btnlistar.Text = "LISTAR";
            this.btnlistar.UseVisualStyleBackColor = true;
            this.btnlistar.Click += new System.EventHandler(this.btnlistar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(321, 208);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(106, 47);
            this.btnagregar.TabIndex = 14;
            this.btnagregar.Text = "AGREGAR";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnactualizar
            // 
            this.btnactualizar.Location = new System.Drawing.Point(447, 208);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(106, 47);
            this.btnactualizar.TabIndex = 15;
            this.btnactualizar.Text = "ACTUALIZAR";
            this.btnactualizar.UseVisualStyleBackColor = true;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(575, 208);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(106, 47);
            this.btnguardar.TabIndex = 16;
            this.btnguardar.Text = "GUARDAR ACT";
            this.btnguardar.UseVisualStyleBackColor = true;
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(700, 208);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(106, 47);
            this.btneliminar.TabIndex = 17;
            this.btneliminar.Text = "ELIMINAR";
            this.btneliminar.UseVisualStyleBackColor = true;
            // 
            // cbusuario
            // 
            this.cbusuario.FormattingEnabled = true;
            this.cbusuario.Location = new System.Drawing.Point(618, 120);
            this.cbusuario.Name = "cbusuario";
            this.cbusuario.Size = new System.Drawing.Size(207, 21);
            this.cbusuario.TabIndex = 18;
            // 
            // SegmentoComerciales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 607);
            this.Controls.Add(this.cbusuario);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.btnlistar);
            this.Controls.Add(this.txtfecha);
            this.Controls.Add(this.txtsubsegdes);
            this.Controls.Add(this.txtsubseg);
            this.Controls.Add(this.txtdesseg);
            this.Controls.Add(this.txtcodseg);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SegmentoComerciales";
            this.Text = "SegmentoComerciales";
            this.Load += new System.EventHandler(this.SegmentoComerciales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtcodseg;
        private System.Windows.Forms.TextBox txtdesseg;
        private System.Windows.Forms.TextBox txtsubseg;
        private System.Windows.Forms.TextBox txtsubsegdes;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.Button btnlistar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.ComboBox cbusuario;
    }
}