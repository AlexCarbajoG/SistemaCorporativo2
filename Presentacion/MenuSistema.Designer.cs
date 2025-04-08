namespace Presentacion
{
    partial class MenuSistema
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
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCIÓN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TXTCODIGO = new System.Windows.Forms.TextBox();
            this.TXTDESCRIPCION = new System.Windows.Forms.TextBox();
            this.TXTFECHA = new System.Windows.Forms.TextBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ELIMINAR = new System.Windows.Forms.Button();
            this.ACTUALIZAR = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.LISTAR = new System.Windows.Forms.Button();
            this.cb_estado = new System.Windows.Forms.ComboBox();
            this.btn_guardarCambios = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO,
            this.DESCRIPCIÓN,
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(442, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(470, 346);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // CODIGO
            // 
            this.CODIGO.HeaderText = "CODIGO";
            this.CODIGO.Name = "CODIGO";
            this.CODIGO.Width = 115;
            // 
            // DESCRIPCIÓN
            // 
            this.DESCRIPCIÓN.HeaderText = "DESCRIPCIÓN";
            this.DESCRIPCIÓN.Name = "DESCRIPCIÓN";
            this.DESCRIPCIÓN.Width = 110;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ESTADO";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.FillWeight = 115F;
            this.Column2.HeaderText = "FECHA";
            this.Column2.Name = "Column2";
            // 
            // TXTCODIGO
            // 
            this.TXTCODIGO.Location = new System.Drawing.Point(122, 156);
            this.TXTCODIGO.Name = "TXTCODIGO";
            this.TXTCODIGO.Size = new System.Drawing.Size(147, 20);
            this.TXTCODIGO.TabIndex = 1;
            this.TXTCODIGO.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TXTDESCRIPCION
            // 
            this.TXTDESCRIPCION.Location = new System.Drawing.Point(122, 211);
            this.TXTDESCRIPCION.Name = "TXTDESCRIPCION";
            this.TXTDESCRIPCION.Size = new System.Drawing.Size(147, 20);
            this.TXTDESCRIPCION.TabIndex = 2;
            this.TXTDESCRIPCION.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // TXTFECHA
            // 
            this.TXTFECHA.Location = new System.Drawing.Point(125, 320);
            this.TXTFECHA.Name = "TXTFECHA";
            this.TXTFECHA.Size = new System.Drawing.Size(147, 20);
            this.TXTFECHA.TabIndex = 4;
            this.TXTFECHA.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(137, 396);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(103, 49);
            this.btn_agregar.TabIndex = 5;
            this.btn_agregar.Text = "AGREGA UN MENU";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(122, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "INGRESA UN NUEVO MENU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "CODIGO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "DESCRIPCIÓN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "ESTADO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "FECHA DE CREACIÓN";
            // 
            // ELIMINAR
            // 
            this.ELIMINAR.Location = new System.Drawing.Point(833, 497);
            this.ELIMINAR.Name = "ELIMINAR";
            this.ELIMINAR.Size = new System.Drawing.Size(79, 30);
            this.ELIMINAR.TabIndex = 11;
            this.ELIMINAR.Text = "ELIMINAR";
            this.ELIMINAR.UseVisualStyleBackColor = true;
            this.ELIMINAR.Click += new System.EventHandler(this.button2_Click);
            // 
            // ACTUALIZAR
            // 
            this.ACTUALIZAR.Location = new System.Drawing.Point(729, 497);
            this.ACTUALIZAR.Name = "ACTUALIZAR";
            this.ACTUALIZAR.Size = new System.Drawing.Size(86, 30);
            this.ACTUALIZAR.TabIndex = 12;
            this.ACTUALIZAR.Text = "ACTUALIZAR";
            this.ACTUALIZAR.UseVisualStyleBackColor = true;
            this.ACTUALIZAR.Click += new System.EventHandler(this.ACTUALIZAR_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(442, 497);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(239, 20);
            this.textBox5.TabIndex = 13;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // LISTAR
            // 
            this.LISTAR.Location = new System.Drawing.Point(837, 69);
            this.LISTAR.Name = "LISTAR";
            this.LISTAR.Size = new System.Drawing.Size(75, 23);
            this.LISTAR.TabIndex = 14;
            this.LISTAR.Text = "LISTAR";
            this.LISTAR.UseVisualStyleBackColor = true;
            this.LISTAR.Click += new System.EventHandler(this.LISTAR_Click);
            // 
            // cb_estado
            // 
            this.cb_estado.FormattingEnabled = true;
            this.cb_estado.Items.AddRange(new object[] {
            "-----------",
            "Activo",
            "Cesado"});
            this.cb_estado.Location = new System.Drawing.Point(122, 264);
            this.cb_estado.Name = "cb_estado";
            this.cb_estado.Size = new System.Drawing.Size(147, 21);
            this.cb_estado.TabIndex = 15;
            this.cb_estado.SelectedIndexChanged += new System.EventHandler(this.cb_estado_SelectedIndexChanged);
            // 
            // btn_guardarCambios
            // 
            this.btn_guardarCambios.Location = new System.Drawing.Point(137, 451);
            this.btn_guardarCambios.Name = "btn_guardarCambios";
            this.btn_guardarCambios.Size = new System.Drawing.Size(103, 66);
            this.btn_guardarCambios.TabIndex = 16;
            this.btn_guardarCambios.Text = "GUARDAR ACTUALIZACIÓN";
            this.btn_guardarCambios.UseVisualStyleBackColor = true;
            this.btn_guardarCambios.Click += new System.EventHandler(this.btn_guardarCambios_Click);
            // 
            // MenuSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 607);
            this.Controls.Add(this.btn_guardarCambios);
            this.Controls.Add(this.cb_estado);
            this.Controls.Add(this.LISTAR);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.ACTUALIZAR);
            this.Controls.Add(this.ELIMINAR);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.TXTFECHA);
            this.Controls.Add(this.TXTDESCRIPCION);
            this.Controls.Add(this.TXTCODIGO);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuSistema";
            this.Text = "MenuSistema";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TXTCODIGO;
        private System.Windows.Forms.TextBox TXTDESCRIPCION;
        private System.Windows.Forms.TextBox TXTFECHA;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ELIMINAR;
        private System.Windows.Forms.Button ACTUALIZAR;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button LISTAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCIÓN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.ComboBox cb_estado;
        private System.Windows.Forms.Button btn_guardarCambios;
    }
}