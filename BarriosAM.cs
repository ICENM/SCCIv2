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
    public partial class BarriosAM : Form
    {
        public BarriosAM()
        {
            InitializeComponent();
        }

        private void BarriosAM_Load(object sender, EventArgs e)
        {

            Metodos.Limpiar(gpdDatosBarrios);

            if (Metodos.Control_F == 'A')
            {
                this.Text = "Barrios - Nuevo";
            }

            if (Metodos.Control_F == 'M')
            {

                this.Text = "Barrios - Actualizar";

                MySqlDataReader Lector = Metodos.LectorConsulta(String.Format("SELECT * FROM Barrios WHERE CLAVE = '{0}'", Metodos.Control_CS));

                if (Lector.HasRows)
                {
                    while (Lector.Read())
                    {
                        txtClave.Text = Lector.GetString(0);
                        txtBarrio.Text = Lector.GetString(1);
                        txtFecha.Value = Lector.GetDateTime(2);
                        cboActivo.Text = Lector.GetString(3);
                    }
                }
            }
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (Metodos.Validar(gpdDatosBarrios)) return;

            MySqlParameter[] Parametros = new MySqlParameter[]
            {
                new MySqlParameter("@CLA", txtClave.Text),
                new MySqlParameter("@BAR", txtBarrio.Text),
                new MySqlParameter("@FEC_RE", txtFecha.Value),
                new MySqlParameter("@ACT", cboActivo.Text),
            };

            if (Metodos.Control_F == 'A')
            {
                Metodos.EjecutarP("Agregar_Barrios", Parametros);

                MessageBox.Show("Registro guardado con éxito", "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (Metodos.Control_F == 'M')
            {
                Metodos.EjecutarP("Actualizar_Barrios", Parametros);

                MessageBox.Show("Registro actualizado con éxito", "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Metodos.Limpiar(gpdDatosBarrios);

            Close();
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Metodos.Control_F = ' ';
        }
    }
}
