namespace CapaPresentacion
{
    partial class ReporteTiposDocs
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
            this.dataSetTiposDoc = new CapaPresentacion.DataSetTiposDoc();
            this.tiposDocumentacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tiposDocumentacionesTableAdapter = new CapaPresentacion.DataSetTiposDocTableAdapters.TiposDocumentacionesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTiposDoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDocumentacionesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetTDoc";
            reportDataSource1.Value = this.tiposDocumentacionesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.ReporteTiposDocs.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSetTiposDoc
            // 
            this.dataSetTiposDoc.DataSetName = "DataSetTiposDoc";
            this.dataSetTiposDoc.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tiposDocumentacionesBindingSource
            // 
            this.tiposDocumentacionesBindingSource.DataMember = "TiposDocumentaciones";
            this.tiposDocumentacionesBindingSource.DataSource = this.dataSetTiposDoc;
            // 
            // tiposDocumentacionesTableAdapter
            // 
            this.tiposDocumentacionesTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteTiposDocs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteTiposDocs";
            this.Text = "ReporteTiposDocs";
            this.Load += new System.EventHandler(this.ReporteTiposDocs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTiposDoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDocumentacionesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSetTiposDoc dataSetTiposDoc;
        private System.Windows.Forms.BindingSource tiposDocumentacionesBindingSource;
        private DataSetTiposDocTableAdapters.TiposDocumentacionesTableAdapter tiposDocumentacionesTableAdapter;
    }
}