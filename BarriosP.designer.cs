
namespace SCCI
{
    partial class BarriosP
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
            this.gridBarrios = new System.Windows.Forms.DataGridView();
            this.gpbOrdenar = new System.Windows.Forms.GroupBox();
            this.RbOrdenarFech_Reg = new System.Windows.Forms.RadioButton();
            this.RbOrdenarBarrios = new System.Windows.Forms.RadioButton();
            this.gpbBuscar = new System.Windows.Forms.GroupBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.rbFech_Reg = new System.Windows.Forms.RadioButton();
            this.rbBarrios = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridBarrios)).BeginInit();
            this.gpbOrdenar.SuspendLayout();
            this.gpbBuscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdSalir
            // 
            this.cmdSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalir.Image = global::SCCI.Properties.Resources.exit;
            this.cmdSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdSalir.Location = new System.Drawing.Point(613, 383);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(111, 38);
            this.cmdSalir.TabIndex = 26;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdSalir.UseVisualStyleBackColor = true;
            // 
            // cmdImprimir
            // 
            this.cmdImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdImprimir.Image = global::SCCI.Properties.Resources.Imprimir;
            this.cmdImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdImprimir.Location = new System.Drawing.Point(496, 383);
            this.cmdImprimir.Name = "cmdImprimir";
            this.cmdImprimir.Size = new System.Drawing.Size(111, 38);
            this.cmdImprimir.TabIndex = 25;
            this.cmdImprimir.Text = "Imprimir";
            this.cmdImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdImprimir.UseVisualStyleBackColor = true;
            // 
            // cmdExportar
            // 
            this.cmdExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExportar.Image = global::SCCI.Properties.Resources.Exportar_Excel;
            this.cmdExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdExportar.Location = new System.Drawing.Point(379, 383);
            this.cmdExportar.Name = "cmdExportar";
            this.cmdExportar.Size = new System.Drawing.Size(111, 38);
            this.cmdExportar.TabIndex = 24;
            this.cmdExportar.Text = "Exportar";
            this.cmdExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdExportar.UseVisualStyleBackColor = true;
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEliminar.Image = global::SCCI.Properties.Resources.Eliminar;
            this.cmdEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdEliminar.Location = new System.Drawing.Point(262, 383);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(111, 38);
            this.cmdEliminar.TabIndex = 23;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdEliminar.UseVisualStyleBackColor = true;
            // 
            // cmdModificar
            // 
            this.cmdModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdModificar.Image = global::SCCI.Properties.Resources.Modificar;
            this.cmdModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdModificar.Location = new System.Drawing.Point(145, 383);
            this.cmdModificar.Name = "cmdModificar";
            this.cmdModificar.Size = new System.Drawing.Size(111, 38);
            this.cmdModificar.TabIndex = 22;
            this.cmdModificar.Text = "Modificar";
            this.cmdModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdModificar.UseVisualStyleBackColor = true;
            // 
            // cmdNuevo
            // 
            this.cmdNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNuevo.Image = global::SCCI.Properties.Resources.Agregar2;
            this.cmdNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdNuevo.Location = new System.Drawing.Point(28, 383);
            this.cmdNuevo.Name = "cmdNuevo";
            this.cmdNuevo.Size = new System.Drawing.Size(111, 38);
            this.cmdNuevo.TabIndex = 21;
            this.cmdNuevo.Text = "Nuevo";
            this.cmdNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdNuevo.UseVisualStyleBackColor = true;
            // 
            // gridBarrios
            // 
            this.gridBarrios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBarrios.Location = new System.Drawing.Point(12, 155);
            this.gridBarrios.Name = "gridBarrios";
            this.gridBarrios.Size = new System.Drawing.Size(728, 212);
            this.gridBarrios.TabIndex = 20;
            // 
            // gpbOrdenar
            // 
            this.gpbOrdenar.Controls.Add(this.RbOrdenarFech_Reg);
            this.gpbOrdenar.Controls.Add(this.RbOrdenarBarrios);
            this.gpbOrdenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.gpbOrdenar.ForeColor = System.Drawing.Color.White;
            this.gpbOrdenar.Location = new System.Drawing.Point(465, 10);
            this.gpbOrdenar.Name = "gpbOrdenar";
            this.gpbOrdenar.Size = new System.Drawing.Size(275, 139);
            this.gpbOrdenar.TabIndex = 19;
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
            // RbOrdenarBarrios
            // 
            this.RbOrdenarBarrios.AutoSize = true;
            this.RbOrdenarBarrios.Location = new System.Drawing.Point(16, 28);
            this.RbOrdenarBarrios.Name = "RbOrdenarBarrios";
            this.RbOrdenarBarrios.Size = new System.Drawing.Size(78, 21);
            this.RbOrdenarBarrios.TabIndex = 0;
            this.RbOrdenarBarrios.TabStop = true;
            this.RbOrdenarBarrios.Text = "Barrios";
            this.RbOrdenarBarrios.UseVisualStyleBackColor = true;
            // 
            // gpbBuscar
            // 
            this.gpbBuscar.Controls.Add(this.txtBuscar);
            this.gpbBuscar.Controls.Add(this.rbFech_Reg);
            this.gpbBuscar.Controls.Add(this.rbBarrios);
            this.gpbBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.gpbBuscar.ForeColor = System.Drawing.Color.White;
            this.gpbBuscar.Location = new System.Drawing.Point(12, 10);
            this.gpbBuscar.Name = "gpbBuscar";
            this.gpbBuscar.Size = new System.Drawing.Size(434, 139);
            this.gpbBuscar.TabIndex = 18;
            this.gpbBuscar.TabStop = false;
            this.gpbBuscar.Text = "Buscar";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(150, 47);
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
            // rbBarrios
            // 
            this.rbBarrios.AutoSize = true;
            this.rbBarrios.Location = new System.Drawing.Point(16, 28);
            this.rbBarrios.Name = "rbBarrios";
            this.rbBarrios.Size = new System.Drawing.Size(78, 21);
            this.rbBarrios.TabIndex = 0;
            this.rbBarrios.TabStop = true;
            this.rbBarrios.Text = "Barrios";
            this.rbBarrios.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(446, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 17;
            // 
            // BarriosP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(150)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(749, 430);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdImprimir);
            this.Controls.Add(this.cmdExportar);
            this.Controls.Add(this.cmdEliminar);
            this.Controls.Add(this.cmdModificar);
            this.Controls.Add(this.cmdNuevo);
            this.Controls.Add(this.gridBarrios);
            this.Controls.Add(this.gpbOrdenar);
            this.Controls.Add(this.gpbBuscar);
            this.Controls.Add(this.label1);
            this.Name = "BarriosP";
            this.Text = "BarriosP";
            ((System.ComponentModel.ISupportInitialize)(this.gridBarrios)).EndInit();
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
        private System.Windows.Forms.DataGridView gridBarrios;
        private System.Windows.Forms.GroupBox gpbOrdenar;
        private System.Windows.Forms.RadioButton RbOrdenarFech_Reg;
        private System.Windows.Forms.RadioButton RbOrdenarBarrios;
        private System.Windows.Forms.GroupBox gpbBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.RadioButton rbFech_Reg;
        private System.Windows.Forms.RadioButton rbBarrios;
        private System.Windows.Forms.Label label1;
    }
}