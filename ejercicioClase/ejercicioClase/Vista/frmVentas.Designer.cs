namespace ejercicioClase.Vista
{
    partial class frmVentas
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
            this.lblNumerodeVenta = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.txtNumerodeVenta = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.cmbTipoDoc = new System.Windows.Forms.ComboBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblCodigoProd = new System.Windows.Forms.Label();
            this.lblNombreProd = new System.Windows.Forms.Label();
            this.lblPrecioProd = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtCodigoProd = new System.Windows.Forms.TextBox();
            this.txtNombredelProd = new System.Windows.Forms.TextBox();
            this.txtPrecioProd = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.dtgVentas = new System.Windows.Forms.DataGridView();
            this.CodigoProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotal2 = new System.Windows.Forms.Label();
            this.txtTotal2 = new System.Windows.Forms.TextBox();
            this.btnGVenta = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumerodeVenta
            // 
            this.lblNumerodeVenta.AutoSize = true;
            this.lblNumerodeVenta.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumerodeVenta.Location = new System.Drawing.Point(33, 31);
            this.lblNumerodeVenta.Name = "lblNumerodeVenta";
            this.lblNumerodeVenta.Size = new System.Drawing.Size(109, 14);
            this.lblNumerodeVenta.TabIndex = 0;
            this.lblNumerodeVenta.Text = "Numero de Venta";
            // 
            // cmbCliente
            // 
            this.cmbCliente.BackColor = System.Drawing.Color.Silver;
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(452, 26);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(121, 21);
            this.cmbCliente.TabIndex = 1;
            // 
            // txtNumerodeVenta
            // 
            this.txtNumerodeVenta.BackColor = System.Drawing.Color.Silver;
            this.txtNumerodeVenta.Enabled = false;
            this.txtNumerodeVenta.Location = new System.Drawing.Point(148, 29);
            this.txtNumerodeVenta.Name = "txtNumerodeVenta";
            this.txtNumerodeVenta.Size = new System.Drawing.Size(100, 20);
            this.txtNumerodeVenta.TabIndex = 2;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(335, 32);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(53, 14);
            this.lblCliente.TabIndex = 3;
            this.lblCliente.Text = "Cliente";
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDoc.Location = new System.Drawing.Point(329, 104);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(117, 14);
            this.lblTipoDoc.TabIndex = 4;
            this.lblTipoDoc.Text = "Tipo de Documento";
            // 
            // cmbTipoDoc
            // 
            this.cmbTipoDoc.BackColor = System.Drawing.Color.Silver;
            this.cmbTipoDoc.FormattingEnabled = true;
            this.cmbTipoDoc.Location = new System.Drawing.Point(452, 101);
            this.cmbTipoDoc.Name = "cmbTipoDoc";
            this.cmbTipoDoc.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoDoc.TabIndex = 5;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(29, 153);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(113, 14);
            this.lblBuscar.TabIndex = 6;
            this.lblBuscar.Text = "Buscar Producto";
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.Silver;
            this.txtBuscar.Location = new System.Drawing.Point(148, 153);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(226, 20);
            this.txtBuscar.TabIndex = 7;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(429, 153);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 26);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblCodigoProd
            // 
            this.lblCodigoProd.AutoSize = true;
            this.lblCodigoProd.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoProd.Location = new System.Drawing.Point(36, 224);
            this.lblCodigoProd.Name = "lblCodigoProd";
            this.lblCodigoProd.Size = new System.Drawing.Size(107, 14);
            this.lblCodigoProd.TabIndex = 9;
            this.lblCodigoProd.Text = "Codigo Producto";
            // 
            // lblNombreProd
            // 
            this.lblNombreProd.AutoSize = true;
            this.lblNombreProd.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProd.Location = new System.Drawing.Point(194, 224);
            this.lblNombreProd.Name = "lblNombreProd";
            this.lblNombreProd.Size = new System.Drawing.Size(137, 14);
            this.lblNombreProd.TabIndex = 10;
            this.lblNombreProd.Text = "Nombre del Producto";
            // 
            // lblPrecioProd
            // 
            this.lblPrecioProd.AutoSize = true;
            this.lblPrecioProd.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioProd.Location = new System.Drawing.Point(426, 224);
            this.lblPrecioProd.Name = "lblPrecioProd";
            this.lblPrecioProd.Size = new System.Drawing.Size(131, 14);
            this.lblPrecioProd.TabIndex = 11;
            this.lblPrecioProd.Text = "Precio del producto";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(587, 224);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(64, 14);
            this.lblCantidad.TabIndex = 12;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(719, 224);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 14);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "Total";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(851, 259);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 26);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtCodigoProd
            // 
            this.txtCodigoProd.BackColor = System.Drawing.Color.Silver;
            this.txtCodigoProd.Enabled = false;
            this.txtCodigoProd.Location = new System.Drawing.Point(39, 263);
            this.txtCodigoProd.Name = "txtCodigoProd";
            this.txtCodigoProd.Size = new System.Drawing.Size(87, 20);
            this.txtCodigoProd.TabIndex = 15;
            // 
            // txtNombredelProd
            // 
            this.txtNombredelProd.BackColor = System.Drawing.Color.Silver;
            this.txtNombredelProd.Enabled = false;
            this.txtNombredelProd.Location = new System.Drawing.Point(197, 263);
            this.txtNombredelProd.Name = "txtNombredelProd";
            this.txtNombredelProd.Size = new System.Drawing.Size(177, 20);
            this.txtNombredelProd.TabIndex = 16;
            // 
            // txtPrecioProd
            // 
            this.txtPrecioProd.BackColor = System.Drawing.Color.Silver;
            this.txtPrecioProd.Enabled = false;
            this.txtPrecioProd.Location = new System.Drawing.Point(429, 263);
            this.txtPrecioProd.Name = "txtPrecioProd";
            this.txtPrecioProd.Size = new System.Drawing.Size(144, 20);
            this.txtPrecioProd.TabIndex = 17;
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.Color.Silver;
            this.txtCantidad.Location = new System.Drawing.Point(590, 263);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 18;
            this.txtCantidad.Text = "1";
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.Silver;
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(722, 263);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 19;
            // 
            // dtgVentas
            // 
            this.dtgVentas.AllowUserToAddRows = false;
            this.dtgVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgVentas.BackgroundColor = System.Drawing.Color.Silver;
            this.dtgVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoProd,
            this.NombreProd,
            this.PrecioProd,
            this.Cantidad,
            this.Total});
            this.dtgVentas.Location = new System.Drawing.Point(39, 308);
            this.dtgVentas.Name = "dtgVentas";
            this.dtgVentas.ReadOnly = true;
            this.dtgVentas.Size = new System.Drawing.Size(887, 242);
            this.dtgVentas.TabIndex = 20;
            // 
            // CodigoProd
            // 
            this.CodigoProd.HeaderText = "Id del Producto";
            this.CodigoProd.Name = "CodigoProd";
            this.CodigoProd.ReadOnly = true;
            // 
            // NombreProd
            // 
            this.NombreProd.HeaderText = "Nombre Producto";
            this.NombreProd.Name = "NombreProd";
            this.NombreProd.ReadOnly = true;
            // 
            // PrecioProd
            // 
            this.PrecioProd.HeaderText = "Precio Producto";
            this.PrecioProd.Name = "PrecioProd";
            this.PrecioProd.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // lblTotal2
            // 
            this.lblTotal2.AutoSize = true;
            this.lblTotal2.Font = new System.Drawing.Font("Algerian", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal2.Location = new System.Drawing.Point(32, 584);
            this.lblTotal2.Name = "lblTotal2";
            this.lblTotal2.Size = new System.Drawing.Size(159, 35);
            this.lblTotal2.TabIndex = 21;
            this.lblTotal2.Text = "Total $:";
            // 
            // txtTotal2
            // 
            this.txtTotal2.BackColor = System.Drawing.Color.Silver;
            this.txtTotal2.Enabled = false;
            this.txtTotal2.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal2.Location = new System.Drawing.Point(192, 562);
            this.txtTotal2.Multiline = true;
            this.txtTotal2.Name = "txtTotal2";
            this.txtTotal2.Size = new System.Drawing.Size(196, 57);
            this.txtTotal2.TabIndex = 22;
            // 
            // btnGVenta
            // 
            this.btnGVenta.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGVenta.Location = new System.Drawing.Point(807, 562);
            this.btnGVenta.Name = "btnGVenta";
            this.btnGVenta.Size = new System.Drawing.Size(128, 57);
            this.btnGVenta.TabIndex = 23;
            this.btnGVenta.Text = "GUARDAR VENTA";
            this.btnGVenta.UseVisualStyleBackColor = true;
            this.btnGVenta.Click += new System.EventHandler(this.btnGVenta_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "yyyy-MM-dd";
            this.dtpFecha.Location = new System.Drawing.Point(722, 32);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 24;
            // 
            // frmVentas
            // 
            this.AcceptButton = this.btnAgregar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(980, 655);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.btnGVenta);
            this.Controls.Add(this.txtTotal2);
            this.Controls.Add(this.lblTotal2);
            this.Controls.Add(this.dtgVentas);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtPrecioProd);
            this.Controls.Add(this.txtNombredelProd);
            this.Controls.Add(this.txtCodigoProd);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblPrecioProd);
            this.Controls.Add(this.lblNombreProd);
            this.Controls.Add(this.lblCodigoProd);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.cmbTipoDoc);
            this.Controls.Add(this.lblTipoDoc);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.txtNumerodeVenta);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.lblNumerodeVenta);
            this.Name = "frmVentas";
            this.Text = "frmVentas";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumerodeVenta;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.TextBox txtNumerodeVenta;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.ComboBox cmbTipoDoc;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblCodigoProd;
        private System.Windows.Forms.Label lblNombreProd;
        private System.Windows.Forms.Label lblPrecioProd;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.DataGridView dtgVentas;
        public System.Windows.Forms.TextBox txtCodigoProd;
        public System.Windows.Forms.TextBox txtNombredelProd;
        public System.Windows.Forms.TextBox txtPrecioProd;
        private System.Windows.Forms.Label lblTotal2;
        private System.Windows.Forms.TextBox txtTotal2;
        public System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Button btnGVenta;
        private System.Windows.Forms.DateTimePicker dtpFecha;
    }
}