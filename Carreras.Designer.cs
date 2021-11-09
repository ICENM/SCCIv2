
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
            this.cmdeliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.cmdeliminar.Image = global::SCCI.Properties.Resources.Eliminar;
            this.cmdeliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdeliminar.Location = new System.Drawing.Point(366, 504);
            this.cmdeliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdeliminar.Name = "cmdeliminar";
            this.cmdeliminar.Size = new System.Drawing.Size(168, 68);
            this.cmdeliminar.TabIndex = 59;
            this.cmdeliminar.Text = "Eliminar";
            this.cmdeliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdeliminar.UseVisualStyleBackColor = true;
            // 
            // cmdagregar
            // 
            this.cmdagregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.cmdagregar.Image = global::SCCI.Properties.Resources.Agregar2;
            this.cmdagregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdagregar.Location = new System.Drawing.Point(14, 504);
            this.cmdagregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdagregar.Name = "cmdagregar";
            this.cmdagregar.Size = new System.Drawing.Size(168, 68);
            this.cmdagregar.TabIndex = 58;
            this.cmdagregar.Text = "Agregar";
            this.cmdagregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdagregar.UseVisualStyleBackColor = true;
            this.cmdagregar.Click += new System.EventHandler(this.cmdagregar_Click);
            // 
            // cmdmodificar
            // 
            this.cmdmodificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.cmdmodificar.Image = global::SCCI.Properties.Resources.Modificar;
            this.cmdmodificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdmodificar.Location = new System.Drawing.Point(190, 504);
            this.cmdmodificar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdmodificar.Name = "cmdmodificar";
            this.cmdmodificar.Size = new System.Drawing.Size(168, 68);
            this.cmdmodificar.TabIndex = 57;
            this.cmdmodificar.Text = "Modificar";
            this.cmdmodificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdmodificar.UseVisualStyleBackColor = true;
            // 
            // cmdsalir
            // 
            this.cmdsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.cmdsalir.Image = global::SCCI.Properties.Resources.Salir32;
            this.cmdsalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdsalir.Location = new System.Drawing.Point(894, 504);
            this.cmdsalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdsalir.Name = "cmdsalir";
            this.cmdsalir.Size = new System.Drawing.Size(168, 68);
            this.cmdsalir.TabIndex = 56;
            this.cmdsalir.Text = "Salir";
            this.cmdsalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdsalir.UseVisualStyleBackColor = true;
            // 
            // cmdexportar
            // 
            this.cmdexportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.cmdexportar.Image = global::SCCI.Properties.Resources.Exportar_Excel;
            this.cmdexportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdexportar.Location = new System.Drawing.Point(542, 504);
            this.cmdexportar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdexportar.Name = "cmdexportar";
            this.cmdexportar.Size = new System.Drawing.Size(168, 68);
            this.cmdexportar.TabIndex = 55;
            this.cmdexportar.Text = "Exportar";
            this.cmdexportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdexportar.UseVisualStyleBackColor = true;
            // 
            // cmdimprimir
            // 
            this.cmdimprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.cmdimprimir.Image = global::SCCI.Properties.Resources.Imprimir;
            this.cmdimprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdimprimir.Location = new System.Drawing.Point(718, 504);
            this.cmdimprimir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdimprimir.Name = "cmdimprimir";
            this.cmdimprimir.Size = new System.Drawing.Size(168, 68);
            this.cmdimprimir.TabIndex = 54;
            this.cmdimprimir.Text = "Imprimir";
            this.cmdimprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdimprimir.UseVisualStyleBackColor = true;
            // 
            // gridcarrera
            // 
            this.gridcarrera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridcarrera.Location = new System.Drawing.Point(14, 148);
            this.gridcarrera.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gridcarrera.Name = "gridcarrera";
            this.gridcarrera.RowHeadersWidth = 51;
            this.gridcarrera.Size = new System.Drawing.Size(1048, 346);
            this.gridcarrera.TabIndex = 53;
            // 
            // grupoOrdenar
            // 
            this.grupoOrdenar.Controls.Add(this.rbordenarcarrera);
            this.grupoOrdenar.Controls.Add(this.rbordenarcodigo);
            this.grupoOrdenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.grupoOrdenar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grupoOrdenar.Location = new System.Drawing.Point(894, 14);
            this.grupoOrdenar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grupoOrdenar.Name = "grupoOrdenar";
            this.grupoOrdenar.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grupoOrdenar.Size = new System.Drawing.Size(168, 122);
            this.grupoOrdenar.TabIndex = 52;
            this.grupoOrdenar.TabStop = false;
            this.grupoOrdenar.Text = "Ordenar:";
            // 
            // rbordenarcarrera
            // 
            this.rbordenarcarrera.AutoSize = true;
            this.rbordenarcarrera.Location = new System.Drawing.Point(7, 67);
            this.rbordenarcarrera.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbordenarcarrera.Name = "rbordenarcarrera";
            this.rbordenarcarrera.Size = new System.Drawing.Size(110, 29);
            this.rbordenarcarrera.TabIndex = 4;
            this.rbordenarcarrera.Text = "Carrera";
            this.rbordenarcarrera.UseVisualStyleBackColor = true;
            // 
            // rbordenarcodigo
            // 
            this.rbordenarcodigo.AutoSize = true;
            this.rbordenarcodigo.Checked = true;
            this.rbordenarcodigo.Location = new System.Drawing.Point(8, 31);
            this.rbordenarcodigo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbordenarcodigo.Name = "rbordenarcodigo";
            this.rbordenarcodigo.Size = new System.Drawing.Size(106, 29);
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
            this.grupoBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.grupoBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grupoBuscar.Location = new System.Drawing.Point(14, 14);
            this.grupoBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grupoBuscar.Name = "grupoBuscar";
            this.grupoBuscar.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grupoBuscar.Size = new System.Drawing.Size(872, 124);
            this.grupoBuscar.TabIndex = 51;
            this.grupoBuscar.TabStop = false;
            this.grupoBuscar.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(166, 52);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(657, 30);
            this.txtBuscar.TabIndex = 3;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // rbcarrera
            // 
            this.rbcarrera.AutoSize = true;
            this.rbcarrera.Location = new System.Drawing.Point(7, 68);
            this.rbcarrera.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbcarrera.Name = "rbcarrera";
            this.rbcarrera.Size = new System.Drawing.Size(110, 29);
            this.rbcarrera.TabIndex = 1;
            this.rbcarrera.Text = "Carrera";
            this.rbcarrera.UseVisualStyleBackColor = true;
            // 
            // rbcodigo
            // 
            this.rbcodigo.AutoSize = true;
            this.rbcodigo.Checked = true;
            this.rbcodigo.Location = new System.Drawing.Point(8, 33);
            this.rbcodigo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbcodigo.Name = "rbcodigo";
            this.rbcodigo.Size = new System.Drawing.Size(106, 29);
            this.rbcodigo.TabIndex = 0;
            this.rbcodigo.TabStop = true;
            this.rbcodigo.Text = "Codigo";
            this.rbcodigo.UseVisualStyleBackColor = true;
            // 
            // Carreras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(150)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(1077, 586);
            this.Controls.Add(this.cmdeliminar);
            this.Controls.Add(this.cmdagregar);
            this.Controls.Add(this.cmdmodificar);
            this.Controls.Add(this.cmdsalir);
            this.Controls.Add(this.cmdexportar);
            this.Controls.Add(this.cmdimprimir);
            this.Controls.Add(this.gridcarrera);
            this.Controls.Add(this.grupoOrdenar);
            this.Controls.Add(this.grupoBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Carreras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Carreras";
            this.Load += new System.EventHandler(this.Carreras_Load_1);
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

