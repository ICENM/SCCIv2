namespace SCCI
{
    partial class NotaPAM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotaPAM));
            this.cmdSalir = new System.Windows.Forms.Button();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.gpbDatosNotap = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtIV = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtIII = new System.Windows.Forms.TextBox();
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
            this.gpbDatosNotap.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdSalir
            // 
            this.cmdSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalir.ForeColor = System.Drawing.Color.Black;
            this.cmdSalir.Image = ((System.Drawing.Image)(resources.GetObject("cmdSalir.Image")));
            this.cmdSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdSalir.Location = new System.Drawing.Point(503, 440);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(155, 61);
            this.cmdSalir.TabIndex = 28;
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
            this.cmdGuardar.Location = new System.Drawing.Point(342, 440);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(155, 61);
            this.cmdGuardar.TabIndex = 27;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdGuardar.UseVisualStyleBackColor = true;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // gpbDatosNotap
            // 
            this.gpbDatosNotap.Controls.Add(this.label12);
            this.gpbDatosNotap.Controls.Add(this.txtIV);
            this.gpbDatosNotap.Controls.Add(this.label11);
            this.gpbDatosNotap.Controls.Add(this.txtIII);
            this.gpbDatosNotap.Controls.Add(this.cboActivo);
            this.gpbDatosNotap.Controls.Add(this.label10);
            this.gpbDatosNotap.Controls.Add(this.label5);
            this.gpbDatosNotap.Controls.Add(this.txtII);
            this.gpbDatosNotap.Controls.Add(this.label1);
            this.gpbDatosNotap.Controls.Add(this.txtI);
            this.gpbDatosNotap.Controls.Add(this.cboMatricula);
            this.gpbDatosNotap.Controls.Add(this.txtCodigo);
            this.gpbDatosNotap.Controls.Add(this.label43);
            this.gpbDatosNotap.Controls.Add(this.label4);
            this.gpbDatosNotap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDatosNotap.ForeColor = System.Drawing.Color.White;
            this.gpbDatosNotap.Location = new System.Drawing.Point(12, 12);
            this.gpbDatosNotap.Name = "gpbDatosNotap";
            this.gpbDatosNotap.Size = new System.Drawing.Size(646, 422);
            this.gpbDatosNotap.TabIndex = 26;
            this.gpbDatosNotap.TabStop = false;
            this.gpbDatosNotap.Text = "Datos Notas de los Parciales";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(48, 306);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 25);
            this.label12.TabIndex = 41;
            this.label12.Text = "IV Parcial";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtIV
            // 
            this.txtIV.Location = new System.Drawing.Point(172, 303);
            this.txtIV.Name = "txtIV";
            this.txtIV.Size = new System.Drawing.Size(421, 30);
            this.txtIV.TabIndex = 40;
            this.txtIV.Tag = "las notas del IV Parcial";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(51, 257);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 25);
            this.label11.TabIndex = 39;
            this.label11.Text = "III Parcial";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtIII
            // 
            this.txtIII.Location = new System.Drawing.Point(172, 254);
            this.txtIII.Name = "txtIII";
            this.txtIII.Size = new System.Drawing.Size(421, 30);
            this.txtIII.TabIndex = 38;
            this.txtIII.Tag = "las notas del III Parcial";
            // 
            // cboActivo
            // 
            this.cboActivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboActivo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboActivo.FormattingEnabled = true;
            this.cboActivo.Items.AddRange(new object[] {
            "S",
            "N"});
            this.cboActivo.Location = new System.Drawing.Point(172, 354);
            this.cboActivo.Name = "cboActivo";
            this.cboActivo.Size = new System.Drawing.Size(121, 33);
            this.cboActivo.TabIndex = 37;
            this.cboActivo.Tag = "Activo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(81, 357);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 25);
            this.label10.TabIndex = 36;
            this.label10.Text = "Activo";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 25);
            this.label5.TabIndex = 34;
            this.label5.Text = "II Parcial";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtII
            // 
            this.txtII.Location = new System.Drawing.Point(172, 203);
            this.txtII.Name = "txtII";
            this.txtII.Size = new System.Drawing.Size(421, 30);
            this.txtII.TabIndex = 33;
            this.txtII.Tag = "las notas del II Parcial";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 32;
            this.label1.Text = "I Parcial";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtI
            // 
            this.txtI.Location = new System.Drawing.Point(172, 152);
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
            this.cboMatricula.Location = new System.Drawing.Point(172, 96);
            this.cboMatricula.Name = "cboMatricula";
            this.cboMatricula.Size = new System.Drawing.Size(421, 33);
            this.cboMatricula.TabIndex = 17;
            this.cboMatricula.Tag = "Matrícula";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(172, 45);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(421, 30);
            this.txtCodigo.TabIndex = 11;
            this.txtCodigo.Tag = "No Validar";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(72, 48);
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
            this.label4.Location = new System.Drawing.Point(53, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Matrícula";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NotaPAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(150)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(672, 514);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.gpbDatosNotap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NotaPAM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.NotaPAM_Load);
            this.gpbDatosNotap.ResumeLayout(false);
            this.gpbDatosNotap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.GroupBox gpbDatosNotap;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtIV;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtIII;
        private System.Windows.Forms.ComboBox cboActivo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtII;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtI;
        private System.Windows.Forms.ComboBox cboMatricula;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label4;
    }
}