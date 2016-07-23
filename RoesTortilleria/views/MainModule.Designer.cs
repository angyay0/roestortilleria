using System;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace RoesTortilleria.views
{
    partial class MainModule
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
            ManiXButton.Office2010Blue office2010Blue1 = new ManiXButton.Office2010Blue();
            ManiXButton.Office2010Green office2010Green1 = new ManiXButton.Office2010Green();
            ManiXButton.Office2010Yellow office2010Yellow1 = new ManiXButton.Office2010Yellow();
            ManiXButton.Office2010Red office2010Red1 = new ManiXButton.Office2010Red();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainModule));
            ManiXButton.Colortable colortable1 = new ManiXButton.Colortable();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabVenta = new System.Windows.Forms.TabPage();
            this.btnCorte = new ManiXButton.XButton();
            this.addVenta = new ManiXButton.XButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.datePickerVenta = new System.Windows.Forms.DateTimePicker();
            this.tableVenta = new System.Windows.Forms.TableLayoutPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.cantidadMostrador = new System.Windows.Forms.TextBox();
            this.cantidad_800 = new System.Windows.Forms.TextBox();
            this.cantidad_900 = new System.Windows.Forms.TextBox();
            this.especial_cantidad = new System.Windows.Forms.TextBox();
            this.mostrador_Normal = new System.Windows.Forms.TextBox();
            this.normal_800 = new System.Windows.Forms.TextBox();
            this.normal_900 = new System.Windows.Forms.TextBox();
            this.especial_Normal = new System.Windows.Forms.TextBox();
            this.mostador_Sabor = new System.Windows.Forms.TextBox();
            this.sabor_800 = new System.Windows.Forms.TextBox();
            this.sabor_900 = new System.Windows.Forms.TextBox();
            this.especial_Sabor = new System.Windows.Forms.TextBox();
            this.monto_Mostrador = new System.Windows.Forms.TextBox();
            this.monto_800 = new System.Windows.Forms.TextBox();
            this.monto_900 = new System.Windows.Forms.TextBox();
            this.especial_monto = new System.Windows.Forms.TextBox();
            this.tabCorte = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.tabProduc = new System.Windows.Forms.TabPage();
            this.addProduccion = new ManiXButton.XButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.datePickerProd = new System.Windows.Forms.DateTimePicker();
            this.tableProd = new System.Windows.Forms.TableLayoutPanel();
            this.detalleBtn = new ManiXButton.XButton();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.finalizarBtn = new ManiXButton.XButton();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.lSacoMaseca = new System.Windows.Forms.Label();
            this.lKiloMas = new System.Windows.Forms.Label();
            this.lKiloMinsa = new System.Windows.Forms.Label();
            this.lKGHarina = new System.Windows.Forms.Label();
            this.lTortilla = new System.Windows.Forms.Label();
            this.lKGSobra = new System.Windows.Forms.Label();
            this.lFTortilla = new System.Windows.Forms.Label();
            this.tabAlmacen = new System.Windows.Forms.TabPage();
            this.addInventario = new ManiXButton.XButton();
            this.label8 = new System.Windows.Forms.Label();
            this.tableInventario = new System.Windows.Forms.TableLayoutPanel();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.lSacosInv = new System.Windows.Forms.Label();
            this.lKGMInv = new System.Windows.Forms.Label();
            this.tabGastos = new System.Windows.Forms.TabPage();
            this.montoTotal = new System.Windows.Forms.Label();
            this.addGasto = new ManiXButton.XButton();
            this.label9 = new System.Windows.Forms.Label();
            this.tableGastos = new System.Windows.Forms.TableLayoutPanel();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.tabClientes = new System.Windows.Forms.TabPage();
            this.tableCliente = new System.Windows.Forms.TableLayoutPanel();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.addCliente = new ManiXButton.XButton();
            this.tabFactNot = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.usertype = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.tabSysUser = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.xButton1 = new ManiXButton.XButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabVenta.SuspendLayout();
            this.tableVenta.SuspendLayout();
            this.tabCorte.SuspendLayout();
            this.tabProduc.SuspendLayout();
            this.tableProd.SuspendLayout();
            this.tabAlmacen.SuspendLayout();
            this.tableInventario.SuspendLayout();
            this.tabGastos.SuspendLayout();
            this.tableGastos.SuspendLayout();
            this.tabClientes.SuspendLayout();
            this.tableCliente.SuspendLayout();
            this.tabFactNot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabSysUser.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabVenta);
            this.tabControl.Controls.Add(this.tabCorte);
            this.tabControl.Controls.Add(this.tabProduc);
            this.tabControl.Controls.Add(this.tabAlmacen);
            this.tabControl.Controls.Add(this.tabGastos);
            this.tabControl.Controls.Add(this.tabClientes);
            this.tabControl.Controls.Add(this.tabFactNot);
            this.tabControl.Controls.Add(this.tabSysUser);
            this.tabControl.Location = new System.Drawing.Point(5, 49);
            this.tabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(961, 534);
            this.tabControl.TabIndex = 0;
            // 
            // tabVenta
            // 
            this.tabVenta.BackColor = System.Drawing.SystemColors.Control;
            this.tabVenta.Controls.Add(this.btnCorte);
            this.tabVenta.Controls.Add(this.addVenta);
            this.tabVenta.Controls.Add(this.label4);
            this.tabVenta.Controls.Add(this.label3);
            this.tabVenta.Controls.Add(this.datePickerVenta);
            this.tabVenta.Controls.Add(this.tableVenta);
            this.tabVenta.Location = new System.Drawing.Point(4, 25);
            this.tabVenta.Margin = new System.Windows.Forms.Padding(2);
            this.tabVenta.Name = "tabVenta";
            this.tabVenta.Padding = new System.Windows.Forms.Padding(2);
            this.tabVenta.Size = new System.Drawing.Size(953, 505);
            this.tabVenta.TabIndex = 2;
            this.tabVenta.Text = "Ventas";
            // 
            // btnCorte
            // 
            office2010Blue1.BorderColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(72)))), ((int)(((byte)(161)))));
            office2010Blue1.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(135)))), ((int)(((byte)(228)))));
            office2010Blue1.ButtonMouseOverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(199)))), ((int)(((byte)(87)))));
            office2010Blue1.ButtonMouseOverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(215)))));
            office2010Blue1.ButtonMouseOverColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(137)))));
            office2010Blue1.ButtonMouseOverColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(224)))));
            office2010Blue1.ButtonNormalColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(72)))), ((int)(((byte)(161)))));
            office2010Blue1.ButtonNormalColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(135)))), ((int)(((byte)(228)))));
            office2010Blue1.ButtonNormalColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(97)))), ((int)(((byte)(181)))));
            office2010Blue1.ButtonNormalColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(125)))), ((int)(((byte)(219)))));
            office2010Blue1.ButtonSelectedColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(199)))), ((int)(((byte)(87)))));
            office2010Blue1.ButtonSelectedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(215)))));
            office2010Blue1.ButtonSelectedColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(117)))));
            office2010Blue1.ButtonSelectedColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(107)))));
            office2010Blue1.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            office2010Blue1.SelectedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            office2010Blue1.TextColor = System.Drawing.Color.White;
            this.btnCorte.ColorTable = office2010Blue1;
            this.btnCorte.Location = new System.Drawing.Point(836, 214);
            this.btnCorte.Name = "btnCorte";
            this.btnCorte.Size = new System.Drawing.Size(103, 44);
            this.btnCorte.TabIndex = 5;
            this.btnCorte.Text = "Venta del Día";
            this.btnCorte.Theme = ManiXButton.Theme.MSOffice2010_BLUE;
            this.btnCorte.UseVisualStyleBackColor = true;
            this.btnCorte.Click += new System.EventHandler(this.btnCorte_Click);
            // 
            // addVenta
            // 
            office2010Green1.BorderColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(72)))), ((int)(((byte)(161)))));
            office2010Green1.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(135)))), ((int)(((byte)(228)))));
            office2010Green1.ButtonMouseOverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(199)))), ((int)(((byte)(87)))));
            office2010Green1.ButtonMouseOverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(215)))));
            office2010Green1.ButtonMouseOverColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(137)))));
            office2010Green1.ButtonMouseOverColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(224)))));
            office2010Green1.ButtonNormalColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(126)))), ((int)(((byte)(43)))));
            office2010Green1.ButtonNormalColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(184)))), ((int)(((byte)(67)))));
            office2010Green1.ButtonNormalColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(126)))), ((int)(((byte)(43)))));
            office2010Green1.ButtonNormalColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(184)))), ((int)(((byte)(67)))));
            office2010Green1.ButtonSelectedColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(199)))), ((int)(((byte)(87)))));
            office2010Green1.ButtonSelectedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(215)))));
            office2010Green1.ButtonSelectedColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(117)))));
            office2010Green1.ButtonSelectedColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(107)))));
            office2010Green1.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            office2010Green1.SelectedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            office2010Green1.TextColor = System.Drawing.Color.White;
            this.addVenta.ColorTable = office2010Green1;
            this.addVenta.Location = new System.Drawing.Point(835, 159);
            this.addVenta.Margin = new System.Windows.Forms.Padding(4);
            this.addVenta.Name = "addVenta";
            this.addVenta.Size = new System.Drawing.Size(104, 48);
            this.addVenta.TabIndex = 4;
            this.addVenta.Text = "Agregar Venta";
            this.addVenta.Theme = ManiXButton.Theme.MSOffice2010_Green;
            this.addVenta.UseVisualStyleBackColor = true;
            this.addVenta.Click += new System.EventHandler(this.addVenta_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.ForestGreen;
            this.label4.Location = new System.Drawing.Point(14, 41);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 69);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ventas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(426, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha:";
            // 
            // datePickerVenta
            // 
            this.datePickerVenta.Location = new System.Drawing.Point(513, 75);
            this.datePickerVenta.Margin = new System.Windows.Forms.Padding(2);
            this.datePickerVenta.Name = "datePickerVenta";
            this.datePickerVenta.Size = new System.Drawing.Size(151, 22);
            this.datePickerVenta.TabIndex = 1;
            this.datePickerVenta.ValueChanged += new System.EventHandler(this.datePickerVenta_ValueChanged);
            // 
            // tableVenta
            // 
            this.tableVenta.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableVenta.ColumnCount = 5;
            this.tableVenta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableVenta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableVenta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableVenta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableVenta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableVenta.Controls.Add(this.label12, 0, 0);
            this.tableVenta.Controls.Add(this.label13, 1, 0);
            this.tableVenta.Controls.Add(this.label14, 2, 0);
            this.tableVenta.Controls.Add(this.label15, 3, 0);
            this.tableVenta.Controls.Add(this.label16, 4, 0);
            this.tableVenta.Controls.Add(this.label17, 0, 1);
            this.tableVenta.Controls.Add(this.label18, 0, 2);
            this.tableVenta.Controls.Add(this.label19, 0, 3);
            this.tableVenta.Controls.Add(this.label20, 0, 4);
            this.tableVenta.Controls.Add(this.cantidadMostrador, 1, 1);
            this.tableVenta.Controls.Add(this.cantidad_800, 1, 2);
            this.tableVenta.Controls.Add(this.cantidad_900, 1, 3);
            this.tableVenta.Controls.Add(this.especial_cantidad, 1, 4);
            this.tableVenta.Controls.Add(this.mostrador_Normal, 2, 1);
            this.tableVenta.Controls.Add(this.normal_800, 2, 2);
            this.tableVenta.Controls.Add(this.normal_900, 2, 3);
            this.tableVenta.Controls.Add(this.especial_Normal, 2, 4);
            this.tableVenta.Controls.Add(this.mostador_Sabor, 3, 1);
            this.tableVenta.Controls.Add(this.sabor_800, 3, 2);
            this.tableVenta.Controls.Add(this.sabor_900, 3, 3);
            this.tableVenta.Controls.Add(this.especial_Sabor, 3, 4);
            this.tableVenta.Controls.Add(this.monto_Mostrador, 4, 1);
            this.tableVenta.Controls.Add(this.monto_800, 4, 2);
            this.tableVenta.Controls.Add(this.monto_900, 4, 3);
            this.tableVenta.Controls.Add(this.especial_monto, 4, 4);
            this.tableVenta.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableVenta.Location = new System.Drawing.Point(24, 129);
            this.tableVenta.Margin = new System.Windows.Forms.Padding(2);
            this.tableVenta.Name = "tableVenta";
            this.tableVenta.RowCount = 5;
            this.tableVenta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableVenta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableVenta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableVenta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableVenta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableVenta.Size = new System.Drawing.Size(803, 273);
            this.tableVenta.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(47, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Concepto";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(209, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 17);
            this.label13.TabIndex = 1;
            this.label13.Text = "Cantidad";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(375, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 17);
            this.label14.TabIndex = 2;
            this.label14.Text = "Normal";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(538, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 17);
            this.label15.TabIndex = 3;
            this.label15.Text = "Sabor";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(698, 20);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 17);
            this.label16.TabIndex = 4;
            this.label16.Text = "Monto";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(45, 74);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 17);
            this.label17.TabIndex = 5;
            this.label17.Text = "Mostrador";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(59, 128);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(45, 17);
            this.label18.TabIndex = 6;
            this.label18.Text = "800gr";
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(59, 182);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(45, 17);
            this.label19.TabIndex = 7;
            this.label19.Text = "900gr";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(31, 236);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(101, 17);
            this.label20.TabIndex = 8;
            this.label20.Text = "Especial Oasis";
            // 
            // cantidadMostrador
            // 
            this.cantidadMostrador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cantidadMostrador.Enabled = false;
            this.cantidadMostrador.Location = new System.Drawing.Point(187, 71);
            this.cantidadMostrador.Name = "cantidadMostrador";
            this.cantidadMostrador.Size = new System.Drawing.Size(109, 22);
            this.cantidadMostrador.TabIndex = 9;
            this.cantidadMostrador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cantidad_800
            // 
            this.cantidad_800.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cantidad_800.Enabled = false;
            this.cantidad_800.Location = new System.Drawing.Point(187, 125);
            this.cantidad_800.Name = "cantidad_800";
            this.cantidad_800.Size = new System.Drawing.Size(109, 22);
            this.cantidad_800.TabIndex = 10;
            this.cantidad_800.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cantidad_900
            // 
            this.cantidad_900.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cantidad_900.Enabled = false;
            this.cantidad_900.Location = new System.Drawing.Point(191, 179);
            this.cantidad_900.Name = "cantidad_900";
            this.cantidad_900.Size = new System.Drawing.Size(100, 22);
            this.cantidad_900.TabIndex = 11;
            this.cantidad_900.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // especial_cantidad
            // 
            this.especial_cantidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.especial_cantidad.Enabled = false;
            this.especial_cantidad.Location = new System.Drawing.Point(191, 233);
            this.especial_cantidad.Name = "especial_cantidad";
            this.especial_cantidad.Size = new System.Drawing.Size(100, 22);
            this.especial_cantidad.TabIndex = 12;
            this.especial_cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mostrador_Normal
            // 
            this.mostrador_Normal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mostrador_Normal.Enabled = false;
            this.mostrador_Normal.Location = new System.Drawing.Point(351, 71);
            this.mostrador_Normal.Name = "mostrador_Normal";
            this.mostrador_Normal.Size = new System.Drawing.Size(100, 22);
            this.mostrador_Normal.TabIndex = 13;
            this.mostrador_Normal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // normal_800
            // 
            this.normal_800.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.normal_800.Enabled = false;
            this.normal_800.Location = new System.Drawing.Point(349, 125);
            this.normal_800.Name = "normal_800";
            this.normal_800.Size = new System.Drawing.Size(104, 22);
            this.normal_800.TabIndex = 14;
            this.normal_800.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // normal_900
            // 
            this.normal_900.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.normal_900.Enabled = false;
            this.normal_900.Location = new System.Drawing.Point(349, 179);
            this.normal_900.Name = "normal_900";
            this.normal_900.Size = new System.Drawing.Size(104, 22);
            this.normal_900.TabIndex = 15;
            this.normal_900.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // especial_Normal
            // 
            this.especial_Normal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.especial_Normal.Enabled = false;
            this.especial_Normal.Location = new System.Drawing.Point(351, 233);
            this.especial_Normal.Name = "especial_Normal";
            this.especial_Normal.Size = new System.Drawing.Size(100, 22);
            this.especial_Normal.TabIndex = 16;
            this.especial_Normal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mostador_Sabor
            // 
            this.mostador_Sabor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mostador_Sabor.Enabled = false;
            this.mostador_Sabor.Location = new System.Drawing.Point(511, 71);
            this.mostador_Sabor.Name = "mostador_Sabor";
            this.mostador_Sabor.Size = new System.Drawing.Size(100, 22);
            this.mostador_Sabor.TabIndex = 17;
            this.mostador_Sabor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sabor_800
            // 
            this.sabor_800.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sabor_800.Enabled = false;
            this.sabor_800.Location = new System.Drawing.Point(511, 125);
            this.sabor_800.Name = "sabor_800";
            this.sabor_800.Size = new System.Drawing.Size(100, 22);
            this.sabor_800.TabIndex = 18;
            this.sabor_800.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sabor_900
            // 
            this.sabor_900.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sabor_900.Enabled = false;
            this.sabor_900.Location = new System.Drawing.Point(511, 179);
            this.sabor_900.Name = "sabor_900";
            this.sabor_900.Size = new System.Drawing.Size(100, 22);
            this.sabor_900.TabIndex = 19;
            this.sabor_900.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // especial_Sabor
            // 
            this.especial_Sabor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.especial_Sabor.Enabled = false;
            this.especial_Sabor.Location = new System.Drawing.Point(511, 233);
            this.especial_Sabor.Name = "especial_Sabor";
            this.especial_Sabor.Size = new System.Drawing.Size(100, 22);
            this.especial_Sabor.TabIndex = 20;
            this.especial_Sabor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // monto_Mostrador
            // 
            this.monto_Mostrador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.monto_Mostrador.Enabled = false;
            this.monto_Mostrador.Location = new System.Drawing.Point(671, 71);
            this.monto_Mostrador.Name = "monto_Mostrador";
            this.monto_Mostrador.Size = new System.Drawing.Size(100, 22);
            this.monto_Mostrador.TabIndex = 21;
            this.monto_Mostrador.Text = "$0.00";
            this.monto_Mostrador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // monto_800
            // 
            this.monto_800.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.monto_800.Enabled = false;
            this.monto_800.Location = new System.Drawing.Point(671, 125);
            this.monto_800.Name = "monto_800";
            this.monto_800.Size = new System.Drawing.Size(100, 22);
            this.monto_800.TabIndex = 22;
            this.monto_800.Text = "$0.00";
            this.monto_800.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // monto_900
            // 
            this.monto_900.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.monto_900.Enabled = false;
            this.monto_900.Location = new System.Drawing.Point(671, 179);
            this.monto_900.Name = "monto_900";
            this.monto_900.Size = new System.Drawing.Size(100, 22);
            this.monto_900.TabIndex = 23;
            this.monto_900.Text = "$0.00";
            this.monto_900.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // especial_monto
            // 
            this.especial_monto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.especial_monto.Enabled = false;
            this.especial_monto.Location = new System.Drawing.Point(671, 233);
            this.especial_monto.Name = "especial_monto";
            this.especial_monto.Size = new System.Drawing.Size(100, 22);
            this.especial_monto.TabIndex = 24;
            this.especial_monto.Text = "$0.00";
            this.especial_monto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabCorte
            // 
            this.tabCorte.BackColor = System.Drawing.SystemColors.Control;
            this.tabCorte.Controls.Add(this.label5);
            this.tabCorte.Location = new System.Drawing.Point(4, 25);
            this.tabCorte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabCorte.Name = "tabCorte";
            this.tabCorte.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabCorte.Size = new System.Drawing.Size(953, 505);
            this.tabCorte.TabIndex = 7;
            this.tabCorte.Text = "Corte";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(405, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Siguiente Entrega";
            // 
            // tabProduc
            // 
            this.tabProduc.BackColor = System.Drawing.SystemColors.Control;
            this.tabProduc.Controls.Add(this.addProduccion);
            this.tabProduc.Controls.Add(this.label7);
            this.tabProduc.Controls.Add(this.label6);
            this.tabProduc.Controls.Add(this.datePickerProd);
            this.tabProduc.Controls.Add(this.tableProd);
            this.tabProduc.Location = new System.Drawing.Point(4, 25);
            this.tabProduc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabProduc.Name = "tabProduc";
            this.tabProduc.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabProduc.Size = new System.Drawing.Size(953, 505);
            this.tabProduc.TabIndex = 4;
            this.tabProduc.Text = "Producción del Día";
            // 
            // addProduccion
            // 
            this.addProduccion.ColorTable = office2010Green1;
            this.addProduccion.Location = new System.Drawing.Point(755, 133);
            this.addProduccion.Margin = new System.Windows.Forms.Padding(4);
            this.addProduccion.Name = "addProduccion";
            this.addProduccion.Size = new System.Drawing.Size(160, 30);
            this.addProduccion.TabIndex = 7;
            this.addProduccion.Text = "Agregar Producción";
            this.addProduccion.Theme = ManiXButton.Theme.MSOffice2010_Green;
            this.addProduccion.UseVisualStyleBackColor = true;
            this.addProduccion.Click += new System.EventHandler(this.addProduccion_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.ForestGreen;
            this.label7.Location = new System.Drawing.Point(186, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(329, 69);
            this.label7.TabIndex = 6;
            this.label7.Text = "Producción";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(576, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fecha:";
            // 
            // datePickerProd
            // 
            this.datePickerProd.Location = new System.Drawing.Point(633, 105);
            this.datePickerProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datePickerProd.Name = "datePickerProd";
            this.datePickerProd.Size = new System.Drawing.Size(200, 22);
            this.datePickerProd.TabIndex = 4;
            this.datePickerProd.ValueChanged += new System.EventHandler(this.datePickerProd_ValueChanged);
            // 
            // tableProd
            // 
            this.tableProd.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableProd.ColumnCount = 8;
            this.tableProd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.50117F));
            this.tableProd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.50117F));
            this.tableProd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.50117F));
            this.tableProd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.50117F));
            this.tableProd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.50117F));
            this.tableProd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.49992F));
            this.tableProd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.49714F));
            this.tableProd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.49707F));
            this.tableProd.Controls.Add(this.detalleBtn, 7, 0);
            this.tableProd.Controls.Add(this.label26, 0, 0);
            this.tableProd.Controls.Add(this.label27, 1, 0);
            this.tableProd.Controls.Add(this.finalizarBtn, 7, 1);
            this.tableProd.Controls.Add(this.label28, 2, 0);
            this.tableProd.Controls.Add(this.label29, 3, 0);
            this.tableProd.Controls.Add(this.label30, 4, 0);
            this.tableProd.Controls.Add(this.label31, 5, 0);
            this.tableProd.Controls.Add(this.label32, 6, 0);
            this.tableProd.Controls.Add(this.lSacoMaseca, 0, 1);
            this.tableProd.Controls.Add(this.lKiloMas, 1, 1);
            this.tableProd.Controls.Add(this.lKiloMinsa, 2, 1);
            this.tableProd.Controls.Add(this.lKGHarina, 3, 1);
            this.tableProd.Controls.Add(this.lTortilla, 4, 1);
            this.tableProd.Controls.Add(this.lKGSobra, 5, 1);
            this.tableProd.Controls.Add(this.lFTortilla, 6, 1);
            this.tableProd.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableProd.Location = new System.Drawing.Point(29, 169);
            this.tableProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableProd.Name = "tableProd";
            this.tableProd.RowCount = 2;
            this.tableProd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tableProd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.42857F));
            this.tableProd.Size = new System.Drawing.Size(886, 142);
            this.tableProd.TabIndex = 3;
            // 
            // detalleBtn
            // 
            office2010Yellow1.BorderColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(72)))), ((int)(((byte)(161)))));
            office2010Yellow1.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(135)))), ((int)(((byte)(228)))));
            office2010Yellow1.ButtonMouseOverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(199)))), ((int)(((byte)(87)))));
            office2010Yellow1.ButtonMouseOverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(215)))));
            office2010Yellow1.ButtonMouseOverColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(137)))));
            office2010Yellow1.ButtonMouseOverColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(224)))));
            office2010Yellow1.ButtonNormalColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(161)))), ((int)(((byte)(8)))));
            office2010Yellow1.ButtonNormalColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(191)))), ((int)(((byte)(45)))));
            office2010Yellow1.ButtonNormalColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(161)))), ((int)(((byte)(8)))));
            office2010Yellow1.ButtonNormalColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(191)))), ((int)(((byte)(45)))));
            office2010Yellow1.ButtonSelectedColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(199)))), ((int)(((byte)(87)))));
            office2010Yellow1.ButtonSelectedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(215)))));
            office2010Yellow1.ButtonSelectedColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(117)))));
            office2010Yellow1.ButtonSelectedColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(107)))));
            office2010Yellow1.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            office2010Yellow1.SelectedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            office2010Yellow1.TextColor = System.Drawing.Color.White;
            this.detalleBtn.ColorTable = office2010Yellow1;
            this.detalleBtn.Location = new System.Drawing.Point(777, 7);
            this.detalleBtn.Margin = new System.Windows.Forms.Padding(4);
            this.detalleBtn.Name = "detalleBtn";
            this.detalleBtn.Size = new System.Drawing.Size(102, 30);
            this.detalleBtn.TabIndex = 8;
            this.detalleBtn.Text = "Ver Detalle";
            this.detalleBtn.Theme = ManiXButton.Theme.MSOffice2010_Yellow;
            this.detalleBtn.UseVisualStyleBackColor = true;
            this.detalleBtn.Click += new System.EventHandler(this.detalleBtn_Click);
            // 
            // label26
            // 
            this.label26.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(29, 13);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(55, 17);
            this.label26.TabIndex = 0;
            this.label26.Text = "SACOS";
            // 
            // label27
            // 
            this.label27.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(142, 13);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(48, 17);
            this.label27.TabIndex = 1;
            this.label27.Text = "KILOS";
            // 
            // finalizarBtn
            // 
            this.finalizarBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.finalizarBtn.ColorTable = office2010Red1;
            this.finalizarBtn.Location = new System.Drawing.Point(777, 76);
            this.finalizarBtn.Margin = new System.Windows.Forms.Padding(4);
            this.finalizarBtn.Name = "finalizarBtn";
            this.finalizarBtn.Size = new System.Drawing.Size(102, 30);
            this.finalizarBtn.TabIndex = 8;
            this.finalizarBtn.Text = "Finalizar";
            this.finalizarBtn.Theme = ManiXButton.Theme.MSOffice2010_RED;
            this.finalizarBtn.UseVisualStyleBackColor = true;
            this.finalizarBtn.Click += new System.EventHandler(this.finalizarBtn_Click);
            // 
            // label28
            // 
            this.label28.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(251, 13);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(50, 17);
            this.label28.TabIndex = 2;
            this.label28.Text = "MINSA";
            // 
            // label29
            // 
            this.label29.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(345, 13);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(83, 17);
            this.label29.TabIndex = 3;
            this.label29.Text = "KG HARINA";
            // 
            // label30
            // 
            this.label30.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(459, 13);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(75, 17);
            this.label30.TabIndex = 4;
            this.label30.Text = "TORTILLA";
            // 
            // label31
            // 
            this.label31.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(564, 13);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(84, 17);
            this.label31.TabIndex = 5;
            this.label31.Text = "SOBRANTE";
            // 
            // label32
            // 
            this.label32.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(689, 13);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(54, 17);
            this.label32.TabIndex = 6;
            this.label32.Text = "VENTA";
            // 
            // lSacoMaseca
            // 
            this.lSacoMaseca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lSacoMaseca.AutoSize = true;
            this.lSacoMaseca.Location = new System.Drawing.Point(26, 74);
            this.lSacoMaseca.Name = "lSacoMaseca";
            this.lSacoMaseca.Size = new System.Drawing.Size(61, 34);
            this.lSacoMaseca.TabIndex = 9;
            this.lSacoMaseca.Text = "No Hay Registro";
            // 
            // lKiloMas
            // 
            this.lKiloMas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lKiloMas.AutoSize = true;
            this.lKiloMas.Location = new System.Drawing.Point(136, 74);
            this.lKiloMas.Name = "lKiloMas";
            this.lKiloMas.Size = new System.Drawing.Size(61, 34);
            this.lKiloMas.TabIndex = 10;
            this.lKiloMas.Text = "No Hay Registro";
            // 
            // lKiloMinsa
            // 
            this.lKiloMinsa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lKiloMinsa.AutoSize = true;
            this.lKiloMinsa.Location = new System.Drawing.Point(246, 74);
            this.lKiloMinsa.Name = "lKiloMinsa";
            this.lKiloMinsa.Size = new System.Drawing.Size(61, 34);
            this.lKiloMinsa.TabIndex = 11;
            this.lKiloMinsa.Text = "No Hay Registro";
            // 
            // lKGHarina
            // 
            this.lKGHarina.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lKGHarina.AutoSize = true;
            this.lKGHarina.Location = new System.Drawing.Point(356, 74);
            this.lKGHarina.Name = "lKGHarina";
            this.lKGHarina.Size = new System.Drawing.Size(61, 34);
            this.lKGHarina.TabIndex = 12;
            this.lKGHarina.Text = "No Hay Registro";
            // 
            // lTortilla
            // 
            this.lTortilla.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lTortilla.AutoSize = true;
            this.lTortilla.Location = new System.Drawing.Point(466, 74);
            this.lTortilla.Name = "lTortilla";
            this.lTortilla.Size = new System.Drawing.Size(61, 34);
            this.lTortilla.TabIndex = 13;
            this.lTortilla.Text = "No Hay Registro";
            // 
            // lKGSobra
            // 
            this.lKGSobra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lKGSobra.AutoSize = true;
            this.lKGSobra.Location = new System.Drawing.Point(576, 74);
            this.lKGSobra.Name = "lKGSobra";
            this.lKGSobra.Size = new System.Drawing.Size(61, 34);
            this.lKGSobra.TabIndex = 14;
            this.lKGSobra.Text = "No Hay Registro";
            // 
            // lFTortilla
            // 
            this.lFTortilla.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lFTortilla.AutoSize = true;
            this.lFTortilla.Location = new System.Drawing.Point(686, 74);
            this.lFTortilla.Name = "lFTortilla";
            this.lFTortilla.Size = new System.Drawing.Size(61, 34);
            this.lFTortilla.TabIndex = 15;
            this.lFTortilla.Text = "No Hay Registro";
            // 
            // tabAlmacen
            // 
            this.tabAlmacen.BackColor = System.Drawing.SystemColors.Control;
            this.tabAlmacen.Controls.Add(this.addInventario);
            this.tabAlmacen.Controls.Add(this.label8);
            this.tabAlmacen.Controls.Add(this.tableInventario);
            this.tabAlmacen.Location = new System.Drawing.Point(4, 25);
            this.tabAlmacen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAlmacen.Name = "tabAlmacen";
            this.tabAlmacen.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAlmacen.Size = new System.Drawing.Size(953, 505);
            this.tabAlmacen.TabIndex = 3;
            this.tabAlmacen.Text = "Almacen";
            // 
            // addInventario
            // 
            this.addInventario.ColorTable = office2010Green1;
            this.addInventario.Location = new System.Drawing.Point(726, 323);
            this.addInventario.Margin = new System.Windows.Forms.Padding(4);
            this.addInventario.Name = "addInventario";
            this.addInventario.Size = new System.Drawing.Size(149, 53);
            this.addInventario.TabIndex = 9;
            this.addInventario.Text = "Agregar a Inventario";
            this.addInventario.Theme = ManiXButton.Theme.MSOffice2010_Green;
            this.addInventario.UseVisualStyleBackColor = true;
            this.addInventario.Click += new System.EventHandler(this.addInventario_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.ForestGreen;
            this.label8.Location = new System.Drawing.Point(344, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(293, 69);
            this.label8.TabIndex = 8;
            this.label8.Text = "Inventario";
            // 
            // tableInventario
            // 
            this.tableInventario.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableInventario.ColumnCount = 2;
            this.tableInventario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableInventario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableInventario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableInventario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableInventario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableInventario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableInventario.Controls.Add(this.label33, 0, 0);
            this.tableInventario.Controls.Add(this.label34, 1, 0);
            this.tableInventario.Controls.Add(this.lSacosInv, 0, 1);
            this.tableInventario.Controls.Add(this.lKGMInv, 1, 1);
            this.tableInventario.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableInventario.Location = new System.Drawing.Point(80, 175);
            this.tableInventario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableInventario.Name = "tableInventario";
            this.tableInventario.RowCount = 2;
            this.tableInventario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tableInventario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.42857F));
            this.tableInventario.Size = new System.Drawing.Size(796, 142);
            this.tableInventario.TabIndex = 7;
            // 
            // label33
            // 
            this.label33.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(145, 13);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(108, 17);
            this.label33.TabIndex = 0;
            this.label33.Text = "SACOS Maseca";
            // 
            // label34
            // 
            this.label34.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(559, 13);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(74, 17);
            this.label34.TabIndex = 1;
            this.label34.Text = "KG MINSA";
            // 
            // lSacosInv
            // 
            this.lSacosInv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lSacosInv.AutoSize = true;
            this.lSacosInv.Location = new System.Drawing.Point(170, 83);
            this.lSacosInv.Name = "lSacosInv";
            this.lSacosInv.Size = new System.Drawing.Size(59, 17);
            this.lSacosInv.TabIndex = 2;
            this.lSacosInv.Text = "0 Sacos";
            // 
            // lKGMInv
            // 
            this.lKGMInv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lKGMInv.AutoSize = true;
            this.lKGMInv.Location = new System.Drawing.Point(576, 83);
            this.lKGMInv.Name = "lKGMInv";
            this.lKGMInv.Size = new System.Drawing.Size(40, 17);
            this.lKGMInv.TabIndex = 3;
            this.lKGMInv.Text = "0 KG";
            // 
            // tabGastos
            // 
            this.tabGastos.BackColor = System.Drawing.SystemColors.Control;
            this.tabGastos.Controls.Add(this.montoTotal);
            this.tabGastos.Controls.Add(this.addGasto);
            this.tabGastos.Controls.Add(this.label9);
            this.tabGastos.Controls.Add(this.tableGastos);
            this.tabGastos.Location = new System.Drawing.Point(4, 25);
            this.tabGastos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabGastos.Name = "tabGastos";
            this.tabGastos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabGastos.Size = new System.Drawing.Size(953, 505);
            this.tabGastos.TabIndex = 5;
            this.tabGastos.Text = "Gastos";
            // 
            // montoTotal
            // 
            this.montoTotal.AutoSize = true;
            this.montoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.montoTotal.Location = new System.Drawing.Point(420, 111);
            this.montoTotal.Name = "montoTotal";
            this.montoTotal.Size = new System.Drawing.Size(66, 25);
            this.montoTotal.TabIndex = 9;
            this.montoTotal.Text = "$0.00";
            // 
            // addGasto
            // 
            this.addGasto.ColorTable = office2010Green1;
            this.addGasto.Location = new System.Drawing.Point(773, 110);
            this.addGasto.Margin = new System.Windows.Forms.Padding(4);
            this.addGasto.Name = "addGasto";
            this.addGasto.Size = new System.Drawing.Size(100, 33);
            this.addGasto.TabIndex = 8;
            this.addGasto.Text = "Agregar Gasto";
            this.addGasto.Theme = ManiXButton.Theme.MSOffice2010_Green;
            this.addGasto.UseVisualStyleBackColor = true;
            this.addGasto.Click += new System.EventHandler(this.addGasto_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.ForestGreen;
            this.label9.Location = new System.Drawing.Point(283, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(357, 55);
            this.label9.TabIndex = 7;
            this.label9.Text = "Gastos del Mes";
            // 
            // tableGastos
            // 
            this.tableGastos.AutoScroll = true;
            this.tableGastos.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableGastos.ColumnCount = 4;
            this.tableGastos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.05739F));
            this.tableGastos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.52706F));
            this.tableGastos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.35743F));
            this.tableGastos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.05812F));
            this.tableGastos.Controls.Add(this.label35, 0, 0);
            this.tableGastos.Controls.Add(this.label36, 1, 0);
            this.tableGastos.Controls.Add(this.label37, 2, 0);
            this.tableGastos.Controls.Add(this.label38, 3, 0);
            this.tableGastos.Location = new System.Drawing.Point(77, 158);
            this.tableGastos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableGastos.MaximumSize = new System.Drawing.Size(796, 910);
            this.tableGastos.MinimumSize = new System.Drawing.Size(796, 91);
            this.tableGastos.Name = "tableGastos";
            this.tableGastos.RowCount = 1;
            this.tableGastos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 314F));
            this.tableGastos.Size = new System.Drawing.Size(796, 302);
            this.tableGastos.TabIndex = 1;
            // 
            // label35
            // 
            this.label35.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(97, 151);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(85, 17);
            this.label35.TabIndex = 0;
            this.label35.Text = "CONCEPTO";
            // 
            // label36
            // 
            this.label36.AllowDrop = true;
            this.label36.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(300, 151);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(77, 17);
            this.label36.TabIndex = 1;
            this.label36.Text = "CANTIDAD";
            // 
            // label37
            // 
            this.label37.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(458, 151);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(54, 17);
            this.label37.TabIndex = 2;
            this.label37.Text = "TOTAL";
            // 
            // label38
            // 
            this.label38.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(646, 151);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(53, 17);
            this.label38.TabIndex = 3;
            this.label38.Text = "FECHA";
            // 
            // tabClientes
            // 
            this.tabClientes.BackColor = System.Drawing.SystemColors.Control;
            this.tabClientes.Controls.Add(this.tableCliente);
            this.tabClientes.Controls.Add(this.label10);
            this.tabClientes.Controls.Add(this.addCliente);
            this.tabClientes.Location = new System.Drawing.Point(4, 25);
            this.tabClientes.Margin = new System.Windows.Forms.Padding(2);
            this.tabClientes.Name = "tabClientes";
            this.tabClientes.Padding = new System.Windows.Forms.Padding(2);
            this.tabClientes.Size = new System.Drawing.Size(953, 505);
            this.tabClientes.TabIndex = 1;
            this.tabClientes.Text = "Clientes";
            // 
            // tableCliente
            // 
            this.tableCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableCliente.AutoScroll = true;
            this.tableCliente.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableCliente.ColumnCount = 5;
            this.tableCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.25369F));
            this.tableCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.25369F));
            this.tableCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.67277F));
            this.tableCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.18618F));
            this.tableCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.633675F));
            this.tableCliente.Controls.Add(this.label21, 0, 0);
            this.tableCliente.Controls.Add(this.label22, 1, 0);
            this.tableCliente.Controls.Add(this.label23, 2, 0);
            this.tableCliente.Controls.Add(this.label24, 3, 0);
            this.tableCliente.Controls.Add(this.label25, 4, 0);
            this.tableCliente.Location = new System.Drawing.Point(131, 107);
            this.tableCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableCliente.MaximumSize = new System.Drawing.Size(696, 910);
            this.tableCliente.MinimumSize = new System.Drawing.Size(696, 91);
            this.tableCliente.Name = "tableCliente";
            this.tableCliente.RowCount = 1;
            this.tableCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 345F));
            this.tableCliente.Size = new System.Drawing.Size(696, 333);
            this.tableCliente.TabIndex = 10;
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(50, 167);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(58, 17);
            this.label21.TabIndex = 0;
            this.label21.Text = "Nombre";
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(202, 167);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(64, 17);
            this.label22.TabIndex = 1;
            this.label22.Text = "Contacto";
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(322, 167);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(64, 17);
            this.label23.TabIndex = 2;
            this.label23.Text = "Teléfono";
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(467, 167);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(67, 17);
            this.label24.TabIndex = 3;
            this.label24.Text = "Dirección";
            // 
            // label25
            // 
            this.label25.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(612, 158);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(53, 34);
            this.label25.TabIndex = 4;
            this.label25.Text = "Slección";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.ForestGreen;
            this.label10.Location = new System.Drawing.Point(281, 41);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(197, 55);
            this.label10.TabIndex = 9;
            this.label10.Text = "Clientes";
            // 
            // addCliente
            // 
            this.addCliente.ColorTable = office2010Blue1;
            this.addCliente.Location = new System.Drawing.Point(678, 57);
            this.addCliente.Name = "addCliente";
            this.addCliente.Size = new System.Drawing.Size(82, 35);
            this.addCliente.TabIndex = 11;
            this.addCliente.Text = "Agregar Cliente";
            this.addCliente.Theme = ManiXButton.Theme.MSOffice2010_BLUE;
            this.addCliente.UseVisualStyleBackColor = true;
            this.addCliente.Click += new System.EventHandler(this.addCliente_Click);
            // 
            // tabFactNot
            // 
            this.tabFactNot.BackColor = System.Drawing.SystemColors.Control;
            this.tabFactNot.Controls.Add(this.label11);
            this.tabFactNot.Location = new System.Drawing.Point(4, 25);
            this.tabFactNot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabFactNot.Name = "tabFactNot";
            this.tabFactNot.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabFactNot.Size = new System.Drawing.Size(953, 505);
            this.tabFactNot.TabIndex = 6;
            this.tabFactNot.Text = "Facturas/Notas";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(416, 244);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 17);
            this.label11.TabIndex = 1;
            this.label11.Text = "Siguiente Entrega";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(845, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 63);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // usertype
            // 
            this.usertype.AutoSize = true;
            this.usertype.Location = new System.Drawing.Point(781, 30);
            this.usertype.Name = "usertype";
            this.usertype.Size = new System.Drawing.Size(55, 17);
            this.usertype.TabIndex = 2;
            this.usertype.Text = "[Admin]";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(635, 5);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(201, 17);
            this.username.TabIndex = 3;
            this.username.Text = "Jorge Armando Rojas Montero";
            // 
            // tabSysUser
            // 
            this.tabSysUser.BackColor = System.Drawing.SystemColors.Control;
            this.tabSysUser.Controls.Add(this.tableLayoutPanel1);
            this.tabSysUser.Controls.Add(this.xButton1);
            this.tabSysUser.Controls.Add(this.label1);
            this.tabSysUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabSysUser.Location = new System.Drawing.Point(4, 25);
            this.tabSysUser.Name = "tabSysUser";
            this.tabSysUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabSysUser.Size = new System.Drawing.Size(953, 505);
            this.tabSysUser.TabIndex = 8;
            this.tabSysUser.Text = "Usuarios del Sistema";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(324, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuarios del Sistema";
            // 
            // xButton1
            // 
            colortable1.BorderColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(72)))), ((int)(((byte)(161)))));
            colortable1.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(135)))), ((int)(((byte)(228)))));
            colortable1.ButtonMouseOverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(199)))), ((int)(((byte)(87)))));
            colortable1.ButtonMouseOverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(215)))));
            colortable1.ButtonMouseOverColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(137)))));
            colortable1.ButtonMouseOverColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(224)))));
            colortable1.ButtonNormalColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(72)))), ((int)(((byte)(161)))));
            colortable1.ButtonNormalColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(135)))), ((int)(((byte)(228)))));
            colortable1.ButtonNormalColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(97)))), ((int)(((byte)(181)))));
            colortable1.ButtonNormalColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(125)))), ((int)(((byte)(219)))));
            colortable1.ButtonSelectedColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(199)))), ((int)(((byte)(87)))));
            colortable1.ButtonSelectedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(215)))));
            colortable1.ButtonSelectedColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(117)))));
            colortable1.ButtonSelectedColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(107)))));
            colortable1.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            colortable1.SelectedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            colortable1.TextColor = System.Drawing.Color.White;
            this.xButton1.ColorTable = colortable1;
            this.xButton1.Location = new System.Drawing.Point(666, 30);
            this.xButton1.Name = "xButton1";
            this.xButton1.Size = new System.Drawing.Size(81, 40);
            this.xButton1.TabIndex = 1;
            this.xButton1.Text = "Agregar";
            this.xButton1.Theme = ManiXButton.Theme.MSOffice2010_BLUE;
            this.xButton1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.5471F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.07969F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.29662F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.07658F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label39, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label40, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label41, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(78, 101);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.MaximumSize = new System.Drawing.Size(796, 910);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(796, 91);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(796, 302);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Usuario";
            // 
            // label39
            // 
            this.label39.AllowDrop = true;
            this.label39.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(238, 9);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(58, 17);
            this.label39.TabIndex = 1;
            this.label39.Text = "Nombre";
            // 
            // label40
            // 
            this.label40.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(508, 9);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(66, 17);
            this.label40.TabIndex = 2;
            this.label40.Text = "Permisos";
            // 
            // label41
            // 
            this.label41.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(693, 9);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(81, 17);
            this.label41.TabIndex = 3;
            this.label41.Text = "Contraseña";
            // 
            // MainModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 591);
            this.Controls.Add(this.username);
            this.Controls.Add(this.usertype);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainModule";
            this.Text = "Módulo Principal";
            this.tabControl.ResumeLayout(false);
            this.tabVenta.ResumeLayout(false);
            this.tabVenta.PerformLayout();
            this.tableVenta.ResumeLayout(false);
            this.tableVenta.PerformLayout();
            this.tabCorte.ResumeLayout(false);
            this.tabCorte.PerformLayout();
            this.tabProduc.ResumeLayout(false);
            this.tabProduc.PerformLayout();
            this.tableProd.ResumeLayout(false);
            this.tableProd.PerformLayout();
            this.tabAlmacen.ResumeLayout(false);
            this.tabAlmacen.PerformLayout();
            this.tableInventario.ResumeLayout(false);
            this.tableInventario.PerformLayout();
            this.tabGastos.ResumeLayout(false);
            this.tabGastos.PerformLayout();
            this.tableGastos.ResumeLayout(false);
            this.tableGastos.PerformLayout();
            this.tabClientes.ResumeLayout(false);
            this.tabClientes.PerformLayout();
            this.tableCliente.ResumeLayout(false);
            this.tableCliente.PerformLayout();
            this.tabFactNot.ResumeLayout(false);
            this.tabFactNot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabSysUser.ResumeLayout(false);
            this.tabSysUser.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
  
        #region items

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabCorte;
        private System.Windows.Forms.TabPage tabVenta;
        private System.Windows.Forms.TabPage tabProduc;
        private System.Windows.Forms.TabPage tabAlmacen;
        private System.Windows.Forms.TabPage tabGastos;
        private System.Windows.Forms.TabPage tabClientes;
        private System.Windows.Forms.TabPage tabFactNot;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label usertype;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.TableLayoutPanel tableVenta;
        private System.Windows.Forms.DateTimePicker datePickerVenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker datePickerProd;
        private System.Windows.Forms.TableLayoutPanel tableProd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel tableInventario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TableLayoutPanel tableGastos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TableLayoutPanel tableCliente;
        private System.Windows.Forms.Label label11;
        private ManiXButton.XButton addVenta;
        private ManiXButton.XButton addProduccion;
        private ManiXButton.XButton addInventario;
        private ManiXButton.XButton addGasto;
        private ManiXButton.XButton addCliente;
        private ManiXButton.XButton btnCorte;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox cantidadMostrador;
        private System.Windows.Forms.TextBox cantidad_800;
        private System.Windows.Forms.TextBox cantidad_900;
        private System.Windows.Forms.TextBox especial_cantidad;
        private System.Windows.Forms.TextBox mostrador_Normal;
        private System.Windows.Forms.TextBox normal_800;
        private System.Windows.Forms.TextBox normal_900;
        private System.Windows.Forms.TextBox especial_Normal;
        private System.Windows.Forms.TextBox mostador_Sabor;
        private System.Windows.Forms.TextBox sabor_800;
        private System.Windows.Forms.TextBox sabor_900;
        private System.Windows.Forms.TextBox especial_Sabor;
        private System.Windows.Forms.TextBox monto_Mostrador;
        private System.Windows.Forms.TextBox monto_800;
        private System.Windows.Forms.TextBox monto_900;
        private System.Windows.Forms.TextBox especial_monto;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;

        #endregion

        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private ManiXButton.XButton detalleBtn;
        private ManiXButton.XButton finalizarBtn;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label lSacoMaseca;
        private System.Windows.Forms.Label lKiloMas;
        private System.Windows.Forms.Label lKiloMinsa;
        private System.Windows.Forms.Label lKGHarina;
        private System.Windows.Forms.Label lTortilla;
        private System.Windows.Forms.Label lKGSobra;
        private System.Windows.Forms.Label lFTortilla;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label lSacosInv;
        private System.Windows.Forms.Label lKGMInv;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private Label montoTotal;
        private TabPage tabSysUser;
        private ManiXButton.XButton xButton1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Label label39;
        private Label label40;
        private Label label41;
    }
}