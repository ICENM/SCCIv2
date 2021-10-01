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
    public partial class NotaSAM : Form
    {
        public NotaSAM()
        {
            InitializeComponent();
        }

        private void NotaSAM_Load(object sender, EventArgs e)
        {
            Metodos.CargarCombo("SELECT * FROM Grados", cboGrado);
            Metodos.CargarCombo("SELECT * FROM Carreras", cboCarrera);
            Metodos.CargarCombo("SELECT * FROM Asignaturas", cboAsignatura);
            Metodos.CargarCombo("SELECT * FROM Periodos", cboPeriodo);
            Metodos.CargarCombo("SELECT * FROM Docentes", cboDocente);
            Metodos.CargarCombo("SELECT * FROM Jornadas", cboJornada);
            Metodos.CargarCombo("SELECT * FROM Alumnos", cboAlumno);
            Metodos.CargarCombo("SELECT * FROM Evaluacion", cboEvaluacion);

            Metodos.Limpiar(gpbDatosNotas);

            if (Metodos.Control_F == 'A')
            {
                this.Text = "Notas Semestre - Nuevo";
            }

            if (Metodos.Control_F == 'M')
            {

                this.Text = "Notas Semestre - Actualizar";

                MySqlDataReader Lector = Metodos.LectorConsulta(String.Format("SELECT * FROM NotaS WHERE CODIGO = '{0}'", Metodos.Control_CS));

                if (Lector.HasRows)
                {
                    while (Lector.Read())
                    {

                        txtCodigo.Text = Lector.GetString(0);
                        cboGrado.SelectedValue = Lector.GetString(1);
                        cboCarrera.SelectedValue = Lector.GetString(2);
                        cboAsignatura.SelectedValue = Lector.GetString(3);
                        cboPeriodo.SelectedValue = Lector.GetString(4);
                        cboDocente.SelectedValue = Lector.GetString(5);
                        cboJornada.SelectedValue = Lector.GetString(6);
                        cboAlumno.SelectedValue = Lector.GetString(7);
                        cboEvaluacion.SelectedValue = Lector.GetString(8);
                        txtI.Text = Lector.GetString(9);
                        txtII.Text = Lector.GetString(10);
                        cboActivo.Text = Lector.GetString(13);

                    }
                }
            }
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (Metodos.Validar(gpbDatosNotas)) return;

            MySqlParameter[] Parametros = new MySqlParameter[]
            {
                new MySqlParameter("@COD", txtCodigo.Text),
                new MySqlParameter("@GRA", cboGrado.SelectedValue),
                new MySqlParameter("@CAR", cboCarrera.SelectedValue),
                new MySqlParameter("@ASI", cboAsignatura.SelectedValue),
                new MySqlParameter("@PER", cboPeriodo.SelectedValue),
                new MySqlParameter("@DOC", cboDocente.SelectedValue),
                new MySqlParameter("@JOR", cboJornada.SelectedValue),
                new MySqlParameter("@ALU", cboAlumno.SelectedValue),
                new MySqlParameter("@EVA", cboEvaluacion.SelectedValue),
                new MySqlParameter("@IPA", txtI.Text),
                new MySqlParameter("@IIPA", txtII.Text),
                new MySqlParameter("@ACT", cboActivo.Text)
            };

            if (Metodos.Control_F == 'A')
            {
                Metodos.EjecutarP("Agregar_NotaS", Parametros);

                MessageBox.Show("Registro guardado con éxito", "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (Metodos.Control_F == 'M')
            {
                Metodos.EjecutarP("Actualizar_NotaS", Parametros);

                MessageBox.Show("Registro actualizado con éxito", "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Metodos.Limpiar(gpbDatosNotas);

        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Metodos.Control_F = ' ';
        }
    }
}
