
namespace SCCI
{
    partial class AlumnoAM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlumnoAM));
            this.gpbAlumnos = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cboSexo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboBarrio = new System.Windows.Forms.ComboBox();
            this.cboActivo = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cboMunicipio = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboDepartamento = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboNacionalidad = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.DateTimePicker();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdCargarImagen = new System.Windows.Forms.Button();
            this.ImagenAlumno = new System.Windows.Forms.PictureBox();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.gpbAlumnos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenAlumno)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbAlumnos
            // 
            this.gpbAlumnos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(150)))), ((int)(((byte)(226)))));
            this.gpbAlumnos.Controls.Add(this.label12);
            this.gpbAlumnos.Controls.Add(this.cboSexo);
            this.gpbAlumnos.Controls.Add(this.label4);
            this.gpbAlumnos.Controls.Add(this.cboBarrio);
            this.gpbAlumnos.Controls.Add(this.cboActivo);
            this.gpbAlumnos.Controls.Add(this.label11);
            this.gpbAlumnos.Controls.Add(this.cboMunicipio);
            this.gpbAlumnos.Controls.Add(this.label10);
            this.gpbAlumnos.Controls.Add(this.cboDepartamento);
            this.gpbAlumnos.Controls.Add(this.label9);
            this.gpbAlumnos.Controls.Add(this.cboNacionalidad);
            this.gpbAlumnos.Controls.Add(this.label8);
            this.gpbAlumnos.Controls.Add(this.txtDireccion);
            this.gpbAlumnos.Controls.Add(this.label14);
            this.gpbAlumnos.Controls.Add(this.txtFecha);
            this.gpbAlumnos.Controls.Add(this.comboBox2);
            this.gpbAlumnos.Controls.Add(this.txtTelefono);
            this.gpbAlumnos.Controls.Add(this.label7);
            this.gpbAlumnos.Controls.Add(this.label6);
            this.gpbAlumnos.Controls.Add(this.label5);
            this.gpbAlumnos.Controls.Add(this.label3);
            this.gpbAlumnos.Controls.Add(this.label2);
            this.gpbAlumnos.Controls.Add(this.txtCorreo);
            this.gpbAlumnos.Controls.Add(this.txtApellidos);
            this.gpbAlumnos.Controls.Add(this.txtNombre);
            this.gpbAlumnos.Controls.Add(this.label1);
            this.gpbAlumnos.Controls.Add(this.txtDNI);
            this.gpbAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.gpbAlumnos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gpbAlumnos.Location = new System.Drawing.Point(9, 10);
            this.gpbAlumnos.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gpbAlumnos.Name = "gpbAlumnos";
            this.gpbAlumnos.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gpbAlumnos.Size = new System.Drawing.Size(833, 263);
            this.gpbAlumnos.TabIndex = 6;
            this.gpbAlumnos.TabStop = false;
            this.gpbAlumnos.Text = "Datos alumnos";
            this.gpbAlumnos.Enter += new System.EventHandler(this.gpbAlumnos_Enter);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(67, 129);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 17);
            this.label12.TabIndex = 45;
            this.label12.Text = "Sexo";
            // 
            // cboSexo
            // 
            this.cboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSexo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboSexo.FormattingEnabled = true;
            this.cboSexo.Items.AddRange(new object[] {
            "Femenino",
            "Masculino"});
            this.cboSexo.Location = new System.Drawing.Point(119, 127);
            this.cboSexo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboSexo.Name = "cboSexo";
            this.cboSexo.Size = new System.Drawing.Size(243, 24);
            this.cboSexo.TabIndex = 44;
            this.cboSexo.Tag = "Sexo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(507, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Activo";
            // 
            // cboBarrio
            // 
            this.cboBarrio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBarrio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboBarrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.cboBarrio.FormattingEnabled = true;
            this.cboBarrio.Location = new System.Drawing.Point(568, 160);
            this.cboBarrio.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cboBarrio.Name = "cboBarrio";
            this.cboBarrio.Size = new System.Drawing.Size(243, 24);
            this.cboBarrio.TabIndex = 43;
            this.cboBarrio.Tag = "Municipio";
            // 
            // cboActivo
            // 
            this.cboActivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboActivo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboActivo.FormattingEnabled = true;
            this.cboActivo.Items.AddRange(new object[] {
            "S",
            "N"});
            this.cboActivo.Location = new System.Drawing.Point(568, 193);
            this.cboActivo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboActivo.Name = "cboActivo";
            this.cboActivo.Size = new System.Drawing.Size(107, 24);
            this.cboActivo.TabIndex = 26;
            this.cboActivo.Tag = "No Validar";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(507, 164);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 17);
            this.label11.TabIndex = 42;
            this.label11.Text = "Barrio";
            // 
            // cboMunicipio
            // 
            this.cboMunicipio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMunicipio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboMunicipio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.cboMunicipio.FormattingEnabled = true;
            this.cboMunicipio.Location = new System.Drawing.Point(568, 127);
            this.cboMunicipio.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cboMunicipio.Name = "cboMunicipio";
            this.cboMunicipio.Size = new System.Drawing.Size(243, 24);
            this.cboMunicipio.TabIndex = 41;
            this.cboMunicipio.Tag = "Municipio";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(483, 134);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 17);
            this.label10.TabIndex = 40;
            this.label10.Text = "Municipio";
            // 
            // cboDepartamento
            // 
            this.cboDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartamento.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.cboDepartamento.FormattingEnabled = true;
            this.cboDepartamento.Location = new System.Drawing.Point(568, 94);
            this.cboDepartamento.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cboDepartamento.Name = "cboDepartamento";
            this.cboDepartamento.Size = new System.Drawing.Size(243, 24);
            this.cboDepartamento.TabIndex = 39;
            this.cboDepartamento.Tag = "Activo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(452, 96);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 17);
            this.label9.TabIndex = 38;
            this.label9.Text = "Departamento";
            // 
            // cboNacionalidad
            // 
            this.cboNacionalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNacionalidad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboNacionalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.cboNacionalidad.FormattingEnabled = true;
            this.cboNacionalidad.Location = new System.Drawing.Point(568, 60);
            this.cboNacionalidad.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cboNacionalidad.Name = "cboNacionalidad";
            this.cboNacionalidad.Size = new System.Drawing.Size(243, 24);
            this.cboNacionalidad.TabIndex = 37;
            this.cboNacionalidad.Tag = "Activo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(459, 62);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 17);
            this.label8.TabIndex = 36;
            this.label8.Text = "Nacionalidad";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtDireccion.Location = new System.Drawing.Point(119, 225);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(243, 23);
            this.txtDireccion.TabIndex = 35;
            this.txtDireccion.Tag = "Dirección";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(34, 227);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 17);
            this.label14.TabIndex = 34;
            this.label14.Text = "Dirección";
            // 
            // txtFecha
            // 
            this.txtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFecha.Location = new System.Drawing.Point(568, 29);
            this.txtFecha.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(123, 23);
            this.txtFecha.TabIndex = 33;
            this.txtFecha.Tag = "Fecha de nacimiento";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(541, 762);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(92, 24);
            this.comboBox2.TabIndex = 27;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtTelefono.Location = new System.Drawing.Point(119, 193);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(243, 23);
            this.txtTelefono.TabIndex = 22;
            this.txtTelefono.Tag = "Telefono";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(404, 30);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Fecha de nacimiento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 195);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Teléfono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 162);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Correo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Apellidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nombres";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtCorreo.Location = new System.Drawing.Point(119, 160);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(243, 23);
            this.txtCorreo.TabIndex = 4;
            this.txtCorreo.Tag = "Correo";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtApellidos.Location = new System.Drawing.Point(119, 92);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(243, 23);
            this.txtApellidos.TabIndex = 3;
            this.txtApellidos.Tag = "Apellidos";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtNombre.Location = new System.Drawing.Point(119, 60);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(243, 23);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.Tag = "Nombres";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "DNI";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDNI
            // 
            this.txtDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtDNI.Location = new System.Drawing.Point(119, 28);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(243, 23);
            this.txtDNI.TabIndex = 0;
            this.txtDNI.Tag = "DNI";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdCargarImagen);
            this.groupBox1.Controls.Add(this.ImagenAlumno);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(848, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 260);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Foto";
            // 
            // cmdCargarImagen
            // 
            this.cmdCargarImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.cmdCargarImagen.ForeColor = System.Drawing.Color.Black;
            this.cmdCargarImagen.Image = global::SCCI.Properties.Resources.Subir_Archivp32;
            this.cmdCargarImagen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCargarImagen.Location = new System.Drawing.Point(5, 190);
            this.cmdCargarImagen.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmdCargarImagen.Name = "cmdCargarImagen";
            this.cmdCargarImagen.Size = new System.Drawing.Size(163, 54);
            this.cmdCargarImagen.TabIndex = 10;
            this.cmdCargarImagen.Text = "Cargar Imagen";
            this.cmdCargarImagen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCargarImagen.UseVisualStyleBackColor = true;
            this.cmdCargarImagen.Click += new System.EventHandler(this.cmdCargarImagen_Click);
            // 
            // ImagenAlumno
            // 
            this.ImagenAlumno.Location = new System.Drawing.Point(7, 23);
            this.ImagenAlumno.Name = "ImagenAlumno";
            this.ImagenAlumno.Size = new System.Drawing.Size(161, 158);
            this.ImagenAlumno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImagenAlumno.TabIndex = 0;
            this.ImagenAlumno.TabStop = false;
            // 
            // cmdSalir
            // 
            this.cmdSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.cmdSalir.Image = ((System.Drawing.Image)(resources.GetObject("cmdSalir.Image")));
            this.cmdSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdSalir.Location = new System.Drawing.Point(731, 278);
            this.cmdSalir.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(112, 44);
            this.cmdSalir.TabIndex = 8;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.cmdGuardar.Image = ((System.Drawing.Image)(resources.GetObject("cmdGuardar.Image")));
            this.cmdGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdGuardar.Location = new System.Drawing.Point(615, 278);
            this.cmdGuardar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(112, 44);
            this.cmdGuardar.TabIndex = 7;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdGuardar.UseVisualStyleBackColor = true;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // AlumnoAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(150)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(1034, 331);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.gpbAlumnos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AlumnoAM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AlumnoAM_Load);
            this.gpbAlumnos.ResumeLayout(false);
            this.gpbAlumnos.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImagenAlumno)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gpbAlumnos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.DateTimePicker txtFecha;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cboNacionalidad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboDepartamento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboBarrio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboMunicipio;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cboSexo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboActivo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdCargarImagen;
        private System.Windows.Forms.PictureBox ImagenAlumno;
    }
}