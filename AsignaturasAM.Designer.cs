
namespace SCCI
{
    partial class AsignaturasAM
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
            this.gpdDatosAsignatura = new System.Windows.Forms.GroupBox();
            this.txtAsignatura = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cboDocente = new System.Windows.Forms.ComboBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Cancelarcmd = new System.Windows.Forms.Button();
            this.Guardarcmd = new System.Windows.Forms.Button();
            this.cboActivo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gpdDatosAsignatura.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpdDatosAsignatura
            // 
            this.gpdDatosAsignatura.Controls.Add(this.label4);
            this.gpdDatosAsignatura.Controls.Add(this.cboActivo);
            this.gpdDatosAsignatura.Controls.Add(this.txtAsignatura);
            this.gpdDatosAsignatura.Controls.Add(this.txtFecha);
            this.gpdDatosAsignatura.Controls.Add(this.label5);
            this.gpdDatosAsignatura.Controls.Add(this.cboDocente);
            this.gpdDatosAsignatura.Controls.Add(this.txtCodigo);
            this.gpdDatosAsignatura.Controls.Add(this.label3);
            this.gpdDatosAsignatura.Controls.Add(this.label1);
            this.gpdDatosAsignatura.Controls.Add(this.label2);
            this.gpdDatosAsignatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.gpdDatosAsignatura.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gpdDatosAsignatura.Location = new System.Drawing.Point(18, 5);
            this.gpdDatosAsignatura.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpdDatosAsignatura.Name = "gpdDatosAsignatura";
            this.gpdDatosAsignatura.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpdDatosAsignatura.Size = new System.Drawing.Size(605, 325);
            this.gpdDatosAsignatura.TabIndex = 0;
            this.gpdDatosAsignatura.TabStop = false;
            this.gpdDatosAsignatura.Text = "Datos Asignaturas";
            // 
            // txtAsignatura
            // 
            this.txtAsignatura.Location = new System.Drawing.Point(202, 88);
            this.txtAsignatura.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAsignatura.Name = "txtAsignatura";
            this.txtAsignatura.Size = new System.Drawing.Size(374, 30);
            this.txtAsignatura.TabIndex = 23;
            this.txtAsignatura.Tag = "Asignatura";
            // 
            // txtFecha
            // 
            this.txtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFecha.Location = new System.Drawing.Point(202, 195);
            this.txtFecha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(192, 30);
            this.txtFecha.TabIndex = 22;
            this.txtFecha.Tag = "Fecha de Registro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(25, 200);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "Fecha Registro";
            // 
            // cboDocente
            // 
            this.cboDocente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDocente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboDocente.FormattingEnabled = true;
            this.cboDocente.Location = new System.Drawing.Point(202, 140);
            this.cboDocente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboDocente.Name = "cboDocente";
            this.cboDocente.Size = new System.Drawing.Size(374, 33);
            this.cboDocente.TabIndex = 20;
            this.cboDocente.Tag = "Docente";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(202, 39);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(374, 30);
            this.txtCodigo.TabIndex = 18;
            this.txtCodigo.Tag = "No Validar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(90, 143);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Docente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(66, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Asignatura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(101, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Codigo";
            // 
            // Cancelarcmd
            // 
            this.Cancelarcmd.AutoSize = true;
            this.Cancelarcmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.Cancelarcmd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Cancelarcmd.Image = global::SCCI.Properties.Resources.Cancelar;
            this.Cancelarcmd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cancelarcmd.Location = new System.Drawing.Point(460, 340);
            this.Cancelarcmd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Cancelarcmd.Name = "Cancelarcmd";
            this.Cancelarcmd.Size = new System.Drawing.Size(168, 68);
            this.Cancelarcmd.TabIndex = 18;
            this.Cancelarcmd.Tag = "Cancelar";
            this.Cancelarcmd.Text = "Cancelar";
            this.Cancelarcmd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Cancelarcmd.UseVisualStyleBackColor = true;
            this.Cancelarcmd.Click += new System.EventHandler(this.Cancelarcmd_Click);
            // 
            // Guardarcmd
            // 
            this.Guardarcmd.AutoSize = true;
            this.Guardarcmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.Guardarcmd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Guardarcmd.Image = global::SCCI.Properties.Resources.Guardar;
            this.Guardarcmd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Guardarcmd.Location = new System.Drawing.Point(284, 340);
            this.Guardarcmd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Guardarcmd.Name = "Guardarcmd";
            this.Guardarcmd.Size = new System.Drawing.Size(168, 68);
            this.Guardarcmd.TabIndex = 17;
            this.Guardarcmd.Tag = "Guardar";
            this.Guardarcmd.Text = "Guardar ";
            this.Guardarcmd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Guardarcmd.UseVisualStyleBackColor = true;
            this.Guardarcmd.Click += new System.EventHandler(this.Guardarcmd_Click);
            // 
            // cboActivo
            // 
            this.cboActivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboActivo.FormattingEnabled = true;
            this.cboActivo.Items.AddRange(new object[] {
            "S",
            "N"});
            this.cboActivo.Location = new System.Drawing.Point(202, 246);
            this.cboActivo.Name = "cboActivo";
            this.cboActivo.Size = new System.Drawing.Size(94, 33);
            this.cboActivo.TabIndex = 24;
            this.cboActivo.Tag = "No Validar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(110, 249);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 25);
            this.label4.TabIndex = 25;
            this.label4.Text = "Activo";
            // 
            // AsignaturasAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(150)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(641, 422);
            this.Controls.Add(this.Cancelarcmd);
            this.Controls.Add(this.Guardarcmd);
            this.Controls.Add(this.gpdDatosAsignatura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AsignaturasAM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpdDatosAsignatura.ResumeLayout(false);
            this.gpdDatosAsignatura.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpdDatosAsignatura;
        private System.Windows.Forms.Button Cancelarcmd;
        private System.Windows.Forms.Button Guardarcmd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.ComboBox cboDocente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker txtFecha;
        private System.Windows.Forms.TextBox txtAsignatura;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboActivo;
    }
}