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
    public partial class DocentesAM : Form
    {
        public DocentesAM()
        {
            InitializeComponent();
        }

        private void DocentesAM_Load(object sender, EventArgs e)
        {
            Metodos.CargarCombo("SELECT * FROM Grados", cboNacionalidad);
            Metodos.CargarCombo("SELECT * FROM Carreras", cboDepartamento);
            Metodos.CargarCombo("SELECT * FROM Asignaturas", cboMunicipio);
            Metodos.CargarCombo("SELECT * FROM Periodos", cboBarrio);

            Metodos.Limpiar(gpbDatosDocentes);

            if (Metodos.Control_F == 'A')
            {
                txtDNI.Enabled = true;

                this.Text = "Docentes - Nuevo";
            }

            if (Metodos.Control_F == 'M')
            {
                txtDNI.Enabled = false;

                this.Text = "Docentes - Actualizar";

                MySqlDataReader Lector = Metodos.LectorConsulta(String.Format("SELECT * FROM Docentes WHERE DNI = '{0}'", Metodos.Control_CS));

                if (Lector.HasRows)
                {
                    while (Lector.Read())
                    {
                        txtDNI.Text = Lector.GetString(0);
                        txtNombres.Text = Lector.GetString(1);
                        txtApellidos.Text = Lector.GetString(2);
                        cboSexo.Text = Lector.GetString(3);
                        txtTelefono.Text = Lector.GetString(4);
                        txtCorreo.Text = Lector.GetString(5);
                        cboNacionalidad.SelectedValue = Lector.GetString(6);
                        cboDepartamento.SelectedValue = Lector.GetString(7);
                        cboMunicipio.SelectedValue = Lector.GetString(8);
                        cboBarrio.SelectedValue = Lector.GetString(9);
                        cboActivo.Text = Lector.GetString(10);

                    }
                }
            }
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {

            if (Metodos.Validar(gpbDatosDocentes)) return;

            MySqlParameter[] Parametros = new MySqlParameter[]
            {
                new MySqlParameter("@ID", txtDNI.Text),
                new MySqlParameter("@NOM", txtNombres.Text),
                new MySqlParameter("@APE", txtApellidos.Text),
                new MySqlParameter("@SEX", cboSexo.Text),
                new MySqlParameter("@TEL", txtTelefono.Text),
                new MySqlParameter("@COR", txtCorreo.Text),
                new MySqlParameter("@NAC", cboNacionalidad.SelectedValue),
                new MySqlParameter("@DEP", cboDepartamento.SelectedValue),
                new MySqlParameter("@MUN", cboMunicipio.SelectedValue),
                new MySqlParameter("@BAR", cboBarrio.SelectedValue),
                new MySqlParameter("@ACT", cboActivo.Text)
            };

            if (Metodos.Control_F == 'A')
            {
                Metodos.EjecutarP("Agregar_Docentes", Parametros);

                MessageBox.Show("Registro guardado con éxito", "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (Metodos.Control_F == 'M')
            {
                Metodos.EjecutarP("Actualizar_Docentes", Parametros);

                MessageBox.Show("Registro actualizado con éxito", "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Metodos.Limpiar(gpbDatosDocentes);

            Close();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Metodos.Control_F = ' ';
        }
    }
}
