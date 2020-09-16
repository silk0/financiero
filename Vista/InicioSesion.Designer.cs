namespace Financiero
{
    partial class InicioSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioSesion));
            this.groupBoxCargando = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCargando = new System.Windows.Forms.PictureBox();
            this.labelEspere = new System.Windows.Forms.Label();
            this.groupBoxCargando.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCargando)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCargando
            // 
            this.groupBoxCargando.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBoxCargando.Controls.Add(this.labelEspere);
            this.groupBoxCargando.Controls.Add(this.pictureBoxCargando);
            this.groupBoxCargando.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxCargando.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.groupBoxCargando.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBoxCargando.Location = new System.Drawing.Point(690, 12);
            this.groupBoxCargando.Name = "groupBoxCargando";
            this.groupBoxCargando.Size = new System.Drawing.Size(256, 510);
            this.groupBoxCargando.TabIndex = 5;
            this.groupBoxCargando.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(672, 510);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxCargando
            // 
            this.pictureBoxCargando.Image = global::Financiero.Properties.Resources.Espere;
            this.pictureBoxCargando.Location = new System.Drawing.Point(100, 212);
            this.pictureBoxCargando.Name = "pictureBoxCargando";
            this.pictureBoxCargando.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxCargando.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCargando.TabIndex = 15;
            this.pictureBoxCargando.TabStop = false;
            // 
            // labelEspere
            // 
            this.labelEspere.AutoSize = true;
            this.labelEspere.Location = new System.Drawing.Point(82, 265);
            this.labelEspere.Name = "labelEspere";
            this.labelEspere.Size = new System.Drawing.Size(88, 18);
            this.labelEspere.TabIndex = 16;
            this.labelEspere.Text = "Cargando";
            // 
            // InicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(958, 534);
            this.Controls.Add(this.groupBoxCargando);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "InicioSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Financiero";
            this.groupBoxCargando.ResumeLayout(false);
            this.groupBoxCargando.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCargando)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.GroupBox groupBoxCargando;
        private System.Windows.Forms.Label labelEspere;
        private System.Windows.Forms.PictureBox pictureBoxCargando;
    }
}

