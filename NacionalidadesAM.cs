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
    public partial class NacionalidadesAM : Form
    {
        public NacionalidadesAM()
        {
            InitializeComponent();
        }

        private void Nacionalidades_AM_Load(object sender, EventArgs e)
        {
            Metodos.Limpiar(gpbNacionalidad);

            if (Metodos.Control_F == 'A')
            {
                this.Text = "Nacionalidades = Nuevo";
                txtClave.Enabled = true;
            }

            if (Metodos.Control_F == 'M')
            {
                this.Text = "Nacionalidades = Actualizar";
                txtClave.Enabled = false;


                MySqlDataReader l = Metodos.LectorConsulta(String.Format("SELECT * FROM Nacionalidades WHERE Codigo ='{0}'", Metodos.Control_CS));


                if (l.HasRows)
                {
                    while (l.Read())
                    {
                        txtClave.Text = l.GetString(0);
                        gpoNacionalidades.Text = l.GetString(1);
                        txtFecha_Reg.Text = l.GetString(2);
                        gpoActivo.Text = l.GetString(3);


                    }
                }
            }
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (Metodos.Validar(gpbNacionalidad)) return;


            MySqlParameter[] param = new MySqlParameter[]
            {
                new MySqlParameter("@COD",txtClave.Text),
                new MySqlParameter("@TIP", gpoNacionalidades.Text),
                new MySqlParameter("@FECH", txtFecha_Reg.Text),
                new MySqlParameter("@ACT", gpoActivo.Text),

            };

            if (Metodos.Control_F == 'A')
            {
                Metodos.EjecutarP("Agregar_Nacionalidades", param);
                MessageBox.Show("Registro Guardado con Exito", "Guardado");

            }
            if (Metodos.Control_F == 'M')
            {
                Metodos.EjecutarP("Actualizar_Nacionalidades", param);
                MessageBox.Show("Registro Actualizado con Exito", "Guardado");

            }

            Metodos.Limpiar(gpbNacionalidad);

            Close();
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
