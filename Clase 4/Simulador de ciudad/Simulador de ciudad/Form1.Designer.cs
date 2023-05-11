namespace Simulador_de_ciudad
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
            this.btnVerCantidades = new System.Windows.Forms.Button();
            this.btnAgregarMonumento = new System.Windows.Forms.Button();
            this.btnAgragarConstruccion = new System.Windows.Forms.Button();
            this.btnAgregarCalle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVerCantidades
            // 
            this.btnVerCantidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerCantidades.Location = new System.Drawing.Point(12, 198);
            this.btnVerCantidades.Name = "btnVerCantidades";
            this.btnVerCantidades.Size = new System.Drawing.Size(237, 55);
            this.btnVerCantidades.TabIndex = 0;
            this.btnVerCantidades.Text = "Ver cantidad de elementos";
            this.btnVerCantidades.UseVisualStyleBackColor = true;
            this.btnVerCantidades.Click += new System.EventHandler(this.btnVerCantidades_Click);
            // 
            // btnAgregarMonumento
            // 
            this.btnAgregarMonumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMonumento.Location = new System.Drawing.Point(12, 137);
            this.btnAgregarMonumento.Name = "btnAgregarMonumento";
            this.btnAgregarMonumento.Size = new System.Drawing.Size(237, 55);
            this.btnAgregarMonumento.TabIndex = 1;
            this.btnAgregarMonumento.Text = "Agregar Monumento";
            this.btnAgregarMonumento.UseVisualStyleBackColor = true;
            this.btnAgregarMonumento.Click += new System.EventHandler(this.btnAgregarMonumento_Click);
            // 
            // btnAgragarConstruccion
            // 
            this.btnAgragarConstruccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgragarConstruccion.Location = new System.Drawing.Point(12, 15);
            this.btnAgragarConstruccion.Name = "btnAgragarConstruccion";
            this.btnAgragarConstruccion.Size = new System.Drawing.Size(237, 55);
            this.btnAgragarConstruccion.TabIndex = 2;
            this.btnAgragarConstruccion.Text = "Agregar Construccion";
            this.btnAgragarConstruccion.UseVisualStyleBackColor = true;
            this.btnAgragarConstruccion.Click += new System.EventHandler(this.btnAgragarConstruccion_Click);
            // 
            // btnAgregarCalle
            // 
            this.btnAgregarCalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCalle.Location = new System.Drawing.Point(12, 76);
            this.btnAgregarCalle.Name = "btnAgregarCalle";
            this.btnAgregarCalle.Size = new System.Drawing.Size(237, 55);
            this.btnAgregarCalle.TabIndex = 3;
            this.btnAgregarCalle.Text = "Agregar Calle";
            this.btnAgregarCalle.UseVisualStyleBackColor = true;
            this.btnAgregarCalle.Click += new System.EventHandler(this.btnAgregarCalle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 267);
            this.Controls.Add(this.btnAgregarCalle);
            this.Controls.Add(this.btnAgragarConstruccion);
            this.Controls.Add(this.btnAgregarMonumento);
            this.Controls.Add(this.btnVerCantidades);
            this.Name = "Form1";
            this.Text = "Simulador de ciudad";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVerCantidades;
        private System.Windows.Forms.Button btnAgregarMonumento;
        private System.Windows.Forms.Button btnAgragarConstruccion;
        private System.Windows.Forms.Button btnAgregarCalle;
    }
}

