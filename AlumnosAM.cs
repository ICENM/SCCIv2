using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SCCI
{
    public partial class AlumnoAM : Form
    {
        public AlumnoAM()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void AlumnoAM_Load(object sender, EventArgs e)
        {
            Metodos.CargarCombo("SELECT * FROM Nacionalidades", cboNacionalidad);
            Metodos.CargarCombo("SELECT * FROM Departamentos", cboDepartamento);
            Metodos.CargarCombo("SELECT * FROM Municipios", cboMunicipio);
            Metodos.CargarCombo("SELECT * FROM Barrios", cboBarrio);


            Metodos.Limpiar(gpbAlumnos);

            if (Metodos.Control_F == 'A')
            {
                txtDNI.Enabled = true;

                this.Text = "Alumnos - Nuevo";
            }

            if (Metodos.Control_F == 'M')
            {
                txtDNI.Enabled = false;

                this.Text = "Alumnos - Actualizar";

                MySqlDataReader Lector = Metodos.LectorConsulta(String.Format("SELECT * FROM Alumnos WHERE DNI = '{0}'", Metodos.Control_CS));

                if (Lector.HasRows)
                {
                    while (Lector.Read())
                    {

                        txtDNI.Text = Lector.GetString(0);
                        txtNombre.Text = Lector.GetString(1);
                        txtApellidos.Text = Lector.GetString(2);
                        txtFotos.Text = Lector.GetString(3);
                        cboSexo.Text = Lector.GetString(4);
                        txtCorreo.Text = Lector.GetString(5);
                        txtTelefono.Text = Lector.GetString(6);
                        txtFecha.Value = Lector.GetDateTime(7);
                        txtDireccion.Text = Lector.GetString(8);
                        cboNacionalidad.SelectedValue = Lector.GetString(9);
                        cboDepartamento.SelectedValue = Lector.GetString(10);
                        cboMunicipio.SelectedValue = Lector.GetString(11);
                        cboBarrio.SelectedValue = Lector.GetString(12);
                        cboActivo.Text = Lector.GetString(12);

                    }
                }
            }
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (Metodos.Validar(gpbAlumnos)) return;

            MySqlParameter[] Parametros = new MySqlParameter[]
            {

                new MySqlParameter("@ID", txtDNI.Text),
                new MySqlParameter("@NOM", txtNombre.Text),
                new MySqlParameter("@APE", txtApellidos.Text),
                new MySqlParameter("@FOT", txtFotos.Text),
                new MySqlParameter("@SEX", cboSexo.Text),
                new MySqlParameter("@COR", txtCorreo.Text),
                new MySqlParameter("@TEL", txtTelefono.Text),
                new MySqlParameter("@FEC", txtFecha.Value),
                new MySqlParameter("@DIR", txtDireccion.Text),
                new MySqlParameter("@NAC", cboNacionalidad.SelectedValue),
                new MySqlParameter("@DEP", cboDepartamento.SelectedValue),
                new MySqlParameter("@MUN", cboMunicipio.SelectedValue),
                new MySqlParameter("@BAR", cboBarrio.SelectedValue),
                new MySqlParameter("@ACT", cboActivo.Text),

            };

            if (Metodos.Control_F == 'A')
            {
                Metodos.EjecutarP("Agregar_Alumnos", Parametros);

                MessageBox.Show("Registro guardado con éxito", "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (Metodos.Control_F == 'M')
            {
                Metodos.EjecutarP("Actualizar_Alumnos", Parametros);

                MessageBox.Show("Registro actualizado con éxito", "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Metodos.Limpiar(gpbAlumnos);

            Close();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Metodos.Control_F = ' ';
        }
    }
}
