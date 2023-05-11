
namespace Duelo_de_suerte_C
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
            this.btnJugadorA = new System.Windows.Forms.Button();
            this.btnJugadorB = new System.Windows.Forms.Button();
            this.lblNumA = new System.Windows.Forms.Label();
            this.lblNumB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnJugadorA
            // 
            this.btnJugadorA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJugadorA.Location = new System.Drawing.Point(9, 12);
            this.btnJugadorA.Name = "btnJugadorA";
            this.btnJugadorA.Size = new System.Drawing.Size(180, 62);
            this.btnJugadorA.TabIndex = 0;
            this.btnJugadorA.Text = "Jugador A";
            this.btnJugadorA.UseVisualStyleBackColor = true;
            this.btnJugadorA.Click += new System.EventHandler(this.btnJugadorA_Click);
            // 
            // btnJugadorB
            // 
            this.btnJugadorB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJugadorB.Location = new System.Drawing.Point(195, 12);
            this.btnJugadorB.Name = "btnJugadorB";
            this.btnJugadorB.Size = new System.Drawing.Size(180, 62);
            this.btnJugadorB.TabIndex = 1;
            this.btnJugadorB.Text = "Jugador B";
            this.btnJugadorB.UseVisualStyleBackColor = true;
            this.btnJugadorB.Click += new System.EventHandler(this.btnJugadorB_Click);
            // 
            // lblNumA
            // 
            this.lblNumA.AutoSize = true;
            this.lblNumA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumA.Location = new System.Drawing.Point(103, 77);
            this.lblNumA.Name = "lblNumA";
            this.lblNumA.Size = new System.Drawing.Size(16, 24);
            this.lblNumA.TabIndex = 2;
            this.lblNumA.Text = "-";
            // 
            // lblNumB
            // 
            this.lblNumB.AutoSize = true;
            this.lblNumB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumB.Location = new System.Drawing.Point(280, 77);
            this.lblNumB.Name = "lblNumB";
            this.lblNumB.Size = new System.Drawing.Size(16, 24);
            this.lblNumB.TabIndex = 3;
            this.lblNumB.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 111);
            this.Controls.Add(this.lblNumB);
            this.Controls.Add(this.lblNumA);
            this.Controls.Add(this.btnJugadorB);
            this.Controls.Add(this.btnJugadorA);
            this.Name = "Form1";
            this.Text = "Juego de la suerte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnJugadorA;
        private System.Windows.Forms.Button btnJugadorB;
        private System.Windows.Forms.Label lblNumA;
        private System.Windows.Forms.Label lblNumB;
    }
}

