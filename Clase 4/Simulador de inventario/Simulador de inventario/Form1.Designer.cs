namespace Simulador_de_inventario
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
            this.btnAgregarMesa = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnAgregarCama = new System.Windows.Forms.Button();
            this.btnAgregarEspada = new System.Windows.Forms.Button();
            this.btnAgregarPico = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAgregarMesa
            // 
            this.btnAgregarMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMesa.Location = new System.Drawing.Point(12, 76);
            this.btnAgregarMesa.Name = "btnAgregarMesa";
            this.btnAgregarMesa.Size = new System.Drawing.Size(236, 60);
            this.btnAgregarMesa.TabIndex = 0;
            this.btnAgregarMesa.Text = "Agregar mesa";
            this.btnAgregarMesa.UseVisualStyleBackColor = true;
            this.btnAgregarMesa.Click += new System.EventHandler(this.btnAgregarMesa_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.Location = new System.Drawing.Point(12, 142);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(478, 60);
            this.btnInventario.TabIndex = 1;
            this.btnInventario.Text = "Ver inventario";
            this.btnInventario.UseVisualStyleBackColor = true;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // btnAgregarCama
            // 
            this.btnAgregarCama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCama.Location = new System.Drawing.Point(254, 76);
            this.btnAgregarCama.Name = "btnAgregarCama";
            this.btnAgregarCama.Size = new System.Drawing.Size(236, 60);
            this.btnAgregarCama.TabIndex = 2;
            this.btnAgregarCama.Text = "Agregar cama";
            this.btnAgregarCama.UseVisualStyleBackColor = true;
            this.btnAgregarCama.Click += new System.EventHandler(this.btnAgregarCama_Click);
            // 
            // btnAgregarEspada
            // 
            this.btnAgregarEspada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarEspada.Location = new System.Drawing.Point(12, 12);
            this.btnAgregarEspada.Name = "btnAgregarEspada";
            this.btnAgregarEspada.Size = new System.Drawing.Size(236, 60);
            this.btnAgregarEspada.TabIndex = 3;
            this.btnAgregarEspada.Text = "Agregar espada";
            this.btnAgregarEspada.UseVisualStyleBackColor = true;
            this.btnAgregarEspada.Click += new System.EventHandler(this.btnAgregarEspada_Click);
            // 
            // btnAgregarPico
            // 
            this.btnAgregarPico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPico.Location = new System.Drawing.Point(254, 12);
            this.btnAgregarPico.Name = "btnAgregarPico";
            this.btnAgregarPico.Size = new System.Drawing.Size(236, 60);
            this.btnAgregarPico.TabIndex = 4;
            this.btnAgregarPico.Text = "Agregar pico";
            this.btnAgregarPico.UseVisualStyleBackColor = true;
            this.btnAgregarPico.Click += new System.EventHandler(this.btnAgregarPico_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 214);
            this.Controls.Add(this.btnAgregarPico);
            this.Controls.Add(this.btnAgregarEspada);
            this.Controls.Add(this.btnAgregarCama);
            this.Controls.Add(this.btnInventario);
            this.Controls.Add(this.btnAgregarMesa);
            this.Name = "Form1";
            this.Text = "Simulador de inventario";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarMesa;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnAgregarCama;
        private System.Windows.Forms.Button btnAgregarEspada;
        private System.Windows.Forms.Button btnAgregarPico;
    }
}

