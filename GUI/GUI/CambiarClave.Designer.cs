namespace GUI
{
    partial class CambiarClave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CambiarClave));
            this.labCC = new System.Windows.Forms.Label();
            this.labContraseñaN = new System.Windows.Forms.Label();
            this.labConfirmarC = new System.Windows.Forms.Label();
            this.txtContraseñaN = new System.Windows.Forms.TextBox();
            this.txtContraseñaC = new System.Windows.Forms.TextBox();
            this.btnCambiarC = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labCC
            // 
            this.labCC.AutoSize = true;
            this.labCC.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCC.Location = new System.Drawing.Point(133, 37);
            this.labCC.Name = "labCC";
            this.labCC.Size = new System.Drawing.Size(161, 29);
            this.labCC.TabIndex = 0;
            this.labCC.Text = "Cambiar clave";
            // 
            // labContraseñaN
            // 
            this.labContraseñaN.AutoSize = true;
            this.labContraseñaN.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labContraseñaN.Location = new System.Drawing.Point(30, 98);
            this.labContraseñaN.Name = "labContraseñaN";
            this.labContraseñaN.Size = new System.Drawing.Size(136, 19);
            this.labContraseñaN.TabIndex = 1;
            this.labContraseñaN.Text = "Contraseña nueva";
            // 
            // labConfirmarC
            // 
            this.labConfirmarC.AutoSize = true;
            this.labConfirmarC.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labConfirmarC.Location = new System.Drawing.Point(30, 150);
            this.labConfirmarC.Name = "labConfirmarC";
            this.labConfirmarC.Size = new System.Drawing.Size(167, 19);
            this.labConfirmarC.TabIndex = 2;
            this.labConfirmarC.Text = "Confirmar contraseña ";
            // 
            // txtContraseñaN
            // 
            this.txtContraseñaN.Location = new System.Drawing.Point(215, 99);
            this.txtContraseñaN.Name = "txtContraseñaN";
            this.txtContraseñaN.Size = new System.Drawing.Size(158, 20);
            this.txtContraseñaN.TabIndex = 3;
            // 
            // txtContraseñaC
            // 
            this.txtContraseñaC.Location = new System.Drawing.Point(215, 151);
            this.txtContraseñaC.Name = "txtContraseñaC";
            this.txtContraseñaC.Size = new System.Drawing.Size(158, 20);
            this.txtContraseñaC.TabIndex = 4;
            // 
            // btnCambiarC
            // 
            this.btnCambiarC.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarC.Location = new System.Drawing.Point(160, 209);
            this.btnCambiarC.Name = "btnCambiarC";
            this.btnCambiarC.Size = new System.Drawing.Size(106, 57);
            this.btnCambiarC.TabIndex = 5;
            this.btnCambiarC.Text = "Cambiar clave";
            this.btnCambiarC.UseVisualStyleBackColor = true;
            this.btnCambiarC.Click += new System.EventHandler(this.btnCambiarC_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 227);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(318, 268);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(91, 41);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // CambiarClave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(211)))), ((int)(((byte)(131)))));
            this.ClientSize = new System.Drawing.Size(421, 321);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCambiarC);
            this.Controls.Add(this.txtContraseñaC);
            this.Controls.Add(this.txtContraseñaN);
            this.Controls.Add(this.labConfirmarC);
            this.Controls.Add(this.labContraseñaN);
            this.Controls.Add(this.labCC);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CambiarClave";
            this.Text = "Cambiar Clave";
            this.Load += new System.EventHandler(this.CambiarClave_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labCC;
        private System.Windows.Forms.Label labContraseñaN;
        private System.Windows.Forms.Label labConfirmarC;
        private System.Windows.Forms.TextBox txtContraseñaN;
        private System.Windows.Forms.TextBox txtContraseñaC;
        private System.Windows.Forms.Button btnCambiarC;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSalir;
    }
}