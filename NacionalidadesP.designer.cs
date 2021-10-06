
namespace SCCI
{
    partial class NacionalidadesP
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
            this.cmdSalir = new System.Windows.Forms.Button();
            this.cmdImprimir = new System.Windows.Forms.Button();
            this.cmdExportar = new System.Windows.Forms.Button();
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.cmdModificar = new System.Windows.Forms.Button();
            this.cmdNuevo = new System.Windows.Forms.Button();
            this.gridNacionalidades = new System.Windows.Forms.DataGridView();
            this.gpbOrdenar = new System.Windows.Forms.GroupBox();
            this.RbOrdenarFech_Reg = new System.Windows.Forms.RadioButton();
            this.RbOrdenarNacionalidades = new System.Windows.Forms.RadioButton();
            this.gpbBuscar = new System.Windows.Forms.GroupBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.rbFech_Reg = new System.Windows.Forms.RadioButton();
            this.rbNacionalidades = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridNacionalidades)).BeginInit();
            this.gpbOrdenar.SuspendLayout();
            this.gpbBuscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdSalir
            // 
            this.cmdSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalir.Image = global::SCCI.Properties.Resources.exit;
            this.cmdSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdSalir.Location = new System.Drawing.Point(613, 385);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(111, 38);
            this.cmdSalir.TabIndex = 46;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // cmdImprimir
            // 
            this.cmdImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdImprimir.Image = global::SCCI.Properties.Resources.Imprimir;
            this.cmdImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdImprimir.Location = new System.Drawing.Point(496, 385);
            this.cmdImprimir.Name = "cmdImprimir";
            this.cmdImprimir.Size = new System.Drawing.Size(111, 38);
            this.cmdImprimir.TabIndex = 45;
            this.cmdImprimir.Text = "Imprimir";
            this.cmdImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdImprimir.UseVisualStyleBackColor = true;
            this.cmdImprimir.Click += new System.EventHandler(this.cmdImprimir_Click);
            // 
            // cmdExportar
            // 
            this.cmdExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExportar.Image = global::SCCI.Properties.Resources.Exportar_Excel;
            this.cmdExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdExportar.Location = new System.Drawing.Point(379, 385);
            this.cmdExportar.Name = "cmdExportar";
            this.cmdExportar.Size = new System.Drawing.Size(111, 38);
            this.cmdExportar.TabIndex = 44;
            this.cmdExportar.Text = "Exportar";
            this.cmdExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdExportar.UseVisualStyleBackColor = true;
            this.cmdExportar.Click += new System.EventHandler(this.cmdExportar_Click);
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEliminar.Image = global::SCCI.Properties.Resources.Eliminar;
            this.cmdEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdEliminar.Location = new System.Drawing.Point(262, 385);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(111, 38);
            this.cmdEliminar.TabIndex = 43;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdEliminar.UseVisualStyleBackColor = true;
            this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
            // 
            // cmdModificar
            // 
            this.cmdModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdModificar.Image = global::SCCI.Properties.Resources.Modificar;
            this.cmdModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdModificar.Location = new System.Drawing.Point(145, 385);
            this.cmdModificar.Name = "cmdModificar";
            this.cmdModificar.Size = new System.Drawing.Size(111, 38);
            this.cmdModificar.TabIndex = 42;
            this.cmdModificar.Text = "Modificar";
            this.cmdModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdModificar.UseVisualStyleBackColor = true;
            this.cmdModificar.Click += new System.EventHandler(this.cmdModificar_Click);
            // 
            // cmdNuevo
            // 
            this.cmdNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNuevo.Image = global::SCCI.Properties.Resources.Agregar2;
            this.cmdNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdNuevo.Location = new System.Drawing.Point(28, 385);
            this.cmdNuevo.Name = "cmdNuevo";
            this.cmdNuevo.Size = new System.Drawing.Size(111, 38);
            this.cmdNuevo.TabIndex = 41;
            this.cmdNuevo.Text = "Nuevo";
            this.cmdNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdNuevo.UseVisualStyleBackColor = true;
            this.cmdNuevo.Click += new System.EventHandler(this.cmdNuevo_Click);
            // 
            // gridNacionalidades
            // 
            this.gridNacionalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridNacionalidades.Location = new System.Drawing.Point(12, 157);
            this.gridNacionalidades.Name = "gridNacionalidades";
            this.gridNacionalidades.Size = new System.Drawing.Size(728, 212);
            this.gridNacionalidades.TabIndex = 40;
            // 
            // gpbOrdenar
            // 
            this.gpbOrdenar.Controls.Add(this.RbOrdenarFech_Reg);
            this.gpbOrdenar.Controls.Add(this.RbOrdenarNacionalidades);
            this.gpbOrdenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.gpbOrdenar.ForeColor = System.Drawing.Color.White;
            this.gpbOrdenar.Location = new System.Drawing.Point(465, 12);
            this.gpbOrdenar.Name = "gpbOrdenar";
            this.gpbOrdenar.Size = new System.Drawing.Size(275, 139);
            this.gpbOrdenar.TabIndex = 39;
            this.gpbOrdenar.TabStop = false;
            this.gpbOrdenar.Text = "Ordenar";
            // 
            // RbOrdenarFech_Reg
            // 
            this.RbOrdenarFech_Reg.AutoSize = true;
            this.RbOrdenarFech_Reg.Location = new System.Drawing.Point(16, 90);
            this.RbOrdenarFech_Reg.Name = "RbOrdenarFech_Reg";
            this.RbOrdenarFech_Reg.Size = new System.Drawing.Size(159, 21);
            this.RbOrdenarFech_Reg.TabIndex = 1;
            this.RbOrdenarFech_Reg.TabStop = true;
            this.RbOrdenarFech_Reg.Text = "Fecha de Registro";
            this.RbOrdenarFech_Reg.UseVisualStyleBackColor = true;
            // 
            // RbOrdenarNacionalidades
            // 
            this.RbOrdenarNacionalidades.AutoSize = true;
            this.RbOrdenarNacionalidades.Location = new System.Drawing.Point(16, 28);
            this.RbOrdenarNacionalidades.Name = "RbOrdenarNacionalidades";
            this.RbOrdenarNacionalidades.Size = new System.Drawing.Size(136, 21);
            this.RbOrdenarNacionalidades.TabIndex = 0;
            this.RbOrdenarNacionalidades.TabStop = true;
            this.RbOrdenarNacionalidades.Text = "Departamentos";
            this.RbOrdenarNacionalidades.UseVisualStyleBackColor = true;
            // 
            // gpbBuscar
            // 
            this.gpbBuscar.Controls.Add(this.txtBuscar);
            this.gpbBuscar.Controls.Add(this.rbFech_Reg);
            this.gpbBuscar.Controls.Add(this.rbNacionalidades);
            this.gpbBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.gpbBuscar.ForeColor = System.Drawing.Color.White;
            this.gpbBuscar.Location = new System.Drawing.Point(12, 12);
            this.gpbBuscar.Name = "gpbBuscar";
            this.gpbBuscar.Size = new System.Drawing.Size(434, 139);
            this.gpbBuscar.TabIndex = 38;
            this.gpbBuscar.TabStop = false;
            this.gpbBuscar.Text = "Buscar";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(150, 55);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(278, 23);
            this.txtBuscar.TabIndex = 2;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // rbFech_Reg
            // 
            this.rbFech_Reg.AutoSize = true;
            this.rbFech_Reg.Location = new System.Drawing.Point(16, 90);
            this.rbFech_Reg.Name = "rbFech_Reg";
            this.rbFech_Reg.Size = new System.Drawing.Size(159, 21);
            this.rbFech_Reg.TabIndex = 1;
            this.rbFech_Reg.TabStop = true;
            this.rbFech_Reg.Text = "Fecha de Registro";
            this.rbFech_Reg.UseVisualStyleBackColor = true;
            // 
            // rbNacionalidades
            // 
            this.rbNacionalidades.AutoSize = true;
            this.rbNacionalidades.Location = new System.Drawing.Point(16, 28);
            this.rbNacionalidades.Name = "rbNacionalidades";
            this.rbNacionalidades.Size = new System.Drawing.Size(137, 21);
            this.rbNacionalidades.TabIndex = 0;
            this.rbNacionalidades.TabStop = true;
            this.rbNacionalidades.Text = "Nacionalidades";
            this.rbNacionalidades.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(446, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 37;
            // 
            // NacionalidadesP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(150)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(752, 435);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdImprimir);
            this.Controls.Add(this.cmdExportar);
            this.Controls.Add(this.cmdEliminar);
            this.Controls.Add(this.cmdModificar);
            this.Controls.Add(this.cmdNuevo);
            this.Controls.Add(this.gridNacionalidades);
            this.Controls.Add(this.gpbOrdenar);
            this.Controls.Add(this.gpbBuscar);
            this.Controls.Add(this.label1);
            this.Name = "NacionalidadesP";
            this.Text = "NacionalidadesP";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NacionalidadesP_FormClosed);
            this.Load += new System.EventHandler(this.NacionalidadesP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridNacionalidades)).EndInit();
            this.gpbOrdenar.ResumeLayout(false);
            this.gpbOrdenar.PerformLayout();
            this.gpbBuscar.ResumeLayout(false);
            this.gpbBuscar.PerformLayout();
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
        private System.Windows.Forms.DataGridView gridNacionalidades;
        private System.Windows.Forms.GroupBox gpbOrdenar;
        private System.Windows.Forms.RadioButton RbOrdenarFech_Reg;
        private System.Windows.Forms.RadioButton RbOrdenarNacionalidades;
        private System.Windows.Forms.GroupBox gpbBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.RadioButton rbFech_Reg;
        private System.Windows.Forms.RadioButton rbNacionalidades;
        private System.Windows.Forms.Label label1;
    }
}