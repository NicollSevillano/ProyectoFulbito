namespace GUI
{
    partial class GReservas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GReservas));
            this.LabDni = new System.Windows.Forms.Label();
            this.labNombre = new System.Windows.Forms.Label();
            this.labCancha = new System.Windows.Forms.Label();
            this.labHorario = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cmbCancha = new System.Windows.Forms.ComboBox();
            this.cmbHorario = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btnReservar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnDisponibilidad = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.labFecha = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabDni
            // 
            this.LabDni.AutoSize = true;
            this.LabDni.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabDni.Location = new System.Drawing.Point(28, 27);
            this.LabDni.Name = "LabDni";
            this.LabDni.Size = new System.Drawing.Size(39, 19);
            this.LabDni.TabIndex = 0;
            this.LabDni.Text = "DNI";
            // 
            // labNombre
            // 
            this.labNombre.AutoSize = true;
            this.labNombre.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNombre.Location = new System.Drawing.Point(28, 73);
            this.labNombre.Name = "labNombre";
            this.labNombre.Size = new System.Drawing.Size(69, 19);
            this.labNombre.TabIndex = 1;
            this.labNombre.Text = "Nombre";
            // 
            // labCancha
            // 
            this.labCancha.AutoSize = true;
            this.labCancha.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCancha.Location = new System.Drawing.Point(28, 119);
            this.labCancha.Name = "labCancha";
            this.labCancha.Size = new System.Drawing.Size(61, 19);
            this.labCancha.TabIndex = 2;
            this.labCancha.Text = "Cancha";
            // 
            // labHorario
            // 
            this.labHorario.AutoSize = true;
            this.labHorario.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labHorario.Location = new System.Drawing.Point(28, 166);
            this.labHorario.Name = "labHorario";
            this.labHorario.Size = new System.Drawing.Size(66, 19);
            this.labHorario.TabIndex = 3;
            this.labHorario.Text = "Horario";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(130, 28);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(128, 20);
            this.txtDni.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(130, 72);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(128, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // cmbCancha
            // 
            this.cmbCancha.FormattingEnabled = true;
            this.cmbCancha.Location = new System.Drawing.Point(130, 118);
            this.cmbCancha.Name = "cmbCancha";
            this.cmbCancha.Size = new System.Drawing.Size(128, 21);
            this.cmbCancha.TabIndex = 6;
            // 
            // cmbHorario
            // 
            this.cmbHorario.FormattingEnabled = true;
            this.cmbHorario.Location = new System.Drawing.Point(130, 165);
            this.cmbHorario.Name = "cmbHorario";
            this.cmbHorario.Size = new System.Drawing.Size(128, 21);
            this.cmbHorario.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(290, 59);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(112, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(545, 26);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 9;
            // 
            // btnReservar
            // 
            this.btnReservar.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservar.Location = new System.Drawing.Point(414, 144);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(107, 44);
            this.btnReservar.TabIndex = 10;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = true;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(32, 221);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(761, 194);
            this.listBox1.TabIndex = 11;
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(32, 458);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(107, 44);
            this.btnVolver.TabIndex = 12;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // btnDisponibilidad
            // 
            this.btnDisponibilidad.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisponibilidad.Location = new System.Drawing.Point(151, 458);
            this.btnDisponibilidad.Name = "btnDisponibilidad";
            this.btnDisponibilidad.Size = new System.Drawing.Size(148, 44);
            this.btnDisponibilidad.TabIndex = 13;
            this.btnDisponibilidad.Text = "Ver disponibilidad";
            this.btnDisponibilidad.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(686, 448);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(107, 64);
            this.btnConfirmar.TabIndex = 14;
            this.btnConfirmar.Text = "Confirmar Reserva";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // labFecha
            // 
            this.labFecha.AutoSize = true;
            this.labFecha.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFecha.Location = new System.Drawing.Point(286, 26);
            this.labFecha.Name = "labFecha";
            this.labFecha.Size = new System.Drawing.Size(49, 19);
            this.labFecha.TabIndex = 15;
            this.labFecha.Text = "Fecha";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(301, 144);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(107, 44);
            this.btnRegistrar.TabIndex = 16;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // GReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(211)))), ((int)(((byte)(131)))));
            this.ClientSize = new System.Drawing.Size(828, 524);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.labFecha);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnDisponibilidad);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cmbHorario);
            this.Controls.Add(this.cmbCancha);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.labHorario);
            this.Controls.Add(this.labCancha);
            this.Controls.Add(this.labNombre);
            this.Controls.Add(this.LabDni);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GReservas";
            this.Text = "GReservas";
            this.Load += new System.EventHandler(this.GReservas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabDni;
        private System.Windows.Forms.Label labNombre;
        private System.Windows.Forms.Label labCancha;
        private System.Windows.Forms.Label labHorario;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cmbCancha;
        private System.Windows.Forms.ComboBox cmbHorario;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnDisponibilidad;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label labFecha;
        private System.Windows.Forms.Button btnRegistrar;
    }
}