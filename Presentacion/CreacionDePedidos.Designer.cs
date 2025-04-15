namespace Presentacion
{
    partial class CreacionDePedidos
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
            this.cblocacion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpedido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbcliente = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtfechacreacion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbvendedor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtruc = new System.Windows.Forms.TextBox();
            this.txtdoccliente = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.chkestado = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbusuario = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.btnlistar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtobservaciones = new System.Windows.Forms.TextBox();
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
            this.Column11});
            this.dataGridView1.Location = new System.Drawing.Point(29, 307);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(917, 288);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "LOCACIÓN";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "NRO. PEDIDO";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "COD. CLIENTE";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "F. CREACIÓN";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "COD. VENDEDOR";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "NRO. RUC";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "DOC CLIENTE";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "OBSERVACIÓN";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "ESTADO DE VENTA";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "USUARIO";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "FECHA";
            this.Column11.Name = "Column11";
            // 
            // cblocacion
            // 
            this.cblocacion.FormattingEnabled = true;
            this.cblocacion.Location = new System.Drawing.Point(29, 99);
            this.cblocacion.Name = "cblocacion";
            this.cblocacion.Size = new System.Drawing.Size(152, 21);
            this.cblocacion.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(28, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "REGISTRO DE VENTAS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Locación";
            // 
            // txtpedido
            // 
            this.txtpedido.Location = new System.Drawing.Point(29, 143);
            this.txtpedido.Name = "txtpedido";
            this.txtpedido.Size = new System.Drawing.Size(152, 20);
            this.txtpedido.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nro. Pedido";
            // 
            // cbcliente
            // 
            this.cbcliente.FormattingEnabled = true;
            this.cbcliente.Location = new System.Drawing.Point(29, 193);
            this.cbcliente.Name = "cbcliente";
            this.cbcliente.Size = new System.Drawing.Size(152, 21);
            this.cbcliente.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Codigo del Cliente";
            // 
            // txtfechacreacion
            // 
            this.txtfechacreacion.Location = new System.Drawing.Point(205, 100);
            this.txtfechacreacion.Name = "txtfechacreacion";
            this.txtfechacreacion.Size = new System.Drawing.Size(152, 20);
            this.txtfechacreacion.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(205, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fecha Creacion";
            // 
            // cbvendedor
            // 
            this.cbvendedor.FormattingEnabled = true;
            this.cbvendedor.Location = new System.Drawing.Point(205, 143);
            this.cbvendedor.Name = "cbvendedor";
            this.cbvendedor.Size = new System.Drawing.Size(152, 21);
            this.cbvendedor.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(205, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Código del Vendedor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(208, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Nro. RUC";
            // 
            // txtruc
            // 
            this.txtruc.Location = new System.Drawing.Point(205, 194);
            this.txtruc.Name = "txtruc";
            this.txtruc.Size = new System.Drawing.Size(152, 20);
            this.txtruc.TabIndex = 13;
            // 
            // txtdoccliente
            // 
            this.txtdoccliente.Location = new System.Drawing.Point(391, 100);
            this.txtdoccliente.Name = "txtdoccliente";
            this.txtdoccliente.Size = new System.Drawing.Size(152, 20);
            this.txtdoccliente.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(388, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Doc. Cliente";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(571, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Estado de Venta";
            // 
            // chkestado
            // 
            this.chkestado.AutoSize = true;
            this.chkestado.Location = new System.Drawing.Point(571, 101);
            this.chkestado.Name = "chkestado";
            this.chkestado.Size = new System.Drawing.Size(94, 17);
            this.chkestado.TabIndex = 17;
            this.chkestado.Text = "Venta Cerrada";
            this.chkestado.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(391, 177);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Cod Usuario";
            // 
            // cbusuario
            // 
            this.cbusuario.FormattingEnabled = true;
            this.cbusuario.Location = new System.Drawing.Point(391, 194);
            this.cbusuario.Name = "cbusuario";
            this.cbusuario.Size = new System.Drawing.Size(152, 21);
            this.cbusuario.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(391, 127);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Fecha Registro";
            // 
            // txtfecha
            // 
            this.txtfecha.Location = new System.Drawing.Point(391, 143);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(152, 20);
            this.txtfecha.TabIndex = 21;
            // 
            // btnlistar
            // 
            this.btnlistar.Location = new System.Drawing.Point(35, 249);
            this.btnlistar.Name = "btnlistar";
            this.btnlistar.Size = new System.Drawing.Size(97, 44);
            this.btnlistar.TabIndex = 22;
            this.btnlistar.Text = "LISTAR";
            this.btnlistar.UseVisualStyleBackColor = true;
            this.btnlistar.Click += new System.EventHandler(this.btnlistar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(294, 249);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 44);
            this.button2.TabIndex = 23;
            this.button2.Text = "ACTUALIZAR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(164, 249);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(97, 44);
            this.btnagregar.TabIndex = 24;
            this.btnagregar.Text = "AGREGAR";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(424, 249);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 44);
            this.button4.TabIndex = 25;
            this.button4.Text = "GUARDAR ATC";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(546, 249);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(97, 44);
            this.button5.TabIndex = 26;
            this.button5.Text = "ELIMINAR";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(571, 127);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Observaciones";
            // 
            // txtobservaciones
            // 
            this.txtobservaciones.Location = new System.Drawing.Point(574, 143);
            this.txtobservaciones.Multiline = true;
            this.txtobservaciones.Name = "txtobservaciones";
            this.txtobservaciones.Size = new System.Drawing.Size(221, 73);
            this.txtobservaciones.TabIndex = 28;
            // 
            // CreacionDePedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 607);
            this.Controls.Add(this.txtobservaciones);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnlistar);
            this.Controls.Add(this.txtfecha);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbusuario);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.chkestado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtdoccliente);
            this.Controls.Add(this.txtruc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbvendedor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtfechacreacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbcliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtpedido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cblocacion);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreacionDePedidos";
            this.Text = "CreacionDePedidos";
            this.Load += new System.EventHandler(this.CreacionDePedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cblocacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpedido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbcliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtfechacreacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbvendedor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtruc;
        private System.Windows.Forms.TextBox txtdoccliente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkestado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbusuario;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtfecha;
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
        private System.Windows.Forms.Button btnlistar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtobservaciones;
    }
}