namespace GUI
{
    partial class GCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GCliente));
            this.btnAgregar = new System.Windows.Forms.Button();
            this.labDatos = new System.Windows.Forms.Label();
            this.labDNI = new System.Windows.Forms.Label();
            this.labNombre = new System.Windows.Forms.Label();
            this.labApellido = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(139, 241);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 40);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // labDatos
            // 
            this.labDatos.AutoSize = true;
            this.labDatos.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDatos.Location = new System.Drawing.Point(30, 36);
            this.labDatos.Name = "labDatos";
            this.labDatos.Size = new System.Drawing.Size(125, 19);
            this.labDatos.TabIndex = 1;
            this.labDatos.Text = "Datos del cliente";
            // 
            // labDNI
            // 
            this.labDNI.AutoSize = true;
            this.labDNI.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDNI.Location = new System.Drawing.Point(51, 102);
            this.labDNI.Name = "labDNI";
            this.labDNI.Size = new System.Drawing.Size(39, 19);
            this.labDNI.TabIndex = 2;
            this.labDNI.Text = "DNI";
            // 
            // labNombre
            // 
            this.labNombre.AutoSize = true;
            this.labNombre.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNombre.Location = new System.Drawing.Point(51, 144);
            this.labNombre.Name = "labNombre";
            this.labNombre.Size = new System.Drawing.Size(69, 19);
            this.labNombre.TabIndex = 3;
            this.labNombre.Text = "Nombre";
            // 
            // labApellido
            // 
            this.labApellido.AutoSize = true;
            this.labApellido.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labApellido.Location = new System.Drawing.Point(51, 186);
            this.labApellido.Name = "labApellido";
            this.labApellido.Size = new System.Drawing.Size(68, 19);
            this.labApellido.TabIndex = 4;
            this.labApellido.Text = "Apellido";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(303, 269);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 40);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(180, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(167, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(180, 145);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(167, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(180, 187);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(167, 20);
            this.textBox3.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(276, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // GCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(211)))), ((int)(((byte)(131)))));
            this.ClientSize = new System.Drawing.Size(415, 321);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.labApellido);
            this.Controls.Add(this.labNombre);
            this.Controls.Add(this.labDNI);
            this.Controls.Add(this.labDatos);
            this.Controls.Add(this.btnAgregar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GCliente";
            this.Text = "Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label labDatos;
        private System.Windows.Forms.Label labDNI;
        private System.Windows.Forms.Label labNombre;
        private System.Windows.Forms.Label labApellido;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}