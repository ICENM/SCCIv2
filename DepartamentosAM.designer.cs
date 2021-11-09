
namespace SCCI
{
    partial class DepartamentosAM
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
            this.gpbDepartamento = new System.Windows.Forms.GroupBox();
            this.txtDepa = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.DateTimePicker();
            this.cboActivo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.gpbDepartamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbDepartamento
            // 
            this.gpbDepartamento.Controls.Add(this.txtDepa);
            this.gpbDepartamento.Controls.Add(this.txtFecha);
            this.gpbDepartamento.Controls.Add(this.cboActivo);
            this.gpbDepartamento.Controls.Add(this.label4);
            this.gpbDepartamento.Controls.Add(this.label3);
            this.gpbDepartamento.Controls.Add(this.label2);
            this.gpbDepartamento.Controls.Add(this.txtClave);
            this.gpbDepartamento.Controls.Add(this.label1);
            this.gpbDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.gpbDepartamento.ForeColor = System.Drawing.Color.White;
            this.gpbDepartamento.Location = new System.Drawing.Point(18, 18);
            this.gpbDepartamento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpbDepartamento.Name = "gpbDepartamento";
            this.gpbDepartamento.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpbDepartamento.Size = new System.Drawing.Size(531, 254);
            this.gpbDepartamento.TabIndex = 10;
            this.gpbDepartamento.TabStop = false;
            this.gpbDepartamento.Text = "Datos Departamentos";
            // 
            // txtDepa
            // 
            this.txtDepa.Location = new System.Drawing.Point(227, 84);
            this.txtDepa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDepa.Name = "txtDepa";
            this.txtDepa.Size = new System.Drawing.Size(286, 30);
            this.txtDepa.TabIndex = 11;
            this.txtDepa.Tag = "Departamento";
            // 
            // txtFecha
            // 
            this.txtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFecha.Location = new System.Drawing.Point(227, 140);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(163, 30);
            this.txtFecha.TabIndex = 10;
            this.txtFecha.Tag = "Fecha de Registro";
            // 
            // cboActivo
            // 
            this.cboActivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboActivo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboActivo.FormattingEnabled = true;
            this.cboActivo.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cboActivo.Location = new System.Drawing.Point(227, 192);
            this.cboActivo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboActivo.Name = "cboActivo";
            this.cboActivo.Size = new System.Drawing.Size(163, 33);
            this.cboActivo.TabIndex = 7;
            this.cboActivo.Tag = "No Validar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 197);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Activo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 147);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha de Registro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Departamento";
            // 
            // txtClave
            // 
            this.txtClave.Enabled = false;
            this.txtClave.Location = new System.Drawing.Point(227, 33);
            this.txtClave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(286, 30);
            this.txtClave.TabIndex = 1;
            this.txtClave.Tag = "No Validar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clave";
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelar.Image = global::SCCI.Properties.Resources.Cancelar;
            this.cmdCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCancelar.Location = new System.Drawing.Point(279, 282);
            this.cmdCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(168, 68);
            this.cmdCancelar.TabIndex = 12;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.Image = global::SCCI.Properties.Resources.Guardar;
            this.cmdGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdGuardar.Location = new System.Drawing.Point(103, 282);
            this.cmdGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(168, 68);
            this.cmdGuardar.TabIndex = 11;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdGuardar.UseVisualStyleBackColor = true;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // DepartamentosAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(150)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(567, 366);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.gpbDepartamento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DepartamentosAM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.DepartamentosAM_Load);
            this.gpbDepartamento.ResumeLayout(false);
            this.gpbDepartamento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.GroupBox gpbDepartamento;
        private System.Windows.Forms.ComboBox cboActivo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker txtFecha;
        private System.Windows.Forms.TextBox txtDepa;
    }
}