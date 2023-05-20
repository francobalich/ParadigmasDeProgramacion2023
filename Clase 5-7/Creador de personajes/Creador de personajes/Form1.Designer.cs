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
            this.btnCrearPersonajes = new System.Windows.Forms.Button();
            this.btnVerPersonaje = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCrearPersonajes
            // 
            this.btnCrearPersonajes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearPersonajes.Location = new System.Drawing.Point(12, 275);
            this.btnCrearPersonajes.Name = "btnCrearPersonajes";
            this.btnCrearPersonajes.Size = new System.Drawing.Size(233, 59);
            this.btnCrearPersonajes.TabIndex = 0;
            this.btnCrearPersonajes.Text = "Crear personaje";
            this.btnCrearPersonajes.UseVisualStyleBackColor = true;
            this.btnCrearPersonajes.Click += new System.EventHandler(this.btnCrearPersonajes_Click);
            // 
            // btnVerPersonaje
            // 
            this.btnVerPersonaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerPersonaje.Location = new System.Drawing.Point(12, 340);
            this.btnVerPersonaje.Name = "btnVerPersonaje";
            this.btnVerPersonaje.Size = new System.Drawing.Size(233, 59);
            this.btnVerPersonaje.TabIndex = 1;
            this.btnVerPersonaje.Text = "Ver personaje";
            this.btnVerPersonaje.UseVisualStyleBackColor = true;
            this.btnVerPersonaje.Click += new System.EventHandler(this.btnVerPersonaje_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Creador_de_personajes.Properties.Resources.robot;
            this.pictureBox1.Location = new System.Drawing.Point(27, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 257);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 412);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnVerPersonaje);
            this.Controls.Add(this.btnCrearPersonajes);
            this.Name = "Form1";
            this.Text = "Creador de personajes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearPersonajes;
        private System.Windows.Forms.Button btnVerPersonaje;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

