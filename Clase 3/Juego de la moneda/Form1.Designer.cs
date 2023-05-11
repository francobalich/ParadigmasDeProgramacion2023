
namespace Juego_de_la_moneda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnJugar = new System.Windows.Forms.Button();
            this.pbxCara = new System.Windows.Forms.PictureBox();
            this.pbxCruz = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCara)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCruz)).BeginInit();
            this.SuspendLayout();
            // 
            // btnJugar
            // 
            this.btnJugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJugar.Location = new System.Drawing.Point(21, 268);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(250, 60);
            this.btnJugar.TabIndex = 0;
            this.btnJugar.Text = "Jugar";
            this.btnJugar.UseVisualStyleBackColor = true;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // pbxCara
            // 
            this.pbxCara.Image = ((System.Drawing.Image)(resources.GetObject("pbxCara.Image")));
            this.pbxCara.Location = new System.Drawing.Point(21, 12);
            this.pbxCara.Name = "pbxCara";
            this.pbxCara.Size = new System.Drawing.Size(250, 250);
            this.pbxCara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCara.TabIndex = 1;
            this.pbxCara.TabStop = false;
            // 
            // pbxCruz
            // 
            this.pbxCruz.Image = ((System.Drawing.Image)(resources.GetObject("pbxCruz.Image")));
            this.pbxCruz.Location = new System.Drawing.Point(21, 12);
            this.pbxCruz.Name = "pbxCruz";
            this.pbxCruz.Size = new System.Drawing.Size(250, 250);
            this.pbxCruz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCruz.TabIndex = 2;
            this.pbxCruz.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(292, 342);
            this.Controls.Add(this.pbxCruz);
            this.Controls.Add(this.pbxCara);
            this.Controls.Add(this.btnJugar);
            this.Name = "Form1";
            this.Text = "Juego de la moneda";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxCara)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCruz)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.PictureBox pbxCara;
        private System.Windows.Forms.PictureBox pbxCruz;
    }
}

