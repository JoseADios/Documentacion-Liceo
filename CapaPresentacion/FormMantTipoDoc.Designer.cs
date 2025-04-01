namespace CapaPresentacion
{
    partial class FormMantenientoTipoDoc
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
            this.textBoxTipoDoc = new System.Windows.Forms.TextBox();
            this.labelTipoDoc = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbbEstado = new System.Windows.Forms.ComboBox();
            this.labelIDTipoDoc = new System.Windows.Forms.Label();
            this.textBoxIDTipoDoc = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnVolver2 = new FontAwesome.Sharp.IconButton();
            this.btnBuscar2 = new FontAwesome.Sharp.IconButton();
            this.btnNuevo2 = new FontAwesome.Sharp.IconButton();
            this.btnEditar2 = new FontAwesome.Sharp.IconButton();
            this.btnCancelar2 = new FontAwesome.Sharp.IconButton();
            this.panelSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxTipoDoc
            // 
            this.textBoxTipoDoc.Location = new System.Drawing.Point(255, 333);
            this.textBoxTipoDoc.Margin = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.textBoxTipoDoc.Name = "textBoxTipoDoc";
            this.textBoxTipoDoc.Size = new System.Drawing.Size(244, 26);
            this.textBoxTipoDoc.TabIndex = 0;
            // 
            // labelTipoDoc
            // 
            this.labelTipoDoc.AutoSize = true;
            this.labelTipoDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipoDoc.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTipoDoc.Location = new System.Drawing.Point(250, 298);
            this.labelTipoDoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTipoDoc.Name = "labelTipoDoc";
            this.labelTipoDoc.Size = new System.Drawing.Size(124, 16);
            this.labelTipoDoc.TabIndex = 1;
            this.labelTipoDoc.Text = "Tipo de documento";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnGuardar.Location = new System.Drawing.Point(861, 611);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(112, 35);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
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
            this.panelSuperior.TabIndex = 7;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelTitulo.Location = new System.Drawing.Point(347, 27);
            this.labelTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(554, 39);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Registro de tipos de documentos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(255, 414);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Estado";
            // 
            // cmbbEstado
            // 
            this.cmbbEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbbEstado.FormattingEnabled = true;
            this.cmbbEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cmbbEstado.Location = new System.Drawing.Point(255, 449);
            this.cmbbEstado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbbEstado.Name = "cmbbEstado";
            this.cmbbEstado.Size = new System.Drawing.Size(180, 28);
            this.cmbbEstado.TabIndex = 9;
            this.cmbbEstado.SelectedIndexChanged += new System.EventHandler(this.cmbbEstado_SelectedIndexChanged);
            // 
            // labelIDTipoDoc
            // 
            this.labelIDTipoDoc.AutoSize = true;
            this.labelIDTipoDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIDTipoDoc.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelIDTipoDoc.Location = new System.Drawing.Point(250, 187);
            this.labelIDTipoDoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIDTipoDoc.Name = "labelIDTipoDoc";
            this.labelIDTipoDoc.Size = new System.Drawing.Size(140, 16);
            this.labelIDTipoDoc.TabIndex = 14;
            this.labelIDTipoDoc.Text = "ID Tipo de documento";
            // 
            // textBoxIDTipoDoc
            // 
            this.textBoxIDTipoDoc.Location = new System.Drawing.Point(255, 223);
            this.textBoxIDTipoDoc.Margin = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.textBoxIDTipoDoc.Name = "textBoxIDTipoDoc";
            this.textBoxIDTipoDoc.Size = new System.Drawing.Size(244, 26);
            this.textBoxIDTipoDoc.TabIndex = 13;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnVolver2
            // 
            this.btnVolver2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnVolver2.FlatAppearance.BorderSize = 0;
            this.btnVolver2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold);
            this.btnVolver2.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnVolver2.IconChar = FontAwesome.Sharp.IconChar.ReplyAll;
            this.btnVolver2.IconColor = System.Drawing.Color.Gainsboro;
            this.btnVolver2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVolver2.IconSize = 20;
            this.btnVolver2.Location = new System.Drawing.Point(0, 93);
            this.btnVolver2.Name = "btnVolver2";
            this.btnVolver2.Size = new System.Drawing.Size(112, 36);
            this.btnVolver2.TabIndex = 27;
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
            this.btnBuscar2.Location = new System.Drawing.Point(704, 211);
            this.btnBuscar2.Name = "btnBuscar2";
            this.btnBuscar2.Size = new System.Drawing.Size(113, 38);
            this.btnBuscar2.TabIndex = 28;
            this.btnBuscar2.Text = " &Buscar";
            this.btnBuscar2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar2.UseVisualStyleBackColor = false;
            this.btnBuscar2.Click += new System.EventHandler(this.btnBuscar2_Click);
            // 
            // btnNuevo2
            // 
            this.btnNuevo2.BackColor = System.Drawing.Color.OrangeRed;
            this.btnNuevo2.FlatAppearance.BorderSize = 0;
            this.btnNuevo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold);
            this.btnNuevo2.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnNuevo2.IconChar = FontAwesome.Sharp.IconChar.FileMedical;
            this.btnNuevo2.IconColor = System.Drawing.Color.Gainsboro;
            this.btnNuevo2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevo2.IconSize = 20;
            this.btnNuevo2.Location = new System.Drawing.Point(114, 611);
            this.btnNuevo2.Name = "btnNuevo2";
            this.btnNuevo2.Size = new System.Drawing.Size(112, 35);
            this.btnNuevo2.TabIndex = 29;
            this.btnNuevo2.Text = "&Nuevo";
            this.btnNuevo2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevo2.UseVisualStyleBackColor = false;
            this.btnNuevo2.Click += new System.EventHandler(this.btnNuevo2_Click);
            // 
            // btnEditar2
            // 
            this.btnEditar2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnEditar2.FlatAppearance.BorderSize = 0;
            this.btnEditar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold);
            this.btnEditar2.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEditar2.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEditar2.IconColor = System.Drawing.Color.Gainsboro;
            this.btnEditar2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnEditar2.IconSize = 20;
            this.btnEditar2.Location = new System.Drawing.Point(255, 610);
            this.btnEditar2.Name = "btnEditar2";
            this.btnEditar2.Size = new System.Drawing.Size(112, 36);
            this.btnEditar2.TabIndex = 30;
            this.btnEditar2.Text = "&Editar";
            this.btnEditar2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar2.UseVisualStyleBackColor = false;
            this.btnEditar2.Click += new System.EventHandler(this.btnEditar2_Click);
            // 
            // btnCancelar2
            // 
            this.btnCancelar2.BackColor = System.Drawing.Color.Gray;
            this.btnCancelar2.FlatAppearance.BorderSize = 0;
            this.btnCancelar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold);
            this.btnCancelar2.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCancelar2.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.btnCancelar2.IconColor = System.Drawing.Color.Gainsboro;
            this.btnCancelar2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelar2.IconSize = 20;
            this.btnCancelar2.Location = new System.Drawing.Point(1004, 610);
            this.btnCancelar2.Name = "btnCancelar2";
            this.btnCancelar2.Size = new System.Drawing.Size(112, 36);
            this.btnCancelar2.TabIndex = 31;
            this.btnCancelar2.Text = "&Cancelar";
            this.btnCancelar2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar2.UseVisualStyleBackColor = false;
            this.btnCancelar2.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // FormMantenientoTipoDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(126)))));
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btnCancelar2);
            this.Controls.Add(this.btnEditar2);
            this.Controls.Add(this.btnNuevo2);
            this.Controls.Add(this.btnBuscar2);
            this.Controls.Add(this.btnVolver2);
            this.Controls.Add(this.labelIDTipoDoc);
            this.Controls.Add(this.textBoxIDTipoDoc);
            this.Controls.Add(this.cmbbEstado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelSuperior);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.labelTipoDoc);
            this.Controls.Add(this.textBoxTipoDoc);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FormMantenientoTipoDoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tipos de documentos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMantenientoTipoDoc_FormClosing);
            this.Load += new System.EventHandler(this.FormMantenientoTipoDoc_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMantenientoTipoDoc_KeyDown);
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTipoDoc;
        private System.Windows.Forms.Label labelTipoDoc;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbbEstado;
        private System.Windows.Forms.Label labelIDTipoDoc;
        private System.Windows.Forms.TextBox textBoxIDTipoDoc;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private FontAwesome.Sharp.IconButton btnVolver2;
        private FontAwesome.Sharp.IconButton btnBuscar2;
        private FontAwesome.Sharp.IconButton btnNuevo2;
        private FontAwesome.Sharp.IconButton btnEditar2;
        private FontAwesome.Sharp.IconButton btnCancelar2;
    }
}