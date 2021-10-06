
namespace SCCI
{
    partial class NacionalidadesAM
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
            this.gpbNacionalidad = new System.Windows.Forms.GroupBox();
            this.txtFecha_Reg = new System.Windows.Forms.DateTimePicker();
            this.gpoNacionalidades = new System.Windows.Forms.ComboBox();
            this.gpoActivo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gpbNacionalidad.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelar.Image = global::SCCI.Properties.Resources.Cancelar;
            this.cmdCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCancelar.Location = new System.Drawing.Point(548, 196);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(111, 38);
            this.cmdCancelar.TabIndex = 15;
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
            this.cmdGuardar.Location = new System.Drawing.Point(428, 196);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(111, 38);
            this.cmdGuardar.TabIndex = 14;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdGuardar.UseVisualStyleBackColor = true;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // gpbNacionalidad
            // 
            this.gpbNacionalidad.Controls.Add(this.txtFecha_Reg);
            this.gpbNacionalidad.Controls.Add(this.gpoNacionalidades);
            this.gpbNacionalidad.Controls.Add(this.gpoActivo);
            this.gpbNacionalidad.Controls.Add(this.label4);
            this.gpbNacionalidad.Controls.Add(this.label3);
            this.gpbNacionalidad.Controls.Add(this.label2);
            this.gpbNacionalidad.Controls.Add(this.txtClave);
            this.gpbNacionalidad.Controls.Add(this.label1);
            this.gpbNacionalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.gpbNacionalidad.ForeColor = System.Drawing.Color.White;
            this.gpbNacionalidad.Location = new System.Drawing.Point(9, 15);
            this.gpbNacionalidad.Name = "gpbNacionalidad";
            this.gpbNacionalidad.Size = new System.Drawing.Size(656, 175);
            this.gpbNacionalidad.TabIndex = 13;
            this.gpbNacionalidad.TabStop = false;
            this.gpbNacionalidad.Text = "Nacionalidad";
            this.gpbNacionalidad.Enter += new System.EventHandler(this.gpbNacionalidad_Enter);
            // 
            // txtFecha_Reg
            // 
            this.txtFecha_Reg.Location = new System.Drawing.Point(419, 82);
            this.txtFecha_Reg.Name = "txtFecha_Reg";
            this.txtFecha_Reg.Size = new System.Drawing.Size(231, 23);
            this.txtFecha_Reg.TabIndex = 9;
            // 
            // gpoNacionalidades
            // 
            this.gpoNacionalidades.FormattingEnabled = true;
            this.gpoNacionalidades.Location = new System.Drawing.Point(131, 80);
            this.gpoNacionalidades.Name = "gpoNacionalidades";
            this.gpoNacionalidades.Size = new System.Drawing.Size(121, 24);
            this.gpoNacionalidades.TabIndex = 8;
            this.gpoNacionalidades.SelectedIndexChanged += new System.EventHandler(this.gpoNacionalidades_SelectedIndexChanged);
            // 
            // gpoActivo
            // 
            this.gpoActivo.FormattingEnabled = true;
            this.gpoActivo.Location = new System.Drawing.Point(64, 140);
            this.gpoActivo.Name = "gpoActivo";
            this.gpoActivo.Size = new System.Drawing.Size(121, 24);
            this.gpoActivo.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Activo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha de Registro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nacionalidades";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(60, 29);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(134, 23);
            this.txtClave.TabIndex = 1;
            this.txtClave.TextChanged += new System.EventHandler(this.txtClave_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clave";
            // 
            // NacionalidadesAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(150)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(674, 249);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.gpbNacionalidad);
            this.Name = "NacionalidadesAM";
            this.Text = "NacionalidadesAM";
            this.Load += new System.EventHandler(this.Nacionalidades_AM_Load);
            this.gpbNacionalidad.ResumeLayout(false);
            this.gpbNacionalidad.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.GroupBox gpbNacionalidad;
        private System.Windows.Forms.DateTimePicker txtFecha_Reg;
        private System.Windows.Forms.ComboBox gpoNacionalidades;
        private System.Windows.Forms.ComboBox gpoActivo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label label1;
    }
}