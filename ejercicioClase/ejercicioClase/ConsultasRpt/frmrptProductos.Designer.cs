namespace ejercicioClase.ConsultasRpt
{
    partial class frmrptProductos
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
            this.crpProducto = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crpProducto
            // 
            this.crpProducto.ActiveViewIndex = 0;
            this.crpProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crpProducto.Cursor = System.Windows.Forms.Cursors.Default;
            this.crpProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crpProducto.Location = new System.Drawing.Point(0, 0);
            this.crpProducto.Name = "crpProducto";
            this.crpProducto.ReportSource = "C:\\Users\\PC\\Documents\\GitHub\\MarcosMirandaClase\\ejercicioClase\\ejercicioClase\\Rep" +
    "ortes\\rptProductos.rpt";
            this.crpProducto.Size = new System.Drawing.Size(1079, 450);
            this.crpProducto.TabIndex = 0;
            // 
            // frmrptProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 450);
            this.Controls.Add(this.crpProducto);
            this.Name = "frmrptProductos";
            this.Text = "frmrptProductos";
            this.Load += new System.EventHandler(this.frmrptProductos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crpProducto;
    }
}