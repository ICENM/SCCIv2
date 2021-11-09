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
    public partial class Evaluacion_AM : Form
    {
        public Evaluacion_AM()
        {
            InitializeComponent();
        }

        private void Evaluacion_AM_Load(object sender, EventArgs e)
        {
            Metodos.Limpiar(gbEvaluacion);

            if (Metodos.Control_F == 'A')
            {
                this.Text = "Evaluacion = Nuevo";
            }

            if (Metodos.Control_F == 'M')
            {
                this.Text = "Evaluacion = Actualizar";


                MySqlDataReader l = Metodos.LectorConsulta(String.Format("SELECT * FROM Evaluacion WHERE Codigo ='{0}'", Metodos.Control_CS));


                if (l.HasRows)
                {
                    while (l.Read())
                    {
                        txtCodigo.Text = l.GetString(0);
                        txtEvaluacion.Text = l.GetString(1);
                        dtpFechaRegistro.Value = l.GetDateTime(2);
                        cboActivo.Text = l.GetString(3);
                        
                    }
                }
            }
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (Metodos.Validar(gbEvaluacion)) return;


            MySqlParameter[] param = new MySqlParameter[]
            {
                new MySqlParameter("@COD",txtCodigo.Text),
                new MySqlParameter("@TIP", txtEvaluacion.Text),
                new MySqlParameter("@FECH", dtpFechaRegistro.Value),
                new MySqlParameter("@ACT", cboActivo.Text),

            };

            if (Metodos.Control_F == 'A')
            {
                Metodos.EjecutarP("Agregar_Evaluacion", param);
                MessageBox.Show("Registro Guardado con Exito", "Guardado");

            }
            if (Metodos.Control_F == 'M')
            {
                Metodos.EjecutarP("Actualizar_Evaluacion", param);
                MessageBox.Show("Registro Actualizado con Exito", "Guardado");

            }

            Metodos.Limpiar(gbEvaluacion);

            Close();
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Metodos.Control_F = ' ';
        }
    }
}
