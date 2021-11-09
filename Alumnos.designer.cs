
namespace SCCI
{
    partial class AlumnosP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlumnosP));
            this.cmdSalir = new System.Windows.Forms.Button();
            this.cmdImprimir = new System.Windows.Forms.Button();
            this.cmdExportar = new System.Windows.Forms.Button();
            this.cmdELiminar = new System.Windows.Forms.Button();
            this.cmdModificar = new System.Windows.Forms.Button();
            this.cmdNuevo = new System.Windows.Forms.Button();
            this.gpbOrdenar = new System.Windows.Forms.GroupBox();
            this.rbOrdenarDireccion = new System.Windows.Forms.RadioButton();
            this.rbOrdenarNombre = new System.Windows.Forms.RadioButton();
            this.rbOrdenarDNI = new System.Windows.Forms.RadioButton();
            this.gpbBuscar = new System.Windows.Forms.GroupBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.rbDireccion = new System.Windows.Forms.RadioButton();
            this.rbNombre = new System.Windows.Forms.RadioButton();
            this.rbDNI = new System.Windows.Forms.RadioButton();
            this.gridAlumnos = new System.Windows.Forms.DataGridView();
            this.gpbOrdenar.SuspendLayout();
            this.gpbBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdSalir
            // 
            this.cmdSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.cmdSalir.Image = ((System.Drawing.Image)(resources.GetObject("cmdSalir.Image")));
            this.cmdSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdSalir.Location = new System.Drawing.Point(883, 507);
            this.cmdSalir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(168, 68);
            this.cmdSalir.TabIndex = 26;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // cmdImprimir
            // 
            this.cmdImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.cmdImprimir.Image = ((System.Drawing.Image)(resources.GetObject("cmdImprimir.Image")));
            this.cmdImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdImprimir.Location = new System.Drawing.Point(709, 506);
            this.cmdImprimir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdImprimir.Name = "cmdImprimir";
            this.cmdImprimir.Size = new System.Drawing.Size(168, 68);
            this.cmdImprimir.TabIndex = 25;
            this.cmdImprimir.Text = "Imprimir";
            this.cmdImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdImprimir.UseVisualStyleBackColor = true;
            this.cmdImprimir.Click += new System.EventHandler(this.cmdImprimir_Click);
            // 
            // cmdExportar
            // 
            this.cmdExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.cmdExportar.Image = ((System.Drawing.Image)(resources.GetObject("cmdExportar.Image")));
            this.cmdExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdExportar.Location = new System.Drawing.Point(535, 506);
            this.cmdExportar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdExportar.Name = "cmdExportar";
            this.cmdExportar.Size = new System.Drawing.Size(168, 68);
            this.cmdExportar.TabIndex = 24;
            this.cmdExportar.Text = "Exportar";
            this.cmdExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdExportar.UseVisualStyleBackColor = true;
            this.cmdExportar.Click += new System.EventHandler(this.cmdExportar_Click);
            // 
            // cmdELiminar
            // 
            this.cmdELiminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.cmdELiminar.Image = ((System.Drawing.Image)(resources.GetObject("cmdELiminar.Image")));
            this.cmdELiminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdELiminar.Location = new System.Drawing.Point(361, 507);
            this.cmdELiminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdELiminar.Name = "cmdELiminar";
            this.cmdELiminar.Size = new System.Drawing.Size(168, 68);
            this.cmdELiminar.TabIndex = 23;
            this.cmdELiminar.Text = "Eliminar";
            this.cmdELiminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdELiminar.UseVisualStyleBackColor = true;
            this.cmdELiminar.Click += new System.EventHandler(this.cmdELiminar_Click);
            // 
            // cmdModificar
            // 
            this.cmdModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdModificar.Image = ((System.Drawing.Image)(resources.GetObject("cmdModificar.Image")));
            this.cmdModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdModificar.Location = new System.Drawing.Point(187, 507);
            this.cmdModificar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdModificar.Name = "cmdModificar";
            this.cmdModificar.Size = new System.Drawing.Size(168, 68);
            this.cmdModificar.TabIndex = 22;
            this.cmdModificar.Text = "Modificar";
            this.cmdModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdModificar.UseVisualStyleBackColor = true;
            this.cmdModificar.Click += new System.EventHandler(this.cmdModificar_Click);
            // 
            // cmdNuevo
            // 
            this.cmdNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNuevo.Image = ((System.Drawing.Image)(resources.GetObject("cmdNuevo.Image")));
            this.cmdNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdNuevo.Location = new System.Drawing.Point(13, 506);
            this.cmdNuevo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdNuevo.Name = "cmdNuevo";
            this.cmdNuevo.Size = new System.Drawing.Size(168, 68);
            this.cmdNuevo.TabIndex = 21;
            this.cmdNuevo.Text = "Nuevo";
            this.cmdNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdNuevo.UseVisualStyleBackColor = true;
            this.cmdNuevo.Click += new System.EventHandler(this.cmdNuevo_Click);
            // 
            // gpbOrdenar
            // 
            this.gpbOrdenar.Controls.Add(this.rbOrdenarDireccion);
            this.gpbOrdenar.Controls.Add(this.rbOrdenarNombre);
            this.gpbOrdenar.Controls.Add(this.rbOrdenarDNI);
            this.gpbOrdenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbOrdenar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gpbOrdenar.Location = new System.Drawing.Point(848, 11);
            this.gpbOrdenar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbOrdenar.Name = "gpbOrdenar";
            this.gpbOrdenar.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbOrdenar.Size = new System.Drawing.Size(203, 164);
            this.gpbOrdenar.TabIndex = 19;
            this.gpbOrdenar.TabStop = false;
            this.gpbOrdenar.Text = "Ordenar";
            // 
            // rbOrdenarDireccion
            // 
            this.rbOrdenarDireccion.AutoSize = true;
            this.rbOrdenarDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.rbOrdenarDireccion.Location = new System.Drawing.Point(24, 114);
            this.rbOrdenarDireccion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbOrdenarDireccion.Name = "rbOrdenarDireccion";
            this.rbOrdenarDireccion.Size = new System.Drawing.Size(143, 26);
            this.rbOrdenarDireccion.TabIndex = 2;
            this.rbOrdenarDireccion.Text = "DIRECCION";
            this.rbOrdenarDireccion.UseVisualStyleBackColor = true;
            // 
            // rbOrdenarNombre
            // 
            this.rbOrdenarNombre.AutoSize = true;
            this.rbOrdenarNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.rbOrdenarNombre.Location = new System.Drawing.Point(24, 80);
            this.rbOrdenarNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbOrdenarNombre.Name = "rbOrdenarNombre";
            this.rbOrdenarNombre.Size = new System.Drawing.Size(119, 26);
            this.rbOrdenarNombre.TabIndex = 1;
            this.rbOrdenarNombre.Text = "NOMBRE";
            this.rbOrdenarNombre.UseVisualStyleBackColor = true;
            // 
            // rbOrdenarDNI
            // 
            this.rbOrdenarDNI.AutoSize = true;
            this.rbOrdenarDNI.Checked = true;
            this.rbOrdenarDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.rbOrdenarDNI.Location = new System.Drawing.Point(24, 46);
            this.rbOrdenarDNI.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbOrdenarDNI.Name = "rbOrdenarDNI";
            this.rbOrdenarDNI.Size = new System.Drawing.Size(68, 26);
            this.rbOrdenarDNI.TabIndex = 0;
            this.rbOrdenarDNI.TabStop = true;
            this.rbOrdenarDNI.Text = "DNI";
            this.rbOrdenarDNI.UseVisualStyleBackColor = true;
            // 
            // gpbBuscar
            // 
            this.gpbBuscar.Controls.Add(this.txtBuscar);
            this.gpbBuscar.Controls.Add(this.rbDireccion);
            this.gpbBuscar.Controls.Add(this.rbNombre);
            this.gpbBuscar.Controls.Add(this.rbDNI);
            this.gpbBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbBuscar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gpbBuscar.Location = new System.Drawing.Point(13, 11);
            this.gpbBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbBuscar.Name = "gpbBuscar";
            this.gpbBuscar.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbBuscar.Size = new System.Drawing.Size(829, 164);
            this.gpbBuscar.TabIndex = 18;
            this.gpbBuscar.TabStop = false;
            this.gpbBuscar.Text = "Buscar";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(216, 76);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(560, 30);
            this.txtBuscar.TabIndex = 3;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // rbDireccion
            // 
            this.rbDireccion.AutoSize = true;
            this.rbDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.rbDireccion.Location = new System.Drawing.Point(25, 114);
            this.rbDireccion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbDireccion.Name = "rbDireccion";
            this.rbDireccion.Size = new System.Drawing.Size(143, 26);
            this.rbDireccion.TabIndex = 2;
            this.rbDireccion.Text = "DIRECCION";
            this.rbDireccion.UseVisualStyleBackColor = true;
            // 
            // rbNombre
            // 
            this.rbNombre.AutoSize = true;
            this.rbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.rbNombre.Location = new System.Drawing.Point(25, 80);
            this.rbNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbNombre.Name = "rbNombre";
            this.rbNombre.Size = new System.Drawing.Size(119, 26);
            this.rbNombre.TabIndex = 1;
            this.rbNombre.Text = "NOMBRE";
            this.rbNombre.UseVisualStyleBackColor = true;
            // 
            // rbDNI
            // 
            this.rbDNI.AutoSize = true;
            this.rbDNI.Checked = true;
            this.rbDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.rbDNI.Location = new System.Drawing.Point(25, 46);
            this.rbDNI.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbDNI.Name = "rbDNI";
            this.rbDNI.Size = new System.Drawing.Size(68, 26);
            this.rbDNI.TabIndex = 0;
            this.rbDNI.TabStop = true;
            this.rbDNI.Text = "DNI";
            this.rbDNI.UseVisualStyleBackColor = true;
            // 
            // gridAlumnos
            // 
            this.gridAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAlumnos.Location = new System.Drawing.Point(13, 183);
            this.gridAlumnos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridAlumnos.Name = "gridAlumnos";
            this.gridAlumnos.RowHeadersWidth = 51;
            this.gridAlumnos.RowTemplate.Height = 24;
            this.gridAlumnos.Size = new System.Drawing.Size(1038, 316);
            this.gridAlumnos.TabIndex = 27;
            // 
            // AlumnosP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(150)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(1063, 590);
            this.Controls.Add(this.gridAlumnos);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdImprimir);
            this.Controls.Add(this.cmdExportar);
            this.Controls.Add(this.cmdELiminar);
            this.Controls.Add(this.cmdModificar);
            this.Controls.Add(this.cmdNuevo);
            this.Controls.Add(this.gpbOrdenar);
            this.Controls.Add(this.gpbBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AlumnosP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Alumnos";
            this.Load += new System.EventHandler(this.AlumnosP_Load);
            this.gpbOrdenar.ResumeLayout(false);
            this.gpbOrdenar.PerformLayout();
            this.gpbBuscar.ResumeLayout(false);
            this.gpbBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAlumnos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.Button cmdImprimir;
        private System.Windows.Forms.Button cmdExportar;
        private System.Windows.Forms.Button cmdELiminar;
        private System.Windows.Forms.Button cmdModificar;
        private System.Windows.Forms.Button cmdNuevo;
        private System.Windows.Forms.GroupBox gpbOrdenar;
        private System.Windows.Forms.RadioButton rbOrdenarDireccion;
        private System.Windows.Forms.RadioButton rbOrdenarNombre;
        private System.Windows.Forms.RadioButton rbOrdenarDNI;
        private System.Windows.Forms.GroupBox gpbBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.RadioButton rbDireccion;
        private System.Windows.Forms.RadioButton rbNombre;
        private System.Windows.Forms.RadioButton rbDNI;
        private System.Windows.Forms.DataGridView gridAlumnos;
    }
}