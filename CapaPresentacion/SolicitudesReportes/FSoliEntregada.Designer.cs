namespace CapaPresentacion.SolicitudesReportes
{
    partial class FSoliEntregada
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSetSolicitudes = new CapaPresentacion.DataSetSolicitudes();
            this.dataTableSoliEntregadasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTableSoliEntregadasTableAdapter = new CapaPresentacion.DataSetSolicitudesTableAdapters.DataTableSoliEntregadasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSolicitudes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableSoliEntregadasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dataTableSoliEntregadasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.SolicitudesReportes.ReporteSoliEntregada.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSetSolicitudes
            // 
            this.dataSetSolicitudes.DataSetName = "DataSetSolicitudes";
            this.dataSetSolicitudes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTableSoliEntregadasBindingSource
            // 
            this.dataTableSoliEntregadasBindingSource.DataMember = "DataTableSoliEntregadas";
            this.dataTableSoliEntregadasBindingSource.DataSource = this.dataSetSolicitudes;
            // 
            // dataTableSoliEntregadasTableAdapter
            // 
            this.dataTableSoliEntregadasTableAdapter.ClearBeforeFill = true;
            // 
            // FSoliEntregada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FSoliEntregada";
            this.Text = "FSoliEntrgada";
            this.Load += new System.EventHandler(this.FSoliEntrgada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSolicitudes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableSoliEntregadasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSetSolicitudes dataSetSolicitudes;
        private System.Windows.Forms.BindingSource dataTableSoliEntregadasBindingSource;
        private DataSetSolicitudesTableAdapters.DataTableSoliEntregadasTableAdapter dataTableSoliEntregadasTableAdapter;
    }
}