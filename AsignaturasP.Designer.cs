namespace SCCI
{
    partial class AsignaturasP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AsignaturasP));
            this.gpbOrdenar = new System.Windows.Forms.GroupBox();
            this.rbOrdenarDocente = new System.Windows.Forms.RadioButton();
            this.rbOrdenarAsignatura = new System.Windows.Forms.RadioButton();
            this.rbOrdenarCodigo = new System.Windows.Forms.RadioButton();
            this.gpbBuscar = new System.Windows.Forms.GroupBox();
            this.rbDocente = new System.Windows.Forms.RadioButton();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.rbAsignatura = new System.Windows.Forms.RadioButton();
            this.rbCodigo = new System.Windows.Forms.RadioButton();
            this.gridAsignaturasP = new System.Windows.Forms.DataGridView();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.cmdImprimir = new System.Windows.Forms.Button();
            this.cmdModificar = new System.Windows.Forms.Button();
            this.cmdNuevo = new System.Windows.Forms.Button();
            this.cmdExportar = new System.Windows.Forms.Button();
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.gpbOrdenar.SuspendLayout();
            this.gpbBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAsignaturasP)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbOrdenar
            // 
            this.gpbOrdenar.Controls.Add(this.rbOrdenarDocente);
            this.gpbOrdenar.Controls.Add(this.rbOrdenarAsignatura);
            this.gpbOrdenar.Controls.Add(this.rbOrdenarCodigo);
            this.gpbOrdenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbOrdenar.ForeColor = System.Drawing.Color.White;
            this.gpbOrdenar.Location = new System.Drawing.Point(882, 13);
            this.gpbOrdenar.Name = "gpbOrdenar";
            this.gpbOrdenar.Size = new System.Drawing.Size(169, 156);
            this.gpbOrdenar.TabIndex = 155;
            this.gpbOrdenar.TabStop = false;
            this.gpbOrdenar.Text = "Ordenar";
            // 
            // rbOrdenarDocente
            // 
            this.rbOrdenarDocente.AutoSize = true;
            this.rbOrdenarDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOrdenarDocente.Location = new System.Drawing.Point(6, 103);
            this.rbOrdenarDocente.Name = "rbOrdenarDocente";
            this.rbOrdenarDocente.Size = new System.Drawing.Size(109, 26);
            this.rbOrdenarDocente.TabIndex = 5;
            this.rbOrdenarDocente.Text = "Docente";
            this.rbOrdenarDocente.UseVisualStyleBackColor = true;
            // 
            // rbOrdenarAsignatura
            // 
            this.rbOrdenarAsignatura.AutoSize = true;
            this.rbOrdenarAsignatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOrdenarAsignatura.Location = new System.Drawing.Point(6, 71);
            this.rbOrdenarAsignatura.Name = "rbOrdenarAsignatura";
            this.rbOrdenarAsignatura.Size = new System.Drawing.Size(131, 26);
            this.rbOrdenarAsignatura.TabIndex = 4;
            this.rbOrdenarAsignatura.Text = "Asignatura";
            this.rbOrdenarAsignatura.UseVisualStyleBackColor = true;
            // 
            // rbOrdenarCodigo
            // 
            this.rbOrdenarCodigo.AutoSize = true;
            this.rbOrdenarCodigo.Checked = true;
            this.rbOrdenarCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOrdenarCodigo.Location = new System.Drawing.Point(6, 39);
            this.rbOrdenarCodigo.Name = "rbOrdenarCodigo";
            this.rbOrdenarCodigo.Size = new System.Drawing.Size(98, 26);
            this.rbOrdenarCodigo.TabIndex = 3;
            this.rbOrdenarCodigo.TabStop = true;
            this.rbOrdenarCodigo.Text = "Codigo";
            this.rbOrdenarCodigo.UseVisualStyleBackColor = true;
            // 
            // gpbBuscar
            // 
            this.gpbBuscar.Controls.Add(this.rbDocente);
            this.gpbBuscar.Controls.Add(this.txtBuscar);
            this.gpbBuscar.Controls.Add(this.rbAsignatura);
            this.gpbBuscar.Controls.Add(this.rbCodigo);
            this.gpbBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbBuscar.ForeColor = System.Drawing.Color.White;
            this.gpbBuscar.Location = new System.Drawing.Point(14, 13);
            this.gpbBuscar.Name = "gpbBuscar";
            this.gpbBuscar.Size = new System.Drawing.Size(862, 156);
            this.gpbBuscar.TabIndex = 154;
            this.gpbBuscar.TabStop = false;
            this.gpbBuscar.Text = "Buscar";
            // 
            // rbDocente
            // 
            this.rbDocente.AutoSize = true;
            this.rbDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDocente.Location = new System.Drawing.Point(7, 103);
            this.rbDocente.Name = "rbDocente";
            this.rbDocente.Size = new System.Drawing.Size(109, 26);
            this.rbDocente.TabIndex = 5;
            this.rbDocente.Text = "Docente";
            this.rbDocente.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(161, 67);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(678, 30);
            this.txtBuscar.TabIndex = 4;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // rbAsignatura
            // 
            this.rbAsignatura.AutoSize = true;
            this.rbAsignatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAsignatura.Location = new System.Drawing.Point(7, 71);
            this.rbAsignatura.Name = "rbAsignatura";
            this.rbAsignatura.Size = new System.Drawing.Size(131, 26);
            this.rbAsignatura.TabIndex = 1;
            this.rbAsignatura.Text = "Asignatura";
            this.rbAsignatura.UseVisualStyleBackColor = true;
            // 
            // rbCodigo
            // 
            this.rbCodigo.AutoSize = true;
            this.rbCodigo.Checked = true;
            this.rbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCodigo.Location = new System.Drawing.Point(7, 39);
            this.rbCodigo.Name = "rbCodigo";
            this.rbCodigo.Size = new System.Drawing.Size(98, 26);
            this.rbCodigo.TabIndex = 0;
            this.rbCodigo.TabStop = true;
            this.rbCodigo.Text = "Codigo";
            this.rbCodigo.UseVisualStyleBackColor = true;
            // 
            // gridAsignaturasP
            // 
            this.gridAsignaturasP.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(129)))), ((int)(((byte)(136)))));
            this.gridAsignaturasP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAsignaturasP.Location = new System.Drawing.Point(12, 175);
            this.gridAsignaturasP.Name = "gridAsignaturasP";
            this.gridAsignaturasP.RowHeadersWidth = 62;
            this.gridAsignaturasP.RowTemplate.Height = 28;
            this.gridAsignaturasP.Size = new System.Drawing.Size(1037, 251);
            this.gridAsignaturasP.TabIndex = 153;
            this.gridAsignaturasP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridAsignaturasP_CellContentClick);
            // 
            // cmdSalir
            // 
            this.cmdSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(66)))), ((int)(((byte)(64)))));
            this.cmdSalir.Image = ((System.Drawing.Image)(resources.GetObject("cmdSalir.Image")));
            this.cmdSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdSalir.Location = new System.Drawing.Point(880, 433);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(168, 68);
            this.cmdSalir.TabIndex = 152;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // cmdImprimir
            // 
            this.cmdImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdImprimir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(66)))), ((int)(((byte)(64)))));
            this.cmdImprimir.Image = ((System.Drawing.Image)(resources.GetObject("cmdImprimir.Image")));
            this.cmdImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdImprimir.Location = new System.Drawing.Point(708, 433);
            this.cmdImprimir.Name = "cmdImprimir";
            this.cmdImprimir.Size = new System.Drawing.Size(168, 68);
            this.cmdImprimir.TabIndex = 151;
            this.cmdImprimir.Text = "Imprimir";
            this.cmdImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdImprimir.UseVisualStyleBackColor = true;
            this.cmdImprimir.Click += new System.EventHandler(this.cmdImprimir_Click);
            // 
            // cmdModificar
            // 
            this.cmdModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdModificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(66)))), ((int)(((byte)(64)))));
            this.cmdModificar.Image = ((System.Drawing.Image)(resources.GetObject("cmdModificar.Image")));
            this.cmdModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdModificar.Location = new System.Drawing.Point(186, 433);
            this.cmdModificar.Name = "cmdModificar";
            this.cmdModificar.Size = new System.Drawing.Size(168, 68);
            this.cmdModificar.TabIndex = 148;
            this.cmdModificar.Text = "Modificar";
            this.cmdModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdModificar.UseVisualStyleBackColor = true;
            this.cmdModificar.Click += new System.EventHandler(this.cmdModificar_Click);
            // 
            // cmdNuevo
            // 
            this.cmdNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(66)))), ((int)(((byte)(64)))));
            this.cmdNuevo.Image = ((System.Drawing.Image)(resources.GetObject("cmdNuevo.Image")));
            this.cmdNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdNuevo.Location = new System.Drawing.Point(12, 433);
            this.cmdNuevo.Name = "cmdNuevo";
            this.cmdNuevo.Size = new System.Drawing.Size(168, 68);
            this.cmdNuevo.TabIndex = 147;
            this.cmdNuevo.Text = "Nuevo";
            this.cmdNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdNuevo.UseVisualStyleBackColor = true;
            this.cmdNuevo.Click += new System.EventHandler(this.cmdNuevo_Click);
            // 
            // cmdExportar
            // 
            this.cmdExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExportar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(66)))), ((int)(((byte)(64)))));
            this.cmdExportar.Image = ((System.Drawing.Image)(resources.GetObject("cmdExportar.Image")));
            this.cmdExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdExportar.Location = new System.Drawing.Point(534, 433);
            this.cmdExportar.Name = "cmdExportar";
            this.cmdExportar.Size = new System.Drawing.Size(168, 68);
            this.cmdExportar.TabIndex = 150;
            this.cmdExportar.Text = "Exportar";
            this.cmdExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdExportar.UseVisualStyleBackColor = true;
            this.cmdExportar.Click += new System.EventHandler(this.cmdExportar_Click);
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(66)))), ((int)(((byte)(64)))));
            this.cmdEliminar.Image = ((System.Drawing.Image)(resources.GetObject("cmdEliminar.Image")));
            this.cmdEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdEliminar.Location = new System.Drawing.Point(360, 432);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(168, 68);
            this.cmdEliminar.TabIndex = 149;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdEliminar.UseVisualStyleBackColor = true;
            this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
            // 
            // AsignaturasP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(150)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(1062, 513);
            this.Controls.Add(this.gpbOrdenar);
            this.Controls.Add(this.gpbBuscar);
            this.Controls.Add(this.gridAsignaturasP);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdImprimir);
            this.Controls.Add(this.cmdModificar);
            this.Controls.Add(this.cmdNuevo);
            this.Controls.Add(this.cmdExportar);
            this.Controls.Add(this.cmdEliminar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AsignaturasP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Asignaturas";
            this.Load += new System.EventHandler(this.AsignaturasP_Load);
            this.gpbOrdenar.ResumeLayout(false);
            this.gpbOrdenar.PerformLayout();
            this.gpbBuscar.ResumeLayout(false);
            this.gpbBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAsignaturasP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbOrdenar;
        private System.Windows.Forms.RadioButton rbOrdenarDocente;
        private System.Windows.Forms.RadioButton rbOrdenarAsignatura;
        private System.Windows.Forms.RadioButton rbOrdenarCodigo;
        private System.Windows.Forms.GroupBox gpbBuscar;
        private System.Windows.Forms.RadioButton rbDocente;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.RadioButton rbAsignatura;
        private System.Windows.Forms.RadioButton rbCodigo;
        private System.Windows.Forms.DataGridView gridAsignaturasP;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.Button cmdImprimir;
        private System.Windows.Forms.Button cmdModificar;
        private System.Windows.Forms.Button cmdNuevo;
        private System.Windows.Forms.Button cmdExportar;
        private System.Windows.Forms.Button cmdEliminar;
    }
}