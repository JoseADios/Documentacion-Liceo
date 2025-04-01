namespace CapaPresentacion.SolicitudesReportes
{
    partial class FRepEntregaDoc
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
            this.entregaSolMostrarTodoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.entrega_SolMostrarTodoTableAdapter = new CapaPresentacion.DataSetSolicitudesTableAdapters.Entrega_SolMostrarTodoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSolicitudes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entregaSolMostrarTodoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.entregaSolMostrarTodoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.SolicitudesReportes.ReporteEntregasDocs.rdlc";
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
            // entregaSolMostrarTodoBindingSource
            // 
            this.entregaSolMostrarTodoBindingSource.DataMember = "Entrega_SolMostrarTodo";
            this.entregaSolMostrarTodoBindingSource.DataSource = this.dataSetSolicitudes;
            // 
            // entrega_SolMostrarTodoTableAdapter
            // 
            this.entrega_SolMostrarTodoTableAdapter.ClearBeforeFill = true;
            // 
            // FRepEntregaDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FRepEntregaDoc";
            this.Text = "FRepEntregaDoc";
            this.Load += new System.EventHandler(this.FRepEntregaDoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSolicitudes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entregaSolMostrarTodoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSetSolicitudes dataSetSolicitudes;
        private System.Windows.Forms.BindingSource entregaSolMostrarTodoBindingSource;
        private DataSetSolicitudesTableAdapters.Entrega_SolMostrarTodoTableAdapter entrega_SolMostrarTodoTableAdapter;
    }
}