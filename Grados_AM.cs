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
    public partial class Grados_AM : Form
    {
        public Grados_AM()
        {
            InitializeComponent();
        }

        private void Grados_AM_Load(object sender, EventArgs e)
        {
            Metodos.Limpiar(gbGrados);

            if (Metodos.Control_F == 'A')
            {
                this.Text = "Grados = Nuevo";
            }

            if (Metodos.Control_F == 'M')
            {
                this.Text = "Grados = Actualizar";


                MySqlDataReader l = Metodos.LectorConsulta(String.Format("SELECT * FROM Grados WHERE Codigo ='{0}'", Metodos.Control_CS));


                if (l.HasRows)
                {
                    while (l.Read())
                    {
                        txtCodigo.Text = l.GetString(0);
                        txtGrado.Text = l.GetString(1);
                        dtpFechaRegistro.Value = l.GetDateTime(2);
                        cbActivo.Text = l.GetString(3);


                    }
                }
            }
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (Metodos.Validar(gbGrados)) return;


            MySqlParameter[] param = new MySqlParameter[]
            {
                new MySqlParameter("@COD",txtCodigo.Text),
                new MySqlParameter("@GRA", txtGrado.Text),
                new MySqlParameter("@FECH", dtpFechaRegistro.Value),
                new MySqlParameter("@ACT", cbActivo.Text),


            };

            if (Metodos.Control_F == 'A')
            {
                Metodos.EjecutarP("Agregar_Grados", param);
                MessageBox.Show("Registro Guardado con Exito", "Guardado");

            }
            if (Metodos.Control_F == 'M')
            {
                Metodos.EjecutarP("Actualizar_Grados", param);
                MessageBox.Show("Registro Actualizado con Exito", "Guardado");

            }

            Metodos.Limpiar(gbGrados);

            Close();
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
