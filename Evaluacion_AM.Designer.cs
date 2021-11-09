
namespace SCCI
{
    partial class Evaluacion_AM
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
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.gbEvaluacion = new System.Windows.Forms.GroupBox();
            this.txtEvaluacion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboActivo = new System.Windows.Forms.ComboBox();
            this.dtpFechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbEvaluacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelar.Image = global::SCCI.Properties.Resources.Cancelar;
            this.cmdCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCancelar.Location = new System.Drawing.Point(280, 248);
            this.cmdCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(146, 60);
            this.cmdCancelar.TabIndex = 5;
            this.cmdCancelar.Text = "Cancelar ";
            this.cmdCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.Image = global::SCCI.Properties.Resources.Guardar;
            this.cmdGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdGuardar.Location = new System.Drawing.Point(135, 248);
            this.cmdGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(136, 60);
            this.cmdGuardar.TabIndex = 4;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdGuardar.UseVisualStyleBackColor = true;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // gbEvaluacion
            // 
            this.gbEvaluacion.Controls.Add(this.txtEvaluacion);
            this.gbEvaluacion.Controls.Add(this.label3);
            this.gbEvaluacion.Controls.Add(this.cboActivo);
            this.gbEvaluacion.Controls.Add(this.dtpFechaRegistro);
            this.gbEvaluacion.Controls.Add(this.txtCodigo);
            this.gbEvaluacion.Controls.Add(this.label5);
            this.gbEvaluacion.Controls.Add(this.label4);
            this.gbEvaluacion.Controls.Add(this.label1);
            this.gbEvaluacion.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEvaluacion.Location = new System.Drawing.Point(18, 18);
            this.gbEvaluacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbEvaluacion.Name = "gbEvaluacion";
            this.gbEvaluacion.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbEvaluacion.Size = new System.Drawing.Size(502, 220);
            this.gbEvaluacion.TabIndex = 3;
            this.gbEvaluacion.TabStop = false;
            this.gbEvaluacion.Text = "Datos Evaluacion";
            // 
            // txtEvaluacion
            // 
            this.txtEvaluacion.Location = new System.Drawing.Point(168, 83);
            this.txtEvaluacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEvaluacion.Name = "txtEvaluacion";
            this.txtEvaluacion.Size = new System.Drawing.Size(308, 28);
            this.txtEvaluacion.TabIndex = 11;
            this.txtEvaluacion.Tag = "Evaluacion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tipo Evaluacion:";
            // 
            // cboActivo
            // 
            this.cboActivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboActivo.FormattingEnabled = true;
            this.cboActivo.Items.AddRange(new object[] {
            "S",
            "N"});
            this.cboActivo.Location = new System.Drawing.Point(168, 166);
            this.cboActivo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboActivo.Name = "cboActivo";
            this.cboActivo.Size = new System.Drawing.Size(148, 28);
            this.cboActivo.TabIndex = 9;
            this.cboActivo.Tag = "Activo";
            // 
            // dtpFechaRegistro
            // 
            this.dtpFechaRegistro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaRegistro.Location = new System.Drawing.Point(168, 125);
            this.dtpFechaRegistro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFechaRegistro.Name = "dtpFechaRegistro";
            this.dtpFechaRegistro.Size = new System.Drawing.Size(148, 28);
            this.dtpFechaRegistro.TabIndex = 8;
            this.dtpFechaRegistro.Tag = "Fecha Registro";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(168, 42);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(308, 28);
            this.txtCodigo.TabIndex = 5;
            this.txtCodigo.Tag = "No Validar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 169);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Activo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 128);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha Registro:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // Evaluacion_AM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(150)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(541, 334);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.gbEvaluacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Evaluacion_AM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Evaluacion_AM_Load);
            this.gbEvaluacion.ResumeLayout(false);
            this.gbEvaluacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.GroupBox gbEvaluacion;
        private System.Windows.Forms.TextBox txtEvaluacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboActivo;
        private System.Windows.Forms.DateTimePicker dtpFechaRegistro;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}