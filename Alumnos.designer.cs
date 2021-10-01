
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
            this.cmdBuscar = new System.Windows.Forms.Button();
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
            this.cmdSalir.Image = ((System.Drawing.Image)(resources.GetObject("cmdSalir.Image")));
            this.cmdSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdSalir.Location = new System.Drawing.Point(813, 416);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(155, 61);
            this.cmdSalir.TabIndex = 26;
            this.cmdSalir.Text = "SALIR";
            this.cmdSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // cmdImprimir
            // 
            this.cmdImprimir.Image = ((System.Drawing.Image)(resources.GetObject("cmdImprimir.Image")));
            this.cmdImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdImprimir.Location = new System.Drawing.Point(652, 416);
            this.cmdImprimir.Name = "cmdImprimir";
            this.cmdImprimir.Size = new System.Drawing.Size(155, 61);
            this.cmdImprimir.TabIndex = 25;
            this.cmdImprimir.Text = "IMPRIMIR";
            this.cmdImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdImprimir.UseVisualStyleBackColor = true;
            this.cmdImprimir.Click += new System.EventHandler(this.cmdImprimir_Click);
            // 
            // cmdExportar
            // 
            this.cmdExportar.Image = ((System.Drawing.Image)(resources.GetObject("cmdExportar.Image")));
            this.cmdExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdExportar.Location = new System.Drawing.Point(491, 416);
            this.cmdExportar.Name = "cmdExportar";
            this.cmdExportar.Size = new System.Drawing.Size(155, 61);
            this.cmdExportar.TabIndex = 24;
            this.cmdExportar.Text = "EXPORTAR";
            this.cmdExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdExportar.UseVisualStyleBackColor = true;
            this.cmdExportar.Click += new System.EventHandler(this.cmdExportar_Click);
            // 
            // cmdELiminar
            // 
            this.cmdELiminar.Image = ((System.Drawing.Image)(resources.GetObject("cmdELiminar.Image")));
            this.cmdELiminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdELiminar.Location = new System.Drawing.Point(330, 416);
            this.cmdELiminar.Name = "cmdELiminar";
            this.cmdELiminar.Size = new System.Drawing.Size(155, 61);
            this.cmdELiminar.TabIndex = 23;
            this.cmdELiminar.Text = "ELIMINAR";
            this.cmdELiminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdELiminar.UseVisualStyleBackColor = true;
            this.cmdELiminar.Click += new System.EventHandler(this.cmdELiminar_Click);
            // 
            // cmdModificar
            // 
            this.cmdModificar.Image = ((System.Drawing.Image)(resources.GetObject("cmdModificar.Image")));
            this.cmdModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdModificar.Location = new System.Drawing.Point(172, 416);
            this.cmdModificar.Name = "cmdModificar";
            this.cmdModificar.Size = new System.Drawing.Size(155, 61);
            this.cmdModificar.TabIndex = 22;
            this.cmdModificar.Text = "MODIFICAR";
            this.cmdModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdModificar.UseVisualStyleBackColor = true;
            this.cmdModificar.Click += new System.EventHandler(this.cmdModificar_Click);
            // 
            // cmdNuevo
            // 
            this.cmdNuevo.Image = ((System.Drawing.Image)(resources.GetObject("cmdNuevo.Image")));
            this.cmdNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdNuevo.Location = new System.Drawing.Point(13, 416);
            this.cmdNuevo.Name = "cmdNuevo";
            this.cmdNuevo.Size = new System.Drawing.Size(155, 61);
            this.cmdNuevo.TabIndex = 21;
            this.cmdNuevo.Text = "NUEVO";
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
            this.gpbOrdenar.Location = new System.Drawing.Point(731, 20);
            this.gpbOrdenar.Name = "gpbOrdenar";
            this.gpbOrdenar.Size = new System.Drawing.Size(237, 153);
            this.gpbOrdenar.TabIndex = 19;
            this.gpbOrdenar.TabStop = false;
            this.gpbOrdenar.Text = "Ordenar";
            // 
            // rbOrdenarDireccion
            // 
            this.rbOrdenarDireccion.AutoSize = true;
            this.rbOrdenarDireccion.Location = new System.Drawing.Point(21, 115);
            this.rbOrdenarDireccion.Name = "rbOrdenarDireccion";
            this.rbOrdenarDireccion.Size = new System.Drawing.Size(132, 24);
            this.rbOrdenarDireccion.TabIndex = 2;
            this.rbOrdenarDireccion.TabStop = true;
            this.rbOrdenarDireccion.Text = "DIRECCION";
            this.rbOrdenarDireccion.UseVisualStyleBackColor = true;
            // 
            // rbOrdenarNombre
            // 
            this.rbOrdenarNombre.AutoSize = true;
            this.rbOrdenarNombre.Location = new System.Drawing.Point(21, 79);
            this.rbOrdenarNombre.Name = "rbOrdenarNombre";
            this.rbOrdenarNombre.Size = new System.Drawing.Size(110, 24);
            this.rbOrdenarNombre.TabIndex = 1;
            this.rbOrdenarNombre.TabStop = true;
            this.rbOrdenarNombre.Text = "NOMBRE";
            this.rbOrdenarNombre.UseVisualStyleBackColor = true;
            // 
            // rbOrdenarDNI
            // 
            this.rbOrdenarDNI.AutoSize = true;
            this.rbOrdenarDNI.Location = new System.Drawing.Point(21, 37);
            this.rbOrdenarDNI.Name = "rbOrdenarDNI";
            this.rbOrdenarDNI.Size = new System.Drawing.Size(62, 24);
            this.rbOrdenarDNI.TabIndex = 0;
            this.rbOrdenarDNI.TabStop = true;
            this.rbOrdenarDNI.Text = "DNI";
            this.rbOrdenarDNI.UseVisualStyleBackColor = true;
            // 
            // gpbBuscar
            // 
            this.gpbBuscar.Controls.Add(this.cmdBuscar);
            this.gpbBuscar.Controls.Add(this.txtBuscar);
            this.gpbBuscar.Controls.Add(this.rbDireccion);
            this.gpbBuscar.Controls.Add(this.rbNombre);
            this.gpbBuscar.Controls.Add(this.rbDNI);
            this.gpbBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbBuscar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gpbBuscar.Location = new System.Drawing.Point(13, 20);
            this.gpbBuscar.Name = "gpbBuscar";
            this.gpbBuscar.Size = new System.Drawing.Size(705, 153);
            this.gpbBuscar.TabIndex = 18;
            this.gpbBuscar.TabStop = false;
            this.gpbBuscar.Text = "Buscar";
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdBuscar.Image = ((System.Drawing.Image)(resources.GetObject("cmdBuscar.Image")));
            this.cmdBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdBuscar.Location = new System.Drawing.Point(544, 65);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(155, 61);
            this.cmdBuscar.TabIndex = 4;
            this.cmdBuscar.Text = "BUSCAR";
            this.cmdBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdBuscar.UseVisualStyleBackColor = true;
            this.cmdBuscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(128, 37);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(571, 27);
            this.txtBuscar.TabIndex = 3;
            // 
            // rbDireccion
            // 
            this.rbDireccion.AutoSize = true;
            this.rbDireccion.Location = new System.Drawing.Point(22, 115);
            this.rbDireccion.Name = "rbDireccion";
            this.rbDireccion.Size = new System.Drawing.Size(132, 24);
            this.rbDireccion.TabIndex = 2;
            this.rbDireccion.TabStop = true;
            this.rbDireccion.Text = "DIRECCION";
            this.rbDireccion.UseVisualStyleBackColor = true;
            // 
            // rbNombre
            // 
            this.rbNombre.AutoSize = true;
            this.rbNombre.Location = new System.Drawing.Point(22, 79);
            this.rbNombre.Name = "rbNombre";
            this.rbNombre.Size = new System.Drawing.Size(110, 24);
            this.rbNombre.TabIndex = 1;
            this.rbNombre.TabStop = true;
            this.rbNombre.Text = "NOMBRE";
            this.rbNombre.UseVisualStyleBackColor = true;
            // 
            // rbDNI
            // 
            this.rbDNI.AutoSize = true;
            this.rbDNI.Location = new System.Drawing.Point(22, 37);
            this.rbDNI.Name = "rbDNI";
            this.rbDNI.Size = new System.Drawing.Size(62, 24);
            this.rbDNI.TabIndex = 0;
            this.rbDNI.TabStop = true;
            this.rbDNI.Text = "DNI";
            this.rbDNI.UseVisualStyleBackColor = true;
            // 
            // gridAlumnos
            // 
            this.gridAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAlumnos.Location = new System.Drawing.Point(13, 180);
            this.gridAlumnos.Name = "gridAlumnos";
            this.gridAlumnos.RowHeadersWidth = 51;
            this.gridAlumnos.RowTemplate.Height = 24;
            this.gridAlumnos.Size = new System.Drawing.Size(955, 230);
            this.gridAlumnos.TabIndex = 27;
            // 
            // AlumnosP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(150)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(980, 496);
            this.Controls.Add(this.gridAlumnos);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdImprimir);
            this.Controls.Add(this.cmdExportar);
            this.Controls.Add(this.cmdELiminar);
            this.Controls.Add(this.cmdModificar);
            this.Controls.Add(this.cmdNuevo);
            this.Controls.Add(this.gpbOrdenar);
            this.Controls.Add(this.gpbBuscar);
            this.Name = "AlumnosP";
            this.Text = "AlumnosP";
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
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.RadioButton rbDireccion;
        private System.Windows.Forms.RadioButton rbNombre;
        private System.Windows.Forms.RadioButton rbDNI;
        private System.Windows.Forms.DataGridView gridAlumnos;
    }
}