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
    public partial class DepartamentosAM : Form
    {
        public DepartamentosAM()
        {
            InitializeComponent();
        }

        private void DepartamentosAM_Load(object sender, EventArgs e)
        {

            Metodos.Limpiar(gpbDepartamento);

            if (Metodos.Control_F == 'A')
            {
                this.Text = "Departamentos - Nuevo";
            }

            if (Metodos.Control_F == 'M')
            {

                this.Text = "Departamentos - Actualizar";

                MySqlDataReader Lector = Metodos.LectorConsulta(String.Format("SELECT * FROM Departamentos WHERE CLAVE = '{0}'", Metodos.Control_CS));

                if (Lector.HasRows)
                {
                    while (Lector.Read())
                    {
                        txtClave.Text = Lector.GetString(0);
                        txtDepa.Text = Lector.GetString(1);
                        txtFecha.Value = Lector.GetDateTime(2);
                        cboActivo.Text = Lector.GetString(3);
                    }
                }
            }
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (Metodos.Validar(gpbDepartamento)) return;

            MySqlParameter[] Parametros = new MySqlParameter[]
            {
                new MySqlParameter("@CLA", txtClave.Text),
                new MySqlParameter("@DEP", txtDepa.Text),
                new MySqlParameter("@FEC_RE", txtFecha.Value),

            };

            if (Metodos.Control_F == 'A')
            {
                Metodos.EjecutarP("Agregar_Departamentos", Parametros);

                MessageBox.Show("Registro guardado con éxito", "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (Metodos.Control_F == 'M')
            {
                Metodos.EjecutarP("Actualizar_Departamentos", Parametros);

                MessageBox.Show("Registro actualizado con éxito", "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Metodos.Limpiar(gpbDepartamento);

            Close();
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Metodos.Control_F = ' ';
        }
    }
}
