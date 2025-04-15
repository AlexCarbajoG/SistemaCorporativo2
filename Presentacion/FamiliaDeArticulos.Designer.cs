namespace Presentacion
{
    partial class FamiliaDeArticulos
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
            this.txtcategoria = new System.Windows.Forms.TextBox();
            this.txtdescat = new System.Windows.Forms.TextBox();
            this.txtcodlinea = new System.Windows.Forms.TextBox();
            this.txtdeslinea = new System.Windows.Forms.TextBox();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.cbusuario = new System.Windows.Forms.ComboBox();
            this.btnlistar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.btnguardaract = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.Button();
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
            this.dataGridView1.Location = new System.Drawing.Point(187, 298);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 278);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "COD CAT";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "DES CAT";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "COD LIN";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "DES LIN";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "COD USER";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "FECHA";
            this.Column6.Name = "Column6";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "COD CATEEGORIA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "DES CATEGORIA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "COD LINEA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(520, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "FECHA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(520, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "USUARIO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(520, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "DES LINEA";
            // 
            // txtcategoria
            // 
            this.txtcategoria.Location = new System.Drawing.Point(243, 41);
            this.txtcategoria.Name = "txtcategoria";
            this.txtcategoria.Size = new System.Drawing.Size(205, 20);
            this.txtcategoria.TabIndex = 7;
            // 
            // txtdescat
            // 
            this.txtdescat.Location = new System.Drawing.Point(243, 75);
            this.txtdescat.Name = "txtdescat";
            this.txtdescat.Size = new System.Drawing.Size(205, 20);
            this.txtdescat.TabIndex = 8;
            // 
            // txtcodlinea
            // 
            this.txtcodlinea.Location = new System.Drawing.Point(243, 112);
            this.txtcodlinea.Name = "txtcodlinea";
            this.txtcodlinea.Size = new System.Drawing.Size(205, 20);
            this.txtcodlinea.TabIndex = 9;
            // 
            // txtdeslinea
            // 
            this.txtdeslinea.Location = new System.Drawing.Point(583, 41);
            this.txtdeslinea.Name = "txtdeslinea";
            this.txtdeslinea.Size = new System.Drawing.Size(205, 20);
            this.txtdeslinea.TabIndex = 10;
            // 
            // txtfecha
            // 
            this.txtfecha.Location = new System.Drawing.Point(583, 112);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(205, 20);
            this.txtfecha.TabIndex = 11;
            // 
            // cbusuario
            // 
            this.cbusuario.FormattingEnabled = true;
            this.cbusuario.Location = new System.Drawing.Point(583, 75);
            this.cbusuario.Name = "cbusuario";
            this.cbusuario.Size = new System.Drawing.Size(155, 21);
            this.cbusuario.TabIndex = 12;
            // 
            // btnlistar
            // 
            this.btnlistar.Location = new System.Drawing.Point(197, 175);
            this.btnlistar.Name = "btnlistar";
            this.btnlistar.Size = new System.Drawing.Size(99, 78);
            this.btnlistar.TabIndex = 13;
            this.btnlistar.Text = "LISTAR";
            this.btnlistar.UseVisualStyleBackColor = true;
            this.btnlistar.Click += new System.EventHandler(this.btnlistar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(335, 175);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(99, 78);
            this.btnagregar.TabIndex = 14;
            this.btnagregar.Text = "AGREGAR";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnactualizar
            // 
            this.btnactualizar.Location = new System.Drawing.Point(465, 175);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(99, 78);
            this.btnactualizar.TabIndex = 15;
            this.btnactualizar.Text = "ACTUALIZAR";
            this.btnactualizar.UseVisualStyleBackColor = true;
            // 
            // btnguardaract
            // 
            this.btnguardaract.Location = new System.Drawing.Point(597, 175);
            this.btnguardaract.Name = "btnguardaract";
            this.btnguardaract.Size = new System.Drawing.Size(99, 78);
            this.btnguardaract.TabIndex = 16;
            this.btnguardaract.Text = "GUARDAR ACT";
            this.btnguardaract.UseVisualStyleBackColor = true;
            // 
            // eliminar
            // 
            this.eliminar.Location = new System.Drawing.Point(721, 175);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(99, 78);
            this.eliminar.TabIndex = 17;
            this.eliminar.Text = "ELIMINAR";
            this.eliminar.UseVisualStyleBackColor = true;
            // 
            // FamiliaDeArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 607);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.btnguardaract);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.btnlistar);
            this.Controls.Add(this.cbusuario);
            this.Controls.Add(this.txtfecha);
            this.Controls.Add(this.txtdeslinea);
            this.Controls.Add(this.txtcodlinea);
            this.Controls.Add(this.txtdescat);
            this.Controls.Add(this.txtcategoria);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FamiliaDeArticulos";
            this.Text = "FamiliaDeArticulos";
            this.Load += new System.EventHandler(this.FamiliaDeArticulos_Load);
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
        private System.Windows.Forms.TextBox txtcategoria;
        private System.Windows.Forms.TextBox txtdescat;
        private System.Windows.Forms.TextBox txtcodlinea;
        private System.Windows.Forms.TextBox txtdeslinea;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.ComboBox cbusuario;
        private System.Windows.Forms.Button btnlistar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Button btnguardaract;
        private System.Windows.Forms.Button eliminar;
    }
}