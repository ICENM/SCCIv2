
namespace SCCI
{
    partial class Evaluacion_P
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
            this.dgvEvaluacion = new System.Windows.Forms.DataGridView();
            this.gbOrdenar = new System.Windows.Forms.GroupBox();
            this.rbOrdenarFecha = new System.Windows.Forms.RadioButton();
            this.rbOrdenarTipoEvaluacion = new System.Windows.Forms.RadioButton();
            this.rbOrdenarCodigo = new System.Windows.Forms.RadioButton();
            this.gbBuscar = new System.Windows.Forms.GroupBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.rbFecha = new System.Windows.Forms.RadioButton();
            this.rbTipoEvaluacion = new System.Windows.Forms.RadioButton();
            this.rbCodigo = new System.Windows.Forms.RadioButton();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.cmdImprimir = new System.Windows.Forms.Button();
            this.cmdExportar = new System.Windows.Forms.Button();
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.cmdModificar = new System.Windows.Forms.Button();
            this.cmdAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvaluacion)).BeginInit();
            this.gbOrdenar.SuspendLayout();
            this.gbBuscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEvaluacion
            // 
            this.dgvEvaluacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvaluacion.Location = new System.Drawing.Point(18, 182);
            this.dgvEvaluacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvEvaluacion.Name = "dgvEvaluacion";
            this.dgvEvaluacion.RowHeadersWidth = 62;
            this.dgvEvaluacion.Size = new System.Drawing.Size(1050, 200);
            this.dgvEvaluacion.TabIndex = 11;
            // 
            // gbOrdenar
            // 
            this.gbOrdenar.Controls.Add(this.rbOrdenarFecha);
            this.gbOrdenar.Controls.Add(this.rbOrdenarTipoEvaluacion);
            this.gbOrdenar.Controls.Add(this.rbOrdenarCodigo);
            this.gbOrdenar.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOrdenar.Location = new System.Drawing.Point(884, 18);
            this.gbOrdenar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbOrdenar.Name = "gbOrdenar";
            this.gbOrdenar.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbOrdenar.Size = new System.Drawing.Size(184, 154);
            this.gbOrdenar.TabIndex = 10;
            this.gbOrdenar.TabStop = false;
            this.gbOrdenar.Text = "Ordenar:";
            // 
            // rbOrdenarFecha
            // 
            this.rbOrdenarFecha.AutoSize = true;
            this.rbOrdenarFecha.Location = new System.Drawing.Point(9, 105);
            this.rbOrdenarFecha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbOrdenarFecha.Name = "rbOrdenarFecha";
            this.rbOrdenarFecha.Size = new System.Drawing.Size(149, 24);
            this.rbOrdenarFecha.TabIndex = 5;
            this.rbOrdenarFecha.Text = "Fecha Registro";
            this.rbOrdenarFecha.UseVisualStyleBackColor = true;
            // 
            // rbOrdenarTipoEvaluacion
            // 
            this.rbOrdenarTipoEvaluacion.AutoSize = true;
            this.rbOrdenarTipoEvaluacion.Location = new System.Drawing.Point(9, 68);
            this.rbOrdenarTipoEvaluacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbOrdenarTipoEvaluacion.Name = "rbOrdenarTipoEvaluacion";
            this.rbOrdenarTipoEvaluacion.Size = new System.Drawing.Size(161, 24);
            this.rbOrdenarTipoEvaluacion.TabIndex = 4;
            this.rbOrdenarTipoEvaluacion.Text = "Tipo Evaluacion";
            this.rbOrdenarTipoEvaluacion.UseVisualStyleBackColor = true;
            // 
            // rbOrdenarCodigo
            // 
            this.rbOrdenarCodigo.AutoSize = true;
            this.rbOrdenarCodigo.Checked = true;
            this.rbOrdenarCodigo.Location = new System.Drawing.Point(9, 31);
            this.rbOrdenarCodigo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbOrdenarCodigo.Name = "rbOrdenarCodigo";
            this.rbOrdenarCodigo.Size = new System.Drawing.Size(91, 24);
            this.rbOrdenarCodigo.TabIndex = 3;
            this.rbOrdenarCodigo.TabStop = true;
            this.rbOrdenarCodigo.Text = "Codigo";
            this.rbOrdenarCodigo.UseVisualStyleBackColor = true;
            // 
            // gbBuscar
            // 
            this.gbBuscar.Controls.Add(this.txtBuscar);
            this.gbBuscar.Controls.Add(this.rbFecha);
            this.gbBuscar.Controls.Add(this.rbTipoEvaluacion);
            this.gbBuscar.Controls.Add(this.rbCodigo);
            this.gbBuscar.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBuscar.Location = new System.Drawing.Point(18, 18);
            this.gbBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbBuscar.Name = "gbBuscar";
            this.gbBuscar.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbBuscar.Size = new System.Drawing.Size(858, 154);
            this.gbBuscar.TabIndex = 9;
            this.gbBuscar.TabStop = false;
            this.gbBuscar.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(235, 67);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(564, 28);
            this.txtBuscar.TabIndex = 3;
            this.txtBuscar.Tag = "Buscar";
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // rbFecha
            // 
            this.rbFecha.AutoSize = true;
            this.rbFecha.Location = new System.Drawing.Point(10, 105);
            this.rbFecha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbFecha.Name = "rbFecha";
            this.rbFecha.Size = new System.Drawing.Size(149, 24);
            this.rbFecha.TabIndex = 2;
            this.rbFecha.Text = "Fecha Registro";
            this.rbFecha.UseVisualStyleBackColor = true;
            // 
            // rbTipoEvaluacion
            // 
            this.rbTipoEvaluacion.AutoSize = true;
            this.rbTipoEvaluacion.Location = new System.Drawing.Point(10, 68);
            this.rbTipoEvaluacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbTipoEvaluacion.Name = "rbTipoEvaluacion";
            this.rbTipoEvaluacion.Size = new System.Drawing.Size(161, 24);
            this.rbTipoEvaluacion.TabIndex = 1;
            this.rbTipoEvaluacion.Text = "Tipo Evaluacion";
            this.rbTipoEvaluacion.UseVisualStyleBackColor = true;
            // 
            // rbCodigo
            // 
            this.rbCodigo.AutoSize = true;
            this.rbCodigo.Checked = true;
            this.rbCodigo.Location = new System.Drawing.Point(10, 31);
            this.rbCodigo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbCodigo.Name = "rbCodigo";
            this.rbCodigo.Size = new System.Drawing.Size(91, 24);
            this.rbCodigo.TabIndex = 0;
            this.rbCodigo.TabStop = true;
            this.rbCodigo.Text = "Codigo";
            this.rbCodigo.UseVisualStyleBackColor = true;
            // 
            // cmdSalir
            // 
            this.cmdSalir.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalir.Image = global::SCCI.Properties.Resources.Salir32;
            this.cmdSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdSalir.Location = new System.Drawing.Point(900, 391);
            this.cmdSalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(168, 68);
            this.cmdSalir.TabIndex = 17;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // cmdImprimir
            // 
            this.cmdImprimir.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdImprimir.Image = global::SCCI.Properties.Resources.Imprimir;
            this.cmdImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdImprimir.Location = new System.Drawing.Point(724, 391);
            this.cmdImprimir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdImprimir.Name = "cmdImprimir";
            this.cmdImprimir.Size = new System.Drawing.Size(168, 68);
            this.cmdImprimir.TabIndex = 16;
            this.cmdImprimir.Text = "Imprimir";
            this.cmdImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdImprimir.UseVisualStyleBackColor = true;
            this.cmdImprimir.Click += new System.EventHandler(this.cmdImprimir_Click);
            // 
            // cmdExportar
            // 
            this.cmdExportar.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExportar.Image = global::SCCI.Properties.Resources.Exportar_Excel;
            this.cmdExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdExportar.Location = new System.Drawing.Point(548, 391);
            this.cmdExportar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdExportar.Name = "cmdExportar";
            this.cmdExportar.Size = new System.Drawing.Size(168, 68);
            this.cmdExportar.TabIndex = 15;
            this.cmdExportar.Text = "Exportar";
            this.cmdExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdExportar.UseVisualStyleBackColor = true;
            this.cmdExportar.Click += new System.EventHandler(this.cmdExportar_Click);
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEliminar.Image = global::SCCI.Properties.Resources.Eliminar;
            this.cmdEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdEliminar.Location = new System.Drawing.Point(372, 391);
            this.cmdEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(168, 68);
            this.cmdEliminar.TabIndex = 14;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdEliminar.UseVisualStyleBackColor = true;
            this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
            // 
            // cmdModificar
            // 
            this.cmdModificar.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdModificar.Image = global::SCCI.Properties.Resources.Modificar;
            this.cmdModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdModificar.Location = new System.Drawing.Point(196, 391);
            this.cmdModificar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdModificar.Name = "cmdModificar";
            this.cmdModificar.Size = new System.Drawing.Size(168, 68);
            this.cmdModificar.TabIndex = 13;
            this.cmdModificar.Text = "Modificar";
            this.cmdModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdModificar.UseVisualStyleBackColor = true;
            this.cmdModificar.Click += new System.EventHandler(this.cmdModificar_Click);
            // 
            // cmdAgregar
            // 
            this.cmdAgregar.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAgregar.Image = global::SCCI.Properties.Resources.Agregar2;
            this.cmdAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdAgregar.Location = new System.Drawing.Point(20, 391);
            this.cmdAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdAgregar.Name = "cmdAgregar";
            this.cmdAgregar.Size = new System.Drawing.Size(168, 68);
            this.cmdAgregar.TabIndex = 12;
            this.cmdAgregar.Text = "Agregar";
            this.cmdAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdAgregar.UseVisualStyleBackColor = true;
            this.cmdAgregar.Click += new System.EventHandler(this.cmdAgregar_Click);
            // 
            // Evaluacion_P
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(150)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(1086, 469);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdImprimir);
            this.Controls.Add(this.cmdExportar);
            this.Controls.Add(this.cmdEliminar);
            this.Controls.Add(this.cmdModificar);
            this.Controls.Add(this.cmdAgregar);
            this.Controls.Add(this.dgvEvaluacion);
            this.Controls.Add(this.gbOrdenar);
            this.Controls.Add(this.gbBuscar);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Evaluacion_P";
            this.Text = "Evaluacion_P";
            this.Load += new System.EventHandler(this.Evaluacion_P_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvaluacion)).EndInit();
            this.gbOrdenar.ResumeLayout(false);
            this.gbOrdenar.PerformLayout();
            this.gbBuscar.ResumeLayout(false);
            this.gbBuscar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.Button cmdImprimir;
        private System.Windows.Forms.Button cmdExportar;
        private System.Windows.Forms.Button cmdEliminar;
        private System.Windows.Forms.Button cmdModificar;
        private System.Windows.Forms.Button cmdAgregar;
        private System.Windows.Forms.DataGridView dgvEvaluacion;
        private System.Windows.Forms.GroupBox gbOrdenar;
        private System.Windows.Forms.RadioButton rbOrdenarFecha;
        private System.Windows.Forms.RadioButton rbOrdenarTipoEvaluacion;
        private System.Windows.Forms.RadioButton rbOrdenarCodigo;
        private System.Windows.Forms.GroupBox gbBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.RadioButton rbFecha;
        private System.Windows.Forms.RadioButton rbTipoEvaluacion;
        private System.Windows.Forms.RadioButton rbCodigo;
    }
}