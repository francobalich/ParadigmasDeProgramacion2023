
namespace Juego_de_cartas
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
            this.pbxTriangulo = new System.Windows.Forms.PictureBox();
            this.pbxCirculo = new System.Windows.Forms.PictureBox();
            this.pbxCartaA = new System.Windows.Forms.PictureBox();
            this.pbxCartaB = new System.Windows.Forms.PictureBox();
            this.pbxCartaC = new System.Windows.Forms.PictureBox();
            this.pbxCartaD = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCartaABuscar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTriangulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCirculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCartaA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCartaB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCartaC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCartaD)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxTriangulo
            // 
            this.pbxTriangulo.Image = global::Juego_de_cartas.Properties.Resources.Carta_triangular;
            this.pbxTriangulo.Location = new System.Drawing.Point(1017, 40);
            this.pbxTriangulo.Name = "pbxTriangulo";
            this.pbxTriangulo.Size = new System.Drawing.Size(191, 269);
            this.pbxTriangulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxTriangulo.TabIndex = 2;
            this.pbxTriangulo.TabStop = false;
            // 
            // pbxCirculo
            // 
            this.pbxCirculo.Image = global::Juego_de_cartas.Properties.Resources.Carta_circular;
            this.pbxCirculo.Location = new System.Drawing.Point(820, 40);
            this.pbxCirculo.Name = "pbxCirculo";
            this.pbxCirculo.Size = new System.Drawing.Size(191, 269);
            this.pbxCirculo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCirculo.TabIndex = 1;
            this.pbxCirculo.TabStop = false;
            // 
            // pbxCartaA
            // 
            this.pbxCartaA.Image = global::Juego_de_cartas.Properties.Resources.Reverso;
            this.pbxCartaA.Location = new System.Drawing.Point(9, 40);
            this.pbxCartaA.Name = "pbxCartaA";
            this.pbxCartaA.Size = new System.Drawing.Size(191, 269);
            this.pbxCartaA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCartaA.TabIndex = 0;
            this.pbxCartaA.TabStop = false;
            this.pbxCartaA.Click += new System.EventHandler(this.pbxCartaA_Click);
            // 
            // pbxCartaB
            // 
            this.pbxCartaB.Image = global::Juego_de_cartas.Properties.Resources.Reverso;
            this.pbxCartaB.Location = new System.Drawing.Point(206, 40);
            this.pbxCartaB.Name = "pbxCartaB";
            this.pbxCartaB.Size = new System.Drawing.Size(191, 269);
            this.pbxCartaB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCartaB.TabIndex = 3;
            this.pbxCartaB.TabStop = false;
            this.pbxCartaB.Click += new System.EventHandler(this.pbxCartaB_Click);
            // 
            // pbxCartaC
            // 
            this.pbxCartaC.Image = global::Juego_de_cartas.Properties.Resources.Reverso;
            this.pbxCartaC.Location = new System.Drawing.Point(403, 40);
            this.pbxCartaC.Name = "pbxCartaC";
            this.pbxCartaC.Size = new System.Drawing.Size(191, 269);
            this.pbxCartaC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCartaC.TabIndex = 4;
            this.pbxCartaC.TabStop = false;
            this.pbxCartaC.Click += new System.EventHandler(this.pbxCartaC_Click);
            // 
            // pbxCartaD
            // 
            this.pbxCartaD.Image = global::Juego_de_cartas.Properties.Resources.Reverso;
            this.pbxCartaD.Location = new System.Drawing.Point(600, 40);
            this.pbxCartaD.Name = "pbxCartaD";
            this.pbxCartaD.Size = new System.Drawing.Size(191, 269);
            this.pbxCartaD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCartaD.TabIndex = 5;
            this.pbxCartaD.TabStop = false;
            this.pbxCartaD.Click += new System.EventHandler(this.pbxCartaD_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Carta a buscar:";
            // 
            // lblCartaABuscar
            // 
            this.lblCartaABuscar.AutoSize = true;
            this.lblCartaABuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCartaABuscar.Location = new System.Drawing.Point(157, 9);
            this.lblCartaABuscar.Name = "lblCartaABuscar";
            this.lblCartaABuscar.Size = new System.Drawing.Size(16, 24);
            this.lblCartaABuscar.TabIndex = 7;
            this.lblCartaABuscar.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 318);
            this.Controls.Add(this.lblCartaABuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbxCartaD);
            this.Controls.Add(this.pbxCartaC);
            this.Controls.Add(this.pbxCartaB);
            this.Controls.Add(this.pbxTriangulo);
            this.Controls.Add(this.pbxCirculo);
            this.Controls.Add(this.pbxCartaA);
            this.Name = "Form1";
            this.Text = "Juego de cartas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxTriangulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCirculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCartaA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCartaB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCartaC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCartaD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxCartaA;
        private System.Windows.Forms.PictureBox pbxCirculo;
        private System.Windows.Forms.PictureBox pbxTriangulo;
        private System.Windows.Forms.PictureBox pbxCartaB;
        private System.Windows.Forms.PictureBox pbxCartaC;
        private System.Windows.Forms.PictureBox pbxCartaD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCartaABuscar;
    }
}

