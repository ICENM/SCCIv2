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

        private void ComprasdetAM_Load(object sender, EventArgs e)
        {
            Metodos.Limpiar(gpbcarrera);

            if (Metodos.Control_F == 'A')
            {
                this.Text = "Carrera - Nuevo";
                txtcodigo.Enabled = true;
            }

            if (Metodos.Control_F == 'M')
            {
                this.Text = "Carreras - Actualizar";
                txtcodigo.Enabled = false;

                MySqlDataReader Lector = Metodos.LectorConsulta(String.Format("SELECT * FROM Carreras WHERE Id = '{0}'", Metodos.Control_CS));

                if (Lector.HasRows)
                {
                    while (Lector.Read())
                    {
                        txtcodigo.Text = Lector.GetString(0);
                        txtcarrera.Text = Lector.GetString(1);
                        dtfecha_registro.Text = Lector.GetString(2);
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
            if (Metodos.Validar(gpbcarrera)) return;

            MySqlParameter[] Parametros = new MySqlParameter[]
            {
                new MySqlParameter("@Cod", txtcodigo.Text),
                new MySqlParameter("@Car", txtcarrera.Text),
                new MySqlParameter("@Fec", dtfecha_registro.Text),
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

            Metodos.Limpiar(gpbcarrera);

            Close();
        }
    }
}
