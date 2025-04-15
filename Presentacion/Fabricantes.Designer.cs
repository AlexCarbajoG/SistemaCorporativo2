namespace Presentacion
{
    partial class Fabricantes
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnlistar = new System.Windows.Forms.Button();
            this.cbpersona = new System.Windows.Forms.ComboBox();
            this.txtfabvricante = new System.Windows.Forms.TextBox();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(586, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(342, 537);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "COD FABRICANTE";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "COR PERSONA";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "FECHA";
            this.Column3.Name = "Column3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "COD FABRICANTE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "COD PERSONA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "FECHA";
            // 
            // btnlistar
            // 
            this.btnlistar.Location = new System.Drawing.Point(78, 310);
            this.btnlistar.Name = "btnlistar";
            this.btnlistar.Size = new System.Drawing.Size(94, 73);
            this.btnlistar.TabIndex = 4;
            this.btnlistar.Text = "LISTAR";
            this.btnlistar.UseVisualStyleBackColor = true;
            this.btnlistar.Click += new System.EventHandler(this.btnlistar_Click);
            // 
            // cbpersona
            // 
            this.cbpersona.FormattingEnabled = true;
            this.cbpersona.Location = new System.Drawing.Point(178, 103);
            this.cbpersona.Name = "cbpersona";
            this.cbpersona.Size = new System.Drawing.Size(171, 21);
            this.cbpersona.TabIndex = 5;
            // 
            // txtfabvricante
            // 
            this.txtfabvricante.Location = new System.Drawing.Point(178, 59);
            this.txtfabvricante.Name = "txtfabvricante";
            this.txtfabvricante.Size = new System.Drawing.Size(171, 20);
            this.txtfabvricante.TabIndex = 6;
            // 
            // txtfecha
            // 
            this.txtfecha.Location = new System.Drawing.Point(178, 144);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(171, 20);
            this.txtfecha.TabIndex = 7;
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(214, 310);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(94, 73);
            this.btnagregar.TabIndex = 8;
            this.btnagregar.Text = "AGREGAR";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(360, 310);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 73);
            this.button3.TabIndex = 9;
            this.button3.Text = "ACTUALIZAR";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(78, 405);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 73);
            this.button4.TabIndex = 10;
            this.button4.Text = "GUARDAR ACT";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(214, 405);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(94, 73);
            this.button5.TabIndex = 11;
            this.button5.Text = "ELIMINAR";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Fabricantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 607);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.txtfecha);
            this.Controls.Add(this.txtfabvricante);
            this.Controls.Add(this.cbpersona);
            this.Controls.Add(this.btnlistar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fabricantes";
            this.Text = "Fabricantes";
            this.Load += new System.EventHandler(this.Fabricantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnlistar;
        private System.Windows.Forms.ComboBox cbpersona;
        private System.Windows.Forms.TextBox txtfabvricante;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}