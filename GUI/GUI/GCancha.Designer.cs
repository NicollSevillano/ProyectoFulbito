namespace GUI
{
    partial class GCancha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GCancha));
            this.groupCanchas = new System.Windows.Forms.GroupBox();
            this.rbCinco = new System.Windows.Forms.RadioButton();
            this.rbSiete = new System.Windows.Forms.RadioButton();
            this.rbOnce = new System.Windows.Forms.RadioButton();
            this.groupPiso = new System.Windows.Forms.GroupBox();
            this.rbCesped = new System.Windows.Forms.RadioButton();
            this.rbMadera = new System.Windows.Forms.RadioButton();
            this.rbCemento = new System.Windows.Forms.RadioButton();
            this.dtgvDisponibilidad = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupCanchas.SuspendLayout();
            this.groupPiso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDisponibilidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupCanchas
            // 
            this.groupCanchas.Controls.Add(this.rbOnce);
            this.groupCanchas.Controls.Add(this.rbSiete);
            this.groupCanchas.Controls.Add(this.rbCinco);
            this.groupCanchas.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupCanchas.Location = new System.Drawing.Point(12, 12);
            this.groupCanchas.Name = "groupCanchas";
            this.groupCanchas.Size = new System.Drawing.Size(172, 170);
            this.groupCanchas.TabIndex = 0;
            this.groupCanchas.TabStop = false;
            this.groupCanchas.Text = "Tipos de canchas";
            // 
            // rbCinco
            // 
            this.rbCinco.AutoSize = true;
            this.rbCinco.Checked = true;
            this.rbCinco.Location = new System.Drawing.Point(32, 39);
            this.rbCinco.Name = "rbCinco";
            this.rbCinco.Size = new System.Drawing.Size(93, 23);
            this.rbCinco.TabIndex = 0;
            this.rbCinco.TabStop = true;
            this.rbCinco.Text = "Cancha 5";
            this.rbCinco.UseVisualStyleBackColor = true;
            // 
            // rbSiete
            // 
            this.rbSiete.AutoSize = true;
            this.rbSiete.Location = new System.Drawing.Point(32, 79);
            this.rbSiete.Name = "rbSiete";
            this.rbSiete.Size = new System.Drawing.Size(93, 23);
            this.rbSiete.TabIndex = 1;
            this.rbSiete.Text = "Cancha 7";
            this.rbSiete.UseVisualStyleBackColor = true;
            // 
            // rbOnce
            // 
            this.rbOnce.AutoSize = true;
            this.rbOnce.Location = new System.Drawing.Point(32, 119);
            this.rbOnce.Name = "rbOnce";
            this.rbOnce.Size = new System.Drawing.Size(96, 23);
            this.rbOnce.TabIndex = 2;
            this.rbOnce.Text = "Cancha 11";
            this.rbOnce.UseVisualStyleBackColor = true;
            // 
            // groupPiso
            // 
            this.groupPiso.Controls.Add(this.rbCemento);
            this.groupPiso.Controls.Add(this.rbMadera);
            this.groupPiso.Controls.Add(this.rbCesped);
            this.groupPiso.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPiso.Location = new System.Drawing.Point(12, 192);
            this.groupPiso.Name = "groupPiso";
            this.groupPiso.Size = new System.Drawing.Size(172, 170);
            this.groupPiso.TabIndex = 1;
            this.groupPiso.TabStop = false;
            this.groupPiso.Text = "Tipos de piso";
            // 
            // rbCesped
            // 
            this.rbCesped.AutoSize = true;
            this.rbCesped.Checked = true;
            this.rbCesped.Location = new System.Drawing.Point(32, 41);
            this.rbCesped.Name = "rbCesped";
            this.rbCesped.Size = new System.Drawing.Size(77, 23);
            this.rbCesped.TabIndex = 3;
            this.rbCesped.TabStop = true;
            this.rbCesped.Text = "Césped";
            this.rbCesped.UseVisualStyleBackColor = true;
            // 
            // rbMadera
            // 
            this.rbMadera.AutoSize = true;
            this.rbMadera.Checked = true;
            this.rbMadera.Location = new System.Drawing.Point(32, 81);
            this.rbMadera.Name = "rbMadera";
            this.rbMadera.Size = new System.Drawing.Size(81, 23);
            this.rbMadera.TabIndex = 4;
            this.rbMadera.TabStop = true;
            this.rbMadera.Text = "Madera";
            this.rbMadera.UseVisualStyleBackColor = true;
            // 
            // rbCemento
            // 
            this.rbCemento.AutoSize = true;
            this.rbCemento.Checked = true;
            this.rbCemento.Location = new System.Drawing.Point(32, 121);
            this.rbCemento.Name = "rbCemento";
            this.rbCemento.Size = new System.Drawing.Size(92, 23);
            this.rbCemento.TabIndex = 5;
            this.rbCemento.TabStop = true;
            this.rbCemento.Text = "Cemento";
            this.rbCemento.UseVisualStyleBackColor = true;
            // 
            // dtgvDisponibilidad
            // 
            this.dtgvDisponibilidad.AllowUserToAddRows = false;
            this.dtgvDisponibilidad.AllowUserToDeleteRows = false;
            this.dtgvDisponibilidad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDisponibilidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDisponibilidad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dtgvDisponibilidad.Location = new System.Drawing.Point(210, 12);
            this.dtgvDisponibilidad.Name = "dtgvDisponibilidad";
            this.dtgvDisponibilidad.ReadOnly = true;
            this.dtgvDisponibilidad.Size = new System.Drawing.Size(569, 350);
            this.dtgvDisponibilidad.TabIndex = 2;
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
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(814, 64);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(109, 36);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(814, 146);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(109, 36);
            this.btnVolver.TabIndex = 4;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(796, 252);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // GCancha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(211)))), ((int)(((byte)(131)))));
            this.ClientSize = new System.Drawing.Size(956, 374);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dtgvDisponibilidad);
            this.Controls.Add(this.groupPiso);
            this.Controls.Add(this.groupCanchas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GCancha";
            this.Text = "GCancha";
            this.groupCanchas.ResumeLayout(false);
            this.groupCanchas.PerformLayout();
            this.groupPiso.ResumeLayout(false);
            this.groupPiso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDisponibilidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupCanchas;
        private System.Windows.Forms.RadioButton rbOnce;
        private System.Windows.Forms.RadioButton rbSiete;
        private System.Windows.Forms.RadioButton rbCinco;
        private System.Windows.Forms.GroupBox groupPiso;
        private System.Windows.Forms.RadioButton rbCemento;
        private System.Windows.Forms.RadioButton rbMadera;
        private System.Windows.Forms.RadioButton rbCesped;
        private System.Windows.Forms.DataGridView dtgvDisponibilidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}