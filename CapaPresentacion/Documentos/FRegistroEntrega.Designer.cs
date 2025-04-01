namespace CapaPresentacion
{
    partial class FRegistroEntrega
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelAcercade = new System.Windows.Forms.Label();
            this.iconButtonAceptar = new FontAwesome.Sharp.IconButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            this.panel2.Controls.Add(this.labelAcercade);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(232, 28);
            this.panel2.TabIndex = 7;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // labelAcercade
            // 
            this.labelAcercade.AutoSize = true;
            this.labelAcercade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAcercade.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelAcercade.Location = new System.Drawing.Point(4, 4);
            this.labelAcercade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAcercade.Name = "labelAcercade";
            this.labelAcercade.Size = new System.Drawing.Size(137, 18);
            this.labelAcercade.TabIndex = 28;
            this.labelAcercade.Text = "Registro de entrega";
            // 
            // iconButtonAceptar
            // 
            this.iconButtonAceptar.BackColor = System.Drawing.Color.SlateBlue;
            this.iconButtonAceptar.FlatAppearance.BorderSize = 0;
            this.iconButtonAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonAceptar.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonAceptar.IconChar = FontAwesome.Sharp.IconChar.ChevronCircleRight;
            this.iconButtonAceptar.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonAceptar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonAceptar.IconSize = 25;
            this.iconButtonAceptar.Location = new System.Drawing.Point(123, 239);
            this.iconButtonAceptar.Name = "iconButtonAceptar";
            this.iconButtonAceptar.Size = new System.Drawing.Size(97, 33);
            this.iconButtonAceptar.TabIndex = 8;
            this.iconButtonAceptar.Text = "Aceptar";
            this.iconButtonAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconButtonAceptar.UseVisualStyleBackColor = false;
            this.iconButtonAceptar.Click += new System.EventHandler(this.iconButtonAceptar_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(12, 97);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(208, 125);
            this.textBox1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Observación";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 259);
            this.panel1.TabIndex = 11;
            // 
            // FRegistroEntrega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 284);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.iconButtonAceptar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRegistroEntrega";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FRegistroEntrega";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelAcercade;
        private FontAwesome.Sharp.IconButton iconButtonAceptar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}