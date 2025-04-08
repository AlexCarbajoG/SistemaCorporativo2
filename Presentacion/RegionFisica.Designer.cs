namespace Presentacion
{
    partial class RegionFisica
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
            this.btn_listar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Tabla_regionfisica = new System.Windows.Forms.DataGridView();
            this.CodigoRegion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaCreación = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_codigoregion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_codigousuario = new System.Windows.Forms.TextBox();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_fechacreacion = new System.Windows.Forms.TextBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla_regionfisica)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_listar
            // 
            this.btn_listar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn_listar.Location = new System.Drawing.Point(827, 476);
            this.btn_listar.Name = "btn_listar";
            this.btn_listar.Size = new System.Drawing.Size(110, 51);
            this.btn_listar.TabIndex = 0;
            this.btn_listar.Text = "Listar";
            this.btn_listar.UseVisualStyleBackColor = true;
            this.btn_listar.Click += new System.EventHandler(this.btn_listar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn_guardar.Location = new System.Drawing.Point(31, 304);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(110, 51);
            this.btn_guardar.TabIndex = 1;
            this.btn_guardar.Text = "Guardar Actualización";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn_agregar.Location = new System.Drawing.Point(147, 304);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(110, 51);
            this.btn_agregar.TabIndex = 2;
            this.btn_agregar.Text = "Agregar Nueva Región";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn_actualizar.Location = new System.Drawing.Point(760, 49);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(84, 36);
            this.btn_actualizar.TabIndex = 3;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn_eliminar.Location = new System.Drawing.Point(850, 49);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(87, 36);
            this.btn_eliminar.TabIndex = 4;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(54, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Regíon Física";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Tabla_regionfisica
            // 
            this.Tabla_regionfisica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabla_regionfisica.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoRegion,
            this.CodigoUsuario,
            this.FechaCreación,
            this.Descripción});
            this.Tabla_regionfisica.Location = new System.Drawing.Point(414, 98);
            this.Tabla_regionfisica.Name = "Tabla_regionfisica";
            this.Tabla_regionfisica.Size = new System.Drawing.Size(525, 372);
            this.Tabla_regionfisica.TabIndex = 6;
            this.Tabla_regionfisica.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // CodigoRegion
            // 
            this.CodigoRegion.FillWeight = 110F;
            this.CodigoRegion.HeaderText = "Código Región";
            this.CodigoRegion.Name = "CodigoRegion";
            this.CodigoRegion.Width = 120;
            // 
            // CodigoUsuario
            // 
            this.CodigoUsuario.FillWeight = 110F;
            this.CodigoUsuario.HeaderText = "Descripción";
            this.CodigoUsuario.Name = "CodigoUsuario";
            this.CodigoUsuario.Width = 120;
            // 
            // FechaCreación
            // 
            this.FechaCreación.FillWeight = 110F;
            this.FechaCreación.HeaderText = "Código Usuario";
            this.FechaCreación.Name = "FechaCreación";
            this.FechaCreación.Width = 120;
            // 
            // Descripción
            // 
            this.Descripción.FillWeight = 110F;
            this.Descripción.HeaderText = "Fecha Creación";
            this.Descripción.Name = "Descripción";
            this.Descripción.Width = 120;
            // 
            // txt_codigoregion
            // 
            this.txt_codigoregion.Location = new System.Drawing.Point(414, 58);
            this.txt_codigoregion.Name = "txt_codigoregion";
            this.txt_codigoregion.Size = new System.Drawing.Size(313, 20);
            this.txt_codigoregion.TabIndex = 7;
            this.txt_codigoregion.TextChanged += new System.EventHandler(this.txt_codigoregion_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(411, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ingresa el código de la región";
            // 
            // txt_codigousuario
            // 
            this.txt_codigousuario.Location = new System.Drawing.Point(46, 105);
            this.txt_codigousuario.Name = "txt_codigousuario";
            this.txt_codigousuario.Size = new System.Drawing.Size(183, 20);
            this.txt_codigousuario.TabIndex = 9;
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(46, 239);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(183, 20);
            this.txt_descripcion.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Codigo Usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Fecha de Creación";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Descripción";
            // 
            // txt_fechacreacion
            // 
            this.txt_fechacreacion.Location = new System.Drawing.Point(49, 167);
            this.txt_fechacreacion.Name = "txt_fechacreacion";
            this.txt_fechacreacion.Size = new System.Drawing.Size(180, 20);
            this.txt_fechacreacion.TabIndex = 15;
            this.txt_fechacreacion.TextChanged += new System.EventHandler(this.txt_fechacreacion_TextChanged);
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(49, 43);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(180, 20);
            this.txt_codigo.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Codigo Región";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_codigo);
            this.panel1.Controls.Add(this.txt_fechacreacion);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_descripcion);
            this.panel1.Controls.Add(this.txt_codigousuario);
            this.panel1.Controls.Add(this.btn_guardar);
            this.panel1.Controls.Add(this.btn_agregar);
            this.panel1.Location = new System.Drawing.Point(60, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 373);
            this.panel1.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Registra o actualiza una región";
            // 
            // RegionFisica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 554);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_codigoregion);
            this.Controls.Add(this.Tabla_regionfisica);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.btn_listar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegionFisica";
            this.Text = "RegionFisica";
            this.Load += new System.EventHandler(this.RegionFisica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tabla_regionfisica)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_listar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Tabla_regionfisica;
        private System.Windows.Forms.TextBox txt_codigoregion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_codigousuario;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_fechacreacion;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoRegion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCreación;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripción;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
    }
}