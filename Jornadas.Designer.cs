﻿
namespace SCCI
{
    partial class Jornadas
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
            this.gridjornada = new System.Windows.Forms.DataGridView();
            this.grupoOrdenar = new System.Windows.Forms.GroupBox();
            this.rbordenarjornada = new System.Windows.Forms.RadioButton();
            this.rbordenarcodigo = new System.Windows.Forms.RadioButton();
            this.grupoBuscar = new System.Windows.Forms.GroupBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.rbjornada = new System.Windows.Forms.RadioButton();
            this.rbcodigo = new System.Windows.Forms.RadioButton();
            this.cmdeliminar = new System.Windows.Forms.Button();
            this.cmdagregar = new System.Windows.Forms.Button();
            this.cmdmodificar = new System.Windows.Forms.Button();
            this.cmdsalir = new System.Windows.Forms.Button();
            this.cmdexportar = new System.Windows.Forms.Button();
            this.cmdimprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridjornada)).BeginInit();
            this.grupoOrdenar.SuspendLayout();
            this.grupoBuscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridjornada
            // 
            this.gridjornada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridjornada.Location = new System.Drawing.Point(44, 186);
            this.gridjornada.Margin = new System.Windows.Forms.Padding(4);
            this.gridjornada.Name = "gridjornada";
            this.gridjornada.RowHeadersWidth = 51;
            this.gridjornada.Size = new System.Drawing.Size(800, 249);
            this.gridjornada.TabIndex = 62;
            // 
            // grupoOrdenar
            // 
            this.grupoOrdenar.Controls.Add(this.rbordenarjornada);
            this.grupoOrdenar.Controls.Add(this.rbordenarcodigo);
            this.grupoOrdenar.Location = new System.Drawing.Point(593, 18);
            this.grupoOrdenar.Margin = new System.Windows.Forms.Padding(4);
            this.grupoOrdenar.Name = "grupoOrdenar";
            this.grupoOrdenar.Padding = new System.Windows.Forms.Padding(4);
            this.grupoOrdenar.Size = new System.Drawing.Size(252, 150);
            this.grupoOrdenar.TabIndex = 61;
            this.grupoOrdenar.TabStop = false;
            this.grupoOrdenar.Text = "Ordenar:";
            // 
            // rbordenarjornada
            // 
            this.rbordenarjornada.AutoSize = true;
            this.rbordenarjornada.Location = new System.Drawing.Point(7, 52);
            this.rbordenarjornada.Margin = new System.Windows.Forms.Padding(4);
            this.rbordenarjornada.Name = "rbordenarjornada";
            this.rbordenarjornada.Size = new System.Drawing.Size(81, 21);
            this.rbordenarjornada.TabIndex = 4;
            this.rbordenarjornada.Text = "Jornada";
            this.rbordenarjornada.UseVisualStyleBackColor = true;
            // 
            // rbordenarcodigo
            // 
            this.rbordenarcodigo.AutoSize = true;
            this.rbordenarcodigo.Checked = true;
            this.rbordenarcodigo.Location = new System.Drawing.Point(8, 23);
            this.rbordenarcodigo.Margin = new System.Windows.Forms.Padding(4);
            this.rbordenarcodigo.Name = "rbordenarcodigo";
            this.rbordenarcodigo.Size = new System.Drawing.Size(73, 21);
            this.rbordenarcodigo.TabIndex = 3;
            this.rbordenarcodigo.TabStop = true;
            this.rbordenarcodigo.Text = "Codigo";
            this.rbordenarcodigo.UseVisualStyleBackColor = true;
            // 
            // grupoBuscar
            // 
            this.grupoBuscar.Controls.Add(this.txtBuscar);
            this.grupoBuscar.Controls.Add(this.rbjornada);
            this.grupoBuscar.Controls.Add(this.rbcodigo);
            this.grupoBuscar.Location = new System.Drawing.Point(44, 17);
            this.grupoBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.grupoBuscar.Name = "grupoBuscar";
            this.grupoBuscar.Padding = new System.Windows.Forms.Padding(4);
            this.grupoBuscar.Size = new System.Drawing.Size(541, 150);
            this.grupoBuscar.TabIndex = 60;
            this.grupoBuscar.TabStop = false;
            this.grupoBuscar.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(135, 53);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(387, 22);
            this.txtBuscar.TabIndex = 3;
            // 
            // rbjornada
            // 
            this.rbjornada.AutoSize = true;
            this.rbjornada.Location = new System.Drawing.Point(8, 53);
            this.rbjornada.Margin = new System.Windows.Forms.Padding(4);
            this.rbjornada.Name = "rbjornada";
            this.rbjornada.Size = new System.Drawing.Size(81, 21);
            this.rbjornada.TabIndex = 1;
            this.rbjornada.Text = "Jornada";
            this.rbjornada.UseVisualStyleBackColor = true;
            // 
            // rbcodigo
            // 
            this.rbcodigo.AutoSize = true;
            this.rbcodigo.Checked = true;
            this.rbcodigo.Location = new System.Drawing.Point(9, 25);
            this.rbcodigo.Margin = new System.Windows.Forms.Padding(4);
            this.rbcodigo.Name = "rbcodigo";
            this.rbcodigo.Size = new System.Drawing.Size(73, 21);
            this.rbcodigo.TabIndex = 0;
            this.rbcodigo.TabStop = true;
            this.rbcodigo.Text = "Codigo";
            this.rbcodigo.UseVisualStyleBackColor = true;
            // 
            // cmdeliminar
            // 
            this.cmdeliminar.Image = global::SCCI.Properties.Resources.Eliminar;
            this.cmdeliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdeliminar.Location = new System.Drawing.Point(310, 443);
            this.cmdeliminar.Margin = new System.Windows.Forms.Padding(4);
            this.cmdeliminar.Name = "cmdeliminar";
            this.cmdeliminar.Size = new System.Drawing.Size(125, 55);
            this.cmdeliminar.TabIndex = 68;
            this.cmdeliminar.Text = "Eliminar";
            this.cmdeliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdeliminar.UseVisualStyleBackColor = true;
            // 
            // cmdagregar
            // 
            this.cmdagregar.Image = global::SCCI.Properties.Resources.Agregar2;
            this.cmdagregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdagregar.Location = new System.Drawing.Point(44, 443);
            this.cmdagregar.Margin = new System.Windows.Forms.Padding(4);
            this.cmdagregar.Name = "cmdagregar";
            this.cmdagregar.Size = new System.Drawing.Size(125, 55);
            this.cmdagregar.TabIndex = 67;
            this.cmdagregar.Text = "Agregar";
            this.cmdagregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdagregar.UseVisualStyleBackColor = true;
            this.cmdagregar.Click += new System.EventHandler(this.cmdagregar_Click);
            // 
            // cmdmodificar
            // 
            this.cmdmodificar.Image = global::SCCI.Properties.Resources.Modificar;
            this.cmdmodificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdmodificar.Location = new System.Drawing.Point(177, 443);
            this.cmdmodificar.Margin = new System.Windows.Forms.Padding(4);
            this.cmdmodificar.Name = "cmdmodificar";
            this.cmdmodificar.Size = new System.Drawing.Size(125, 55);
            this.cmdmodificar.TabIndex = 66;
            this.cmdmodificar.Text = "Modificar";
            this.cmdmodificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdmodificar.UseVisualStyleBackColor = true;
            // 
            // cmdsalir
            // 
            this.cmdsalir.Image = global::SCCI.Properties.Resources.Salir32;
            this.cmdsalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdsalir.Location = new System.Drawing.Point(719, 443);
            this.cmdsalir.Margin = new System.Windows.Forms.Padding(4);
            this.cmdsalir.Name = "cmdsalir";
            this.cmdsalir.Size = new System.Drawing.Size(125, 55);
            this.cmdsalir.TabIndex = 65;
            this.cmdsalir.Text = "Salir";
            this.cmdsalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdsalir.UseVisualStyleBackColor = true;
            // 
            // cmdexportar
            // 
            this.cmdexportar.Image = global::SCCI.Properties.Resources.Exportar_Excel;
            this.cmdexportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdexportar.Location = new System.Drawing.Point(443, 443);
            this.cmdexportar.Margin = new System.Windows.Forms.Padding(4);
            this.cmdexportar.Name = "cmdexportar";
            this.cmdexportar.Size = new System.Drawing.Size(125, 55);
            this.cmdexportar.TabIndex = 64;
            this.cmdexportar.Text = "Exportar";
            this.cmdexportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdexportar.UseVisualStyleBackColor = true;
            // 
            // cmdimprimir
            // 
            this.cmdimprimir.Image = global::SCCI.Properties.Resources.Imprimir;
            this.cmdimprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdimprimir.Location = new System.Drawing.Point(576, 443);
            this.cmdimprimir.Margin = new System.Windows.Forms.Padding(4);
            this.cmdimprimir.Name = "cmdimprimir";
            this.cmdimprimir.Size = new System.Drawing.Size(125, 55);
            this.cmdimprimir.TabIndex = 63;
            this.cmdimprimir.Text = "Imprimir";
            this.cmdimprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdimprimir.UseVisualStyleBackColor = true;
            // 
            // Jornadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(888, 514);
            this.Controls.Add(this.cmdeliminar);
            this.Controls.Add(this.cmdagregar);
            this.Controls.Add(this.cmdmodificar);
            this.Controls.Add(this.cmdsalir);
            this.Controls.Add(this.cmdexportar);
            this.Controls.Add(this.cmdimprimir);
            this.Controls.Add(this.gridjornada);
            this.Controls.Add(this.grupoOrdenar);
            this.Controls.Add(this.grupoBuscar);
            this.Name = "Jornadas";
            this.Text = "Jornadas";
            ((System.ComponentModel.ISupportInitialize)(this.gridjornada)).EndInit();
            this.grupoOrdenar.ResumeLayout(false);
            this.grupoOrdenar.PerformLayout();
            this.grupoBuscar.ResumeLayout(false);
            this.grupoBuscar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdeliminar;
        private System.Windows.Forms.Button cmdagregar;
        private System.Windows.Forms.Button cmdmodificar;
        private System.Windows.Forms.Button cmdsalir;
        private System.Windows.Forms.Button cmdexportar;
        private System.Windows.Forms.Button cmdimprimir;
        private System.Windows.Forms.DataGridView gridjornada;
        private System.Windows.Forms.GroupBox grupoOrdenar;
        private System.Windows.Forms.RadioButton rbordenarjornada;
        private System.Windows.Forms.RadioButton rbordenarcodigo;
        private System.Windows.Forms.GroupBox grupoBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.RadioButton rbjornada;
        private System.Windows.Forms.RadioButton rbcodigo;
    }
}