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
    public partial class JornadasAM : Form
    {
        public JornadasAM()
        {
            InitializeComponent();
        }

        private void ComprasdetAM_Load(object sender, EventArgs e)
        {
            Metodos.Limpiar(gpbjornada);

            if (Metodos.Control_F == 'A')
            {
                this.Text = "Jornadas - Nuevo";
                txtcodigo.Enabled = true;
            }

            if (Metodos.Control_F == 'M')
            {
                this.Text = "Jornadas - Actualizar";
                txtcodigo.Enabled = false;

                MySqlDataReader Lector = Metodos.LectorConsulta(String.Format("SELECT * FROM Jornadas WHERE Id = '{0}'", Metodos.Control_CS));

                if (Lector.HasRows)
                {
                    while (Lector.Read())
                    {
                        txtcodigo.Text = Lector.GetString(0);
                        txtjornada.Text = Lector.GetString(1);
                        txthorario.Text = Lector.GetString(2);
                        txtactivo.Text = Lector.GetString(3);


                    }
                }
            }
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            Close();
            Metodos.Control_F = ' ';
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (Metodos.Validar(gpbjornada)) return;

            MySqlParameter[] Parametros = new MySqlParameter[]
            {
                new MySqlParameter("@Cod", txtcodigo.Text),
                new MySqlParameter("@Jor", txtjornada.Text),
                new MySqlParameter("@Hor", txthorario.Text),
                new MySqlParameter("@Act", txtactivo.Text),


            };

            if (Metodos.Control_F == 'A')
            {
                Metodos.EjecutarP("Agregar", Parametros);

                MessageBox.Show("Registro guardado con éxito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (Metodos.Control_F == 'M')
            {
                Metodos.EjecutarP("Actualizar", Parametros);

                MessageBox.Show("Registro actualizado con éxito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Metodos.Limpiar(gpbjornada);

            Close();
        }
    }
}
