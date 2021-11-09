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
    public partial class MunicipiosAM : Form
    {
        public MunicipiosAM()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void MunicipiosAM_Load(object sender, EventArgs e)
        {

            Metodos.Limpiar(gpbMunicipios);

            if (Metodos.Control_F == 'A')
            {

                this.Text = "Municipios - Nuevo";
            }

            if (Metodos.Control_F == 'M')
            {

                this.Text = "Municipios - Actualizar";

                MySqlDataReader Lector = Metodos.LectorConsulta(String.Format("SELECT * FROM Municipios WHERE CLAVE = '{0}'", Metodos.Control_CS));

                if (Lector.HasRows)
                {
                    while (Lector.Read())
                    {

                        txtClave.Text = Lector.GetString(0);
                        txtMunicipio.Text = Lector.GetString(1);
                        dateFecha_Registro.Value = Lector.GetDateTime(2);
                        combActivo.Text = Lector.GetString(3);
                    }
                }
            }
        }

        private void Guardarcmd_Click(object sender, EventArgs e)
        {
            if (Metodos.Validar(gpbMunicipios)) return;

            MySqlParameter[] Parametros = new MySqlParameter[]
            {

                new MySqlParameter("@CLA", txtClave.Text),
                new MySqlParameter("@MUN", txtMunicipio.Text),
                new MySqlParameter("@FEC_RE", dateFecha_Registro.Value),

            };

            if (Metodos.Control_F == 'A')
            {
                Metodos.EjecutarP("Agregar_Municipios", Parametros);

                MessageBox.Show("Registro guardado con éxito", "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (Metodos.Control_F == 'M')
            {
                Metodos.EjecutarP("Actualizar_Municipios", Parametros);

                MessageBox.Show("Registro actualizado con éxito", "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Metodos.Limpiar(gpbMunicipios);

            Close();
        }

        private void Cancelarcmd_Click(object sender, EventArgs e)
        {
            this.Close();
            Metodos.Control_F = ' ';
        }
    }
}
