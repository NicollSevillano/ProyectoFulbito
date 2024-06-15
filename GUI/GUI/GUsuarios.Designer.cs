namespace GUI
{
    partial class GUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUsuarios));
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbDatos = new System.Windows.Forms.Label();
            this.labDNI = new System.Windows.Forms.Label();
            this.labNombre = new System.Windows.Forms.Label();
            this.labApellido = new System.Windows.Forms.Label();
            this.labEmail = new System.Windows.Forms.Label();
            this.labUsuario = new System.Windows.Forms.Label();
            this.labContraseña = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnDesbloquear = new System.Windows.Forms.Button();
            this.labFiltrar = new System.Windows.Forms.Label();
            this.cbBloqueados = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.rbAdministrador = new System.Windows.Forms.RadioButton();
            this.rbEmpleado = new System.Windows.Forms.RadioButton();
            this.btnCambiarC = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dgvUsuarios.Location = new System.Drawing.Point(12, 12);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(911, 189);
            this.dgvUsuarios.TabIndex = 0;
            this.dgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick);
            this.dgvUsuarios.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_RowEnter);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "DNI";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nombre";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Apellido";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Email";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Perfil";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Usuario";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Contraseña";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Bloqueado";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Activo";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // lbDatos
            // 
            this.lbDatos.AutoSize = true;
            this.lbDatos.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDatos.Location = new System.Drawing.Point(45, 224);
            this.lbDatos.Name = "lbDatos";
            this.lbDatos.Size = new System.Drawing.Size(127, 19);
            this.lbDatos.TabIndex = 1;
            this.lbDatos.Text = "Datos de usuario";
            // 
            // labDNI
            // 
            this.labDNI.AutoSize = true;
            this.labDNI.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDNI.Location = new System.Drawing.Point(45, 271);
            this.labDNI.Name = "labDNI";
            this.labDNI.Size = new System.Drawing.Size(39, 19);
            this.labDNI.TabIndex = 2;
            this.labDNI.Text = "DNI";
            // 
            // labNombre
            // 
            this.labNombre.AutoSize = true;
            this.labNombre.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNombre.Location = new System.Drawing.Point(45, 313);
            this.labNombre.Name = "labNombre";
            this.labNombre.Size = new System.Drawing.Size(69, 19);
            this.labNombre.TabIndex = 3;
            this.labNombre.Text = "Nombre";
            // 
            // labApellido
            // 
            this.labApellido.AutoSize = true;
            this.labApellido.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labApellido.Location = new System.Drawing.Point(45, 355);
            this.labApellido.Name = "labApellido";
            this.labApellido.Size = new System.Drawing.Size(68, 19);
            this.labApellido.TabIndex = 4;
            this.labApellido.Text = "Apellido";
            // 
            // labEmail
            // 
            this.labEmail.AutoSize = true;
            this.labEmail.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labEmail.Location = new System.Drawing.Point(45, 397);
            this.labEmail.Name = "labEmail";
            this.labEmail.Size = new System.Drawing.Size(47, 19);
            this.labEmail.TabIndex = 5;
            this.labEmail.Text = "Email";
            // 
            // labUsuario
            // 
            this.labUsuario.AutoSize = true;
            this.labUsuario.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labUsuario.Location = new System.Drawing.Point(45, 439);
            this.labUsuario.Name = "labUsuario";
            this.labUsuario.Size = new System.Drawing.Size(63, 19);
            this.labUsuario.TabIndex = 7;
            this.labUsuario.Text = "Usuario";
            // 
            // labContraseña
            // 
            this.labContraseña.AutoSize = true;
            this.labContraseña.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labContraseña.Location = new System.Drawing.Point(45, 481);
            this.labContraseña.Name = "labContraseña";
            this.labContraseña.Size = new System.Drawing.Size(88, 19);
            this.labContraseña.TabIndex = 8;
            this.labContraseña.Text = "Contraseña";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(214, 271);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(145, 20);
            this.txtDni.TabIndex = 9;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(214, 313);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(145, 20);
            this.txtNombre.TabIndex = 10;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(214, 355);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(145, 20);
            this.txtApellido.TabIndex = 11;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(214, 397);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(145, 20);
            this.txtEmail.TabIndex = 12;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(214, 439);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(145, 20);
            this.txtUsuario.TabIndex = 14;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(214, 481);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(145, 20);
            this.txtContraseña.TabIndex = 15;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(417, 231);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(105, 43);
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(417, 280);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(105, 43);
            this.btnBorrar.TabIndex = 17;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(417, 332);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(105, 43);
            this.btnModificar.TabIndex = 18;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnDesbloquear
            // 
            this.btnDesbloquear.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesbloquear.Location = new System.Drawing.Point(597, 307);
            this.btnDesbloquear.Name = "btnDesbloquear";
            this.btnDesbloquear.Size = new System.Drawing.Size(100, 31);
            this.btnDesbloquear.TabIndex = 19;
            this.btnDesbloquear.Text = "Desbloquear";
            this.btnDesbloquear.UseVisualStyleBackColor = true;
            this.btnDesbloquear.Click += new System.EventHandler(this.btnDesbloquear_Click);
            // 
            // labFiltrar
            // 
            this.labFiltrar.AutoSize = true;
            this.labFiltrar.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFiltrar.Location = new System.Drawing.Point(593, 246);
            this.labFiltrar.Name = "labFiltrar";
            this.labFiltrar.Size = new System.Drawing.Size(50, 19);
            this.labFiltrar.TabIndex = 21;
            this.labFiltrar.Text = "Filtrar";
            // 
            // cbBloqueados
            // 
            this.cbBloqueados.AutoSize = true;
            this.cbBloqueados.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBloqueados.Location = new System.Drawing.Point(597, 280);
            this.cbBloqueados.Name = "cbBloqueados";
            this.cbBloqueados.Size = new System.Drawing.Size(103, 22);
            this.cbBloqueados.TabIndex = 24;
            this.cbBloqueados.Text = "Bloqueados";
            this.cbBloqueados.UseVisualStyleBackColor = true;
            this.cbBloqueados.CheckedChanged += new System.EventHandler(this.cbBloqueados_CheckedChanged);
            this.cbBloqueados.TextChanged += new System.EventHandler(this.cbBloqueados_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(597, 391);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(818, 491);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(105, 43);
            this.btnSalir.TabIndex = 20;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // rbAdministrador
            // 
            this.rbAdministrador.AutoSize = true;
            this.rbAdministrador.Checked = true;
            this.rbAdministrador.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAdministrador.Location = new System.Drawing.Point(417, 391);
            this.rbAdministrador.Name = "rbAdministrador";
            this.rbAdministrador.Size = new System.Drawing.Size(127, 23);
            this.rbAdministrador.TabIndex = 27;
            this.rbAdministrador.TabStop = true;
            this.rbAdministrador.Text = "Administrador";
            this.rbAdministrador.UseVisualStyleBackColor = true;
            // 
            // rbEmpleado
            // 
            this.rbEmpleado.AutoSize = true;
            this.rbEmpleado.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEmpleado.Location = new System.Drawing.Point(417, 425);
            this.rbEmpleado.Name = "rbEmpleado";
            this.rbEmpleado.Size = new System.Drawing.Size(97, 23);
            this.rbEmpleado.TabIndex = 28;
            this.rbEmpleado.Text = "Empleado";
            this.rbEmpleado.UseVisualStyleBackColor = true;
            // 
            // btnCambiarC
            // 
            this.btnCambiarC.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarC.Location = new System.Drawing.Point(417, 468);
            this.btnCambiarC.Name = "btnCambiarC";
            this.btnCambiarC.Size = new System.Drawing.Size(105, 54);
            this.btnCambiarC.TabIndex = 34;
            this.btnCambiarC.Text = "Cambiar clave";
            this.btnCambiarC.UseVisualStyleBackColor = true;
            this.btnCambiarC.Click += new System.EventHandler(this.btnCambiarC_Click);
            // 
            // GUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(211)))), ((int)(((byte)(131)))));
            this.ClientSize = new System.Drawing.Size(935, 546);
            this.Controls.Add(this.cbBloqueados);
            this.Controls.Add(this.btnCambiarC);
            this.Controls.Add(this.rbEmpleado);
            this.Controls.Add(this.rbAdministrador);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labFiltrar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnDesbloquear);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.labContraseña);
            this.Controls.Add(this.labUsuario);
            this.Controls.Add(this.labEmail);
            this.Controls.Add(this.labApellido);
            this.Controls.Add(this.labNombre);
            this.Controls.Add(this.labDNI);
            this.Controls.Add(this.lbDatos);
            this.Controls.Add(this.dgvUsuarios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GUsuarios";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.GUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Label lbDatos;
        private System.Windows.Forms.Label labDNI;
        private System.Windows.Forms.Label labNombre;
        private System.Windows.Forms.Label labApellido;
        private System.Windows.Forms.Label labEmail;
        private System.Windows.Forms.Label labUsuario;
        private System.Windows.Forms.Label labContraseña;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnDesbloquear;
        private System.Windows.Forms.Label labFiltrar;
        private System.Windows.Forms.CheckBox cbBloqueados;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.RadioButton rbAdministrador;
        private System.Windows.Forms.RadioButton rbEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.Button btnCambiarC;
    }
}