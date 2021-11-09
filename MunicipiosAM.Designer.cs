
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
            this.gpbMunicipios = new System.Windows.Forms.GroupBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.dateFecha_Registro = new System.Windows.Forms.DateTimePicker();
            this.combActivo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Clave = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Cancelarcmd = new System.Windows.Forms.Button();
            this.Guardarcmd = new System.Windows.Forms.Button();
            this.txtMunicipio = new System.Windows.Forms.TextBox();
            this.gpbMunicipios.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbMunicipios
            // 
            this.gpbMunicipios.Controls.Add(this.txtMunicipio);
            this.gpbMunicipios.Controls.Add(this.txtClave);
            this.gpbMunicipios.Controls.Add(this.dateFecha_Registro);
            this.gpbMunicipios.Controls.Add(this.combActivo);
            this.gpbMunicipios.Controls.Add(this.label5);
            this.gpbMunicipios.Controls.Add(this.label4);
            this.gpbMunicipios.Controls.Add(this.label3);
            this.gpbMunicipios.Controls.Add(this.label2);
            this.gpbMunicipios.Controls.Add(this.Clave);
            this.gpbMunicipios.Controls.Add(this.label1);
            this.gpbMunicipios.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.gpbMunicipios.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gpbMunicipios.Location = new System.Drawing.Point(18, 18);
            this.gpbMunicipios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpbMunicipios.Name = "gpbMunicipios";
            this.gpbMunicipios.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpbMunicipios.Size = new System.Drawing.Size(491, 302);
            this.gpbMunicipios.TabIndex = 0;
            this.gpbMunicipios.TabStop = false;
            this.gpbMunicipios.Text = "Datos Municipios";
            this.gpbMunicipios.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtClave
            // 
            this.txtClave.Enabled = false;
            this.txtClave.Location = new System.Drawing.Point(225, 42);
            this.txtClave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(240, 30);
            this.txtClave.TabIndex = 17;
            this.txtClave.Tag = "No Validar";
            // 
            // dateFecha_Registro
            // 
            this.dateFecha_Registro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFecha_Registro.Location = new System.Drawing.Point(225, 176);
            this.dateFecha_Registro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateFecha_Registro.Name = "dateFecha_Registro";
            this.dateFecha_Registro.Size = new System.Drawing.Size(240, 30);
            this.dateFecha_Registro.TabIndex = 16;
            this.dateFecha_Registro.Tag = "Fecha_Registro";
            // 
            // combActivo
            // 
            this.combActivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combActivo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.combActivo.FormattingEnabled = true;
            this.combActivo.Items.AddRange(new object[] {
            "0",
            "1"});
            this.combActivo.Location = new System.Drawing.Point(225, 242);
            this.combActivo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.combActivo.Name = "combActivo";
            this.combActivo.Size = new System.Drawing.Size(240, 32);
            this.combActivo.TabIndex = 12;
            this.combActivo.Tag = "No Validar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(19, 181);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fecha de Registro";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(130, 245);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Activo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(98, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Municipio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(134, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Clave";
            // 
            // Clave
            // 
            this.Clave.AutoSize = true;
            this.Clave.Location = new System.Drawing.Point(99, 85);
            this.Clave.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Clave.Name = "Clave";
            this.Clave.Size = new System.Drawing.Size(0, 24);
            this.Clave.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 24);
            this.label1.TabIndex = 1;
            // 
            // Cancelarcmd
            // 
            this.Cancelarcmd.AutoSize = true;
            this.Cancelarcmd.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Cancelarcmd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Cancelarcmd.Image = global::SCCI.Properties.Resources.Cancelar;
            this.Cancelarcmd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Cancelarcmd.Location = new System.Drawing.Point(266, 330);
            this.Cancelarcmd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Cancelarcmd.Name = "Cancelarcmd";
            this.Cancelarcmd.Size = new System.Drawing.Size(168, 68);
            this.Cancelarcmd.TabIndex = 16;
            this.Cancelarcmd.Tag = "Cancelar";
            this.Cancelarcmd.Text = "Cancelar";
            this.Cancelarcmd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cancelarcmd.UseVisualStyleBackColor = true;
            this.Cancelarcmd.Click += new System.EventHandler(this.Cancelarcmd_Click);
            // 
            // Guardarcmd
            // 
            this.Guardarcmd.AutoSize = true;
            this.Guardarcmd.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Guardarcmd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Guardarcmd.Image = global::SCCI.Properties.Resources.Guardar;
            this.Guardarcmd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Guardarcmd.Location = new System.Drawing.Point(90, 330);
            this.Guardarcmd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Guardarcmd.Name = "Guardarcmd";
            this.Guardarcmd.Size = new System.Drawing.Size(168, 68);
            this.Guardarcmd.TabIndex = 10;
            this.Guardarcmd.Tag = "Guardar";
            this.Guardarcmd.Text = "Guardar ";
            this.Guardarcmd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Guardarcmd.UseVisualStyleBackColor = true;
            this.Guardarcmd.Click += new System.EventHandler(this.Guardarcmd_Click);
            // 
            // txtMunicipio
            // 
            this.txtMunicipio.Location = new System.Drawing.Point(225, 108);
            this.txtMunicipio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMunicipio.Name = "txtMunicipio";
            this.txtMunicipio.Size = new System.Drawing.Size(240, 30);
            this.txtMunicipio.TabIndex = 18;
            this.txtMunicipio.Tag = "Municipio";
            // 
            // MunicipiosAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(150)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(529, 413);
            this.Controls.Add(this.Cancelarcmd);
            this.Controls.Add(this.Guardarcmd);
            this.Controls.Add(this.gpbMunicipios);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MunicipiosAM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MunicipiosAM_Load);
            this.gpbMunicipios.ResumeLayout(false);
            this.gpbMunicipios.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbMunicipios;
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
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtMunicipio;
    }
}