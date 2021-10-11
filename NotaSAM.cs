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
            Metodos.CargarCombo("SELECT * FROM MATRICULA", cboMatricula);

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
                        cboMatricula.SelectedValue = Lector.GetString(1);
                        txtI.Text = Lector.GetString(2);
                        txtII.Text = Lector.GetString(3);
                        cboActivo.Text = Lector.GetString(4);

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
                new MySqlParameter("@MAT", cboMatricula.SelectedValue),
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
