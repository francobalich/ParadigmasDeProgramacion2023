
namespace Simulador_de_personaje
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAtacar = new System.Windows.Forms.Button();
            this.btnDefender = new System.Windows.Forms.Button();
            this.btnDormir = new System.Windows.Forms.Button();
            this.btnSoltar = new System.Windows.Forms.Button();
            this.btnTomar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Simulador_de_personaje.Properties.Resources.robot;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(241, 292);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnAtacar
            // 
            this.btnAtacar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtacar.Location = new System.Drawing.Point(259, 12);
            this.btnAtacar.Name = "btnAtacar";
            this.btnAtacar.Size = new System.Drawing.Size(156, 53);
            this.btnAtacar.TabIndex = 1;
            this.btnAtacar.Text = "Atacar";
            this.btnAtacar.UseVisualStyleBackColor = true;
            this.btnAtacar.Click += new System.EventHandler(this.btnAtacar_Click);
            // 
            // btnDefender
            // 
            this.btnDefender.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDefender.Location = new System.Drawing.Point(259, 71);
            this.btnDefender.Name = "btnDefender";
            this.btnDefender.Size = new System.Drawing.Size(156, 53);
            this.btnDefender.TabIndex = 2;
            this.btnDefender.Text = "Defender";
            this.btnDefender.UseVisualStyleBackColor = true;
            this.btnDefender.Click += new System.EventHandler(this.btnDefender_Click);
            // 
            // btnDormir
            // 
            this.btnDormir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDormir.Location = new System.Drawing.Point(259, 130);
            this.btnDormir.Name = "btnDormir";
            this.btnDormir.Size = new System.Drawing.Size(156, 53);
            this.btnDormir.TabIndex = 3;
            this.btnDormir.Text = "Dormir";
            this.btnDormir.UseVisualStyleBackColor = true;
            this.btnDormir.Click += new System.EventHandler(this.btnDormir_Click);
            // 
            // btnSoltar
            // 
            this.btnSoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoltar.Location = new System.Drawing.Point(259, 251);
            this.btnSoltar.Name = "btnSoltar";
            this.btnSoltar.Size = new System.Drawing.Size(156, 53);
            this.btnSoltar.TabIndex = 5;
            this.btnSoltar.Text = "Soltar";
            this.btnSoltar.UseVisualStyleBackColor = true;
            this.btnSoltar.Click += new System.EventHandler(this.btnSoltar_Click);
            // 
            // btnTomar
            // 
            this.btnTomar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTomar.Location = new System.Drawing.Point(259, 192);
            this.btnTomar.Name = "btnTomar";
            this.btnTomar.Size = new System.Drawing.Size(156, 53);
            this.btnTomar.TabIndex = 4;
            this.btnTomar.Text = "Tomar";
            this.btnTomar.UseVisualStyleBackColor = true;
            this.btnTomar.Click += new System.EventHandler(this.btnTomar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 308);
            this.Controls.Add(this.btnSoltar);
            this.Controls.Add(this.btnTomar);
            this.Controls.Add(this.btnDormir);
            this.Controls.Add(this.btnDefender);
            this.Controls.Add(this.btnAtacar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAtacar;
        private System.Windows.Forms.Button btnDefender;
        private System.Windows.Forms.Button btnDormir;
        private System.Windows.Forms.Button btnSoltar;
        private System.Windows.Forms.Button btnTomar;
    }
}

