namespace RoesTortilleria
{
    partial class AddVentaModule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddVentaModule));
            this.conceptoCombo = new System.Windows.Forms.ComboBox();
            this.colorNaranja = new System.Windows.Forms.PictureBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clientesCombo = new System.Windows.Forms.ComboBox();
            this.cuotaCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.colorNaranja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // conceptoCombo
            // 
            this.conceptoCombo.FormattingEnabled = true;
            this.conceptoCombo.Items.AddRange(new object[] {
            "Cliente",
            "Mostrador"});
            this.conceptoCombo.Location = new System.Drawing.Point(9, 141);
            this.conceptoCombo.Name = "conceptoCombo";
            this.conceptoCombo.Size = new System.Drawing.Size(76, 21);
            this.conceptoCombo.TabIndex = 1;
            this.conceptoCombo.Text = "Concepto";
            this.conceptoCombo.SelectedIndexChanged += new System.EventHandler(this.conceptoCombo_SelectedIndexChanged);
            // 
            // colorNaranja
            // 
            this.colorNaranja.Image = ((System.Drawing.Image)(resources.GetObject("colorNaranja.Image")));
            this.colorNaranja.Location = new System.Drawing.Point(11, 88);
            this.colorNaranja.Name = "colorNaranja";
            this.colorNaranja.Size = new System.Drawing.Size(320, 10);
            this.colorNaranja.TabIndex = 2;
            this.colorNaranja.TabStop = false;
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(231, 12);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(100, 55);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Logo.TabIndex = 3;
            this.Logo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 24F);
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 72);
            this.label1.TabIndex = 4;
            this.label1.Text = "Agregar\r\nVenta";
            // 
            // clientesCombo
            // 
            this.clientesCombo.Enabled = false;
            this.clientesCombo.FormattingEnabled = true;
            this.clientesCombo.Location = new System.Drawing.Point(91, 141);
            this.clientesCombo.Name = "clientesCombo";
            this.clientesCombo.Size = new System.Drawing.Size(104, 21);
            this.clientesCombo.TabIndex = 5;
            this.clientesCombo.Text = "Cliente";
            // 
            // cuotaCombo
            // 
            this.cuotaCombo.Enabled = false;
            this.cuotaCombo.FormattingEnabled = true;
            this.cuotaCombo.Items.AddRange(new object[] {
            "800gr",
            "900gr",
            "Especial"});
            this.cuotaCombo.Location = new System.Drawing.Point(201, 141);
            this.cuotaCombo.Name = "cuotaCombo";
            this.cuotaCombo.Size = new System.Drawing.Size(121, 21);
            this.cuotaCombo.TabIndex = 6;
            this.cuotaCombo.Text = "Cuota";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Concepto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cliente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cuota:";
            // 
            // AddVentaModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 303);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cuotaCombo);
            this.Controls.Add(this.clientesCombo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.colorNaranja);
            this.Controls.Add(this.conceptoCombo);
            this.Controls.Add(this.Logo);
            this.Name = "AddVentaModule";
            this.Text = "Agregar Vneta";
            ((System.ComponentModel.ISupportInitialize)(this.colorNaranja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox conceptoCombo;
        private System.Windows.Forms.PictureBox colorNaranja;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox clientesCombo;
        private System.Windows.Forms.ComboBox cuotaCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}