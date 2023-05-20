namespace Creador_de_personajes
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
            this.btnCrearHerrero = new System.Windows.Forms.Button();
            this.btnVerPersonajes = new System.Windows.Forms.Button();
            this.btnGuerrero = new System.Windows.Forms.Button();
            this.btnCrearMago = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrearHerrero
            // 
            this.btnCrearHerrero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearHerrero.Location = new System.Drawing.Point(12, 142);
            this.btnCrearHerrero.Name = "btnCrearHerrero";
            this.btnCrearHerrero.Size = new System.Drawing.Size(233, 59);
            this.btnCrearHerrero.TabIndex = 0;
            this.btnCrearHerrero.Text = "Crear herrero";
            this.btnCrearHerrero.UseVisualStyleBackColor = true;
            this.btnCrearHerrero.Click += new System.EventHandler(this.btnCrearHerrero_Click);
            // 
            // btnVerPersonajes
            // 
            this.btnVerPersonajes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerPersonajes.Location = new System.Drawing.Point(12, 207);
            this.btnVerPersonajes.Name = "btnVerPersonajes";
            this.btnVerPersonajes.Size = new System.Drawing.Size(233, 59);
            this.btnVerPersonajes.TabIndex = 1;
            this.btnVerPersonajes.Text = "Ver personajes";
            this.btnVerPersonajes.UseVisualStyleBackColor = true;
            this.btnVerPersonajes.Click += new System.EventHandler(this.btnVerPersonajes_Click);
            // 
            // btnGuerrero
            // 
            this.btnGuerrero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuerrero.Location = new System.Drawing.Point(12, 77);
            this.btnGuerrero.Name = "btnGuerrero";
            this.btnGuerrero.Size = new System.Drawing.Size(233, 59);
            this.btnGuerrero.TabIndex = 2;
            this.btnGuerrero.Text = "Crear guerrero";
            this.btnGuerrero.UseVisualStyleBackColor = true;
            this.btnGuerrero.Click += new System.EventHandler(this.btnGuerrero_Click);
            // 
            // btnCrearMago
            // 
            this.btnCrearMago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearMago.Location = new System.Drawing.Point(12, 12);
            this.btnCrearMago.Name = "btnCrearMago";
            this.btnCrearMago.Size = new System.Drawing.Size(233, 59);
            this.btnCrearMago.TabIndex = 3;
            this.btnCrearMago.Text = "Crear mago";
            this.btnCrearMago.UseVisualStyleBackColor = true;
            this.btnCrearMago.Click += new System.EventHandler(this.btnCrearMago_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 278);
            this.Controls.Add(this.btnCrearMago);
            this.Controls.Add(this.btnGuerrero);
            this.Controls.Add(this.btnVerPersonajes);
            this.Controls.Add(this.btnCrearHerrero);
            this.Name = "Form1";
            this.Text = "Creador de personajes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearHerrero;
        private System.Windows.Forms.Button btnVerPersonajes;
        private System.Windows.Forms.Button btnGuerrero;
        private System.Windows.Forms.Button btnCrearMago;
    }
}

