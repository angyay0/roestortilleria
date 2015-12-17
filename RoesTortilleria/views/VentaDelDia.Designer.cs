namespace RoesTortilleria.views
{
    partial class VentaDelDia
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ventaTortilla = new System.Windows.Forms.TextBox();
            this.ventaPrecio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kilos de Tortilla:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Venta:";
            // 
            // ventaTortilla
            // 
            this.ventaTortilla.Location = new System.Drawing.Point(180, 84);
            this.ventaTortilla.Name = "ventaTortilla";
            this.ventaTortilla.Size = new System.Drawing.Size(145, 22);
            this.ventaTortilla.TabIndex = 2;
            // 
            // ventaPrecio
            // 
            this.ventaPrecio.Location = new System.Drawing.Point(180, 129);
            this.ventaPrecio.Name = "ventaPrecio";
            this.ventaPrecio.Size = new System.Drawing.Size(145, 22);
            this.ventaPrecio.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Coral;
            this.label3.Location = new System.Drawing.Point(82, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 43);
            this.label3.TabIndex = 4;
            this.label3.Text = "Resumen de Venta";
            // 
            // VentaDelDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 260);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ventaPrecio);
            this.Controls.Add(this.ventaTortilla);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VentaDelDia";
            this.Text = "VentaDelDia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ventaTortilla;
        private System.Windows.Forms.TextBox ventaPrecio;
        private System.Windows.Forms.Label label3;
    }
}