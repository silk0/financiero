namespace Financiero.Vista
{
    partial class RecuperarSesion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxRecuperarUsuario = new System.Windows.Forms.GroupBox();
            this.labelCargando = new System.Windows.Forms.Label();
            this.pictureBoxCargando = new System.Windows.Forms.PictureBox();
            this.iconButtonVolver = new FontAwesome.Sharp.IconButton();
            this.iconButtonEnviarToken = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxValidarToken = new System.Windows.Forms.TextBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCorreo = new System.Windows.Forms.TextBox();
            this.iconButtonValidarToken = new FontAwesome.Sharp.IconButton();
            this.groupBoxRecuperarUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCargando)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxRecuperarUsuario
            // 
            this.groupBoxRecuperarUsuario.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxRecuperarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBoxRecuperarUsuario.Controls.Add(this.labelCargando);
            this.groupBoxRecuperarUsuario.Controls.Add(this.pictureBoxCargando);
            this.groupBoxRecuperarUsuario.Controls.Add(this.iconButtonVolver);
            this.groupBoxRecuperarUsuario.Controls.Add(this.iconButtonEnviarToken);
            this.groupBoxRecuperarUsuario.Controls.Add(this.label3);
            this.groupBoxRecuperarUsuario.Controls.Add(this.textBoxValidarToken);
            this.groupBoxRecuperarUsuario.Controls.Add(this.iconPictureBox1);
            this.groupBoxRecuperarUsuario.Controls.Add(this.label1);
            this.groupBoxRecuperarUsuario.Controls.Add(this.textBoxCorreo);
            this.groupBoxRecuperarUsuario.Controls.Add(this.iconButtonValidarToken);
            this.groupBoxRecuperarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxRecuperarUsuario.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxRecuperarUsuario.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBoxRecuperarUsuario.Location = new System.Drawing.Point(1, 0);
            this.groupBoxRecuperarUsuario.Name = "groupBoxRecuperarUsuario";
            this.groupBoxRecuperarUsuario.Size = new System.Drawing.Size(256, 510);
            this.groupBoxRecuperarUsuario.TabIndex = 6;
            this.groupBoxRecuperarUsuario.TabStop = false;
            this.groupBoxRecuperarUsuario.Text = "Recuperar Usuario";
            // 
            // labelCargando
            // 
            this.labelCargando.AutoSize = true;
            this.labelCargando.Font = new System.Drawing.Font("Georgia", 10F);
            this.labelCargando.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelCargando.Location = new System.Drawing.Point(56, 195);
            this.labelCargando.Name = "labelCargando";
            this.labelCargando.Size = new System.Drawing.Size(68, 17);
            this.labelCargando.TabIndex = 23;
            this.labelCargando.Text = "Cargando";
            // 
            // pictureBoxCargando
            // 
            this.pictureBoxCargando.Image = global::Financiero.Properties.Resources.Espere;
            this.pictureBoxCargando.Location = new System.Drawing.Point(15, 186);
            this.pictureBoxCargando.Name = "pictureBoxCargando";
            this.pictureBoxCargando.Size = new System.Drawing.Size(35, 35);
            this.pictureBoxCargando.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCargando.TabIndex = 22;
            this.pictureBoxCargando.TabStop = false;
            // 
            // iconButtonVolver
            // 
            this.iconButtonVolver.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.iconButtonVolver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.iconButtonVolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.iconButtonVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonVolver.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonVolver.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.iconButtonVolver.IconColor = System.Drawing.Color.MidnightBlue;
            this.iconButtonVolver.IconSize = 30;
            this.iconButtonVolver.Location = new System.Drawing.Point(13, 25);
            this.iconButtonVolver.Name = "iconButtonVolver";
            this.iconButtonVolver.Rotation = 0D;
            this.iconButtonVolver.Size = new System.Drawing.Size(40, 36);
            this.iconButtonVolver.TabIndex = 21;
            this.iconButtonVolver.Text = " ";
            this.iconButtonVolver.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButtonVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButtonVolver.UseVisualStyleBackColor = true;
            this.iconButtonVolver.Click += new System.EventHandler(this.iconButtonVolver_Click);
            // 
            // iconButtonEnviarToken
            // 
            this.iconButtonEnviarToken.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.iconButtonEnviarToken.FlatAppearance.BorderSize = 0;
            this.iconButtonEnviarToken.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.iconButtonEnviarToken.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.iconButtonEnviarToken.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonEnviarToken.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonEnviarToken.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonEnviarToken.ForeColor = System.Drawing.Color.MidnightBlue;
            this.iconButtonEnviarToken.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonEnviarToken.IconColor = System.Drawing.Color.Black;
            this.iconButtonEnviarToken.IconSize = 16;
            this.iconButtonEnviarToken.Location = new System.Drawing.Point(15, 292);
            this.iconButtonEnviarToken.Name = "iconButtonEnviarToken";
            this.iconButtonEnviarToken.Rotation = 0D;
            this.iconButtonEnviarToken.Size = new System.Drawing.Size(226, 35);
            this.iconButtonEnviarToken.TabIndex = 20;
            this.iconButtonEnviarToken.Text = "Enviar token";
            this.iconButtonEnviarToken.UseVisualStyleBackColor = false;
            this.iconButtonEnviarToken.Click += new System.EventHandler(this.iconButtonEnviarToken_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(11, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "Ingresar token";
            // 
            // textBoxValidarToken
            // 
            this.textBoxValidarToken.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxValidarToken.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxValidarToken.Enabled = false;
            this.textBoxValidarToken.Location = new System.Drawing.Point(15, 395);
            this.textBoxValidarToken.Name = "textBoxValidarToken";
            this.textBoxValidarToken.Size = new System.Drawing.Size(226, 26);
            this.textBoxValidarToken.TabIndex = 11;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserLock;
            this.iconPictureBox1.IconColor = System.Drawing.Color.MidnightBlue;
            this.iconPictureBox1.IconSize = 120;
            this.iconPictureBox1.Location = new System.Drawing.Point(70, 61);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(120, 121);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconPictureBox1.TabIndex = 10;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.WaitOnLoad = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(11, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Correo";
            // 
            // textBoxCorreo
            // 
            this.textBoxCorreo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxCorreo.Font = new System.Drawing.Font("Georgia", 12F);
            this.textBoxCorreo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxCorreo.Location = new System.Drawing.Point(15, 260);
            this.textBoxCorreo.Name = "textBoxCorreo";
            this.textBoxCorreo.Size = new System.Drawing.Size(226, 26);
            this.textBoxCorreo.TabIndex = 7;
            // 
            // iconButtonValidarToken
            // 
            this.iconButtonValidarToken.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.iconButtonValidarToken.Enabled = false;
            this.iconButtonValidarToken.FlatAppearance.BorderSize = 0;
            this.iconButtonValidarToken.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.iconButtonValidarToken.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.iconButtonValidarToken.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonValidarToken.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonValidarToken.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonValidarToken.ForeColor = System.Drawing.Color.MidnightBlue;
            this.iconButtonValidarToken.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonValidarToken.IconColor = System.Drawing.Color.Black;
            this.iconButtonValidarToken.IconSize = 16;
            this.iconButtonValidarToken.Location = new System.Drawing.Point(15, 427);
            this.iconButtonValidarToken.Name = "iconButtonValidarToken";
            this.iconButtonValidarToken.Rotation = 0D;
            this.iconButtonValidarToken.Size = new System.Drawing.Size(226, 35);
            this.iconButtonValidarToken.TabIndex = 5;
            this.iconButtonValidarToken.Text = "Validar token";
            this.iconButtonValidarToken.UseVisualStyleBackColor = false;
            this.iconButtonValidarToken.Click += new System.EventHandler(this.iconButtonValidarToken_Click);
            // 
            // RecuperarSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(259, 510);
            this.Controls.Add(this.groupBoxRecuperarUsuario);
            this.Name = "RecuperarSesion";
            this.Text = "InicioSesion";
            this.groupBoxRecuperarUsuario.ResumeLayout(false);
            this.groupBoxRecuperarUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCargando)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBoxRecuperarUsuario;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCorreo;
        private FontAwesome.Sharp.IconButton iconButtonValidarToken;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxValidarToken;
        private FontAwesome.Sharp.IconButton iconButtonEnviarToken;
        private FontAwesome.Sharp.IconButton iconButtonVolver;
        private System.Windows.Forms.PictureBox pictureBoxCargando;
        private System.Windows.Forms.Label labelCargando;
    }
}