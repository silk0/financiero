namespace Financiero.Vista
{
    partial class Generos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Generos));
            this.dataGridViewGeneros = new System.Windows.Forms.DataGridView();
            this.ColumnEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconButtonAgregar = new FontAwesome.Sharp.IconButton();
            this.iconButtonModificar = new FontAwesome.Sharp.IconButton();
            this.iconButtonEliminar = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelGenero = new System.Windows.Forms.Label();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxIngresar = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.iconButtonBuscar = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.pictureBoxCargando = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGeneros)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCargando)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewGeneros
            // 
            this.dataGridViewGeneros.AllowUserToAddRows = false;
            this.dataGridViewGeneros.AllowUserToDeleteRows = false;
            this.dataGridViewGeneros.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Georgia", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewGeneros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewGeneros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGeneros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnEstado});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Georgia", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewGeneros.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewGeneros.Location = new System.Drawing.Point(12, 283);
            this.dataGridViewGeneros.Name = "dataGridViewGeneros";
            this.dataGridViewGeneros.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Georgia", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewGeneros.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewGeneros.Size = new System.Drawing.Size(777, 171);
            this.dataGridViewGeneros.TabIndex = 0;
            this.dataGridViewGeneros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGenero_CellContentClick);
            // 
            // ColumnEstado
            // 
            this.ColumnEstado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnEstado.HeaderText = "Tipo de Genero";
            this.ColumnEstado.Name = "ColumnEstado";
            this.ColumnEstado.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.iconButtonAgregar);
            this.panel2.Controls.Add(this.iconButtonModificar);
            this.panel2.Controls.Add(this.iconButtonEliminar);
            this.panel2.Location = new System.Drawing.Point(12, 190);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(777, 42);
            this.panel2.TabIndex = 13;
            // 
            // iconButtonAgregar
            // 
            this.iconButtonAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonAgregar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonAgregar.Font = new System.Drawing.Font("Georgia", 12F);
            this.iconButtonAgregar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.iconButtonAgregar.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButtonAgregar.IconColor = System.Drawing.Color.MidnightBlue;
            this.iconButtonAgregar.IconSize = 25;
            this.iconButtonAgregar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.iconButtonAgregar.Location = new System.Drawing.Point(3, 3);
            this.iconButtonAgregar.Name = "iconButtonAgregar";
            this.iconButtonAgregar.Padding = new System.Windows.Forms.Padding(3);
            this.iconButtonAgregar.Rotation = 0D;
            this.iconButtonAgregar.Size = new System.Drawing.Size(105, 34);
            this.iconButtonAgregar.TabIndex = 6;
            this.iconButtonAgregar.Text = "Agregar";
            this.iconButtonAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonAgregar.UseVisualStyleBackColor = true;
            this.iconButtonAgregar.Click += new System.EventHandler(this.iconButtonAgregar_Click);
            // 
            // iconButtonModificar
            // 
            this.iconButtonModificar.Enabled = false;
            this.iconButtonModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonModificar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonModificar.Font = new System.Drawing.Font("Georgia", 12F);
            this.iconButtonModificar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.iconButtonModificar.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.iconButtonModificar.IconColor = System.Drawing.Color.MidnightBlue;
            this.iconButtonModificar.IconSize = 21;
            this.iconButtonModificar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.iconButtonModificar.Location = new System.Drawing.Point(556, 3);
            this.iconButtonModificar.Name = "iconButtonModificar";
            this.iconButtonModificar.Padding = new System.Windows.Forms.Padding(3);
            this.iconButtonModificar.Rotation = 0D;
            this.iconButtonModificar.Size = new System.Drawing.Size(105, 34);
            this.iconButtonModificar.TabIndex = 7;
            this.iconButtonModificar.Text = "Modificar";
            this.iconButtonModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonModificar.UseVisualStyleBackColor = true;
            this.iconButtonModificar.Click += new System.EventHandler(this.iconButtonModificar_Click);
            // 
            // iconButtonEliminar
            // 
            this.iconButtonEliminar.Enabled = false;
            this.iconButtonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonEliminar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonEliminar.Font = new System.Drawing.Font("Georgia", 12F);
            this.iconButtonEliminar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.iconButtonEliminar.IconChar = FontAwesome.Sharp.IconChar.Backspace;
            this.iconButtonEliminar.IconColor = System.Drawing.Color.MidnightBlue;
            this.iconButtonEliminar.IconSize = 25;
            this.iconButtonEliminar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.iconButtonEliminar.Location = new System.Drawing.Point(667, 3);
            this.iconButtonEliminar.Name = "iconButtonEliminar";
            this.iconButtonEliminar.Padding = new System.Windows.Forms.Padding(3);
            this.iconButtonEliminar.Rotation = 0D;
            this.iconButtonEliminar.Size = new System.Drawing.Size(105, 34);
            this.iconButtonEliminar.TabIndex = 8;
            this.iconButtonEliminar.Text = "Eliminar";
            this.iconButtonEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonEliminar.UseVisualStyleBackColor = true;
            this.iconButtonEliminar.Click += new System.EventHandler(this.iconButtonEliminar_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.labelGenero);
            this.panel3.Controls.Add(this.iconPictureBox2);
            this.panel3.Location = new System.Drawing.Point(11, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(778, 97);
            this.panel3.TabIndex = 15;
            // 
            // labelGenero
            // 
            this.labelGenero.AutoSize = true;
            this.labelGenero.Font = new System.Drawing.Font("Georgia", 20F);
            this.labelGenero.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelGenero.Location = new System.Drawing.Point(158, 31);
            this.labelGenero.Name = "labelGenero";
            this.labelGenero.Size = new System.Drawing.Size(114, 31);
            this.labelGenero.TabIndex = 4;
            this.labelGenero.Text = "Generos";
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.VenusMars;
            this.iconPictureBox2.IconColor = System.Drawing.Color.MidnightBlue;
            this.iconPictureBox2.IconSize = 84;
            this.iconPictureBox2.Location = new System.Drawing.Point(4, 3);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(136, 84);
            this.iconPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBox2.TabIndex = 13;
            this.iconPictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxIngresar);
            this.panel1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.panel1.Location = new System.Drawing.Point(12, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 69);
            this.panel1.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F);
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(3, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ingresar:";
            // 
            // textBoxIngresar
            // 
            this.textBoxIngresar.Font = new System.Drawing.Font("Georgia", 12F);
            this.textBoxIngresar.Location = new System.Drawing.Point(81, 22);
            this.textBoxIngresar.Name = "textBoxIngresar";
            this.textBoxIngresar.Size = new System.Drawing.Size(343, 26);
            this.textBoxIngresar.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(153)))), ((int)(((byte)(184)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.textBoxBuscar);
            this.panel4.Controls.Add(this.iconButtonBuscar);
            this.panel4.Controls.Add(this.iconButton1);
            this.panel4.Controls.Add(this.pictureBoxCargando);
            this.panel4.Location = new System.Drawing.Point(12, 238);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(777, 39);
            this.panel4.TabIndex = 16;
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Font = new System.Drawing.Font("Georgia", 12F);
            this.textBoxBuscar.Location = new System.Drawing.Point(6, 5);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(201, 26);
            this.textBoxBuscar.TabIndex = 6;
            // 
            // iconButtonBuscar
            // 
            this.iconButtonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonBuscar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonBuscar.Font = new System.Drawing.Font("Georgia", 9F);
            this.iconButtonBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButtonBuscar.IconColor = System.Drawing.Color.MidnightBlue;
            this.iconButtonBuscar.IconSize = 20;
            this.iconButtonBuscar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.iconButtonBuscar.Location = new System.Drawing.Point(213, 5);
            this.iconButtonBuscar.Name = "iconButtonBuscar";
            this.iconButtonBuscar.Padding = new System.Windows.Forms.Padding(3);
            this.iconButtonBuscar.Rotation = 0D;
            this.iconButtonBuscar.Size = new System.Drawing.Size(77, 29);
            this.iconButtonBuscar.TabIndex = 9;
            this.iconButtonBuscar.Text = "Buscar";
            this.iconButtonBuscar.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.iconButtonBuscar.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.Font = new System.Drawing.Font("Georgia", 12F);
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Undo;
            this.iconButton1.IconColor = System.Drawing.Color.MidnightBlue;
            this.iconButton1.IconSize = 19;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.iconButton1.Location = new System.Drawing.Point(737, 3);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(3);
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(35, 29);
            this.iconButton1.TabIndex = 9;
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // pictureBoxCargando
            // 
            this.pictureBoxCargando.Image = global::Financiero.Properties.Resources.Espere;
            this.pictureBoxCargando.Location = new System.Drawing.Point(737, 5);
            this.pictureBoxCargando.Name = "pictureBoxCargando";
            this.pictureBoxCargando.Size = new System.Drawing.Size(35, 26);
            this.pictureBoxCargando.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCargando.TabIndex = 14;
            this.pictureBoxCargando.TabStop = false;
            // 
            // Generos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(153)))), ((int)(((byte)(184)))));
            this.ClientSize = new System.Drawing.Size(801, 466);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dataGridViewGeneros);
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Generos";
            this.Text = "Administracion de sexos";
            this.Load += new System.EventHandler(this.Generos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGeneros)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCargando)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewGeneros;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton iconButtonAgregar;
        private FontAwesome.Sharp.IconButton iconButtonModificar;
        private FontAwesome.Sharp.IconButton iconButtonEliminar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelGenero;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxIngresar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEstado;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private FontAwesome.Sharp.IconButton iconButtonBuscar;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.PictureBox pictureBoxCargando;
    }
}