namespace Encuentra_al_impostor
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
            this.btnJugador1 = new System.Windows.Forms.Button();
            this.btnJugador2 = new System.Windows.Forms.Button();
            this.btnJugador3 = new System.Windows.Forms.Button();
            this.btnJugador4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnJugador1
            // 
            this.btnJugador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJugador1.Location = new System.Drawing.Point(12, 12);
            this.btnJugador1.Name = "btnJugador1";
            this.btnJugador1.Size = new System.Drawing.Size(151, 54);
            this.btnJugador1.TabIndex = 0;
            this.btnJugador1.Text = "Jugador 1";
            this.btnJugador1.UseVisualStyleBackColor = true;
            this.btnJugador1.Click += new System.EventHandler(this.btnJugador1_Click);
            // 
            // btnJugador2
            // 
            this.btnJugador2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJugador2.Location = new System.Drawing.Point(169, 12);
            this.btnJugador2.Name = "btnJugador2";
            this.btnJugador2.Size = new System.Drawing.Size(151, 54);
            this.btnJugador2.TabIndex = 1;
            this.btnJugador2.Text = "Jugador 2";
            this.btnJugador2.UseVisualStyleBackColor = true;
            this.btnJugador2.Click += new System.EventHandler(this.btnJugador2_Click);
            // 
            // btnJugador3
            // 
            this.btnJugador3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJugador3.Location = new System.Drawing.Point(12, 72);
            this.btnJugador3.Name = "btnJugador3";
            this.btnJugador3.Size = new System.Drawing.Size(151, 54);
            this.btnJugador3.TabIndex = 2;
            this.btnJugador3.Text = "Jugador 3";
            this.btnJugador3.UseVisualStyleBackColor = true;
            this.btnJugador3.Click += new System.EventHandler(this.btnJugador3_Click);
            // 
            // btnJugador4
            // 
            this.btnJugador4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJugador4.Location = new System.Drawing.Point(169, 72);
            this.btnJugador4.Name = "btnJugador4";
            this.btnJugador4.Size = new System.Drawing.Size(151, 54);
            this.btnJugador4.TabIndex = 3;
            this.btnJugador4.Text = "Jugador 4";
            this.btnJugador4.UseVisualStyleBackColor = true;
            this.btnJugador4.Click += new System.EventHandler(this.btnJugador4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 138);
            this.Controls.Add(this.btnJugador4);
            this.Controls.Add(this.btnJugador3);
            this.Controls.Add(this.btnJugador2);
            this.Controls.Add(this.btnJugador1);
            this.Name = "Form1";
            this.Text = "Encuentra al impostor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnJugador1;
        private System.Windows.Forms.Button btnJugador2;
        private System.Windows.Forms.Button btnJugador3;
        private System.Windows.Forms.Button btnJugador4;
    }
}

