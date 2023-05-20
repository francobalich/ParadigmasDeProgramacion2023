namespace Simulador_de_horno
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
            this.trbTemp = new System.Windows.Forms.TrackBar();
            this.txtElemento = new System.Windows.Forms.TextBox();
            this.lblElemento = new System.Windows.Forms.Label();
            this.lblTemperaturaCoccion = new System.Windows.Forms.Label();
            this.txtTemperatura = new System.Windows.Forms.TextBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trbTemp)).BeginInit();
            this.SuspendLayout();
            // 
            // trbTemp
            // 
            this.trbTemp.Location = new System.Drawing.Point(3, 74);
            this.trbTemp.Maximum = 200;
            this.trbTemp.Name = "trbTemp";
            this.trbTemp.Size = new System.Drawing.Size(785, 45);
            this.trbTemp.TabIndex = 2;
            this.trbTemp.Value = 20;
            this.trbTemp.Scroll += new System.EventHandler(this.trbTemp_Scroll);
            // 
            // txtElemento
            // 
            this.txtElemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtElemento.Location = new System.Drawing.Point(85, 28);
            this.txtElemento.Name = "txtElemento";
            this.txtElemento.Size = new System.Drawing.Size(157, 22);
            this.txtElemento.TabIndex = 0;
            this.txtElemento.TextChanged += new System.EventHandler(this.txtElemento_TextChanged);
            // 
            // lblElemento
            // 
            this.lblElemento.AutoSize = true;
            this.lblElemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElemento.Location = new System.Drawing.Point(12, 31);
            this.lblElemento.Name = "lblElemento";
            this.lblElemento.Size = new System.Drawing.Size(67, 16);
            this.lblElemento.TabIndex = 2;
            this.lblElemento.Text = "Elemento:";
            // 
            // lblTemperaturaCoccion
            // 
            this.lblTemperaturaCoccion.AutoSize = true;
            this.lblTemperaturaCoccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperaturaCoccion.Location = new System.Drawing.Point(260, 31);
            this.lblTemperaturaCoccion.Name = "lblTemperaturaCoccion";
            this.lblTemperaturaCoccion.Size = new System.Drawing.Size(157, 16);
            this.lblTemperaturaCoccion.TabIndex = 4;
            this.lblTemperaturaCoccion.Text = "Temperatura de cocción:";
            // 
            // txtTemperatura
            // 
            this.txtTemperatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTemperatura.Location = new System.Drawing.Point(423, 28);
            this.txtTemperatura.Name = "txtTemperatura";
            this.txtTemperatura.Size = new System.Drawing.Size(157, 22);
            this.txtTemperatura.TabIndex = 1;
            this.txtTemperatura.Text = "200";
            this.txtTemperatura.TextChanged += new System.EventHandler(this.txtTemperatura_TextChanged);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(9, 122);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(11, 16);
            this.lblMensaje.TabIndex = 5;
            this.lblMensaje.Text = "-";
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp.Location = new System.Drawing.Point(721, 122);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(34, 16);
            this.lblTemp.TabIndex = 6;
            this.lblTemp.Text = "20°C";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 147);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.lblTemperaturaCoccion);
            this.Controls.Add(this.txtTemperatura);
            this.Controls.Add(this.lblElemento);
            this.Controls.Add(this.txtElemento);
            this.Controls.Add(this.trbTemp);
            this.Name = "Form1";
            this.Text = "Simulador de horno";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trbTemp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trbTemp;
        private System.Windows.Forms.TextBox txtElemento;
        private System.Windows.Forms.Label lblElemento;
        private System.Windows.Forms.Label lblTemperaturaCoccion;
        private System.Windows.Forms.TextBox txtTemperatura;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label lblTemp;
    }
}

