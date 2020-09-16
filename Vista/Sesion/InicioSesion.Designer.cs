namespace Financiero.Vista
{
    partial class InicioSesion
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
            this.groupBoxInicioSesion = new System.Windows.Forms.GroupBox();
            this.labelContrasenaMensaje = new System.Windows.Forms.Label();
            this.labelUsuarioMensaje = new System.Windows.Forms.Label();
            this.labelCargando = new System.Windows.Forms.Label();
            this.pictureBoxCargando = new System.Windows.Forms.PictureBox();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.textBoxContrasena = new System.Windows.Forms.TextBox();
            this.linkLabelRecuperarSesion = new System.Windows.Forms.LinkLabel();
            this.linkLabelNuevoUsuario = new System.Windows.Forms.LinkLabel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.iconButtonCancelar = new FontAwesome.Sharp.IconButton();
            this.iconButtonIniciar = new FontAwesome.Sharp.IconButton();
            this.groupBoxInicioSesion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCargando)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxInicioSesion
            // 
            this.groupBoxInicioSesion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxInicioSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBoxInicioSesion.Controls.Add(this.labelContrasenaMensaje);
            this.groupBoxInicioSesion.Controls.Add(this.labelUsuarioMensaje);
            this.groupBoxInicioSesion.Controls.Add(this.labelCargando);
            this.groupBoxInicioSesion.Controls.Add(this.pictureBoxCargando);
            this.groupBoxInicioSesion.Controls.Add(this.iconPictureBox3);
            this.groupBoxInicioSesion.Controls.Add(this.iconPictureBox2);
            this.groupBoxInicioSesion.Controls.Add(this.textBoxContrasena);
            this.groupBoxInicioSesion.Controls.Add(this.linkLabelRecuperarSesion);
            this.groupBoxInicioSesion.Controls.Add(this.linkLabelNuevoUsuario);
            this.groupBoxInicioSesion.Controls.Add(this.iconPictureBox1);
            this.groupBoxInicioSesion.Controls.Add(this.label2);
            this.groupBoxInicioSesion.Controls.Add(this.label1);
            this.groupBoxInicioSesion.Controls.Add(this.textBoxUsuario);
            this.groupBoxInicioSesion.Controls.Add(this.iconButtonCancelar);
            this.groupBoxInicioSesion.Controls.Add(this.iconButtonIniciar);
            this.groupBoxInicioSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxInicioSesion.Font = new System.Drawing.Font("Georgia", 12F);
            this.groupBoxInicioSesion.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBoxInicioSesion.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInicioSesion.Name = "groupBoxInicioSesion";
            this.groupBoxInicioSesion.Size = new System.Drawing.Size(259, 510);
            this.groupBoxInicioSesion.TabIndex = 6;
            this.groupBoxInicioSesion.TabStop = false;
            this.groupBoxInicioSesion.Text = "Inicio de Sesion";
            // 
            // labelContrasenaMensaje
            // 
            this.labelContrasenaMensaje.AutoSize = true;
            this.labelContrasenaMensaje.Font = new System.Drawing.Font("Georgia", 10F);
            this.labelContrasenaMensaje.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelContrasenaMensaje.Location = new System.Drawing.Point(12, 371);
            this.labelContrasenaMensaje.Name = "labelContrasenaMensaje";
            this.labelContrasenaMensaje.Size = new System.Drawing.Size(79, 17);
            this.labelContrasenaMensaje.TabIndex = 27;
            this.labelContrasenaMensaje.Text = "Contrasena";
            // 
            // labelUsuarioMensaje
            // 
            this.labelUsuarioMensaje.AutoSize = true;
            this.labelUsuarioMensaje.Font = new System.Drawing.Font("Georgia", 10F);
            this.labelUsuarioMensaje.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelUsuarioMensaje.Location = new System.Drawing.Point(12, 302);
            this.labelUsuarioMensaje.Name = "labelUsuarioMensaje";
            this.labelUsuarioMensaje.Size = new System.Drawing.Size(58, 17);
            this.labelUsuarioMensaje.TabIndex = 26;
            this.labelUsuarioMensaje.Text = "Usuario";
            // 
            // labelCargando
            // 
            this.labelCargando.AutoSize = true;
            this.labelCargando.Font = new System.Drawing.Font("Georgia", 10F);
            this.labelCargando.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelCargando.Location = new System.Drawing.Point(56, 214);
            this.labelCargando.Name = "labelCargando";
            this.labelCargando.Size = new System.Drawing.Size(69, 17);
            this.labelCargando.TabIndex = 25;
            this.labelCargando.Text = "Buscando";
            // 
            // pictureBoxCargando
            // 
            this.pictureBoxCargando.Image = global::Financiero.Properties.Resources.Espere;
            this.pictureBoxCargando.Location = new System.Drawing.Point(15, 205);
            this.pictureBoxCargando.Name = "pictureBoxCargando";
            this.pictureBoxCargando.Size = new System.Drawing.Size(35, 35);
            this.pictureBoxCargando.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCargando.TabIndex = 24;
            this.pictureBoxCargando.TabStop = false;
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.iconPictureBox3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.UserLock;
            this.iconPictureBox3.IconColor = System.Drawing.Color.MidnightBlue;
            this.iconPictureBox3.IconSize = 22;
            this.iconPictureBox3.Location = new System.Drawing.Point(16, 420);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(22, 22);
            this.iconPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.iconPictureBox3.TabIndex = 15;
            this.iconPictureBox3.TabStop = false;
            this.iconPictureBox3.WaitOnLoad = true;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.iconPictureBox2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.iconPictureBox2.IconColor = System.Drawing.Color.MidnightBlue;
            this.iconPictureBox2.IconSize = 22;
            this.iconPictureBox2.Location = new System.Drawing.Point(16, 392);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(22, 22);
            this.iconPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.iconPictureBox2.TabIndex = 14;
            this.iconPictureBox2.TabStop = false;
            this.iconPictureBox2.WaitOnLoad = true;
            // 
            // textBoxContrasena
            // 
            this.textBoxContrasena.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxContrasena.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxContrasena.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.textBoxContrasena.Location = new System.Drawing.Point(15, 342);
            this.textBoxContrasena.Name = "textBoxContrasena";
            this.textBoxContrasena.PasswordChar = '*';
            this.textBoxContrasena.Size = new System.Drawing.Size(226, 26);
            this.textBoxContrasena.TabIndex = 13;
            // 
            // linkLabelRecuperarSesion
            // 
            this.linkLabelRecuperarSesion.AutoSize = true;
            this.linkLabelRecuperarSesion.Font = new System.Drawing.Font("Georgia", 10F);
            this.linkLabelRecuperarSesion.Location = new System.Drawing.Point(44, 420);
            this.linkLabelRecuperarSesion.Name = "linkLabelRecuperarSesion";
            this.linkLabelRecuperarSesion.Size = new System.Drawing.Size(118, 17);
            this.linkLabelRecuperarSesion.TabIndex = 12;
            this.linkLabelRecuperarSesion.TabStop = true;
            this.linkLabelRecuperarSesion.Text = "Recuperar Sesion";
            this.linkLabelRecuperarSesion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelRecuperarSesion_LinkClicked);
            // 
            // linkLabelNuevoUsuario
            // 
            this.linkLabelNuevoUsuario.AutoSize = true;
            this.linkLabelNuevoUsuario.Font = new System.Drawing.Font("Georgia", 10F);
            this.linkLabelNuevoUsuario.Location = new System.Drawing.Point(44, 392);
            this.linkLabelNuevoUsuario.Name = "linkLabelNuevoUsuario";
            this.linkLabelNuevoUsuario.Size = new System.Drawing.Size(103, 17);
            this.linkLabelNuevoUsuario.TabIndex = 11;
            this.linkLabelNuevoUsuario.TabStop = true;
            this.linkLabelNuevoUsuario.Text = "Nuevo Usuario";
            this.linkLabelNuevoUsuario.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelNuevoUsuario_LinkClicked);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.iconPictureBox1.IconColor = System.Drawing.Color.MidnightBlue;
            this.iconPictureBox1.IconSize = 215;
            this.iconPictureBox1.Location = new System.Drawing.Point(15, 25);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(226, 215);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconPictureBox1.TabIndex = 10;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.WaitOnLoad = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(11, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(11, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Usuario";
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxUsuario.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.textBoxUsuario.Location = new System.Drawing.Point(15, 273);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(226, 26);
            this.textBoxUsuario.TabIndex = 7;
            this.textBoxUsuario.KeyUp += new System.Windows.Forms.KeyEventHandler(this.extBoxUsuario_KeyUp);
            // 
            // iconButtonCancelar
            // 
            this.iconButtonCancelar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.iconButtonCancelar.FlatAppearance.BorderSize = 0;
            this.iconButtonCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.iconButtonCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.iconButtonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonCancelar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonCancelar.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonCancelar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.iconButtonCancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonCancelar.IconColor = System.Drawing.Color.Black;
            this.iconButtonCancelar.IconSize = 16;
            this.iconButtonCancelar.Location = new System.Drawing.Point(131, 451);
            this.iconButtonCancelar.Name = "iconButtonCancelar";
            this.iconButtonCancelar.Rotation = 0D;
            this.iconButtonCancelar.Size = new System.Drawing.Size(110, 35);
            this.iconButtonCancelar.TabIndex = 5;
            this.iconButtonCancelar.Text = "Cancelar";
            this.iconButtonCancelar.UseVisualStyleBackColor = false;
            this.iconButtonCancelar.Click += new System.EventHandler(this.iconButtonCancelar_Click);
            // 
            // iconButtonIniciar
            // 
            this.iconButtonIniciar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.iconButtonIniciar.FlatAppearance.BorderSize = 0;
            this.iconButtonIniciar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.iconButtonIniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.iconButtonIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonIniciar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonIniciar.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonIniciar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.iconButtonIniciar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonIniciar.IconColor = System.Drawing.Color.Black;
            this.iconButtonIniciar.IconSize = 16;
            this.iconButtonIniciar.Location = new System.Drawing.Point(15, 451);
            this.iconButtonIniciar.Name = "iconButtonIniciar";
            this.iconButtonIniciar.Rotation = 0D;
            this.iconButtonIniciar.Size = new System.Drawing.Size(110, 35);
            this.iconButtonIniciar.TabIndex = 4;
            this.iconButtonIniciar.Text = "Iniciar Sesion";
            this.iconButtonIniciar.UseVisualStyleBackColor = false;
            this.iconButtonIniciar.Click += new System.EventHandler(this.iconButtonIniciar_Click);
            // 
            // InicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(259, 510);
            this.Controls.Add(this.groupBoxInicioSesion);
            this.Name = "InicioSesion";
            this.Text = "InicioSesion";
            this.groupBoxInicioSesion.ResumeLayout(false);
            this.groupBoxInicioSesion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCargando)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBoxInicioSesion;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private FontAwesome.Sharp.IconButton iconButtonCancelar;
        private FontAwesome.Sharp.IconButton iconButtonIniciar;
        private System.Windows.Forms.LinkLabel linkLabelRecuperarSesion;
        private System.Windows.Forms.LinkLabel linkLabelNuevoUsuario;
        private System.Windows.Forms.TextBox textBoxContrasena;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private System.Windows.Forms.Label labelCargando;
        private System.Windows.Forms.PictureBox pictureBoxCargando;
        private System.Windows.Forms.Label labelContrasenaMensaje;
        private System.Windows.Forms.Label labelUsuarioMensaje;
    }
}