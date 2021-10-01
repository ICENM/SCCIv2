
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.combDocente = new System.Windows.Forms.ComboBox();
            this.combAsignatura = new System.Windows.Forms.ComboBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Cancelarcmd = new System.Windows.Forms.Button();
            this.Guardarcmd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dateFecha_Registro = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateFecha_Registro);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.combDocente);
            this.groupBox1.Controls.Add(this.combAsignatura);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(516, 173);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Asignaturas";
            // 
            // combDocente
            // 
            this.combDocente.FormattingEnabled = true;
            this.combDocente.Location = new System.Drawing.Point(85, 127);
            this.combDocente.Name = "combDocente";
            this.combDocente.Size = new System.Drawing.Size(161, 28);
            this.combDocente.TabIndex = 20;
            this.combDocente.Tag = "Docente";
            // 
            // combAsignatura
            // 
            this.combAsignatura.FormattingEnabled = true;
            this.combAsignatura.Location = new System.Drawing.Point(99, 81);
            this.combAsignatura.Name = "combAsignatura";
            this.combAsignatura.Size = new System.Drawing.Size(161, 28);
            this.combAsignatura.TabIndex = 19;
            this.combAsignatura.Tag = "Asignatura";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(77, 33);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(148, 26);
            this.txtCodigo.TabIndex = 18;
            this.txtCodigo.Tag = "Clave";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(23, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Docente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(23, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Asignatura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(23, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Codigo";
            // 
            // Cancelarcmd
            // 
            this.Cancelarcmd.AutoSize = true;
            this.Cancelarcmd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelarcmd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Cancelarcmd.Image = global::SCCI.Properties.Resources.Cancelar;
            this.Cancelarcmd.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.Cancelarcmd.Location = new System.Drawing.Point(377, 193);
            this.Cancelarcmd.Name = "Cancelarcmd";
            this.Cancelarcmd.Size = new System.Drawing.Size(114, 40);
            this.Cancelarcmd.TabIndex = 18;
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
            this.Guardarcmd.Location = new System.Drawing.Point(247, 193);
            this.Guardarcmd.Name = "Guardarcmd";
            this.Guardarcmd.Size = new System.Drawing.Size(105, 40);
            this.Guardarcmd.TabIndex = 17;
            this.Guardarcmd.Tag = "Guardar";
            this.Guardarcmd.Text = "Guardar ";
            this.Guardarcmd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Guardarcmd.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(280, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Fecha_Registro";
            // 
            // dateFecha_Registro
            // 
            this.dateFecha_Registro.Location = new System.Drawing.Point(381, 83);
            this.dateFecha_Registro.Name = "dateFecha_Registro";
            this.dateFecha_Registro.Size = new System.Drawing.Size(129, 26);
            this.dateFecha_Registro.TabIndex = 22;
            this.dateFecha_Registro.Tag = "Fecha_Registro";
            // 
            // AsignaturasAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(150)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(540, 245);
            this.Controls.Add(this.Cancelarcmd);
            this.Controls.Add(this.Guardarcmd);
            this.Controls.Add(this.groupBox1);
            this.Name = "AsignaturasAM";
            this.Text = "Asignaturas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Cancelarcmd;
        private System.Windows.Forms.Button Guardarcmd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.ComboBox combDocente;
        private System.Windows.Forms.ComboBox combAsignatura;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateFecha_Registro;
    }
}