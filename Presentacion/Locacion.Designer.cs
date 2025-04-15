namespace Presentacion
{
    partial class Locacion
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
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FLG_DEP_CEN = new System.Windows.Forms.Label();
            this.COD_LOC = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cbpais = new System.Windows.Forms.ComboBox();
            this.cbdepartamento = new System.Windows.Forms.ComboBox();
            this.cbciudad = new System.Windows.Forms.ComboBox();
            this.cbbarrio = new System.Windows.Forms.ComboBox();
            this.cbusuario = new System.Windows.Forms.ComboBox();
            this.txtcodigolocacion = new System.Windows.Forms.TextBox();
            this.txtdeslocal = new System.Windows.Forms.TextBox();
            this.txtfechacreacion = new System.Windows.Forms.TextBox();
            this.txtencargado = new System.Windows.Forms.TextBox();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.txtaltura = new System.Windows.Forms.TextBox();
            this.txtsuperficie = new System.Windows.Forms.TextBox();
            this.txtcobertura = new System.Windows.Forms.TextBox();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.btnlistar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.btnagregaractualizacion = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.chkDepCentral = new System.Windows.Forms.CheckBox();
            this.chkLocVirtual = new System.Windows.Forms.CheckBox();
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
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15,
            this.Column16});
            this.dataGridView1.Location = new System.Drawing.Point(13, 286);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(963, 309);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "FLG_DEP_CEN";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "COD_LOC";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "DES_LOC";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "FEC_CREA";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "DES_NOM_ENC";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "FLG_LOC_VIR";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "COD_PAIS";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "COD_DPTO";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "COD_CIU";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "COD_BARR";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "DES_DIR_LOC";
            this.Column11.Name = "Column11";
            // 
            // Column12
            // 
            this.Column12.HeaderText = "VAL_ZLOC_ALT";
            this.Column12.Name = "Column12";
            // 
            // Column13
            // 
            this.Column13.HeaderText = "VAL_ZLOC_SUP";
            this.Column13.Name = "Column13";
            // 
            // Column14
            // 
            this.Column14.HeaderText = "VAL_COB_ESP";
            this.Column14.Name = "Column14";
            // 
            // Column15
            // 
            this.Column15.HeaderText = "COD_USER";
            this.Column15.Name = "Column15";
            // 
            // Column16
            // 
            this.Column16.HeaderText = "FEC_ABM";
            this.Column16.Name = "Column16";
            // 
            // FLG_DEP_CEN
            // 
            this.FLG_DEP_CEN.AutoSize = true;
            this.FLG_DEP_CEN.Location = new System.Drawing.Point(51, 38);
            this.FLG_DEP_CEN.Name = "FLG_DEP_CEN";
            this.FLG_DEP_CEN.Size = new System.Drawing.Size(83, 13);
            this.FLG_DEP_CEN.TabIndex = 1;
            this.FLG_DEP_CEN.Text = "FLG_DEP_CEN";
            // 
            // COD_LOC
            // 
            this.COD_LOC.AutoSize = true;
            this.COD_LOC.Location = new System.Drawing.Point(51, 68);
            this.COD_LOC.Name = "COD_LOC";
            this.COD_LOC.Size = new System.Drawing.Size(57, 13);
            this.COD_LOC.TabIndex = 2;
            this.COD_LOC.Text = "COD_LOC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "DES_LOC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "FEC_CREA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "DES_NOM_ENC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "FLG_LOC_VIR";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(306, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "COD_PAIS";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(306, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "COD_DPTO";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(306, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "COD_CIU";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(306, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "COD_BARR";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(309, 157);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "DES_DIR_LOC";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(309, 187);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "VAL_ZLOC_ALT";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(555, 38);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "VAL_ZLOC_SUP";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(558, 68);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 13);
            this.label14.TabIndex = 14;
            this.label14.Text = "VAL_COB_ESP";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(558, 100);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 13);
            this.label15.TabIndex = 15;
            this.label15.Text = "COD_USER";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(558, 129);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 13);
            this.label16.TabIndex = 16;
            this.label16.Text = "FEC_ABM";
            // 
            // cbpais
            // 
            this.cbpais.FormattingEnabled = true;
            this.cbpais.Location = new System.Drawing.Point(401, 35);
            this.cbpais.Name = "cbpais";
            this.cbpais.Size = new System.Drawing.Size(148, 21);
            this.cbpais.TabIndex = 17;
            // 
            // cbdepartamento
            // 
            this.cbdepartamento.FormattingEnabled = true;
            this.cbdepartamento.Location = new System.Drawing.Point(401, 60);
            this.cbdepartamento.Name = "cbdepartamento";
            this.cbdepartamento.Size = new System.Drawing.Size(148, 21);
            this.cbdepartamento.TabIndex = 18;
            // 
            // cbciudad
            // 
            this.cbciudad.FormattingEnabled = true;
            this.cbciudad.Location = new System.Drawing.Point(401, 100);
            this.cbciudad.Name = "cbciudad";
            this.cbciudad.Size = new System.Drawing.Size(148, 21);
            this.cbciudad.TabIndex = 19;
            // 
            // cbbarrio
            // 
            this.cbbarrio.FormattingEnabled = true;
            this.cbbarrio.Location = new System.Drawing.Point(401, 126);
            this.cbbarrio.Name = "cbbarrio";
            this.cbbarrio.Size = new System.Drawing.Size(148, 21);
            this.cbbarrio.TabIndex = 20;
            // 
            // cbusuario
            // 
            this.cbusuario.FormattingEnabled = true;
            this.cbusuario.Location = new System.Drawing.Point(650, 97);
            this.cbusuario.Name = "cbusuario";
            this.cbusuario.Size = new System.Drawing.Size(148, 21);
            this.cbusuario.TabIndex = 21;
            // 
            // txtcodigolocacion
            // 
            this.txtcodigolocacion.Location = new System.Drawing.Point(141, 68);
            this.txtcodigolocacion.Name = "txtcodigolocacion";
            this.txtcodigolocacion.Size = new System.Drawing.Size(159, 20);
            this.txtcodigolocacion.TabIndex = 23;
            this.txtcodigolocacion.TextChanged += new System.EventHandler(this.txtcodigolocacion_TextChanged);
            // 
            // txtdeslocal
            // 
            this.txtdeslocal.Location = new System.Drawing.Point(141, 97);
            this.txtdeslocal.Name = "txtdeslocal";
            this.txtdeslocal.Size = new System.Drawing.Size(159, 20);
            this.txtdeslocal.TabIndex = 24;
            // 
            // txtfechacreacion
            // 
            this.txtfechacreacion.Location = new System.Drawing.Point(141, 129);
            this.txtfechacreacion.Name = "txtfechacreacion";
            this.txtfechacreacion.Size = new System.Drawing.Size(159, 20);
            this.txtfechacreacion.TabIndex = 25;
            // 
            // txtencargado
            // 
            this.txtencargado.Location = new System.Drawing.Point(141, 157);
            this.txtencargado.Name = "txtencargado";
            this.txtencargado.Size = new System.Drawing.Size(159, 20);
            this.txtencargado.TabIndex = 26;
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(401, 157);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(159, 20);
            this.txtdireccion.TabIndex = 28;
            // 
            // txtaltura
            // 
            this.txtaltura.Location = new System.Drawing.Point(401, 187);
            this.txtaltura.Name = "txtaltura";
            this.txtaltura.Size = new System.Drawing.Size(159, 20);
            this.txtaltura.TabIndex = 29;
            // 
            // txtsuperficie
            // 
            this.txtsuperficie.Location = new System.Drawing.Point(650, 38);
            this.txtsuperficie.Name = "txtsuperficie";
            this.txtsuperficie.Size = new System.Drawing.Size(159, 20);
            this.txtsuperficie.TabIndex = 30;
            // 
            // txtcobertura
            // 
            this.txtcobertura.Location = new System.Drawing.Point(650, 65);
            this.txtcobertura.Name = "txtcobertura";
            this.txtcobertura.Size = new System.Drawing.Size(159, 20);
            this.txtcobertura.TabIndex = 31;
            // 
            // txtfecha
            // 
            this.txtfecha.Location = new System.Drawing.Point(650, 129);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(159, 20);
            this.txtfecha.TabIndex = 32;
            // 
            // btnlistar
            // 
            this.btnlistar.Location = new System.Drawing.Point(160, 225);
            this.btnlistar.Name = "btnlistar";
            this.btnlistar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnlistar.Size = new System.Drawing.Size(96, 42);
            this.btnlistar.TabIndex = 33;
            this.btnlistar.Text = "LISTAR";
            this.btnlistar.UseVisualStyleBackColor = true;
            this.btnlistar.Click += new System.EventHandler(this.btnlistar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(285, 225);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(96, 42);
            this.btnagregar.TabIndex = 34;
            this.btnagregar.Text = "AGREGAR";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnactualizar
            // 
            this.btnactualizar.Location = new System.Drawing.Point(418, 225);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(96, 42);
            this.btnactualizar.TabIndex = 35;
            this.btnactualizar.Text = "ACTUALIZAR";
            this.btnactualizar.UseVisualStyleBackColor = true;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // btnagregaractualizacion
            // 
            this.btnagregaractualizacion.Location = new System.Drawing.Point(548, 225);
            this.btnagregaractualizacion.Name = "btnagregaractualizacion";
            this.btnagregaractualizacion.Size = new System.Drawing.Size(96, 42);
            this.btnagregaractualizacion.TabIndex = 36;
            this.btnagregaractualizacion.Text = "GUARDAR ACT";
            this.btnagregaractualizacion.UseVisualStyleBackColor = true;
            this.btnagregaractualizacion.Click += new System.EventHandler(this.btnagregaractualizacion_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(686, 225);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(96, 42);
            this.btneliminar.TabIndex = 37;
            this.btneliminar.Text = "ELIMINAR";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // chkDepCentral
            // 
            this.chkDepCentral.AutoSize = true;
            this.chkDepCentral.Location = new System.Drawing.Point(141, 37);
            this.chkDepCentral.Name = "chkDepCentral";
            this.chkDepCentral.Size = new System.Drawing.Size(15, 14);
            this.chkDepCentral.TabIndex = 38;
            this.chkDepCentral.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chkDepCentral.UseVisualStyleBackColor = true;
            // 
            // chkLocVirtual
            // 
            this.chkLocVirtual.AutoSize = true;
            this.chkLocVirtual.Location = new System.Drawing.Point(141, 186);
            this.chkLocVirtual.Name = "chkLocVirtual";
            this.chkLocVirtual.Size = new System.Drawing.Size(15, 14);
            this.chkLocVirtual.TabIndex = 39;
            this.chkLocVirtual.UseVisualStyleBackColor = true;
            // 
            // Locacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 607);
            this.Controls.Add(this.chkLocVirtual);
            this.Controls.Add(this.chkDepCentral);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnagregaractualizacion);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.btnlistar);
            this.Controls.Add(this.txtfecha);
            this.Controls.Add(this.txtcobertura);
            this.Controls.Add(this.txtsuperficie);
            this.Controls.Add(this.txtaltura);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.txtencargado);
            this.Controls.Add(this.txtfechacreacion);
            this.Controls.Add(this.txtdeslocal);
            this.Controls.Add(this.txtcodigolocacion);
            this.Controls.Add(this.cbusuario);
            this.Controls.Add(this.cbbarrio);
            this.Controls.Add(this.cbciudad);
            this.Controls.Add(this.cbdepartamento);
            this.Controls.Add(this.cbpais);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.COD_LOC);
            this.Controls.Add(this.FLG_DEP_CEN);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Locacion";
            this.Text = "Locacion";
            this.Load += new System.EventHandler(this.Locacion_Load);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.Label FLG_DEP_CEN;
        private System.Windows.Forms.Label COD_LOC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbpais;
        private System.Windows.Forms.ComboBox cbdepartamento;
        private System.Windows.Forms.ComboBox cbciudad;
        private System.Windows.Forms.ComboBox cbbarrio;
        private System.Windows.Forms.ComboBox cbusuario;
        private System.Windows.Forms.TextBox txtcodigolocacion;
        private System.Windows.Forms.TextBox txtdeslocal;
        private System.Windows.Forms.TextBox txtfechacreacion;
        private System.Windows.Forms.TextBox txtencargado;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.TextBox txtaltura;
        private System.Windows.Forms.TextBox txtsuperficie;
        private System.Windows.Forms.TextBox txtcobertura;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.Button btnlistar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Button btnagregaractualizacion;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.CheckBox chkDepCentral;
        private System.Windows.Forms.CheckBox chkLocVirtual;
    }
}