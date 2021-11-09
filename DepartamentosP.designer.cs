
namespace SCCI
{
    partial class DepartamentosP
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
            this.gridDepartamento = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbOrdenarDepa = new System.Windows.Forms.RadioButton();
            this.rbOrdenarClave = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.rbDepartamentos = new System.Windows.Forms.RadioButton();
            this.rbClave = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.cmdImprimir = new System.Windows.Forms.Button();
            this.cmdExportar = new System.Windows.Forms.Button();
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.cmdModificar = new System.Windows.Forms.Button();
            this.cmdNuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridDepartamento)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridDepartamento
            // 
            this.gridDepartamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDepartamento.Location = new System.Drawing.Point(13, 147);
            this.gridDepartamento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gridDepartamento.Name = "gridDepartamento";
            this.gridDepartamento.RowHeadersWidth = 62;
            this.gridDepartamento.Size = new System.Drawing.Size(1044, 326);
            this.gridDepartamento.TabIndex = 20;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbOrdenarDepa);
            this.groupBox2.Controls.Add(this.rbOrdenarClave);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(827, 7);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(230, 130);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ordenar";
            // 
            // rbOrdenarDepa
            // 
            this.rbOrdenarDepa.AutoSize = true;
            this.rbOrdenarDepa.Location = new System.Drawing.Point(8, 72);
            this.rbOrdenarDepa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbOrdenarDepa.Name = "rbOrdenarDepa";
            this.rbOrdenarDepa.Size = new System.Drawing.Size(172, 29);
            this.rbOrdenarDepa.TabIndex = 1;
            this.rbOrdenarDepa.Text = "Departamento";
            this.rbOrdenarDepa.UseVisualStyleBackColor = true;
            // 
            // rbOrdenarClave
            // 
            this.rbOrdenarClave.AutoSize = true;
            this.rbOrdenarClave.Checked = true;
            this.rbOrdenarClave.Location = new System.Drawing.Point(8, 33);
            this.rbOrdenarClave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbOrdenarClave.Name = "rbOrdenarClave";
            this.rbOrdenarClave.Size = new System.Drawing.Size(93, 29);
            this.rbOrdenarClave.TabIndex = 0;
            this.rbOrdenarClave.TabStop = true;
            this.rbOrdenarClave.Text = "Clave";
            this.rbOrdenarClave.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBuscar);
            this.groupBox1.Controls.Add(this.rbDepartamentos);
            this.groupBox1.Controls.Add(this.rbClave);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(13, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(806, 130);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(248, 52);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(524, 30);
            this.txtBuscar.TabIndex = 2;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // rbDepartamentos
            // 
            this.rbDepartamentos.AutoSize = true;
            this.rbDepartamentos.Location = new System.Drawing.Point(8, 72);
            this.rbDepartamentos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbDepartamentos.Name = "rbDepartamentos";
            this.rbDepartamentos.Size = new System.Drawing.Size(172, 29);
            this.rbDepartamentos.TabIndex = 1;
            this.rbDepartamentos.Text = "Departamento";
            this.rbDepartamentos.UseVisualStyleBackColor = true;
            // 
            // rbClave
            // 
            this.rbClave.AutoSize = true;
            this.rbClave.Checked = true;
            this.rbClave.Location = new System.Drawing.Point(8, 33);
            this.rbClave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbClave.Name = "rbClave";
            this.rbClave.Size = new System.Drawing.Size(93, 29);
            this.rbClave.TabIndex = 0;
            this.rbClave.TabStop = true;
            this.rbClave.Text = "Clave";
            this.rbClave.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(663, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 17;
            // 
            // cmdSalir
            // 
            this.cmdSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.cmdSalir.Image = global::SCCI.Properties.Resources.exit;
            this.cmdSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdSalir.Location = new System.Drawing.Point(889, 483);
            this.cmdSalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.cmdImprimir.Image = global::SCCI.Properties.Resources.Imprimir;
            this.cmdImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdImprimir.Location = new System.Drawing.Point(714, 483);
            this.cmdImprimir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.cmdExportar.Image = global::SCCI.Properties.Resources.Exportar_Excel;
            this.cmdExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdExportar.Location = new System.Drawing.Point(538, 483);
            this.cmdExportar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdExportar.Name = "cmdExportar";
            this.cmdExportar.Size = new System.Drawing.Size(168, 68);
            this.cmdExportar.TabIndex = 24;
            this.cmdExportar.Text = "Exportar";
            this.cmdExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdExportar.UseVisualStyleBackColor = true;
            this.cmdExportar.Click += new System.EventHandler(this.cmdExportar_Click);
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.cmdEliminar.Image = global::SCCI.Properties.Resources.Eliminar;
            this.cmdEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdEliminar.Location = new System.Drawing.Point(362, 483);
            this.cmdEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(168, 68);
            this.cmdEliminar.TabIndex = 23;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdEliminar.UseVisualStyleBackColor = true;
            this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
            // 
            // cmdModificar
            // 
            this.cmdModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.cmdModificar.Image = global::SCCI.Properties.Resources.Modificar;
            this.cmdModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdModificar.Location = new System.Drawing.Point(187, 483);
            this.cmdModificar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.cmdNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.cmdNuevo.Image = global::SCCI.Properties.Resources.Agregar2;
            this.cmdNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdNuevo.Location = new System.Drawing.Point(12, 483);
            this.cmdNuevo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdNuevo.Name = "cmdNuevo";
            this.cmdNuevo.Size = new System.Drawing.Size(168, 68);
            this.cmdNuevo.TabIndex = 21;
            this.cmdNuevo.Text = "Nuevo";
            this.cmdNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdNuevo.UseVisualStyleBackColor = true;
            this.cmdNuevo.Click += new System.EventHandler(this.cmdNuevo_Click);
            // 
            // DepartamentosP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(150)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(1072, 565);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdImprimir);
            this.Controls.Add(this.cmdExportar);
            this.Controls.Add(this.cmdEliminar);
            this.Controls.Add(this.cmdModificar);
            this.Controls.Add(this.cmdNuevo);
            this.Controls.Add(this.gridDepartamento);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DepartamentosP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Departamentos";
            this.Load += new System.EventHandler(this.Departamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridDepartamento)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.Button cmdImprimir;
        private System.Windows.Forms.Button cmdExportar;
        private System.Windows.Forms.Button cmdEliminar;
        private System.Windows.Forms.Button cmdModificar;
        private System.Windows.Forms.Button cmdNuevo;
        private System.Windows.Forms.DataGridView gridDepartamento;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbOrdenarDepa;
        private System.Windows.Forms.RadioButton rbOrdenarClave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.RadioButton rbDepartamentos;
        private System.Windows.Forms.RadioButton rbClave;
        private System.Windows.Forms.Label label1;
    }
}