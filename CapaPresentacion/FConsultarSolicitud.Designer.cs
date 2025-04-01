namespace CapaPresentacion
{
    partial class FConsultarSolicitud
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.BConsultar = new FontAwesome.Sharp.IconButton();
            this.BPrimero = new FontAwesome.Sharp.IconButton();
            this.BUltimo = new FontAwesome.Sharp.IconButton();
            this.BSiguiente = new FontAwesome.Sharp.IconButton();
            this.BAnterior = new FontAwesome.Sharp.IconButton();
            this.BSalir = new FontAwesome.Sharp.IconButton();
            this.BImprimir = new FontAwesome.Sharp.IconButton();
            this.PTitulo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PInformacion = new System.Windows.Forms.Panel();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PBotones = new System.Windows.Forms.Panel();
            this.lbCantidadSolicitudes = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DGVDatos = new System.Windows.Forms.DataGridView();
            this.PTitulo.SuspendLayout();
            this.PInformacion.SuspendLayout();
            this.PBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // BConsultar
            // 
            this.BConsultar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BConsultar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.BConsultar.IconColor = System.Drawing.Color.Black;
            this.BConsultar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BConsultar.IconSize = 30;
            this.BConsultar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BConsultar.Location = new System.Drawing.Point(892, 9);
            this.BConsultar.Name = "BConsultar";
            this.BConsultar.Size = new System.Drawing.Size(150, 40);
            this.BConsultar.TabIndex = 18;
            this.BConsultar.Text = "&Consultar";
            this.BConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.BConsultar, "Realizar la consulta de información");
            this.BConsultar.UseVisualStyleBackColor = true;
            this.BConsultar.Click += new System.EventHandler(this.BConsultar_Click_1);
            // 
            // BPrimero
            // 
            this.BPrimero.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BPrimero.IconChar = FontAwesome.Sharp.IconChar.Backward;
            this.BPrimero.IconColor = System.Drawing.Color.Black;
            this.BPrimero.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BPrimero.IconSize = 30;
            this.BPrimero.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BPrimero.Location = new System.Drawing.Point(10, 20);
            this.BPrimero.Name = "BPrimero";
            this.BPrimero.Size = new System.Drawing.Size(132, 44);
            this.BPrimero.TabIndex = 22;
            this.BPrimero.Text = "&Primero";
            this.BPrimero.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.BPrimero, "Ir al primer registro");
            this.BPrimero.UseVisualStyleBackColor = true;
            this.BPrimero.Click += new System.EventHandler(this.BPrimero_Click_1);
            // 
            // BUltimo
            // 
            this.BUltimo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUltimo.IconChar = FontAwesome.Sharp.IconChar.Forward;
            this.BUltimo.IconColor = System.Drawing.Color.Black;
            this.BUltimo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BUltimo.IconSize = 30;
            this.BUltimo.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.BUltimo.Location = new System.Drawing.Point(431, 20);
            this.BUltimo.Name = "BUltimo";
            this.BUltimo.Size = new System.Drawing.Size(114, 45);
            this.BUltimo.TabIndex = 25;
            this.BUltimo.Text = "&Ultimo";
            this.BUltimo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.BUltimo, "Ir al último registro");
            this.BUltimo.UseVisualStyleBackColor = true;
            this.BUltimo.Click += new System.EventHandler(this.BUltimo_Click_1);
            // 
            // BSiguiente
            // 
            this.BSiguiente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BSiguiente.IconChar = FontAwesome.Sharp.IconChar.AngleRight;
            this.BSiguiente.IconColor = System.Drawing.Color.Black;
            this.BSiguiente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BSiguiente.IconSize = 30;
            this.BSiguiente.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.BSiguiente.Location = new System.Drawing.Point(286, 20);
            this.BSiguiente.Name = "BSiguiente";
            this.BSiguiente.Size = new System.Drawing.Size(139, 45);
            this.BSiguiente.TabIndex = 24;
            this.BSiguiente.Text = "&Siguiente";
            this.BSiguiente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.BSiguiente, "Ir al registro siguiente");
            this.BSiguiente.UseVisualStyleBackColor = true;
            this.BSiguiente.Click += new System.EventHandler(this.BSiguiente_Click_1);
            // 
            // BAnterior
            // 
            this.BAnterior.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAnterior.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            this.BAnterior.IconColor = System.Drawing.Color.Black;
            this.BAnterior.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BAnterior.IconSize = 30;
            this.BAnterior.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BAnterior.Location = new System.Drawing.Point(148, 20);
            this.BAnterior.Name = "BAnterior";
            this.BAnterior.Size = new System.Drawing.Size(132, 44);
            this.BAnterior.TabIndex = 23;
            this.BAnterior.Text = "&Anterior";
            this.BAnterior.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.BAnterior, "Ir al registro anterior");
            this.BAnterior.UseVisualStyleBackColor = true;
            this.BAnterior.Click += new System.EventHandler(this.BAnterior_Click_1);
            // 
            // BSalir
            // 
            this.BSalir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BSalir.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.BSalir.IconColor = System.Drawing.Color.Black;
            this.BSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BSalir.IconSize = 30;
            this.BSalir.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BSalir.Location = new System.Drawing.Point(1084, 22);
            this.BSalir.Name = "BSalir";
            this.BSalir.Size = new System.Drawing.Size(98, 44);
            this.BSalir.TabIndex = 27;
            this.BSalir.Text = "&Salir";
            this.BSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.BSalir, "Salir del Formulario");
            this.BSalir.UseVisualStyleBackColor = true;
            this.BSalir.Click += new System.EventHandler(this.BSalir_Click_1);
            // 
            // BImprimir
            // 
            this.BImprimir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BImprimir.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.BImprimir.IconColor = System.Drawing.Color.Black;
            this.BImprimir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BImprimir.IconSize = 30;
            this.BImprimir.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BImprimir.Location = new System.Drawing.Point(940, 22);
            this.BImprimir.Name = "BImprimir";
            this.BImprimir.Size = new System.Drawing.Size(138, 44);
            this.BImprimir.TabIndex = 26;
            this.BImprimir.Text = "&Imprimir";
            this.BImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.BImprimir, "Generar el reporte correspondiente");
            this.BImprimir.UseVisualStyleBackColor = true;
            this.BImprimir.Click += new System.EventHandler(this.BImprimir_Click_1);
            // 
            // PTitulo
            // 
            this.PTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            this.PTitulo.Controls.Add(this.label1);
            this.PTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PTitulo.Location = new System.Drawing.Point(0, 0);
            this.PTitulo.Name = "PTitulo";
            this.PTitulo.Size = new System.Drawing.Size(1200, 90);
            this.PTitulo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(48, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(980, 81);
            this.label1.TabIndex = 1;
            this.label1.Text = "Consulta General de Solicitudes\r\n";
            // 
            // PInformacion
            // 
            this.PInformacion.BackColor = System.Drawing.Color.SlateBlue;
            this.PInformacion.Controls.Add(this.BConsultar);
            this.PInformacion.Controls.Add(this.tbBuscar);
            this.PInformacion.Controls.Add(this.label2);
            this.PInformacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.PInformacion.Location = new System.Drawing.Point(0, 90);
            this.PInformacion.Name = "PInformacion";
            this.PInformacion.Size = new System.Drawing.Size(1200, 66);
            this.PInformacion.TabIndex = 1;
            // 
            // tbBuscar
            // 
            this.tbBuscar.Location = new System.Drawing.Point(542, 15);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(343, 26);
            this.tbBuscar.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(230, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Digite el dato a buscar";
            // 
            // PBotones
            // 
            this.PBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            this.PBotones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PBotones.Controls.Add(this.BSalir);
            this.PBotones.Controls.Add(this.BImprimir);
            this.PBotones.Controls.Add(this.BUltimo);
            this.PBotones.Controls.Add(this.BSiguiente);
            this.PBotones.Controls.Add(this.BAnterior);
            this.PBotones.Controls.Add(this.BPrimero);
            this.PBotones.Controls.Add(this.lbCantidadSolicitudes);
            this.PBotones.Controls.Add(this.label3);
            this.PBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PBotones.Location = new System.Drawing.Point(0, 533);
            this.PBotones.Name = "PBotones";
            this.PBotones.Size = new System.Drawing.Size(1200, 90);
            this.PBotones.TabIndex = 2;
            // 
            // lbCantidadSolicitudes
            // 
            this.lbCantidadSolicitudes.AutoSize = true;
            this.lbCantidadSolicitudes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCantidadSolicitudes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbCantidadSolicitudes.Location = new System.Drawing.Point(816, 32);
            this.lbCantidadSolicitudes.Name = "lbCantidadSolicitudes";
            this.lbCantidadSolicitudes.Size = new System.Drawing.Size(0, 24);
            this.lbCantidadSolicitudes.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(560, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Cantidad de Solicitudes";
            // 
            // DGVDatos
            // 
            this.DGVDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVDatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGVDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVDatos.Location = new System.Drawing.Point(0, 156);
            this.DGVDatos.Name = "DGVDatos";
            this.DGVDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVDatos.Size = new System.Drawing.Size(1200, 377);
            this.DGVDatos.TabIndex = 3;
            this.DGVDatos.CurrentCellChanged += new System.EventHandler(this.DGVDatos_CurrentCellChanged);
            // 
            // FConsultarSolicitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 623);
            this.Controls.Add(this.DGVDatos);
            this.Controls.Add(this.PBotones);
            this.Controls.Add(this.PInformacion);
            this.Controls.Add(this.PTitulo);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FConsultarSolicitud";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consultar Solicitud";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FConsultarSolicitud_FormClosing);
            this.Load += new System.EventHandler(this.FConsultarSolicitud_Load);
            this.PTitulo.ResumeLayout(false);
            this.PTitulo.PerformLayout();
            this.PInformacion.ResumeLayout(false);
            this.PInformacion.PerformLayout();
            this.PBotones.ResumeLayout(false);
            this.PBotones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel PTitulo;
        private System.Windows.Forms.Panel PInformacion;
        private System.Windows.Forms.Panel PBotones;
        private System.Windows.Forms.DataGridView DGVDatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbCantidadSolicitudes;
        private FontAwesome.Sharp.IconButton BConsultar;
        private FontAwesome.Sharp.IconButton BPrimero;
        private FontAwesome.Sharp.IconButton BUltimo;
        private FontAwesome.Sharp.IconButton BSiguiente;
        private FontAwesome.Sharp.IconButton BAnterior;
        private FontAwesome.Sharp.IconButton BSalir;
        private FontAwesome.Sharp.IconButton BImprimir;
    }
}