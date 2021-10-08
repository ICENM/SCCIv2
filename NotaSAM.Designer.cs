namespace SCCI
{
    partial class NotaSAM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotaSAM));
            this.cmdSalir = new System.Windows.Forms.Button();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.gpbDatosNotas = new System.Windows.Forms.GroupBox();
            this.cboActivo = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtII = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtI = new System.Windows.Forms.TextBox();
            this.cboMatricula = new System.Windows.Forms.ComboBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gpbDatosNotas.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdSalir
            // 
            this.cmdSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalir.ForeColor = System.Drawing.Color.Black;
            this.cmdSalir.Image = ((System.Drawing.Image)(resources.GetObject("cmdSalir.Image")));
            this.cmdSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdSalir.Location = new System.Drawing.Point(509, 343);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(155, 61);
            this.cmdSalir.TabIndex = 25;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.ForeColor = System.Drawing.Color.Black;
            this.cmdGuardar.Image = ((System.Drawing.Image)(resources.GetObject("cmdGuardar.Image")));
            this.cmdGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdGuardar.Location = new System.Drawing.Point(348, 343);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(155, 61);
            this.cmdGuardar.TabIndex = 24;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdGuardar.UseVisualStyleBackColor = true;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // gpbDatosNotas
            // 
            this.gpbDatosNotas.Controls.Add(this.cboActivo);
            this.gpbDatosNotas.Controls.Add(this.label10);
            this.gpbDatosNotas.Controls.Add(this.label5);
            this.gpbDatosNotas.Controls.Add(this.txtII);
            this.gpbDatosNotas.Controls.Add(this.label1);
            this.gpbDatosNotas.Controls.Add(this.txtI);
            this.gpbDatosNotas.Controls.Add(this.cboMatricula);
            this.gpbDatosNotas.Controls.Add(this.txtCodigo);
            this.gpbDatosNotas.Controls.Add(this.label43);
            this.gpbDatosNotas.Controls.Add(this.label4);
            this.gpbDatosNotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDatosNotas.ForeColor = System.Drawing.Color.White;
            this.gpbDatosNotas.Location = new System.Drawing.Point(12, 12);
            this.gpbDatosNotas.Name = "gpbDatosNotas";
            this.gpbDatosNotas.Size = new System.Drawing.Size(652, 325);
            this.gpbDatosNotas.TabIndex = 23;
            this.gpbDatosNotas.TabStop = false;
            this.gpbDatosNotas.Text = "Datos Notas del Semestre";
            // 
            // cboActivo
            // 
            this.cboActivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboActivo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboActivo.FormattingEnabled = true;
            this.cboActivo.Items.AddRange(new object[] {
            "S",
            "N"});
            this.cboActivo.Location = new System.Drawing.Point(168, 262);
            this.cboActivo.Name = "cboActivo";
            this.cboActivo.Size = new System.Drawing.Size(121, 33);
            this.cboActivo.TabIndex = 37;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(77, 265);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 25);
            this.label10.TabIndex = 36;
            this.label10.Text = "Activo";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 25);
            this.label5.TabIndex = 34;
            this.label5.Text = "II Parcial";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtII
            // 
            this.txtII.Location = new System.Drawing.Point(168, 206);
            this.txtII.Name = "txtII";
            this.txtII.Size = new System.Drawing.Size(421, 30);
            this.txtII.TabIndex = 33;
            this.txtII.Tag = "las notas del II Parcial";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 32;
            this.label1.Text = "I Parcial";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtI
            // 
            this.txtI.Location = new System.Drawing.Point(168, 154);
            this.txtI.Name = "txtI";
            this.txtI.Size = new System.Drawing.Size(421, 30);
            this.txtI.TabIndex = 31;
            this.txtI.Tag = "las notas del I Parcial";
            // 
            // cboMatricula
            // 
            this.cboMatricula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMatricula.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboMatricula.FormattingEnabled = true;
            this.cboMatricula.Items.AddRange(new object[] {
            "1",
            "0"});
            this.cboMatricula.Location = new System.Drawing.Point(168, 95);
            this.cboMatricula.Name = "cboMatricula";
            this.cboMatricula.Size = new System.Drawing.Size(421, 33);
            this.cboMatricula.TabIndex = 17;
            this.cboMatricula.Tag = "Matrícula";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(168, 40);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(421, 30);
            this.txtCodigo.TabIndex = 11;
            this.txtCodigo.Tag = "No Validar";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(68, 43);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(81, 25);
            this.label43.TabIndex = 10;
            this.label43.Tag = "";
            this.label43.Text = "Codigo";
            this.label43.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Matrícula";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NotaSAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(150)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(676, 418);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.gpbDatosNotas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NotaSAM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.NotaSAM_Load);
            this.gpbDatosNotas.ResumeLayout(false);
            this.gpbDatosNotas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.GroupBox gpbDatosNotas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtII;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtI;
        private System.Windows.Forms.ComboBox cboMatricula;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboActivo;
        private System.Windows.Forms.Label label10;
    }
}