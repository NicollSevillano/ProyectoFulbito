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
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.btnCliente = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.labNombre = new System.Windows.Forms.Label();
            this.labDNI = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPagar = new System.Windows.Forms.Button();
            this.calendario1 = new Controles.Calendario();
            this.gbCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.btnCliente);
            this.gbCliente.Controls.Add(this.txtNombre);
            this.gbCliente.Controls.Add(this.txtDni);
            this.gbCliente.Controls.Add(this.labNombre);
            this.gbCliente.Controls.Add(this.labDNI);
            this.gbCliente.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCliente.Location = new System.Drawing.Point(22, 12);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(269, 196);
            this.gbCliente.TabIndex = 0;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Datos del cliente";
            // 
            // btnCliente
            // 
            this.btnCliente.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.Location = new System.Drawing.Point(145, 133);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(100, 42);
            this.btnCliente.TabIndex = 7;
            this.btnCliente.Text = "Agregar";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(92, 85);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(153, 27);
            this.txtNombre.TabIndex = 3;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(92, 42);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(153, 27);
            this.txtDni.TabIndex = 2;
            // 
            // labNombre
            // 
            this.labNombre.AutoSize = true;
            this.labNombre.Location = new System.Drawing.Point(17, 88);
            this.labNombre.Name = "labNombre";
            this.labNombre.Size = new System.Drawing.Size(69, 19);
            this.labNombre.TabIndex = 1;
            this.labNombre.Text = "Nombre";
            // 
            // labDNI
            // 
            this.labDNI.AutoSize = true;
            this.labDNI.Location = new System.Drawing.Point(17, 45);
            this.labDNI.Name = "labDNI";
            this.labDNI.Size = new System.Drawing.Size(39, 19);
            this.labDNI.TabIndex = 0;
            this.labDNI.Text = "DNI";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "30min",
            "1h",
            "2h",
            "3h"});
            this.comboBox1.Location = new System.Drawing.Point(512, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(317, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(644, 342);
            this.dataGridView1.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Martes";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Miercoles";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Jueves";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Viernes";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Sábado";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Domingo";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // btnPagar
            // 
            this.btnPagar.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagar.Location = new System.Drawing.Point(662, 39);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(97, 42);
            this.btnPagar.TabIndex = 6;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            // 
            // calendario1
            // 
            this.calendario1.Location = new System.Drawing.Point(22, 225);
            this.calendario1.Name = "calendario1";
            this.calendario1.Size = new System.Drawing.Size(269, 227);
            this.calendario1.TabIndex = 7;
            // 
            // GReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(211)))), ((int)(((byte)(131)))));
            this.ClientSize = new System.Drawing.Size(973, 481);
            this.Controls.Add(this.calendario1);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.gbCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GReservas";
            this.Text = "GReservas";
            this.Load += new System.EventHandler(this.GReservas_Load);
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.Label labNombre;
        private System.Windows.Forms.Label labDNI;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btnCliente;
        private Controles.Calendario calendario1;
    }
}