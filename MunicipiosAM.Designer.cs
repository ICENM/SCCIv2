
namespace SCCI
{
    partial class MunicipiosAM
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.combActivo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Clave = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Cancelarcmd = new System.Windows.Forms.Button();
            this.Guardarcmd = new System.Windows.Forms.Button();
            this.dateFecha_Registro = new System.Windows.Forms.DateTimePicker();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.combDepartamento = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.combDepartamento);
            this.groupBox1.Controls.Add(this.txtClave);
            this.groupBox1.Controls.Add(this.dateFecha_Registro);
            this.groupBox1.Controls.Add(this.combActivo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Clave);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 196);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Municipios";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // combActivo
            // 
            this.combActivo.FormattingEnabled = true;
            this.combActivo.Location = new System.Drawing.Point(84, 163);
            this.combActivo.Name = "combActivo";
            this.combActivo.Size = new System.Drawing.Size(161, 31);
            this.combActivo.TabIndex = 12;
            this.combActivo.Tag = "Activo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(297, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fecha_Registro";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(35, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Activo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(19, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Departamento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(35, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Clave";
            // 
            // Clave
            // 
            this.Clave.AutoSize = true;
            this.Clave.Location = new System.Drawing.Point(74, 41);
            this.Clave.Name = "Clave";
            this.Clave.Size = new System.Drawing.Size(0, 23);
            this.Clave.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 23);
            this.label1.TabIndex = 1;
            // 
            // Cancelarcmd
            // 
            this.Cancelarcmd.AutoSize = true;
            this.Cancelarcmd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelarcmd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Cancelarcmd.Image = global::SCCI.Properties.Resources.Cancelar;
            this.Cancelarcmd.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.Cancelarcmd.Location = new System.Drawing.Point(442, 240);
            this.Cancelarcmd.Name = "Cancelarcmd";
            this.Cancelarcmd.Size = new System.Drawing.Size(114, 40);
            this.Cancelarcmd.TabIndex = 16;
            this.Cancelarcmd.Tag = "Cancelar";
            this.Cancelarcmd.Text = "Cancelar";
            this.Cancelarcmd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cancelarcmd.UseVisualStyleBackColor = true;
            // 
            // Guardarcmd
            // 
            this.Guardarcmd.AutoSize = true;
            this.Guardarcmd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardarcmd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Guardarcmd.Image = global::SCCI.Properties.Resources.Guardar;
            this.Guardarcmd.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.Guardarcmd.Location = new System.Drawing.Point(312, 240);
            this.Guardarcmd.Name = "Guardarcmd";
            this.Guardarcmd.Size = new System.Drawing.Size(105, 40);
            this.Guardarcmd.TabIndex = 10;
            this.Guardarcmd.Tag = "Guardar";
            this.Guardarcmd.Text = "Guardar ";
            this.Guardarcmd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Guardarcmd.UseVisualStyleBackColor = true;
            // 
            // dateFecha_Registro
            // 
            this.dateFecha_Registro.Location = new System.Drawing.Point(398, 105);
            this.dateFecha_Registro.Name = "dateFecha_Registro";
            this.dateFecha_Registro.Size = new System.Drawing.Size(129, 30);
            this.dateFecha_Registro.TabIndex = 16;
            this.dateFecha_Registro.Tag = "Fecha_Registro";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(80, 27);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(148, 30);
            this.txtClave.TabIndex = 17;
            this.txtClave.Tag = "Clave";
            // 
            // combDepartamento
            // 
            this.combDepartamento.FormattingEnabled = true;
            this.combDepartamento.Location = new System.Drawing.Point(105, 97);
            this.combDepartamento.Name = "combDepartamento";
            this.combDepartamento.Size = new System.Drawing.Size(161, 31);
            this.combDepartamento.TabIndex = 18;
            // 
            // MunicipiosAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(150)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(574, 292);
            this.Controls.Add(this.Cancelarcmd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Guardarcmd);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Name = "MunicipiosAM";
            this.Text = "Ciudades";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Clave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Guardarcmd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox combActivo;
        private System.Windows.Forms.Button Cancelarcmd;
        private System.Windows.Forms.DateTimePicker dateFecha_Registro;
        private System.Windows.Forms.ComboBox combDepartamento;
        private System.Windows.Forms.TextBox txtClave;
    }
}