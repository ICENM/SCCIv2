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
    public partial class Secciones_AM : Form
    {
        public Secciones_AM()
        {
            InitializeComponent();
        }

        private void Secciones_AM_Load(object sender, EventArgs e)
        {
            Metodos.Limpiar(gbDatosSecciones);

            if (Metodos.Control_F == 'A')
            {
                this.Text = "Secciones = Nuevo";
                txtCodigo.Enabled = true;
            }

            if (Metodos.Control_F == 'M')
            {
                this.Text = "Secciones = Actualizar";
                txtCodigo.Enabled = false;


                MySqlDataReader l = Metodos.LectorConsulta(String.Format("SELECT * FROM Secciones WHERE Codigo ='{0}'", Metodos.Control_CS));


                if (l.HasRows)
                {
                    while (l.Read())
                    {
                        txtCodigo.Text = l.GetString(0);
                        cbGrado.Text = l.GetString(1);
                        txtSeccion.Text = l.GetString(2);
                        dtpFechaRegistro.Text = l.GetString(3);
                        cbActivo.Text = l.GetString(4);


                    }
                }
            }
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (Metodos.Validar(gbDatosSecciones)) return;


            MySqlParameter[] param = new MySqlParameter[]
            {
                new MySqlParameter("@COD",txtCodigo.Text),
                new MySqlParameter("@GRA", cbGrado.Text),
                new MySqlParameter("@SEC", txtSeccion.Text),
                new MySqlParameter("@FECH", dtpFechaRegistro.Text),
                new MySqlParameter("@ACT", cbActivo.Text),


            };

            if (Metodos.Control_F == 'A')
            {
                Metodos.EjecutarP("Agregar_Secciones", param);
                MessageBox.Show("Registro Guardado con Exito", "Guardado");

            }
            if (Metodos.Control_F == 'M')
            {
                Metodos.EjecutarP("Actualizar_Seccionees", param);
                MessageBox.Show("Registro Actualizado con Exito", "Guardado");

            }

            Metodos.Limpiar(gbDatosSecciones);

            Close();
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
