namespace SCCI
{
    partial class MatriculaAM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MatriculaAM));
            this.cmdSalir = new System.Windows.Forms.Button();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.gpbDatosMatricula = new System.Windows.Forms.GroupBox();
            this.cboEvaluacion = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboAlumno = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboJornada = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboDocente = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboPeriodo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboAsignatura = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboCarrera = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboGrado = new System.Windows.Forms.ComboBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gpbDatosMatricula.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdSalir
            // 
            this.cmdSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalir.ForeColor = System.Drawing.Color.Black;
            this.cmdSalir.Image = ((System.Drawing.Image)(resources.GetObject("cmdSalir.Image")));
            this.cmdSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdSalir.Location = new System.Drawing.Point(509, 565);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(155, 61);
            this.cmdSalir.TabIndex = 28;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.ForeColor = System.Drawing.Color.Black;
            this.cmdGuardar.Image = ((System.Drawing.Image)(resources.GetObject("cmdGuardar.Image")));
            this.cmdGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdGuardar.Location = new System.Drawing.Point(348, 565);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(155, 61);
            this.cmdGuardar.TabIndex = 27;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdGuardar.UseVisualStyleBackColor = true;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // gpbDatosMatricula
            // 
            this.gpbDatosMatricula.Controls.Add(this.cboEvaluacion);
            this.gpbDatosMatricula.Controls.Add(this.label8);
            this.gpbDatosMatricula.Controls.Add(this.cboAlumno);
            this.gpbDatosMatricula.Controls.Add(this.label7);
            this.gpbDatosMatricula.Controls.Add(this.cboJornada);
            this.gpbDatosMatricula.Controls.Add(this.label6);
            this.gpbDatosMatricula.Controls.Add(this.cboDocente);
            this.gpbDatosMatricula.Controls.Add(this.label5);
            this.gpbDatosMatricula.Controls.Add(this.cboPeriodo);
            this.gpbDatosMatricula.Controls.Add(this.label3);
            this.gpbDatosMatricula.Controls.Add(this.cboAsignatura);
            this.gpbDatosMatricula.Controls.Add(this.label2);
            this.gpbDatosMatricula.Controls.Add(this.cboCarrera);
            this.gpbDatosMatricula.Controls.Add(this.label1);
            this.gpbDatosMatricula.Controls.Add(this.cboGrado);
            this.gpbDatosMatricula.Controls.Add(this.txtCodigo);
            this.gpbDatosMatricula.Controls.Add(this.label43);
            this.gpbDatosMatricula.Controls.Add(this.label4);
            this.gpbDatosMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDatosMatricula.ForeColor = System.Drawing.Color.White;
            this.gpbDatosMatricula.Location = new System.Drawing.Point(12, 13);
            this.gpbDatosMatricula.Name = "gpbDatosMatricula";
            this.gpbDatosMatricula.Size = new System.Drawing.Size(652, 546);
            this.gpbDatosMatricula.TabIndex = 26;
            this.gpbDatosMatricula.TabStop = false;
            this.gpbDatosMatricula.Text = "Datos Matricula";
            // 
            // cboEvaluacion
            // 
            this.cboEvaluacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEvaluacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboEvaluacion.FormattingEnabled = true;
            this.cboEvaluacion.Items.AddRange(new object[] {
            "1",
            "0"});
            this.cboEvaluacion.Location = new System.Drawing.Point(182, 483);
            this.cboEvaluacion.Name = "cboEvaluacion";
            this.cboEvaluacion.Size = new System.Drawing.Size(421, 33);
            this.cboEvaluacion.TabIndex = 31;
            this.cboEvaluacion.Tag = "Evaluación";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 486);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 25);
            this.label8.TabIndex = 30;
            this.label8.Text = "Evaluación";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboAlumno
            // 
            this.cboAlumno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboAlumno.FormattingEnabled = true;
            this.cboAlumno.Items.AddRange(new object[] {
            "1",
            "0"});
            this.cboAlumno.Location = new System.Drawing.Point(182, 427);
            this.cboAlumno.Name = "cboAlumno";
            this.cboAlumno.Size = new System.Drawing.Size(421, 33);
            this.cboAlumno.TabIndex = 29;
            this.cboAlumno.Tag = "Alumno";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(77, 430);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 25);
            this.label7.TabIndex = 28;
            this.label7.Text = "Alumno";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboJornada
            // 
            this.cboJornada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboJornada.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboJornada.FormattingEnabled = true;
            this.cboJornada.Items.AddRange(new object[] {
            "1",
            "0"});
            this.cboJornada.Location = new System.Drawing.Point(182, 372);
            this.cboJornada.Name = "cboJornada";
            this.cboJornada.Size = new System.Drawing.Size(421, 33);
            this.cboJornada.TabIndex = 27;
            this.cboJornada.Tag = "Jornada";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 375);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 25);
            this.label6.TabIndex = 26;
            this.label6.Text = "Jornada";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboDocente
            // 
            this.cboDocente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDocente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboDocente.FormattingEnabled = true;
            this.cboDocente.Items.AddRange(new object[] {
            "1",
            "0"});
            this.cboDocente.Location = new System.Drawing.Point(182, 316);
            this.cboDocente.Name = "cboDocente";
            this.cboDocente.Size = new System.Drawing.Size(421, 33);
            this.cboDocente.TabIndex = 25;
            this.cboDocente.Tag = "Docente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 25);
            this.label5.TabIndex = 24;
            this.label5.Text = "Docente";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboPeriodo
            // 
            this.cboPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPeriodo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboPeriodo.FormattingEnabled = true;
            this.cboPeriodo.Items.AddRange(new object[] {
            "1",
            "0"});
            this.cboPeriodo.Location = new System.Drawing.Point(182, 260);
            this.cboPeriodo.Name = "cboPeriodo";
            this.cboPeriodo.Size = new System.Drawing.Size(421, 33);
            this.cboPeriodo.TabIndex = 23;
            this.cboPeriodo.Tag = "Periodo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "Periodo";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboAsignatura
            // 
            this.cboAsignatura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAsignatura.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboAsignatura.FormattingEnabled = true;
            this.cboAsignatura.Items.AddRange(new object[] {
            "1",
            "0"});
            this.cboAsignatura.Location = new System.Drawing.Point(182, 203);
            this.cboAsignatura.Name = "cboAsignatura";
            this.cboAsignatura.Size = new System.Drawing.Size(421, 33);
            this.cboAsignatura.TabIndex = 21;
            this.cboAsignatura.Tag = "Asignatura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Asignatura";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboCarrera
            // 
            this.cboCarrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCarrera.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboCarrera.FormattingEnabled = true;
            this.cboCarrera.Items.AddRange(new object[] {
            "1",
            "0"});
            this.cboCarrera.Location = new System.Drawing.Point(182, 149);
            this.cboCarrera.Name = "cboCarrera";
            this.cboCarrera.Size = new System.Drawing.Size(421, 33);
            this.cboCarrera.TabIndex = 19;
            this.cboCarrera.Tag = "Carrera";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Carrera";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboGrado
            // 
            this.cboGrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGrado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboGrado.FormattingEnabled = true;
            this.cboGrado.Items.AddRange(new object[] {
            "1",
            "0"});
            this.cboGrado.Location = new System.Drawing.Point(182, 93);
            this.cboGrado.Name = "cboGrado";
            this.cboGrado.Size = new System.Drawing.Size(421, 33);
            this.cboGrado.TabIndex = 17;
            this.cboGrado.Tag = "Grado";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(182, 40);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(421, 30);
            this.txtCodigo.TabIndex = 11;
            this.txtCodigo.Tag = "No Validar";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(82, 43);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(81, 25);
            this.label43.TabIndex = 10;
            this.label43.Tag = "";
            this.label43.Text = "Codigo";
            this.label43.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Grado";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MatriculaAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(150)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(676, 638);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.gpbDatosMatricula);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MatriculaAM";
            this.Load += new System.EventHandler(this.MatriculaAM_Load);
            this.gpbDatosMatricula.ResumeLayout(false);
            this.gpbDatosMatricula.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.GroupBox gpbDatosMatricula;
        private System.Windows.Forms.ComboBox cboEvaluacion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboAlumno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboJornada;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboDocente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboPeriodo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboAsignatura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboCarrera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboGrado;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label4;
    }
}