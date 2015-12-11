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
            ManiXButton.Office2010Red office2010Red1 = new ManiXButton.Office2010Red();
            this.conceptoCombo = new System.Windows.Forms.ComboBox();
            this.colorNaranja = new System.Windows.Forms.PictureBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clientesCombo = new System.Windows.Forms.ComboBox();
            this.cuotaCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.kilosNormal = new System.Windows.Forms.TextBox();
            this.kilosSabor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.precioNormal = new System.Windows.Forms.TextBox();
            this.precioSabor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.addVenta = new ManiXButton.XButton();
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
            this.cuotaCombo.Location = new System.Drawing.Point(201, 141);
            this.cuotaCombo.Name = "cuotaCombo";
            this.cuotaCombo.Size = new System.Drawing.Size(121, 21);
            this.cuotaCombo.TabIndex = 6;
            this.cuotaCombo.Text = "Cuota";
            this.cuotaCombo.SelectedIndexChanged += new System.EventHandler(this.cuotaCombo_SelectedIndexChanged);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Normal : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Sabor : ";
            // 
            // kilosNormal
            // 
            this.kilosNormal.Location = new System.Drawing.Point(65, 213);
            this.kilosNormal.Name = "kilosNormal";
            this.kilosNormal.Size = new System.Drawing.Size(48, 20);
            this.kilosNormal.TabIndex = 12;
            this.kilosNormal.TextChanged += new System.EventHandler(this.kilosNormal_TextChanged);
            // 
            // kilosSabor
            // 
            this.kilosSabor.Location = new System.Drawing.Point(65, 246);
            this.kilosSabor.Name = "kilosSabor";
            this.kilosSabor.Size = new System.Drawing.Size(48, 20);
            this.kilosSabor.TabIndex = 13;
            this.kilosSabor.TextChanged += new System.EventHandler(this.kilosSabor_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Kilos";
            // 
            // precioNormal
            // 
            this.precioNormal.Location = new System.Drawing.Point(119, 213);
            this.precioNormal.Name = "precioNormal";
            this.precioNormal.Size = new System.Drawing.Size(76, 20);
            this.precioNormal.TabIndex = 15;
            this.precioNormal.Text = "$ 0.00";
            // 
            // precioSabor
            // 
            this.precioSabor.Location = new System.Drawing.Point(121, 248);
            this.precioSabor.Name = "precioSabor";
            this.precioSabor.Size = new System.Drawing.Size(74, 20);
            this.precioSabor.TabIndex = 16;
            this.precioSabor.Text = "$ 0.00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(136, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Precio";
            // 
            // Total
            // 
            this.Total.Location = new System.Drawing.Point(121, 279);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(73, 20);
            this.Total.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(72, 282);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Total : ";
            // 
            // addVenta
            // 
            office2010Red1.BorderColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(72)))), ((int)(((byte)(161)))));
            office2010Red1.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(135)))), ((int)(((byte)(228)))));
            office2010Red1.ButtonMouseOverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(199)))), ((int)(((byte)(87)))));
            office2010Red1.ButtonMouseOverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(215)))));
            office2010Red1.ButtonMouseOverColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(137)))));
            office2010Red1.ButtonMouseOverColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(224)))));
            office2010Red1.ButtonNormalColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(77)))), ((int)(((byte)(45)))));
            office2010Red1.ButtonNormalColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(148)))), ((int)(((byte)(64)))));
            office2010Red1.ButtonNormalColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(77)))), ((int)(((byte)(45)))));
            office2010Red1.ButtonNormalColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(148)))), ((int)(((byte)(64)))));
            office2010Red1.ButtonSelectedColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(199)))), ((int)(((byte)(87)))));
            office2010Red1.ButtonSelectedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(215)))));
            office2010Red1.ButtonSelectedColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(117)))));
            office2010Red1.ButtonSelectedColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(107)))));
            office2010Red1.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            office2010Red1.SelectedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            office2010Red1.TextColor = System.Drawing.Color.White;
            this.addVenta.ColorTable = office2010Red1;
            this.addVenta.Location = new System.Drawing.Point(213, 280);
            this.addVenta.Name = "addVenta";
            this.addVenta.Size = new System.Drawing.Size(89, 18);
            this.addVenta.TabIndex = 20;
            this.addVenta.Text = "Agregar Venta";
            this.addVenta.Theme = ManiXButton.Theme.MSOffice2010_RED;
            this.addVenta.UseVisualStyleBackColor = true;
            this.addVenta.Click += new System.EventHandler(this.addVenta_Click);
            // 
            // AddVentaModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 311);
            this.Controls.Add(this.addVenta);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.precioSabor);
            this.Controls.Add(this.precioNormal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.kilosSabor);
            this.Controls.Add(this.kilosNormal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
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
            this.Text = "Agregar Venta";
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox kilosNormal;
        private System.Windows.Forms.TextBox kilosSabor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox precioNormal;
        private System.Windows.Forms.TextBox precioSabor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Total;
        private System.Windows.Forms.Label label9;
        private ManiXButton.XButton addVenta;
    }
}