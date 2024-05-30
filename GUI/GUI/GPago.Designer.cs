namespace GUI
{
    partial class GPago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GPago));
            this.labResumen = new System.Windows.Forms.Label();
            this.listResumen = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbEfectivo = new System.Windows.Forms.RadioButton();
            this.rbTransferencia = new System.Windows.Forms.RadioButton();
            this.rbMp = new System.Windows.Forms.RadioButton();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labResumen
            // 
            this.labResumen.AutoSize = true;
            this.labResumen.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labResumen.Location = new System.Drawing.Point(31, 25);
            this.labResumen.Name = "labResumen";
            this.labResumen.Size = new System.Drawing.Size(166, 19);
            this.labResumen.TabIndex = 0;
            this.labResumen.Text = "Resumen de la reserva";
            // 
            // listResumen
            // 
            this.listResumen.HideSelection = false;
            this.listResumen.Location = new System.Drawing.Point(35, 66);
            this.listResumen.Name = "listResumen";
            this.listResumen.Size = new System.Drawing.Size(212, 226);
            this.listResumen.TabIndex = 1;
            this.listResumen.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbMp);
            this.groupBox1.Controls.Add(this.rbTransferencia);
            this.groupBox1.Controls.Add(this.rbEfectivo);
            this.groupBox1.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(292, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 180);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipos de pago";
            // 
            // rbEfectivo
            // 
            this.rbEfectivo.AutoSize = true;
            this.rbEfectivo.Checked = true;
            this.rbEfectivo.Location = new System.Drawing.Point(42, 42);
            this.rbEfectivo.Name = "rbEfectivo";
            this.rbEfectivo.Size = new System.Drawing.Size(83, 23);
            this.rbEfectivo.TabIndex = 0;
            this.rbEfectivo.TabStop = true;
            this.rbEfectivo.Text = "Efectivo";
            this.rbEfectivo.UseVisualStyleBackColor = true;
            // 
            // rbTransferencia
            // 
            this.rbTransferencia.AutoSize = true;
            this.rbTransferencia.Location = new System.Drawing.Point(42, 85);
            this.rbTransferencia.Name = "rbTransferencia";
            this.rbTransferencia.Size = new System.Drawing.Size(120, 23);
            this.rbTransferencia.TabIndex = 1;
            this.rbTransferencia.Text = "Transferencia";
            this.rbTransferencia.UseVisualStyleBackColor = true;
            // 
            // rbMp
            // 
            this.rbMp.AutoSize = true;
            this.rbMp.Location = new System.Drawing.Point(42, 128);
            this.rbMp.Name = "rbMp";
            this.rbMp.Size = new System.Drawing.Size(130, 23);
            this.rbMp.TabIndex = 2;
            this.rbMp.Text = "Mercado pago";
            this.rbMp.UseVisualStyleBackColor = true;
            // 
            // btnCobrar
            // 
            this.btnCobrar.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCobrar.Location = new System.Drawing.Point(277, 249);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(113, 43);
            this.btnCobrar.TabIndex = 3;
            this.btnCobrar.Text = "Cobrar";
            this.btnCobrar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(396, 249);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(113, 43);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // GPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(211)))), ((int)(((byte)(131)))));
            this.ClientSize = new System.Drawing.Size(549, 314);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCobrar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listResumen);
            this.Controls.Add(this.labResumen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GPago";
            this.Text = "Pago";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labResumen;
        private System.Windows.Forms.ListView listResumen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbMp;
        private System.Windows.Forms.RadioButton rbTransferencia;
        private System.Windows.Forms.RadioButton rbEfectivo;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.Button btnCancelar;
    }
}