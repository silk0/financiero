namespace Financiero.Vista
{
    partial class Estado_Civil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Estado_Civil));
            this.dataGridViewEstadoCivil = new System.Windows.Forms.DataGridView();
            this.ColumnEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxIngresar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.iconButtonAgregar = new FontAwesome.Sharp.IconButton();
            this.iconButtonModificar = new FontAwesome.Sharp.IconButton();
            this.iconButtonEliminar = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.iconButtonBuscar = new FontAwesome.Sharp.IconButton();
            this.pictureBoxCargando = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstadoCivil)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCargando)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEstadoCivil
            // 
            this.dataGridViewEstadoCivil.AllowUserToAddRows = false;
            this.dataGridViewEstadoCivil.AllowUserToDeleteRows = false;
            this.dataGridViewEstadoCivil.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Georgia", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEstadoCivil.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewEstadoCivil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEstadoCivil.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnEstado});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Georgia", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewEstadoCivil.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewEstadoCivil.Location = new System.Drawing.Point(12, 283);
            this.dataGridViewEstadoCivil.Name = "dataGridViewEstadoCivil";
            this.dataGridViewEstadoCivil.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Georgia", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEstadoCivil.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewEstadoCivil.Size = new System.Drawing.Size(777, 171);
            this.dataGridViewEstadoCivil.TabIndex = 0;
            this.dataGridViewEstadoCivil.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEstadoCivil_CellContentClick);
            // 
            // ColumnEstado
            // 
            this.ColumnEstado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnEstado.HeaderText = "Estado Civil";
            this.ColumnEstado.Name = "ColumnEstado";
            this.ColumnEstado.ReadOnly = true;
            // 
            // textBoxIngresar
            // 
            this.textBoxIngresar.BackColor = System.Drawing.Color.White;
            this.textBoxIngresar.Font = new System.Drawing.Font("Georgia", 12F);
            this.textBoxIngresar.Location = new System.Drawing.Point(81, 22);
            this.textBoxIngresar.Name = "textBoxIngresar";
            this.textBoxIngresar.Size = new System.Drawing.Size(343, 26);
            this.textBoxIngresar.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 20F);
            this.label2.Location = new System.Drawing.Point(133, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Estados civiles";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F);
            this.label3.Location = new System.Drawing.Point(3, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ingresar:";
            // 
            // iconButtonAgregar
            // 
            this.iconButtonAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.iconButtonAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonAgregar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonAgregar.Font = new System.Drawing.Font("Georgia", 12F);
            this.iconButtonAgregar.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.iconButtonAgregar.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButtonAgregar.IconColor = System.Drawing.Color.CornflowerBlue;
            this.iconButtonAgregar.IconSize = 25;
            this.iconButtonAgregar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.iconButtonAgregar.Location = new System.Drawing.Point(3, 3);
            this.iconButtonAgregar.Name = "iconButtonAgregar";
            this.iconButtonAgregar.Padding = new System.Windows.Forms.Padding(3);
            this.iconButtonAgregar.Rotation = 0D;
            this.iconButtonAgregar.Size = new System.Drawing.Size(110, 34);
            this.iconButtonAgregar.TabIndex = 6;
            this.iconButtonAgregar.Text = "Agregar";
            this.iconButtonAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButtonAgregar.UseVisualStyleBackColor = false;
            this.iconButtonAgregar.Click += new System.EventHandler(this.iconButtonAgregar_Click);
            // 
            // iconButtonModificar
            // 
            this.iconButtonModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.iconButtonModificar.Enabled = false;
            this.iconButtonModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonModificar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonModificar.Font = new System.Drawing.Font("Georgia", 12F);
            this.iconButtonModificar.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.iconButtonModificar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.iconButtonModificar.IconColor = System.Drawing.Color.CornflowerBlue;
            this.iconButtonModificar.IconSize = 25;
            this.iconButtonModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonModificar.Location = new System.Drawing.Point(547, 3);
            this.iconButtonModificar.Name = "iconButtonModificar";
            this.iconButtonModificar.Padding = new System.Windows.Forms.Padding(2);
            this.iconButtonModificar.Rotation = 0D;
            this.iconButtonModificar.Size = new System.Drawing.Size(110, 34);
            this.iconButtonModificar.TabIndex = 7;
            this.iconButtonModificar.Text = "Modificar";
            this.iconButtonModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButtonModificar.UseVisualStyleBackColor = false;
            this.iconButtonModificar.Click += new System.EventHandler(this.iconButtonModificar_Click);
            // 
            // iconButtonEliminar
            // 
            this.iconButtonEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.iconButtonEliminar.Enabled = false;
            this.iconButtonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonEliminar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonEliminar.Font = new System.Drawing.Font("Georgia", 12F);
            this.iconButtonEliminar.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.iconButtonEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.iconButtonEliminar.IconColor = System.Drawing.Color.CornflowerBlue;
            this.iconButtonEliminar.IconSize = 25;
            this.iconButtonEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonEliminar.Location = new System.Drawing.Point(662, 3);
            this.iconButtonEliminar.Name = "iconButtonEliminar";
            this.iconButtonEliminar.Padding = new System.Windows.Forms.Padding(3);
            this.iconButtonEliminar.Rotation = 0D;
            this.iconButtonEliminar.Size = new System.Drawing.Size(110, 34);
            this.iconButtonEliminar.TabIndex = 8;
            this.iconButtonEliminar.Text = "Eliminar";
            this.iconButtonEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButtonEliminar.UseVisualStyleBackColor = false;
            this.iconButtonEliminar.Click += new System.EventHandler(this.iconButtonEliminar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(153)))), ((int)(((byte)(184)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxIngresar);
            this.panel1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.panel1.Location = new System.Drawing.Point(12, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 69);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(153)))), ((int)(((byte)(184)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.iconButtonAgregar);
            this.panel2.Controls.Add(this.iconButtonModificar);
            this.panel2.Controls.Add(this.iconButtonEliminar);
            this.panel2.Location = new System.Drawing.Point(12, 190);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(777, 42);
            this.panel2.TabIndex = 12;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconPictureBox2.IconColor = System.Drawing.Color.MidnightBlue;
            this.iconPictureBox2.IconSize = 84;
            this.iconPictureBox2.Location = new System.Drawing.Point(6, 7);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(121, 84);
            this.iconPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBox2.TabIndex = 13;
            this.iconPictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(153)))), ((int)(((byte)(184)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.iconPictureBox2);
            this.panel3.Location = new System.Drawing.Point(12, 9);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(777, 96);
            this.panel3.TabIndex = 14;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.Font = new System.Drawing.Font("Georgia", 12F);
            this.iconButton1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Undo;
            this.iconButton1.IconColor = System.Drawing.Color.CornflowerBlue;
            this.iconButton1.IconSize = 19;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.iconButton1.Location = new System.Drawing.Point(737, 3);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(3);
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(35, 29);
            this.iconButton1.TabIndex = 9;
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_RefrescarTabla);
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
            this.panel4.TabIndex = 13;
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
            this.iconButtonBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.iconButtonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonBuscar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonBuscar.Font = new System.Drawing.Font("Georgia", 9F);
            this.iconButtonBuscar.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.iconButtonBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButtonBuscar.IconColor = System.Drawing.Color.CornflowerBlue;
            this.iconButtonBuscar.IconSize = 20;
            this.iconButtonBuscar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.iconButtonBuscar.Location = new System.Drawing.Point(213, 5);
            this.iconButtonBuscar.Name = "iconButtonBuscar";
            this.iconButtonBuscar.Padding = new System.Windows.Forms.Padding(3);
            this.iconButtonBuscar.Rotation = 0D;
            this.iconButtonBuscar.Size = new System.Drawing.Size(35, 29);
            this.iconButtonBuscar.TabIndex = 9;
            this.iconButtonBuscar.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.iconButtonBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButtonBuscar.UseVisualStyleBackColor = false;
            this.iconButtonBuscar.Click += new System.EventHandler(this.iconButtonBuscar_Click);
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
            // Estado_Civil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(153)))), ((int)(((byte)(184)))));
            this.ClientSize = new System.Drawing.Size(801, 466);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewEstadoCivil);
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Estado_Civil";
            this.Text = "Administracion de estados civiles";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstadoCivil)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCargando)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEstadoCivil;
        private System.Windows.Forms.TextBox textBoxIngresar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEstado;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton iconButtonAgregar;
        private FontAwesome.Sharp.IconButton iconButtonModificar;
        private FontAwesome.Sharp.IconButton iconButtonEliminar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton iconButtonBuscar;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.PictureBox pictureBoxCargando;
    }
}