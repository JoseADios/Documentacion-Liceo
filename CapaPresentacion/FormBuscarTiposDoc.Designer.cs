namespace CapaPresentacion
{
    partial class FormBuscarTiposDoc
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.panelInferior = new System.Windows.Forms.Panel();
            this.labelNumTiposDoc = new System.Windows.Forms.Label();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.panelCentral = new System.Windows.Forms.Panel();
            this.dataGridDatos = new System.Windows.Forms.DataGridView();
            this.labelingresedato = new System.Windows.Forms.Label();
            this.textBoxBusqueda = new System.Windows.Forms.TextBox();
            this.panelBusqueda = new System.Windows.Forms.Panel();
            this.btnBuscar2 = new FontAwesome.Sharp.IconButton();
            this.btnAceptar2 = new FontAwesome.Sharp.IconButton();
            this.btnCancelar2 = new FontAwesome.Sharp.IconButton();
            this.btnUltimo2 = new FontAwesome.Sharp.IconButton();
            this.btnSiguiente2 = new FontAwesome.Sharp.IconButton();
            this.btnAnterior2 = new FontAwesome.Sharp.IconButton();
            this.btnPrimero2 = new FontAwesome.Sharp.IconButton();
            this.panelSuperior.SuspendLayout();
            this.panelInferior.SuspendLayout();
            this.panelCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDatos)).BeginInit();
            this.panelBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            this.panelSuperior.Controls.Add(this.labelTitulo);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1200, 92);
            this.panelSuperior.TabIndex = 17;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelTitulo.Location = new System.Drawing.Point(338, 26);
            this.labelTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(493, 33);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Búsqueda de tipos de documentos";
            this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelInferior
            // 
            this.panelInferior.Controls.Add(this.btnPrimero2);
            this.panelInferior.Controls.Add(this.btnCancelar2);
            this.panelInferior.Controls.Add(this.btnAnterior2);
            this.panelInferior.Controls.Add(this.btnAceptar2);
            this.panelInferior.Controls.Add(this.btnSiguiente2);
            this.panelInferior.Controls.Add(this.btnUltimo2);
            this.panelInferior.Controls.Add(this.labelNumTiposDoc);
            this.panelInferior.Controls.Add(this.labelCantidad);
            this.panelInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInferior.Location = new System.Drawing.Point(0, 600);
            this.panelInferior.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelInferior.Name = "panelInferior";
            this.panelInferior.Size = new System.Drawing.Size(1200, 92);
            this.panelInferior.TabIndex = 20;
            this.panelInferior.Paint += new System.Windows.Forms.PaintEventHandler(this.panelInferior_Paint);
            // 
            // labelNumTiposDoc
            // 
            this.labelNumTiposDoc.AutoSize = true;
            this.labelNumTiposDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumTiposDoc.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelNumTiposDoc.Location = new System.Drawing.Point(798, 32);
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
            this.labelCantidad.Location = new System.Drawing.Point(638, 32);
            this.labelCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(130, 13);
            this.labelCantidad.TabIndex = 17;
            this.labelCantidad.Text = "Cantidad de tipos de docs";
            // 
            // panelCentral
            // 
            this.panelCentral.Controls.Add(this.dataGridDatos);
            this.panelCentral.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelCentral.Location = new System.Drawing.Point(0, 194);
            this.panelCentral.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(1200, 406);
            this.panelCentral.TabIndex = 21;
            // 
            // dataGridDatos
            // 
            this.dataGridDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridDatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(126)))));
            this.dataGridDatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridDatos.GridColor = System.Drawing.Color.MidnightBlue;
            this.dataGridDatos.Location = new System.Drawing.Point(0, 0);
            this.dataGridDatos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridDatos.Name = "dataGridDatos";
            this.dataGridDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridDatos.Size = new System.Drawing.Size(1200, 406);
            this.dataGridDatos.TabIndex = 0;
            this.dataGridDatos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDatos_CellDoubleClick);
            this.dataGridDatos.CurrentCellChanged += new System.EventHandler(this.dataGridDatos_CurrentCellChanged);
            // 
            // labelingresedato
            // 
            this.labelingresedato.AutoSize = true;
            this.labelingresedato.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelingresedato.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelingresedato.Location = new System.Drawing.Point(195, 39);
            this.labelingresedato.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelingresedato.Name = "labelingresedato";
            this.labelingresedato.Size = new System.Drawing.Size(165, 18);
            this.labelingresedato.TabIndex = 15;
            this.labelingresedato.Text = "Ingrese el dato a buscar";
            // 
            // textBoxBusqueda
            // 
            this.textBoxBusqueda.Location = new System.Drawing.Point(412, 35);
            this.textBoxBusqueda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxBusqueda.Name = "textBoxBusqueda";
            this.textBoxBusqueda.Size = new System.Drawing.Size(386, 26);
            this.textBoxBusqueda.TabIndex = 0;
            // 
            // panelBusqueda
            // 
            this.panelBusqueda.Controls.Add(this.btnBuscar2);
            this.panelBusqueda.Controls.Add(this.textBoxBusqueda);
            this.panelBusqueda.Controls.Add(this.labelingresedato);
            this.panelBusqueda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBusqueda.Location = new System.Drawing.Point(0, 92);
            this.panelBusqueda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelBusqueda.Name = "panelBusqueda";
            this.panelBusqueda.Size = new System.Drawing.Size(1200, 102);
            this.panelBusqueda.TabIndex = 22;
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
            this.btnBuscar2.Location = new System.Drawing.Point(845, 30);
            this.btnBuscar2.Name = "btnBuscar2";
            this.btnBuscar2.Size = new System.Drawing.Size(112, 33);
            this.btnBuscar2.TabIndex = 17;
            this.btnBuscar2.Text = " &Buscar";
            this.btnBuscar2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar2.UseVisualStyleBackColor = false;
            this.btnBuscar2.Click += new System.EventHandler(this.btnBuscar2_Click);
            // 
            // btnAceptar2
            // 
            this.btnAceptar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAceptar2.FlatAppearance.BorderSize = 0;
            this.btnAceptar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold);
            this.btnAceptar2.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAceptar2.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnAceptar2.IconColor = System.Drawing.Color.Gainsboro;
            this.btnAceptar2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAceptar2.IconSize = 20;
            this.btnAceptar2.Location = new System.Drawing.Point(1060, 28);
            this.btnAceptar2.Name = "btnAceptar2";
            this.btnAceptar2.Size = new System.Drawing.Size(102, 33);
            this.btnAceptar2.TabIndex = 18;
            this.btnAceptar2.Text = "&Aceptar";
            this.btnAceptar2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAceptar2.UseVisualStyleBackColor = false;
            this.btnAceptar2.Click += new System.EventHandler(this.btnAceptar2_Click);
            // 
            // btnCancelar2
            // 
            this.btnCancelar2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCancelar2.FlatAppearance.BorderSize = 0;
            this.btnCancelar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold);
            this.btnCancelar2.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCancelar2.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.btnCancelar2.IconColor = System.Drawing.Color.Gainsboro;
            this.btnCancelar2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelar2.IconSize = 20;
            this.btnCancelar2.Location = new System.Drawing.Point(952, 28);
            this.btnCancelar2.Name = "btnCancelar2";
            this.btnCancelar2.Size = new System.Drawing.Size(102, 33);
            this.btnCancelar2.TabIndex = 19;
            this.btnCancelar2.Text = "&Cancelar";
            this.btnCancelar2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar2.UseVisualStyleBackColor = false;
            this.btnCancelar2.Click += new System.EventHandler(this.btnCancelar2_Click);
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
            this.btnUltimo2.Location = new System.Drawing.Point(361, 26);
            this.btnUltimo2.Name = "btnUltimo2";
            this.btnUltimo2.Size = new System.Drawing.Size(105, 35);
            this.btnUltimo2.TabIndex = 19;
            this.btnUltimo2.Text = "&Ultimo";
            this.btnUltimo2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUltimo2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUltimo2.UseVisualStyleBackColor = false;
            this.btnUltimo2.Click += new System.EventHandler(this.btnUltimo2_Click);
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
            this.btnSiguiente2.Location = new System.Drawing.Point(255, 26);
            this.btnSiguiente2.Name = "btnSiguiente2";
            this.btnSiguiente2.Size = new System.Drawing.Size(105, 35);
            this.btnSiguiente2.TabIndex = 20;
            this.btnSiguiente2.Text = "&Siguiente";
            this.btnSiguiente2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSiguiente2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSiguiente2.UseVisualStyleBackColor = false;
            this.btnSiguiente2.Click += new System.EventHandler(this.btnSiguiente2_Click);
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
            this.btnAnterior2.Location = new System.Drawing.Point(149, 26);
            this.btnAnterior2.Name = "btnAnterior2";
            this.btnAnterior2.Size = new System.Drawing.Size(105, 35);
            this.btnAnterior2.TabIndex = 21;
            this.btnAnterior2.Text = "&Anterior";
            this.btnAnterior2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAnterior2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnterior2.UseVisualStyleBackColor = false;
            this.btnAnterior2.Click += new System.EventHandler(this.btnAnterior2_Click);
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
            this.btnPrimero2.Location = new System.Drawing.Point(43, 26);
            this.btnPrimero2.Name = "btnPrimero2";
            this.btnPrimero2.Size = new System.Drawing.Size(105, 35);
            this.btnPrimero2.TabIndex = 22;
            this.btnPrimero2.Text = "&Primero";
            this.btnPrimero2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrimero2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrimero2.UseVisualStyleBackColor = false;
            this.btnPrimero2.Click += new System.EventHandler(this.btnPrimero2_Click);
            // 
            // FormBuscarTiposDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(126)))));
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.panelBusqueda);
            this.Controls.Add(this.panelCentral);
            this.Controls.Add(this.panelInferior);
            this.Controls.Add(this.panelSuperior);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimizeBox = false;
            this.Name = "FormBuscarTiposDoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormConsultaTiposDoc";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormConsultaTiposDoc_FormClosing);
            this.Load += new System.EventHandler(this.FormConsultaTiposDoc_Load_1);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormConsultaTiposDoc_KeyDown);
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.panelInferior.ResumeLayout(false);
            this.panelInferior.PerformLayout();
            this.panelCentral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDatos)).EndInit();
            this.panelBusqueda.ResumeLayout(false);
            this.panelBusqueda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Panel panelInferior;
        private System.Windows.Forms.Panel panelCentral;
        private System.Windows.Forms.TextBox textBoxBusqueda;
        private System.Windows.Forms.Label labelingresedato;
        private System.Windows.Forms.Label labelNumTiposDoc;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.DataGridView dataGridDatos;
        private System.Windows.Forms.Panel panelBusqueda;
        private FontAwesome.Sharp.IconButton btnBuscar2;
        private FontAwesome.Sharp.IconButton btnCancelar2;
        private FontAwesome.Sharp.IconButton btnAceptar2;
        private FontAwesome.Sharp.IconButton btnUltimo2;
        private FontAwesome.Sharp.IconButton btnSiguiente2;
        private FontAwesome.Sharp.IconButton btnPrimero2;
        private FontAwesome.Sharp.IconButton btnAnterior2;
    }
}