namespace Clicker
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
            this.pbxEnemy = new System.Windows.Forms.PictureBox();
            this.lblDamage = new System.Windows.Forms.Label();
            this.lblHealth = new System.Windows.Forms.Label();
            this.btnHit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEnemy)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxEnemy
            // 
            this.pbxEnemy.Image = global::Clicker.Properties.Resources.tierra;
            this.pbxEnemy.Location = new System.Drawing.Point(12, 12);
            this.pbxEnemy.Name = "pbxEnemy";
            this.pbxEnemy.Size = new System.Drawing.Size(250, 250);
            this.pbxEnemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxEnemy.TabIndex = 0;
            this.pbxEnemy.TabStop = false;
            this.pbxEnemy.Click += new System.EventHandler(this.pbxEnemy_Click);
            // 
            // lblDamage
            // 
            this.lblDamage.AutoSize = true;
            this.lblDamage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDamage.ForeColor = System.Drawing.Color.Red;
            this.lblDamage.Location = new System.Drawing.Point(12, 292);
            this.lblDamage.Name = "lblDamage";
            this.lblDamage.Size = new System.Drawing.Size(60, 24);
            this.lblDamage.TabIndex = 1;
            this.lblDamage.Text = "Daño:";
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHealth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblHealth.Location = new System.Drawing.Point(12, 268);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(58, 24);
            this.lblHealth.TabIndex = 2;
            this.lblHealth.Text = "Vida: ";
            // 
            // btnHit
            // 
            this.btnHit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHit.BackColor = System.Drawing.Color.Silver;
            this.btnHit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHit.Location = new System.Drawing.Point(16, 320);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(246, 54);
            this.btnHit.TabIndex = 3;
            this.btnHit.Text = "Picar";
            this.btnHit.UseVisualStyleBackColor = false;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(170, 268);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(92, 48);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(276, 386);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnHit);
            this.Controls.Add(this.lblHealth);
            this.Controls.Add(this.lblDamage);
            this.Controls.Add(this.pbxEnemy);
            this.Name = "Form1";
            this.Text = "Clicker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxEnemy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxEnemy;
        private System.Windows.Forms.Label lblDamage;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Button btnReset;
    }
}

