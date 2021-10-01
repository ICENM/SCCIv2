
namespace SCCI
{
    partial class Carreras
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdeliminar = new System.Windows.Forms.Button();
            this.cmdagregar = new System.Windows.Forms.Button();
            this.cmdmodificar = new System.Windows.Forms.Button();
            this.cmdsalir = new System.Windows.Forms.Button();
            this.cmdexportar = new System.Windows.Forms.Button();
            this.cmdimprimir = new System.Windows.Forms.Button();
            this.gridcarrera = new System.Windows.Forms.DataGridView();
            this.grupoOrdenar = new System.Windows.Forms.GroupBox();
            this.rbordenarcarrera = new System.Windows.Forms.RadioButton();
            this.rbordenarcodigo = new System.Windows.Forms.RadioButton();
            this.grupoBuscar = new System.Windows.Forms.GroupBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.rbcarrera = new System.Windows.Forms.RadioButton();
            this.rbcodigo = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridcarrera)).BeginInit();
            this.grupoOrdenar.SuspendLayout();
            this.grupoBuscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdeliminar
            // 
            this.cmdeliminar.Image = global::SCCI.Properties.Resources.Eliminar;
            this.cmdeliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdeliminar.Location = new System.Drawing.Point(305, 439);
            this.cmdeliminar.Margin = new System.Windows.Forms.Padding(4);
            this.cmdeliminar.Name = "cmdeliminar";
            this.cmdeliminar.Size = new System.Drawing.Size(125, 55);
            this.cmdeliminar.TabIndex = 59;
            this.cmdeliminar.Text = "Eliminar";
            this.cmdeliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdeliminar.UseVisualStyleBackColor = true;
            // 
            // cmdagregar
            // 
            this.cmdagregar.Image = global::SCCI.Properties.Resources.Agregar2;
            this.cmdagregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdagregar.Location = new System.Drawing.Point(39, 439);
            this.cmdagregar.Margin = new System.Windows.Forms.Padding(4);
            this.cmdagregar.Name = "cmdagregar";
            this.cmdagregar.Size = new System.Drawing.Size(125, 55);
            this.cmdagregar.TabIndex = 58;
            this.cmdagregar.Text = "Agregar";
            this.cmdagregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdagregar.UseVisualStyleBackColor = true;
            this.cmdagregar.Click += new System.EventHandler(this.cmdagregar_Click);
            // 
            // cmdmodificar
            // 
            this.cmdmodificar.Image = global::SCCI.Properties.Resources.Modificar;
            this.cmdmodificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdmodificar.Location = new System.Drawing.Point(172, 439);
            this.cmdmodificar.Margin = new System.Windows.Forms.Padding(4);
            this.cmdmodificar.Name = "cmdmodificar";
            this.cmdmodificar.Size = new System.Drawing.Size(125, 55);
            this.cmdmodificar.TabIndex = 57;
            this.cmdmodificar.Text = "Modificar";
            this.cmdmodificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdmodificar.UseVisualStyleBackColor = true;
            // 
            // cmdsalir
            // 
            this.cmdsalir.Image = global::SCCI.Properties.Resources.Salir32;
            this.cmdsalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdsalir.Location = new System.Drawing.Point(714, 439);
            this.cmdsalir.Margin = new System.Windows.Forms.Padding(4);
            this.cmdsalir.Name = "cmdsalir";
            this.cmdsalir.Size = new System.Drawing.Size(125, 55);
            this.cmdsalir.TabIndex = 56;
            this.cmdsalir.Text = "Salir";
            this.cmdsalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdsalir.UseVisualStyleBackColor = true;
            // 
            // cmdexportar
            // 
            this.cmdexportar.Image = global::SCCI.Properties.Resources.Exportar_Excel;
            this.cmdexportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdexportar.Location = new System.Drawing.Point(438, 439);
            this.cmdexportar.Margin = new System.Windows.Forms.Padding(4);
            this.cmdexportar.Name = "cmdexportar";
            this.cmdexportar.Size = new System.Drawing.Size(125, 55);
            this.cmdexportar.TabIndex = 55;
            this.cmdexportar.Text = "Exportar";
            this.cmdexportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdexportar.UseVisualStyleBackColor = true;
            // 
            // cmdimprimir
            // 
            this.cmdimprimir.Image = global::SCCI.Properties.Resources.Imprimir;
            this.cmdimprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdimprimir.Location = new System.Drawing.Point(571, 439);
            this.cmdimprimir.Margin = new System.Windows.Forms.Padding(4);
            this.cmdimprimir.Name = "cmdimprimir";
            this.cmdimprimir.Size = new System.Drawing.Size(125, 55);
            this.cmdimprimir.TabIndex = 54;
            this.cmdimprimir.Text = "Imprimir";
            this.cmdimprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdimprimir.UseVisualStyleBackColor = true;
            // 
            // gridcarrera
            // 
            this.gridcarrera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridcarrera.Location = new System.Drawing.Point(39, 182);
            this.gridcarrera.Margin = new System.Windows.Forms.Padding(4);
            this.gridcarrera.Name = "gridcarrera";
            this.gridcarrera.RowHeadersWidth = 51;
            this.gridcarrera.Size = new System.Drawing.Size(800, 249);
            this.gridcarrera.TabIndex = 53;
            // 
            // grupoOrdenar
            // 
            this.grupoOrdenar.Controls.Add(this.rbordenarcarrera);
            this.grupoOrdenar.Controls.Add(this.rbordenarcodigo);
            this.grupoOrdenar.Location = new System.Drawing.Point(588, 14);
            this.grupoOrdenar.Margin = new System.Windows.Forms.Padding(4);
            this.grupoOrdenar.Name = "grupoOrdenar";
            this.grupoOrdenar.Padding = new System.Windows.Forms.Padding(4);
            this.grupoOrdenar.Size = new System.Drawing.Size(252, 150);
            this.grupoOrdenar.TabIndex = 52;
            this.grupoOrdenar.TabStop = false;
            this.grupoOrdenar.Text = "Ordenar:";
            // 
            // rbordenarcarrera
            // 
            this.rbordenarcarrera.AutoSize = true;
            this.rbordenarcarrera.Location = new System.Drawing.Point(7, 52);
            this.rbordenarcarrera.Margin = new System.Windows.Forms.Padding(4);
            this.rbordenarcarrera.Name = "rbordenarcarrera";
            this.rbordenarcarrera.Size = new System.Drawing.Size(77, 21);
            this.rbordenarcarrera.TabIndex = 4;
            this.rbordenarcarrera.Text = "Carrera";
            this.rbordenarcarrera.UseVisualStyleBackColor = true;
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
            this.grupoBuscar.Controls.Add(this.rbcarrera);
            this.grupoBuscar.Controls.Add(this.rbcodigo);
            this.grupoBuscar.Location = new System.Drawing.Point(39, 13);
            this.grupoBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.grupoBuscar.Name = "grupoBuscar";
            this.grupoBuscar.Padding = new System.Windows.Forms.Padding(4);
            this.grupoBuscar.Size = new System.Drawing.Size(541, 150);
            this.grupoBuscar.TabIndex = 51;
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
            // rbcarrera
            // 
            this.rbcarrera.AutoSize = true;
            this.rbcarrera.Location = new System.Drawing.Point(8, 53);
            this.rbcarrera.Margin = new System.Windows.Forms.Padding(4);
            this.rbcarrera.Name = "rbcarrera";
            this.rbcarrera.Size = new System.Drawing.Size(77, 21);
            this.rbcarrera.TabIndex = 1;
            this.rbcarrera.Text = "Carrera";
            this.rbcarrera.UseVisualStyleBackColor = true;
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
            // Carreras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(927, 519);
            this.Controls.Add(this.cmdeliminar);
            this.Controls.Add(this.cmdagregar);
            this.Controls.Add(this.cmdmodificar);
            this.Controls.Add(this.cmdsalir);
            this.Controls.Add(this.cmdexportar);
            this.Controls.Add(this.cmdimprimir);
            this.Controls.Add(this.gridcarrera);
            this.Controls.Add(this.grupoOrdenar);
            this.Controls.Add(this.grupoBuscar);
            this.Name = "Carreras";
            this.Text = "Carreras";
            ((System.ComponentModel.ISupportInitialize)(this.gridcarrera)).EndInit();
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
        private System.Windows.Forms.DataGridView gridcarrera;
        private System.Windows.Forms.GroupBox grupoOrdenar;
        private System.Windows.Forms.RadioButton rbordenarcarrera;
        private System.Windows.Forms.RadioButton rbordenarcodigo;
        private System.Windows.Forms.GroupBox grupoBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.RadioButton rbcarrera;
        private System.Windows.Forms.RadioButton rbcodigo;
    }
}

