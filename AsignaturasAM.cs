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
    public partial class AsignaturasAM : Form
    {
        public AsignaturasAM()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Metodos.CargarCombo("SELECT * FROM Docentes", cboDocente);

            Metodos.Limpiar(gpdDatosAsignatura);

            if (Metodos.Control_F == 'A')
            {
                this.Text = "Asignaturas - Nuevo";
            }

            if (Metodos.Control_F == 'M')
            {

                this.Text = "Asignaturas - Actualizar";

                MySqlDataReader Lector = Metodos.LectorConsulta(String.Format("SELECT * FROM Asignaturas WHERE CODIGO = '{0}'", Metodos.Control_CS));

                if (Lector.HasRows)
                {
                    while (Lector.Read())
                    {

                        txtCodigo.Text = Lector.GetString(0);
                        txtAsignatura.Text = Lector.GetString(1);
                        cboDocente.SelectedValue = Lector.GetString(2);
                        txtFecha.Value = Lector.GetDateTime(3);
                        cboActivo.Text = Lector.GetString(4);
                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Guardarcmd_Click(object sender, EventArgs e)
        {
            if (Metodos.Validar(gpdDatosAsignatura)) return;

            MySqlParameter[] Parametros = new MySqlParameter[]
            {
                new MySqlParameter("@COD", txtCodigo.Text),
                new MySqlParameter("@ASIG", txtAsignatura.Text),
                new MySqlParameter("@DOC", cboDocente.SelectedValue),
                new MySqlParameter("@FECH", txtFecha.Value),
                new MySqlParameter("@ACT", cboActivo.Text)
            };

            if (Metodos.Control_F == 'A')
            {
                Metodos.EjecutarP("Agregar_Asignaturas", Parametros);

                MessageBox.Show("Registro guardado con éxito", "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (Metodos.Control_F == 'M')
            {
                Metodos.EjecutarP("Actualizar_Asignaturas", Parametros);

                MessageBox.Show("Registro actualizado con éxito", "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Metodos.Limpiar(gpdDatosAsignatura);

            Close();
        }

        private void Cancelarcmd_Click(object sender, EventArgs e)
        {
            this.Close();
            Metodos.Control_F = ' ';
        }
    }
}
