
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
            this.gpbperiodo.Location = new System.Drawing.Point(58, 43);
            this.gpbperiodo.Name = "gpbperiodo";
            this.gpbperiodo.Size = new System.Drawing.Size(549, 262);
            this.gpbperiodo.TabIndex = 18;
            this.gpbperiodo.TabStop = false;
            this.gpbperiodo.Text = "Datos del periodo:";
            // 
            // dtfecharegistro
            // 
            this.dtfecharegistro.Location = new System.Drawing.Point(230, 89);
            this.dtfecharegistro.Name = "dtfecharegistro";
            this.dtfecharegistro.Size = new System.Drawing.Size(301, 22);
            this.dtfecharegistro.TabIndex = 10;
            // 
            // txtactivo
            // 
            this.txtactivo.Location = new System.Drawing.Point(230, 135);
            this.txtactivo.Name = "txtactivo";
            this.txtactivo.Size = new System.Drawing.Size(301, 22);
            this.txtactivo.TabIndex = 9;
            this.txtactivo.Tag = "codigo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(60, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fecha Registro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(90, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Activo";
            // 
            // txtperiodoactual
            // 
            this.txtperiodoactual.Location = new System.Drawing.Point(230, 56);
            this.txtperiodoactual.Name = "txtperiodoactual";
            this.txtperiodoactual.Size = new System.Drawing.Size(301, 22);
            this.txtperiodoactual.TabIndex = 3;
            this.txtperiodoactual.Tag = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Periodo actual";
            // 
            // txtclave
            // 
            this.txtclave.Location = new System.Drawing.Point(230, 28);
            this.txtclave.Name = "txtclave";
            this.txtclave.Size = new System.Drawing.Size(301, 22);
            this.txtclave.TabIndex = 1;
            this.txtclave.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clave";
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Image = global::SCCI.Properties.Resources.Cancelar;
            this.cmdCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCancelar.Location = new System.Drawing.Point(490, 323);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(117, 40);
            this.cmdCancelar.TabIndex = 20;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCancelar.UseVisualStyleBackColor = true;
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Image = global::SCCI.Properties.Resources.Guardar;
            this.cmdGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdGuardar.Location = new System.Drawing.Point(367, 323);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(117, 40);
            this.cmdGuardar.TabIndex = 19;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdGuardar.UseVisualStyleBackColor = true;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // PeriodosAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(690, 419);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.gpbperiodo);
            this.Name = "PeriodosAM";
            this.Text = "PeriodosAM";
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