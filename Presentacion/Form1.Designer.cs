namespace Presentacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnPrueba = new System.Windows.Forms.Button();
            this.lbl_Resultado = new System.Windows.Forms.Label();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_AltaLibro = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Consulta = new System.Windows.Forms.Button();
            this.btn_ConsultaConUnidades = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnPrueba
            // 
            this.BtnPrueba.Location = new System.Drawing.Point(76, 40);
            this.BtnPrueba.Name = "BtnPrueba";
            this.BtnPrueba.Size = new System.Drawing.Size(143, 102);
            this.BtnPrueba.TabIndex = 0;
            this.BtnPrueba.Text = "Prueba De Conexión";
            this.BtnPrueba.UseVisualStyleBackColor = true;
            this.BtnPrueba.Click += new System.EventHandler(this.BtnPrueba_Click);
            // 
            // lbl_Resultado
            // 
            this.lbl_Resultado.AutoSize = true;
            this.lbl_Resultado.Location = new System.Drawing.Point(402, 81);
            this.lbl_Resultado.Name = "lbl_Resultado";
            this.lbl_Resultado.Size = new System.Drawing.Size(51, 20);
            this.lbl_Resultado.TabIndex = 1;
            this.lbl_Resultado.Text = "label1";
            this.lbl_Resultado.Visible = false;
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(253, 40);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(143, 102);
            this.btn_Modificar.TabIndex = 2;
            this.btn_Modificar.Text = "Modificacion de Libro";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_AltaLibro
            // 
            this.btn_AltaLibro.Location = new System.Drawing.Point(76, 236);
            this.btn_AltaLibro.Name = "btn_AltaLibro";
            this.btn_AltaLibro.Size = new System.Drawing.Size(143, 102);
            this.btn_AltaLibro.TabIndex = 3;
            this.btn_AltaLibro.Text = "Alta de Libro";
            this.btn_AltaLibro.UseVisualStyleBackColor = true;
            this.btn_AltaLibro.Click += new System.EventHandler(this.btn_AltaLibro_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(253, 236);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(143, 102);
            this.btn_Eliminar.TabIndex = 4;
            this.btn_Eliminar.Text = "Eliminación de Libro";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(53, 426);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(891, 201);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGriView1_CellContentClick);
            // 
            // btn_Consulta
            // 
            this.btn_Consulta.Location = new System.Drawing.Point(694, 40);
            this.btn_Consulta.Name = "btn_Consulta";
            this.btn_Consulta.Size = new System.Drawing.Size(154, 102);
            this.btn_Consulta.TabIndex = 6;
            this.btn_Consulta.Text = "Consulta de Libros";
            this.btn_Consulta.UseVisualStyleBackColor = true;
            this.btn_Consulta.Click += new System.EventHandler(this.btn_Consulta_Click);
            // 
            // btn_ConsultaConUnidades
            // 
            this.btn_ConsultaConUnidades.Location = new System.Drawing.Point(694, 236);
            this.btn_ConsultaConUnidades.Name = "btn_ConsultaConUnidades";
            this.btn_ConsultaConUnidades.Size = new System.Drawing.Size(154, 102);
            this.btn_ConsultaConUnidades.TabIndex = 7;
            this.btn_ConsultaConUnidades.Text = "Consulta de Libros con Unidades";
            this.btn_ConsultaConUnidades.UseVisualStyleBackColor = true;
            this.btn_ConsultaConUnidades.Click += new System.EventHandler(this.btn_ConsultaConUnidades_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 684);
            this.Controls.Add(this.btn_ConsultaConUnidades);
            this.Controls.Add(this.btn_Consulta);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_AltaLibro);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.lbl_Resultado);
            this.Controls.Add(this.BtnPrueba);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnPrueba;
        private System.Windows.Forms.Label lbl_Resultado;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_AltaLibro;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Consulta;
        private System.Windows.Forms.Button btn_ConsultaConUnidades;
    }
}

