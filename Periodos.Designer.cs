
namespace SCCI
{
    partial class Periodos
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
            this.gridperiodos = new System.Windows.Forms.DataGridView();
            this.grupoOrdenar = new System.Windows.Forms.GroupBox();
            this.rbordenarfecha_registro = new System.Windows.Forms.RadioButton();
            this.rbordenarperiodo = new System.Windows.Forms.RadioButton();
            this.grupoBuscar = new System.Windows.Forms.GroupBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.rbfecha_registro = new System.Windows.Forms.RadioButton();
            this.rbperiodo = new System.Windows.Forms.RadioButton();
            this.cmdeliminar = new System.Windows.Forms.Button();
            this.cmdagregar = new System.Windows.Forms.Button();
            this.cmdmodificar = new System.Windows.Forms.Button();
            this.cmdsalir = new System.Windows.Forms.Button();
            this.cmdexportar = new System.Windows.Forms.Button();
            this.cmdimprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridperiodos)).BeginInit();
            this.grupoOrdenar.SuspendLayout();
            this.grupoBuscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridperiodos
            // 
            this.gridperiodos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridperiodos.Location = new System.Drawing.Point(57, 198);
            this.gridperiodos.Margin = new System.Windows.Forms.Padding(4);
            this.gridperiodos.Name = "gridperiodos";
            this.gridperiodos.RowHeadersWidth = 51;
            this.gridperiodos.Size = new System.Drawing.Size(800, 249);
            this.gridperiodos.TabIndex = 71;
            // 
            // grupoOrdenar
            // 
            this.grupoOrdenar.Controls.Add(this.rbordenarfecha_registro);
            this.grupoOrdenar.Controls.Add(this.rbordenarperiodo);
            this.grupoOrdenar.Location = new System.Drawing.Point(606, 30);
            this.grupoOrdenar.Margin = new System.Windows.Forms.Padding(4);
            this.grupoOrdenar.Name = "grupoOrdenar";
            this.grupoOrdenar.Padding = new System.Windows.Forms.Padding(4);
            this.grupoOrdenar.Size = new System.Drawing.Size(252, 150);
            this.grupoOrdenar.TabIndex = 70;
            this.grupoOrdenar.TabStop = false;
            this.grupoOrdenar.Text = "Ordenar:";
            // 
            // rbordenarfecha_registro
            // 
            this.rbordenarfecha_registro.AutoSize = true;
            this.rbordenarfecha_registro.Location = new System.Drawing.Point(7, 52);
            this.rbordenarfecha_registro.Margin = new System.Windows.Forms.Padding(4);
            this.rbordenarfecha_registro.Name = "rbordenarfecha_registro";
            this.rbordenarfecha_registro.Size = new System.Drawing.Size(125, 21);
            this.rbordenarfecha_registro.TabIndex = 4;
            this.rbordenarfecha_registro.Text = "Fecha Registro";
            this.rbordenarfecha_registro.UseVisualStyleBackColor = true;
            // 
            // rbordenarperiodo
            // 
            this.rbordenarperiodo.AutoSize = true;
            this.rbordenarperiodo.Checked = true;
            this.rbordenarperiodo.Location = new System.Drawing.Point(8, 23);
            this.rbordenarperiodo.Margin = new System.Windows.Forms.Padding(4);
            this.rbordenarperiodo.Name = "rbordenarperiodo";
            this.rbordenarperiodo.Size = new System.Drawing.Size(78, 21);
            this.rbordenarperiodo.TabIndex = 3;
            this.rbordenarperiodo.TabStop = true;
            this.rbordenarperiodo.Text = "Periodo";
            this.rbordenarperiodo.UseVisualStyleBackColor = true;
            // 
            // grupoBuscar
            // 
            this.grupoBuscar.Controls.Add(this.txtBuscar);
            this.grupoBuscar.Controls.Add(this.rbfecha_registro);
            this.grupoBuscar.Controls.Add(this.rbperiodo);
            this.grupoBuscar.Location = new System.Drawing.Point(57, 29);
            this.grupoBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.grupoBuscar.Name = "grupoBuscar";
            this.grupoBuscar.Padding = new System.Windows.Forms.Padding(4);
            this.grupoBuscar.Size = new System.Drawing.Size(541, 150);
            this.grupoBuscar.TabIndex = 69;
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
            // rbfecha_registro
            // 
            this.rbfecha_registro.AutoSize = true;
            this.rbfecha_registro.Location = new System.Drawing.Point(8, 53);
            this.rbfecha_registro.Margin = new System.Windows.Forms.Padding(4);
            this.rbfecha_registro.Name = "rbfecha_registro";
            this.rbfecha_registro.Size = new System.Drawing.Size(125, 21);
            this.rbfecha_registro.TabIndex = 1;
            this.rbfecha_registro.Text = "Fecha Registro";
            this.rbfecha_registro.UseVisualStyleBackColor = true;
            // 
            // rbperiodo
            // 
            this.rbperiodo.AutoSize = true;
            this.rbperiodo.Checked = true;
            this.rbperiodo.Location = new System.Drawing.Point(9, 25);
            this.rbperiodo.Margin = new System.Windows.Forms.Padding(4);
            this.rbperiodo.Name = "rbperiodo";
            this.rbperiodo.Size = new System.Drawing.Size(78, 21);
            this.rbperiodo.TabIndex = 0;
            this.rbperiodo.TabStop = true;
            this.rbperiodo.Text = "Periodo";
            this.rbperiodo.UseVisualStyleBackColor = true;
            // 
            // cmdeliminar
            // 
            this.cmdeliminar.Image = global::SCCI.Properties.Resources.Eliminar;
            this.cmdeliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdeliminar.Location = new System.Drawing.Point(323, 455);
            this.cmdeliminar.Margin = new System.Windows.Forms.Padding(4);
            this.cmdeliminar.Name = "cmdeliminar";
            this.cmdeliminar.Size = new System.Drawing.Size(125, 55);
            this.cmdeliminar.TabIndex = 77;
            this.cmdeliminar.Text = "Eliminar";
            this.cmdeliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdeliminar.UseVisualStyleBackColor = true;
            // 
            // cmdagregar
            // 
            this.cmdagregar.Image = global::SCCI.Properties.Resources.Agregar2;
            this.cmdagregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdagregar.Location = new System.Drawing.Point(57, 455);
            this.cmdagregar.Margin = new System.Windows.Forms.Padding(4);
            this.cmdagregar.Name = "cmdagregar";
            this.cmdagregar.Size = new System.Drawing.Size(125, 55);
            this.cmdagregar.TabIndex = 76;
            this.cmdagregar.Text = "Agregar";
            this.cmdagregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdagregar.UseVisualStyleBackColor = true;
            this.cmdagregar.Click += new System.EventHandler(this.cmdagregar_Click);
            // 
            // cmdmodificar
            // 
            this.cmdmodificar.Image = global::SCCI.Properties.Resources.Modificar;
            this.cmdmodificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdmodificar.Location = new System.Drawing.Point(190, 455);
            this.cmdmodificar.Margin = new System.Windows.Forms.Padding(4);
            this.cmdmodificar.Name = "cmdmodificar";
            this.cmdmodificar.Size = new System.Drawing.Size(125, 55);
            this.cmdmodificar.TabIndex = 75;
            this.cmdmodificar.Text = "Modificar";
            this.cmdmodificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdmodificar.UseVisualStyleBackColor = true;
            // 
            // cmdsalir
            // 
            this.cmdsalir.Image = global::SCCI.Properties.Resources.Salir32;
            this.cmdsalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdsalir.Location = new System.Drawing.Point(732, 455);
            this.cmdsalir.Margin = new System.Windows.Forms.Padding(4);
            this.cmdsalir.Name = "cmdsalir";
            this.cmdsalir.Size = new System.Drawing.Size(125, 55);
            this.cmdsalir.TabIndex = 74;
            this.cmdsalir.Text = "Salir";
            this.cmdsalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdsalir.UseVisualStyleBackColor = true;
            // 
            // cmdexportar
            // 
            this.cmdexportar.Image = global::SCCI.Properties.Resources.Exportar_Excel;
            this.cmdexportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdexportar.Location = new System.Drawing.Point(456, 455);
            this.cmdexportar.Margin = new System.Windows.Forms.Padding(4);
            this.cmdexportar.Name = "cmdexportar";
            this.cmdexportar.Size = new System.Drawing.Size(125, 55);
            this.cmdexportar.TabIndex = 73;
            this.cmdexportar.Text = "Exportar";
            this.cmdexportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdexportar.UseVisualStyleBackColor = true;
            // 
            // cmdimprimir
            // 
            this.cmdimprimir.Image = global::SCCI.Properties.Resources.Imprimir;
            this.cmdimprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdimprimir.Location = new System.Drawing.Point(589, 455);
            this.cmdimprimir.Margin = new System.Windows.Forms.Padding(4);
            this.cmdimprimir.Name = "cmdimprimir";
            this.cmdimprimir.Size = new System.Drawing.Size(125, 55);
            this.cmdimprimir.TabIndex = 72;
            this.cmdimprimir.Text = "Imprimir";
            this.cmdimprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdimprimir.UseVisualStyleBackColor = true;
            // 
            // Periodos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(915, 538);
            this.Controls.Add(this.cmdeliminar);
            this.Controls.Add(this.cmdagregar);
            this.Controls.Add(this.cmdmodificar);
            this.Controls.Add(this.cmdsalir);
            this.Controls.Add(this.cmdexportar);
            this.Controls.Add(this.cmdimprimir);
            this.Controls.Add(this.gridperiodos);
            this.Controls.Add(this.grupoOrdenar);
            this.Controls.Add(this.grupoBuscar);
            this.Name = "Periodos";
            this.Text = "Periodos";
            ((System.ComponentModel.ISupportInitialize)(this.gridperiodos)).EndInit();
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
        private System.Windows.Forms.DataGridView gridperiodos;
        private System.Windows.Forms.GroupBox grupoOrdenar;
        private System.Windows.Forms.RadioButton rbordenarfecha_registro;
        private System.Windows.Forms.RadioButton rbordenarperiodo;
        private System.Windows.Forms.GroupBox grupoBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.RadioButton rbfecha_registro;
        private System.Windows.Forms.RadioButton rbperiodo;
    }
}