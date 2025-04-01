namespace CapaPresentacion
{
    partial class ReporteSolicitudes
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
            this.DataSetSolicitudes = new CapaPresentacion.DataSetSolicitudes();
            this.Solicitud_documentacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Solicitud_documentacionTableAdapter = new CapaPresentacion.DataSetSolicitudesTableAdapters.Solicitud_documentacionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetSolicitudes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Solicitud_documentacionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Solicitud_documentacionBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.ReportSolicitud.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetSolicitudes
            // 
            this.DataSetSolicitudes.DataSetName = "DataSetSolicitudes";
            this.DataSetSolicitudes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Solicitud_documentacionBindingSource
            // 
            this.Solicitud_documentacionBindingSource.DataMember = "Solicitud_documentacion";
            this.Solicitud_documentacionBindingSource.DataSource = this.DataSetSolicitudes;
            // 
            // Solicitud_documentacionTableAdapter
            // 
            this.Solicitud_documentacionTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteSolicitudes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteSolicitudes";
            this.Text = "Reporte de Solicitudes";
            this.Load += new System.EventHandler(this.ReporteSolicitudes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetSolicitudes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Solicitud_documentacionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Solicitud_documentacionBindingSource;
        private DataSetSolicitudes DataSetSolicitudes;
        private DataSetSolicitudesTableAdapters.Solicitud_documentacionTableAdapter Solicitud_documentacionTableAdapter;
    }
}