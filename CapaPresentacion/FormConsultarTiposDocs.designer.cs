namespace CapaPresentacion
{
    partial class FormConsultarTiposDocs
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
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.panelBusqueda = new System.Windows.Forms.Panel();
            this.btnVolver2 = new FontAwesome.Sharp.IconButton();
            this.btnBuscar2 = new FontAwesome.Sharp.IconButton();
            this.textBoxBusqueda = new System.Windows.Forms.TextBox();
            this.labelingresedato = new System.Windows.Forms.Label();
            this.dataGridDatos = new System.Windows.Forms.DataGridView();
            this.panelInferior = new System.Windows.Forms.Panel();
            this.btnUltimo2 = new FontAwesome.Sharp.IconButton();
            this.labelNumTiposDoc = new System.Windows.Forms.Label();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.btnPrimero2 = new FontAwesome.Sharp.IconButton();
            this.btnAnterior2 = new FontAwesome.Sharp.IconButton();
            this.btnSiguiente2 = new FontAwesome.Sharp.IconButton();
            this.btnImprimir2 = new FontAwesome.Sharp.IconButton();
            this.panelSuperior.SuspendLayout();
            this.panelBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDatos)).BeginInit();
            this.panelInferior.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.toolTip1.ForeColor = System.Drawing.Color.White;
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            this.panelSuperior.Controls.Add(this.labelTitulo);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1236, 92);
            this.panelSuperior.TabIndex = 18;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelTitulo.Location = new System.Drawing.Point(354, 31);
            this.labelTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(513, 31);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Consulta general de tipos de documentos";
            this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBusqueda
            // 
            this.panelBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(126)))));
            this.panelBusqueda.Controls.Add(this.btnImprimir2);
            this.panelBusqueda.Controls.Add(this.btnVolver2);
            this.panelBusqueda.Controls.Add(this.btnBuscar2);
            this.panelBusqueda.Controls.Add(this.textBoxBusqueda);
            this.panelBusqueda.Controls.Add(this.labelingresedato);
            this.panelBusqueda.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBusqueda.Location = new System.Drawing.Point(0, 92);
            this.panelBusqueda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelBusqueda.Name = "panelBusqueda";
            this.panelBusqueda.Size = new System.Drawing.Size(1236, 102);
            this.panelBusqueda.TabIndex = 23;
            // 
            // btnVolver2
            // 
            this.btnVolver2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnVolver2.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnVolver2.FlatAppearance.BorderSize = 0;
            this.btnVolver2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold);
            this.btnVolver2.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnVolver2.IconChar = FontAwesome.Sharp.IconChar.ReplyAll;
            this.btnVolver2.IconColor = System.Drawing.Color.Gainsboro;
            this.btnVolver2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVolver2.IconSize = 20;
            this.btnVolver2.Location = new System.Drawing.Point(0, 0);
            this.btnVolver2.Name = "btnVolver2";
            this.btnVolver2.Size = new System.Drawing.Size(102, 102);
            this.btnVolver2.TabIndex = 26;
            this.btnVolver2.Text = "&Volver";
            this.btnVolver2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVolver2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVolver2.UseVisualStyleBackColor = false;
            this.btnVolver2.Click += new System.EventHandler(this.btnVolver2_Click);
            // 
            // btnBuscar2
            // 
            this.btnBuscar2.BackColor = System.Drawing.Color.OrangeRed;
            this.btnBuscar2.FlatAppearance.BorderSize = 0;
            this.btnBuscar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold);
            this.btnBuscar2.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBuscar2.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnBuscar2.IconColor = System.Drawing.Color.Gainsboro;
            this.btnBuscar2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar2.IconSize = 20;
            this.btnBuscar2.Location = new System.Drawing.Point(832, 35);
            this.btnBuscar2.Name = "btnBuscar2";
            this.btnBuscar2.Size = new System.Drawing.Size(112, 33);
            this.btnBuscar2.TabIndex = 26;
            this.btnBuscar2.Text = " &Buscar";
            this.btnBuscar2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar2.UseVisualStyleBackColor = false;
            this.btnBuscar2.Click += new System.EventHandler(this.btnBuscar2_Click);
            // 
            // textBoxBusqueda
            // 
            this.textBoxBusqueda.Location = new System.Drawing.Point(406, 38);
            this.textBoxBusqueda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxBusqueda.Name = "textBoxBusqueda";
            this.textBoxBusqueda.Size = new System.Drawing.Size(386, 26);
            this.textBoxBusqueda.TabIndex = 0;
            // 
            // labelingresedato
            // 
            this.labelingresedato.AutoSize = true;
            this.labelingresedato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelingresedato.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelingresedato.Location = new System.Drawing.Point(204, 42);
            this.labelingresedato.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelingresedato.Name = "labelingresedato";
            this.labelingresedato.Size = new System.Drawing.Size(180, 20);
            this.labelingresedato.TabIndex = 15;
            this.labelingresedato.Text = "Ingrese el dato a buscar";
            // 
            // dataGridDatos
            // 
            this.dataGridDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridDatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(126)))));
            this.dataGridDatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridDatos.GridColor = System.Drawing.Color.MidnightBlue;
            this.dataGridDatos.Location = new System.Drawing.Point(0, 194);
            this.dataGridDatos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridDatos.Name = "dataGridDatos";
            this.dataGridDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridDatos.Size = new System.Drawing.Size(1236, 365);
            this.dataGridDatos.TabIndex = 24;
            this.dataGridDatos.CurrentCellChanged += new System.EventHandler(this.dataGridDatos_CurrentCellChanged);
            // 
            // panelInferior
            // 
            this.panelInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(126)))));
            this.panelInferior.Controls.Add(this.btnPrimero2);
            this.panelInferior.Controls.Add(this.btnAnterior2);
            this.panelInferior.Controls.Add(this.btnSiguiente2);
            this.panelInferior.Controls.Add(this.btnUltimo2);
            this.panelInferior.Controls.Add(this.labelNumTiposDoc);
            this.panelInferior.Controls.Add(this.labelCantidad);
            this.panelInferior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInferior.Location = new System.Drawing.Point(0, 559);
            this.panelInferior.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelInferior.Name = "panelInferior";
            this.panelInferior.Size = new System.Drawing.Size(1236, 95);
            this.panelInferior.TabIndex = 25;
            // 
            // btnUltimo2
            // 
            this.btnUltimo2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnUltimo2.FlatAppearance.BorderSize = 0;
            this.btnUltimo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUltimo2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold);
            this.btnUltimo2.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnUltimo2.IconChar = FontAwesome.Sharp.IconChar.Forward;
            this.btnUltimo2.IconColor = System.Drawing.Color.Gainsboro;
            this.btnUltimo2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUltimo2.IconSize = 20;
            this.btnUltimo2.Location = new System.Drawing.Point(716, 27);
            this.btnUltimo2.Name = "btnUltimo2";
            this.btnUltimo2.Size = new System.Drawing.Size(105, 35);
            this.btnUltimo2.TabIndex = 26;
            this.btnUltimo2.Text = "&Ultimo";
            this.btnUltimo2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUltimo2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUltimo2.UseVisualStyleBackColor = false;
            this.btnUltimo2.Click += new System.EventHandler(this.btnUltimo2_Click);
            // 
            // labelNumTiposDoc
            // 
            this.labelNumTiposDoc.AutoSize = true;
            this.labelNumTiposDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumTiposDoc.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelNumTiposDoc.Location = new System.Drawing.Point(1146, 37);
            this.labelNumTiposDoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNumTiposDoc.Name = "labelNumTiposDoc";
            this.labelNumTiposDoc.Size = new System.Drawing.Size(0, 13);
            this.labelNumTiposDoc.TabIndex = 18;
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantidad.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelCantidad.Location = new System.Drawing.Point(990, 36);
            this.labelCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(130, 13);
            this.labelCantidad.TabIndex = 17;
            this.labelCantidad.Text = "Cantidad de tipos de docs";
            // 
            // btnPrimero2
            // 
            this.btnPrimero2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnPrimero2.FlatAppearance.BorderSize = 0;
            this.btnPrimero2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrimero2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold);
            this.btnPrimero2.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPrimero2.IconChar = FontAwesome.Sharp.IconChar.Backward;
            this.btnPrimero2.IconColor = System.Drawing.Color.Gainsboro;
            this.btnPrimero2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPrimero2.IconSize = 20;
            this.btnPrimero2.Location = new System.Drawing.Point(398, 27);
            this.btnPrimero2.Name = "btnPrimero2";
            this.btnPrimero2.Size = new System.Drawing.Size(105, 35);
            this.btnPrimero2.TabIndex = 29;
            this.btnPrimero2.Text = "&Primero";
            this.btnPrimero2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrimero2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrimero2.UseVisualStyleBackColor = false;
            this.btnPrimero2.Click += new System.EventHandler(this.btnPrimero2_Click);
            // 
            // btnAnterior2
            // 
            this.btnAnterior2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAnterior2.FlatAppearance.BorderSize = 0;
            this.btnAnterior2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnterior2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold);
            this.btnAnterior2.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAnterior2.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            this.btnAnterior2.IconColor = System.Drawing.Color.Gainsboro;
            this.btnAnterior2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAnterior2.IconSize = 20;
            this.btnAnterior2.Location = new System.Drawing.Point(504, 27);
            this.btnAnterior2.Name = "btnAnterior2";
            this.btnAnterior2.Size = new System.Drawing.Size(105, 35);
            this.btnAnterior2.TabIndex = 28;
            this.btnAnterior2.Text = "&Anterior";
            this.btnAnterior2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAnterior2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnterior2.UseVisualStyleBackColor = false;
            this.btnAnterior2.Click += new System.EventHandler(this.btnAnterior2_Click);
            // 
            // btnSiguiente2
            // 
            this.btnSiguiente2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSiguiente2.FlatAppearance.BorderSize = 0;
            this.btnSiguiente2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold);
            this.btnSiguiente2.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSiguiente2.IconChar = FontAwesome.Sharp.IconChar.AngleRight;
            this.btnSiguiente2.IconColor = System.Drawing.Color.Gainsboro;
            this.btnSiguiente2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSiguiente2.IconSize = 20;
            this.btnSiguiente2.Location = new System.Drawing.Point(610, 27);
            this.btnSiguiente2.Name = "btnSiguiente2";
            this.btnSiguiente2.Size = new System.Drawing.Size(105, 35);
            this.btnSiguiente2.TabIndex = 27;
            this.btnSiguiente2.Text = "&Siguiente";
            this.btnSiguiente2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSiguiente2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSiguiente2.UseVisualStyleBackColor = false;
            this.btnSiguiente2.Click += new System.EventHandler(this.btnSiguiente2_Click);
            // 
            // btnImprimir2
            // 
            this.btnImprimir2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnImprimir2.FlatAppearance.BorderSize = 0;
            this.btnImprimir2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold);
            this.btnImprimir2.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnImprimir2.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btnImprimir2.IconColor = System.Drawing.Color.Gainsboro;
            this.btnImprimir2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnImprimir2.IconSize = 20;
            this.btnImprimir2.Location = new System.Drawing.Point(1081, 33);
            this.btnImprimir2.Name = "btnImprimir2";
            this.btnImprimir2.Size = new System.Drawing.Size(105, 35);
            this.btnImprimir2.TabIndex = 27;
            this.btnImprimir2.Text = "&Imprimir";
            this.btnImprimir2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImprimir2.UseVisualStyleBackColor = false;
            this.btnImprimir2.Click += new System.EventHandler(this.btnImprimir2_Click);
            // 
            // FormConsultarTiposDocs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 654);
            this.Controls.Add(this.panelInferior);
            this.Controls.Add(this.dataGridDatos);
            this.Controls.Add(this.panelBusqueda);
            this.Controls.Add(this.panelSuperior);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormConsultarTiposDocs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormConsultarTiposDocs";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormConsultarTiposDocs_FormClosing);
            this.Load += new System.EventHandler(this.FormConsultarTiposDocs_Load);
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.panelBusqueda.ResumeLayout(false);
            this.panelBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDatos)).EndInit();
            this.panelInferior.ResumeLayout(false);
            this.panelInferior.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Panel panelBusqueda;
        private System.Windows.Forms.TextBox textBoxBusqueda;
        private System.Windows.Forms.Label labelingresedato;
        private System.Windows.Forms.DataGridView dataGridDatos;
        private System.Windows.Forms.Panel panelInferior;
        private System.Windows.Forms.Label labelNumTiposDoc;
        private System.Windows.Forms.Label labelCantidad;
        private FontAwesome.Sharp.IconButton btnBuscar2;
        private FontAwesome.Sharp.IconButton btnVolver2;
        private FontAwesome.Sharp.IconButton btnPrimero2;
        private FontAwesome.Sharp.IconButton btnAnterior2;
        private FontAwesome.Sharp.IconButton btnSiguiente2;
        private FontAwesome.Sharp.IconButton btnUltimo2;
        private FontAwesome.Sharp.IconButton btnImprimir2;
    }
}