﻿
namespace CapaPresentacion
{
    partial class ReporteCurso
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
            this.DataSetCurso = new CapaPresentacion.DataSetCurso();
            this.CursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CursoTableAdapter = new CapaPresentacion.DataSetCursoTableAdapters.CursoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetCurso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CursoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.CursoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.ReportCurso.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetCurso
            // 
            this.DataSetCurso.DataSetName = "DataSetCurso";
            this.DataSetCurso.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CursoBindingSource
            // 
            this.CursoBindingSource.DataMember = "Curso";
            this.CursoBindingSource.DataSource = this.DataSetCurso;
            // 
            // CursoTableAdapter
            // 
            this.CursoTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteCurso";
            this.Text = "ReporteCurso";
            this.Load += new System.EventHandler(this.ReporteCurso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetCurso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CursoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CursoBindingSource;
        private DataSetCurso DataSetCurso;
        private DataSetCursoTableAdapters.CursoTableAdapter CursoTableAdapter;
    }
}