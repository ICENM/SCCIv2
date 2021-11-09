
namespace SCCI
{
    partial class BarriosAM
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
            this.gpdDatosBarrios = new System.Windows.Forms.GroupBox();
            this.txtBarrio = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.DateTimePicker();
            this.cboActivo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.gpdDatosBarrios.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpdDatosBarrios
            // 
            this.gpdDatosBarrios.Controls.Add(this.txtBarrio);
            this.gpdDatosBarrios.Controls.Add(this.txtFecha);
            this.gpdDatosBarrios.Controls.Add(this.cboActivo);
            this.gpdDatosBarrios.Controls.Add(this.label4);
            this.gpdDatosBarrios.Controls.Add(this.label3);
            this.gpdDatosBarrios.Controls.Add(this.label2);
            this.gpdDatosBarrios.Controls.Add(this.txtClave);
            this.gpdDatosBarrios.Controls.Add(this.label1);
            this.gpdDatosBarrios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.gpdDatosBarrios.ForeColor = System.Drawing.Color.White;
            this.gpdDatosBarrios.Location = new System.Drawing.Point(18, 18);
            this.gpdDatosBarrios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpdDatosBarrios.Name = "gpdDatosBarrios";
            this.gpdDatosBarrios.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpdDatosBarrios.Size = new System.Drawing.Size(653, 343);
            this.gpdDatosBarrios.TabIndex = 13;
            this.gpdDatosBarrios.TabStop = false;
            this.gpdDatosBarrios.Text = "Datos Barrios";
            // 
            // txtBarrio
            // 
            this.txtBarrio.Location = new System.Drawing.Point(241, 85);
            this.txtBarrio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBarrio.Multiline = true;
            this.txtBarrio.Name = "txtBarrio";
            this.txtBarrio.Size = new System.Drawing.Size(396, 117);
            this.txtBarrio.TabIndex = 11;
            this.txtBarrio.Tag = "Barrio";
            // 
            // txtFecha
            // 
            this.txtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFecha.Location = new System.Drawing.Point(241, 227);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(210, 30);
            this.txtFecha.TabIndex = 10;
            this.txtFecha.Tag = "Fecha de Registro";
            // 
            // cboActivo
            // 
            this.cboActivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboActivo.FormattingEnabled = true;
            this.cboActivo.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cboActivo.Location = new System.Drawing.Point(241, 281);
            this.cboActivo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboActivo.Name = "cboActivo";
            this.cboActivo.Size = new System.Drawing.Size(210, 33);
            this.cboActivo.TabIndex = 7;
            this.cboActivo.Tag = "No Validar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 282);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Activo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 232);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha de Registro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Barrio";
            // 
            // txtClave
            // 
            this.txtClave.Enabled = false;
            this.txtClave.Location = new System.Drawing.Point(241, 33);
            this.txtClave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(396, 30);
            this.txtClave.TabIndex = 1;
            this.txtClave.Tag = "No Validar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clave";
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.cmdCancelar.Image = global::SCCI.Properties.Resources.Cancelar;
            this.cmdCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCancelar.Location = new System.Drawing.Point(337, 371);
            this.cmdCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(168, 68);
            this.cmdCancelar.TabIndex = 15;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.cmdGuardar.Image = global::SCCI.Properties.Resources.Guardar;
            this.cmdGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdGuardar.Location = new System.Drawing.Point(161, 371);
            this.cmdGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(168, 68);
            this.cmdGuardar.TabIndex = 14;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdGuardar.UseVisualStyleBackColor = true;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // BarriosAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(150)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(689, 453);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.gpdDatosBarrios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BarriosAM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.BarriosAM_Load);
            this.gpdDatosBarrios.ResumeLayout(false);
            this.gpdDatosBarrios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.GroupBox gpdDatosBarrios;
        private System.Windows.Forms.ComboBox cboActivo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker txtFecha;
        private System.Windows.Forms.TextBox txtBarrio;
    }
}