
namespace SCCI
{
    partial class PeriodosAM
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
            this.gpbperiodo = new System.Windows.Forms.GroupBox();
            this.dtfecharegistro = new System.Windows.Forms.DateTimePicker();
            this.txtactivo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtperiodoactual = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.gpbperiodo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbperiodo
            // 
            this.gpbperiodo.Controls.Add(this.dtfecharegistro);
            this.gpbperiodo.Controls.Add(this.txtactivo);
            this.gpbperiodo.Controls.Add(this.label5);
            this.gpbperiodo.Controls.Add(this.label4);
            this.gpbperiodo.Controls.Add(this.txtperiodoactual);
            this.gpbperiodo.Controls.Add(this.label2);
            this.gpbperiodo.Controls.Add(this.txtclave);
            this.gpbperiodo.Controls.Add(this.label1);
            this.gpbperiodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.gpbperiodo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gpbperiodo.Location = new System.Drawing.Point(12, 13);
            this.gpbperiodo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbperiodo.Name = "gpbperiodo";
            this.gpbperiodo.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbperiodo.Size = new System.Drawing.Size(618, 222);
            this.gpbperiodo.TabIndex = 18;
            this.gpbperiodo.TabStop = false;
            this.gpbperiodo.Text = "Datos del Periodo";
            // 
            // dtfecharegistro
            // 
            this.dtfecharegistro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfecharegistro.Location = new System.Drawing.Point(246, 122);
            this.dtfecharegistro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtfecharegistro.Name = "dtfecharegistro";
            this.dtfecharegistro.Size = new System.Drawing.Size(210, 30);
            this.dtfecharegistro.TabIndex = 10;
            // 
            // txtactivo
            // 
            this.txtactivo.Location = new System.Drawing.Point(246, 163);
            this.txtactivo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtactivo.Name = "txtactivo";
            this.txtactivo.Size = new System.Drawing.Size(338, 30);
            this.txtactivo.TabIndex = 9;
            this.txtactivo.Tag = "codigo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fecha Registro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(145, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Activo";
            // 
            // txtperiodoactual
            // 
            this.txtperiodoactual.Location = new System.Drawing.Point(246, 84);
            this.txtperiodoactual.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtperiodoactual.Name = "txtperiodoactual";
            this.txtperiodoactual.Size = new System.Drawing.Size(338, 30);
            this.txtperiodoactual.TabIndex = 3;
            this.txtperiodoactual.Tag = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Periodo actual";
            // 
            // txtclave
            // 
            this.txtclave.Location = new System.Drawing.Point(246, 42);
            this.txtclave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtclave.Name = "txtclave";
            this.txtclave.Size = new System.Drawing.Size(338, 30);
            this.txtclave.TabIndex = 1;
            this.txtclave.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clave";
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.cmdCancelar.Image = global::SCCI.Properties.Resources.Cancelar;
            this.cmdCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCancelar.Location = new System.Drawing.Point(462, 243);
            this.cmdCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(168, 68);
            this.cmdCancelar.TabIndex = 20;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCancelar.UseVisualStyleBackColor = true;
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.cmdGuardar.Image = global::SCCI.Properties.Resources.Guardar;
            this.cmdGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdGuardar.Location = new System.Drawing.Point(288, 243);
            this.cmdGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(168, 68);
            this.cmdGuardar.TabIndex = 19;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdGuardar.UseVisualStyleBackColor = true;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // PeriodosAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(150)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(642, 325);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.gpbperiodo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PeriodosAM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.gpbperiodo.ResumeLayout(false);
            this.gpbperiodo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.GroupBox gpbperiodo;
        private System.Windows.Forms.TextBox txtactivo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtperiodoactual;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtclave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtfecharegistro;
    }
}