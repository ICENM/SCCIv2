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
    public partial class CarrerasAM : Form
    {
        public CarrerasAM()
        {
            InitializeComponent();
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            Close();
            Metodos.Control_F = ' ';
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (Metodos.Validar(gpbcarrera)) return;

            MySqlParameter[] Parametros = new MySqlParameter[]
            {
                new MySqlParameter("@COD", txtcodigo.Text),
                new MySqlParameter("@CARR", txtcarrera.Text),
                new MySqlParameter("@FECH", dtfecha_registro.Value),
                new MySqlParameter("@ACT", cboActivo.Text),
               

            };

            if (Metodos.Control_F == 'A')
            {
                Metodos.EjecutarP("Agregar_Carreras", Parametros);

                MessageBox.Show("Registro guardado con éxito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (Metodos.Control_F == 'M')
            {
                Metodos.EjecutarP("Actualizar_Carreras", Parametros);

                MessageBox.Show("Registro actualizado con éxito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Metodos.Limpiar(gpbcarrera);

            Close();
        }

        private void gpbcarrera_Enter(object sender, EventArgs e)
        {

        }

        private void CarrerasAM_Load(object sender, EventArgs e)
        {
            Metodos.Limpiar(gpbcarrera);

            if (Metodos.Control_F == 'A')
            {
                this.Text = "Carrera - Nuevo";
            }

            if (Metodos.Control_F == 'M')
            {
                this.Text = "Carreras - Actualizar";

                MySqlDataReader Lector = Metodos.LectorConsulta(String.Format("SELECT * FROM Carreras WHERE CODIGO = '{0}'", Metodos.Control_CS));

                if (Lector.HasRows)
                {
                    while (Lector.Read())
                    {
                        txtcodigo.Text = Lector.GetString(0);
                        txtcarrera.Text = Lector.GetString(1);
                        dtfecha_registro.Value = Lector.GetDateTime(2);
                        cboActivo.Text = Lector.GetString(3);
                    }
                }
            }
        }

        private void cmdCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Metodos.Control_F = ' ';
        }
    }
}
