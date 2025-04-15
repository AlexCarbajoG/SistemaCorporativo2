namespace Presentacion
{
    partial class Trabajadores
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
            this.txtcodtra = new System.Windows.Forms.Label();
            this.txtcodper = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkestado = new System.Windows.Forms.CheckBox();
            this.cbpersona = new System.Windows.Forms.ComboBox();
            this.txtcodtrabajador = new System.Windows.Forms.TextBox();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.btnlistar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.btnguardaract = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
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
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(513, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 437);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "COD TRA";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "COD PER";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "ESTADO";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "DECHA";
            this.Column4.Name = "Column4";
            // 
            // txtcodtra
            // 
            this.txtcodtra.AutoSize = true;
            this.txtcodtra.Location = new System.Drawing.Point(57, 103);
            this.txtcodtra.Name = "txtcodtra";
            this.txtcodtra.Size = new System.Drawing.Size(105, 13);
            this.txtcodtra.TabIndex = 1;
            this.txtcodtra.Text = "COD TRABAJADOR";
            // 
            // txtcodper
            // 
            this.txtcodper.AutoSize = true;
            this.txtcodper.Location = new System.Drawing.Point(57, 141);
            this.txtcodper.Name = "txtcodper";
            this.txtcodper.Size = new System.Drawing.Size(85, 13);
            this.txtcodper.TabIndex = 2;
            this.txtcodper.Text = "COD PERSONA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "ESTADO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "FECHA";
            // 
            // chkestado
            // 
            this.chkestado.AutoSize = true;
            this.chkestado.Location = new System.Drawing.Point(189, 178);
            this.chkestado.Name = "chkestado";
            this.chkestado.Size = new System.Drawing.Size(15, 14);
            this.chkestado.TabIndex = 5;
            this.chkestado.UseVisualStyleBackColor = true;
            // 
            // cbpersona
            // 
            this.cbpersona.FormattingEnabled = true;
            this.cbpersona.Location = new System.Drawing.Point(189, 138);
            this.cbpersona.Name = "cbpersona";
            this.cbpersona.Size = new System.Drawing.Size(180, 21);
            this.cbpersona.TabIndex = 6;
            // 
            // txtcodtrabajador
            // 
            this.txtcodtrabajador.Location = new System.Drawing.Point(189, 103);
            this.txtcodtrabajador.Name = "txtcodtrabajador";
            this.txtcodtrabajador.Size = new System.Drawing.Size(180, 20);
            this.txtcodtrabajador.TabIndex = 7;
            // 
            // txtfecha
            // 
            this.txtfecha.Location = new System.Drawing.Point(189, 212);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(180, 20);
            this.txtfecha.TabIndex = 8;
            // 
            // btnlistar
            // 
            this.btnlistar.Location = new System.Drawing.Point(46, 286);
            this.btnlistar.Name = "btnlistar";
            this.btnlistar.Size = new System.Drawing.Size(96, 56);
            this.btnlistar.TabIndex = 9;
            this.btnlistar.Text = "LISTAR";
            this.btnlistar.UseVisualStyleBackColor = true;
            this.btnlistar.Click += new System.EventHandler(this.btnlistar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(189, 286);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(96, 56);
            this.btnagregar.TabIndex = 10;
            this.btnagregar.Text = "AGREGAR";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnactualizar
            // 
            this.btnactualizar.Location = new System.Drawing.Point(335, 286);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(96, 56);
            this.btnactualizar.TabIndex = 11;
            this.btnactualizar.Text = "ACTUALIZAR";
            this.btnactualizar.UseVisualStyleBackColor = true;
            // 
            // btnguardaract
            // 
            this.btnguardaract.Location = new System.Drawing.Point(46, 370);
            this.btnguardaract.Name = "btnguardaract";
            this.btnguardaract.Size = new System.Drawing.Size(96, 56);
            this.btnguardaract.TabIndex = 12;
            this.btnguardaract.Text = "GUARDAR ACT";
            this.btnguardaract.UseVisualStyleBackColor = true;
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(189, 370);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(96, 56);
            this.btneliminar.TabIndex = 13;
            this.btneliminar.Text = "ELIMINAR";
            this.btneliminar.UseVisualStyleBackColor = true;
            // 
            // Trabajadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 607);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnguardaract);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.btnlistar);
            this.Controls.Add(this.txtfecha);
            this.Controls.Add(this.txtcodtrabajador);
            this.Controls.Add(this.cbpersona);
            this.Controls.Add(this.chkestado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcodper);
            this.Controls.Add(this.txtcodtra);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Trabajadores";
            this.Text = "Trabajadores";
            this.Load += new System.EventHandler(this.Trabajadores_Load);
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
        private System.Windows.Forms.Label txtcodtra;
        private System.Windows.Forms.Label txtcodper;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkestado;
        private System.Windows.Forms.ComboBox cbpersona;
        private System.Windows.Forms.TextBox txtcodtrabajador;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.Button btnlistar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Button btnguardaract;
        private System.Windows.Forms.Button btneliminar;
    }
}