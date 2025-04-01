namespace CapaPresentacion.Documentos
{
    partial class FReporteCartaRec
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
            this.datosCartaRecBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEntregado2 = new FontAwesome.Sharp.IconButton();
            this.btnAceptar2 = new FontAwesome.Sharp.IconButton();
            this.labelDatosadicionales = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxEmisor = new System.Windows.Forms.TextBox();
            this.labelSolicitud = new System.Windows.Forms.Label();
            this.textBoxSolicitud = new System.Windows.Forms.TextBox();
            this.labelDepartamento = new System.Windows.Forms.Label();
            this.textBoxdepartamento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLiceo = new System.Windows.Forms.TextBox();
            this.labelCuidad = new System.Windows.Forms.Label();
            this.textBoxCiudad = new System.Windows.Forms.TextBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datosCartaRecBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // datosCartaRecBindingSource
            // 
            this.datosCartaRecBindingSource.DataSource = typeof(CapaPresentacion.Documentos.DatosCartaRec);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.datosCartaRecBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Documentos.ReporteCartaRec.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(299, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(900, 691);
            this.reportViewer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(126)))));
            this.panel1.Controls.Add(this.btnEntregado2);
            this.panel1.Controls.Add(this.btnAceptar2);
            this.panel1.Controls.Add(this.labelDatosadicionales);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxEmisor);
            this.panel1.Controls.Add(this.labelSolicitud);
            this.panel1.Controls.Add(this.textBoxSolicitud);
            this.panel1.Controls.Add(this.labelDepartamento);
            this.panel1.Controls.Add(this.textBoxdepartamento);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxLiceo);
            this.panel1.Controls.Add(this.labelCuidad);
            this.panel1.Controls.Add(this.textBoxCiudad);
            this.panel1.Controls.Add(this.labelTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 692);
            this.panel1.TabIndex = 1;
            // 
            // btnEntregado2
            // 
            this.btnEntregado2.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEntregado2.FlatAppearance.BorderSize = 0;
            this.btnEntregado2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntregado2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold);
            this.btnEntregado2.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEntregado2.IconChar = FontAwesome.Sharp.IconChar.ClipboardCheck;
            this.btnEntregado2.IconColor = System.Drawing.Color.Gainsboro;
            this.btnEntregado2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEntregado2.IconSize = 20;
            this.btnEntregado2.Location = new System.Drawing.Point(81, 622);
            this.btnEntregado2.Name = "btnEntregado2";
            this.btnEntregado2.Size = new System.Drawing.Size(118, 35);
            this.btnEntregado2.TabIndex = 29;
            this.btnEntregado2.Text = "&Entregado";
            this.btnEntregado2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEntregado2.UseVisualStyleBackColor = false;
            this.btnEntregado2.Click += new System.EventHandler(this.btnEntregado2_Click);
            // 
            // btnAceptar2
            // 
            this.btnAceptar2.BackColor = System.Drawing.Color.OrangeRed;
            this.btnAceptar2.FlatAppearance.BorderSize = 0;
            this.btnAceptar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold);
            this.btnAceptar2.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAceptar2.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.btnAceptar2.IconColor = System.Drawing.Color.Gainsboro;
            this.btnAceptar2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnAceptar2.IconSize = 20;
            this.btnAceptar2.Location = new System.Drawing.Point(81, 567);
            this.btnAceptar2.Name = "btnAceptar2";
            this.btnAceptar2.Size = new System.Drawing.Size(118, 35);
            this.btnAceptar2.TabIndex = 28;
            this.btnAceptar2.Text = " &Aceptar";
            this.btnAceptar2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAceptar2.UseVisualStyleBackColor = false;
            this.btnAceptar2.Click += new System.EventHandler(this.btnAceptar2_Click);
            // 
            // labelDatosadicionales
            // 
            this.labelDatosadicionales.AutoSize = true;
            this.labelDatosadicionales.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDatosadicionales.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelDatosadicionales.Location = new System.Drawing.Point(52, 122);
            this.labelDatosadicionales.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDatosadicionales.Name = "labelDatosadicionales";
            this.labelDatosadicionales.Size = new System.Drawing.Size(174, 24);
            this.labelDatosadicionales.TabIndex = 25;
            this.labelDatosadicionales.Text = "Datos adicionales";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(31, 492);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Emisor";
            // 
            // textBoxEmisor
            // 
            this.textBoxEmisor.Location = new System.Drawing.Point(33, 513);
            this.textBoxEmisor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxEmisor.Name = "textBoxEmisor";
            this.textBoxEmisor.Size = new System.Drawing.Size(223, 26);
            this.textBoxEmisor.TabIndex = 23;
            // 
            // labelSolicitud
            // 
            this.labelSolicitud.AutoSize = true;
            this.labelSolicitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSolicitud.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelSolicitud.Location = new System.Drawing.Point(30, 413);
            this.labelSolicitud.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSolicitud.Name = "labelSolicitud";
            this.labelSolicitud.Size = new System.Drawing.Size(58, 16);
            this.labelSolicitud.TabIndex = 22;
            this.labelSolicitud.Text = "Solicitud";
            // 
            // textBoxSolicitud
            // 
            this.textBoxSolicitud.Location = new System.Drawing.Point(32, 434);
            this.textBoxSolicitud.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxSolicitud.Name = "textBoxSolicitud";
            this.textBoxSolicitud.Size = new System.Drawing.Size(223, 26);
            this.textBoxSolicitud.TabIndex = 21;
            // 
            // labelDepartamento
            // 
            this.labelDepartamento.AutoSize = true;
            this.labelDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDepartamento.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelDepartamento.Location = new System.Drawing.Point(29, 339);
            this.labelDepartamento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDepartamento.Name = "labelDepartamento";
            this.labelDepartamento.Size = new System.Drawing.Size(93, 16);
            this.labelDepartamento.TabIndex = 20;
            this.labelDepartamento.Text = "Departamento";
            // 
            // textBoxdepartamento
            // 
            this.textBoxdepartamento.Location = new System.Drawing.Point(31, 360);
            this.textBoxdepartamento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxdepartamento.Name = "textBoxdepartamento";
            this.textBoxdepartamento.Size = new System.Drawing.Size(223, 26);
            this.textBoxdepartamento.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(29, 259);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nombre del centro educativo";
            // 
            // textBoxLiceo
            // 
            this.textBoxLiceo.Location = new System.Drawing.Point(31, 280);
            this.textBoxLiceo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxLiceo.Name = "textBoxLiceo";
            this.textBoxLiceo.Size = new System.Drawing.Size(223, 26);
            this.textBoxLiceo.TabIndex = 17;
            this.textBoxLiceo.Text = "José Francisco Peña Gómez";
            // 
            // labelCuidad
            // 
            this.labelCuidad.AutoSize = true;
            this.labelCuidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCuidad.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelCuidad.Location = new System.Drawing.Point(28, 187);
            this.labelCuidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCuidad.Name = "labelCuidad";
            this.labelCuidad.Size = new System.Drawing.Size(50, 16);
            this.labelCuidad.TabIndex = 16;
            this.labelCuidad.Text = "Ciudad";
            // 
            // textBoxCiudad
            // 
            this.textBoxCiudad.Location = new System.Drawing.Point(30, 208);
            this.textBoxCiudad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxCiudad.Name = "textBoxCiudad";
            this.textBoxCiudad.Size = new System.Drawing.Size(223, 26);
            this.textBoxCiudad.TabIndex = 2;
            this.textBoxCiudad.Text = "Bonao";
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelTitulo.Location = new System.Drawing.Point(24, 29);
            this.labelTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(228, 62);
            this.labelTitulo.TabIndex = 1;
            this.labelTitulo.Text = "Solicitud Carta de\r\n Recomendación\r\n";
            this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FReporteCartaRec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(126)))));
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FReporteCartaRec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reporte Carta de Recomendacion";
            this.Load += new System.EventHandler(this.FReporteCartaRec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datosCartaRecBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource datosCartaRecBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelCuidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDepartamento;
        private System.Windows.Forms.Label labelSolicitud;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelDatosadicionales;
        public System.Windows.Forms.TextBox textBoxCiudad;
        public System.Windows.Forms.TextBox textBoxLiceo;
        public System.Windows.Forms.TextBox textBoxdepartamento;
        public System.Windows.Forms.TextBox textBoxSolicitud;
        public System.Windows.Forms.TextBox textBoxEmisor;
        private FontAwesome.Sharp.IconButton btnEntregado2;
        private FontAwesome.Sharp.IconButton btnAceptar2;
    }
}