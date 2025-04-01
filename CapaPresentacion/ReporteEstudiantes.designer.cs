namespace CapaPresentacion
{
    partial class ReporteEstudiantes
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
            this.EstudianteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetEstudiantes = new CapaPresentacion.DataSetEstudiantes();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.EstudianteTableAdapter = new CapaPresentacion.DataSetEstudiantesTableAdapters.EstudianteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.EstudianteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetEstudiantes)).BeginInit();
            this.SuspendLayout();
            // 
            // EstudianteBindingSource
            // 
            this.EstudianteBindingSource.DataMember = "Estudiante";
            this.EstudianteBindingSource.DataSource = this.DataSetEstudiantes;
            // 
            // DataSetEstudiantes
            // 
            this.DataSetEstudiantes.DataSetName = "DataSetEstudiantes";
            this.DataSetEstudiantes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.EstudianteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.ReporteEstudiantes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // EstudianteTableAdapter
            // 
            this.EstudianteTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteEstudiantes";
            this.Text = "Reporte de Estudiantes";
            this.Load += new System.EventHandler(this.ReporteEstudiantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EstudianteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetEstudiantes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource EstudianteBindingSource;
        private DataSetEstudiantes DataSetEstudiantes;
        private DataSetEstudiantesTableAdapters.EstudianteTableAdapter EstudianteTableAdapter;
    }
}