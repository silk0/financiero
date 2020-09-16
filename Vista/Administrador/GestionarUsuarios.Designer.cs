namespace Financiero
{
    partial class GestionarUsuarios
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionarUsuarios));
            this.Usuarios = new System.Windows.Forms.GroupBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxPersona = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxContrasena = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textBoxContrasena2 = new System.Windows.Forms.TextBox();
            this.iconButtonCancelar = new FontAwesome.Sharp.IconButton();
            this.iconButtonAgregar = new FontAwesome.Sharp.IconButton();
            this.labelTiempo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Usuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Usuarios
            // 
            this.Usuarios.BackColor = System.Drawing.Color.Transparent;
            this.Usuarios.Controls.Add(this.iconButton1);
            this.Usuarios.Controls.Add(this.textBox1);
            this.Usuarios.Controls.Add(this.dataGridView1);
            this.Usuarios.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.Usuarios.Location = new System.Drawing.Point(371, 77);
            this.Usuarios.Margin = new System.Windows.Forms.Padding(5);
            this.Usuarios.Name = "Usuarios";
            this.Usuarios.Size = new System.Drawing.Size(309, 443);
            this.Usuarios.TabIndex = 0;
            this.Usuarios.TabStop = false;
            this.Usuarios.Text = "Usuarios";
            // 
            // iconButton1
            // 
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconSize = 20;
            this.iconButton1.Location = new System.Drawing.Point(245, 34);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(38, 34);
            this.iconButton1.TabIndex = 4;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 26);
            this.textBox1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Usuario,
            this.Activo});
            this.dataGridView1.Location = new System.Drawing.Point(13, 88);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(283, 342);
            this.dataGridView1.TabIndex = 2;
            // 
            // Usuario
            // 
            this.Usuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Usuario.FillWeight = 98.47716F;
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            // 
            // Activo
            // 
            this.Activo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Activo.FillWeight = 101.5228F;
            this.Activo.HeaderText = "Activo";
            this.Activo.MinimumWidth = 100;
            this.Activo.Name = "Activo";
            this.Activo.ReadOnly = true;
            this.Activo.TrueValue = "1";
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.comboBoxPersona);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxContrasena);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxUsuario);
            this.groupBox1.Controls.Add(this.textBoxContrasena2);
            this.groupBox1.Controls.Add(this.iconButtonCancelar);
            this.groupBox1.Controls.Add(this.iconButtonAgregar);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 443);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Usuarios";
            // 
            // comboBoxPersona
            // 
            this.comboBoxPersona.FormattingEnabled = true;
            this.comboBoxPersona.Location = new System.Drawing.Point(73, 295);
            this.comboBoxPersona.Name = "comboBoxPersona";
            this.comboBoxPersona.Size = new System.Drawing.Size(226, 27);
            this.comboBoxPersona.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 262);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Elegir Persona";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 196);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nueva Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Contraseña";
            // 
            // textBoxContrasena
            // 
            this.textBoxContrasena.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxContrasena.Location = new System.Drawing.Point(73, 152);
            this.textBoxContrasena.Name = "textBoxContrasena";
            this.textBoxContrasena.PasswordChar = '*';
            this.textBoxContrasena.Size = new System.Drawing.Size(226, 26);
            this.textBoxContrasena.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Usuario";
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxUsuario.Location = new System.Drawing.Point(73, 84);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(226, 26);
            this.textBoxUsuario.TabIndex = 7;
            // 
            // textBoxContrasena2
            // 
            this.textBoxContrasena2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxContrasena2.Location = new System.Drawing.Point(73, 218);
            this.textBoxContrasena2.Name = "textBoxContrasena2";
            this.textBoxContrasena2.PasswordChar = '*';
            this.textBoxContrasena2.Size = new System.Drawing.Size(226, 26);
            this.textBoxContrasena2.TabIndex = 6;
            // 
            // iconButtonCancelar
            // 
            this.iconButtonCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonCancelar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonCancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonCancelar.IconColor = System.Drawing.Color.Black;
            this.iconButtonCancelar.IconSize = 16;
            this.iconButtonCancelar.Location = new System.Drawing.Point(184, 395);
            this.iconButtonCancelar.Margin = new System.Windows.Forms.Padding(10);
            this.iconButtonCancelar.Name = "iconButtonCancelar";
            this.iconButtonCancelar.Rotation = 0D;
            this.iconButtonCancelar.Size = new System.Drawing.Size(130, 35);
            this.iconButtonCancelar.TabIndex = 5;
            this.iconButtonCancelar.Text = "Cancelar";
            this.iconButtonCancelar.UseVisualStyleBackColor = true;
            this.iconButtonCancelar.Click += new System.EventHandler(this.iconButtonCancelar_Click);
            // 
            // iconButtonAgregar
            // 
            this.iconButtonAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonAgregar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonAgregar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonAgregar.IconColor = System.Drawing.Color.Black;
            this.iconButtonAgregar.IconSize = 16;
            this.iconButtonAgregar.Location = new System.Drawing.Point(13, 395);
            this.iconButtonAgregar.Margin = new System.Windows.Forms.Padding(10);
            this.iconButtonAgregar.Name = "iconButtonAgregar";
            this.iconButtonAgregar.Rotation = 0D;
            this.iconButtonAgregar.Size = new System.Drawing.Size(130, 35);
            this.iconButtonAgregar.TabIndex = 4;
            this.iconButtonAgregar.Text = "Agregar";
            this.iconButtonAgregar.UseVisualStyleBackColor = true;
            this.iconButtonAgregar.Click += new System.EventHandler(this.IconButtonAgregar_Click);
            // 
            // labelTiempo
            // 
            this.labelTiempo.AutoSize = true;
            this.labelTiempo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTiempo.Location = new System.Drawing.Point(30, 37);
            this.labelTiempo.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.labelTiempo.Name = "labelTiempo";
            this.labelTiempo.Size = new System.Drawing.Size(69, 19);
            this.labelTiempo.TabIndex = 15;
            this.labelTiempo.Text = "Tiempo: 0";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // GestionarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 533);
            this.Controls.Add(this.labelTiempo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Usuarios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GestionarUsuarios";
            this.Text = "GestionarUsuarios";
            this.Usuarios.ResumeLayout(false);
            this.Usuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Usuarios;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Activo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textBoxContrasena2;
        private FontAwesome.Sharp.IconButton iconButtonCancelar;
        private FontAwesome.Sharp.IconButton iconButtonAgregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxContrasena;
        private System.Windows.Forms.ComboBox comboBoxPersona;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelTiempo;
        private System.Windows.Forms.Timer timer1;
    }
}