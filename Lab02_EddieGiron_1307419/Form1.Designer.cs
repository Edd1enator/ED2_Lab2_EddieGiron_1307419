namespace Lab02_EddieGiron_1307419
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstPersona = new System.Windows.Forms.ListBox();
            this.btnLista = new System.Windows.Forms.Button();
            this.txtBuscarC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuscarC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(535, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Exportar personas";
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(538, 268);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(75, 30);
            this.btnExportar.TabIndex = 18;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(194, 384);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(88, 46);
            this.btnAnterior.TabIndex = 17;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(288, 384);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(89, 46);
            this.btnSiguiente.TabIndex = 16;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(538, 125);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 22);
            this.txtBuscar.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(535, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Buscar persona";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(644, 121);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 30);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "Mostrar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(535, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Lista de personas";
            // 
            // lstPersona
            // 
            this.lstPersona.FormattingEnabled = true;
            this.lstPersona.ItemHeight = 16;
            this.lstPersona.Location = new System.Drawing.Point(82, 22);
            this.lstPersona.Name = "lstPersona";
            this.lstPersona.Size = new System.Drawing.Size(433, 356);
            this.lstPersona.TabIndex = 11;
            // 
            // btnLista
            // 
            this.btnLista.Location = new System.Drawing.Point(538, 48);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(75, 30);
            this.btnLista.TabIndex = 10;
            this.btnLista.Text = "Mostrar";
            this.btnLista.UseVisualStyleBackColor = true;
            this.btnLista.Click += new System.EventHandler(this.btnLista_Click);
            // 
            // txtBuscarC
            // 
            this.txtBuscarC.Location = new System.Drawing.Point(538, 196);
            this.txtBuscarC.Name = "txtBuscarC";
            this.txtBuscarC.Size = new System.Drawing.Size(100, 22);
            this.txtBuscarC.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(535, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Buscar por compañia";
            // 
            // btnBuscarC
            // 
            this.btnBuscarC.Location = new System.Drawing.Point(644, 192);
            this.btnBuscarC.Name = "btnBuscarC";
            this.btnBuscarC.Size = new System.Drawing.Size(75, 30);
            this.btnBuscarC.TabIndex = 20;
            this.btnBuscarC.Text = "Mostrar";
            this.btnBuscarC.UseVisualStyleBackColor = true;
            this.btnBuscarC.Click += new System.EventHandler(this.btnBuscarC_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBuscarC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBuscarC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstPersona);
            this.Controls.Add(this.btnLista);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstPersona;
        private System.Windows.Forms.Button btnLista;
        private System.Windows.Forms.TextBox txtBuscarC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBuscarC;
    }
}

