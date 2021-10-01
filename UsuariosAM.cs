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
    public partial class UsuariosAM : Form
    {
        public UsuariosAM()
        {
            InitializeComponent();
        }

        private void UsuariosAM_Load(object sender, EventArgs e)
        {

            Metodos.Limpiar(gpbDatosUsuarios);

            if (Metodos.Control_F == 'A')
            {
                this.Text = "Usuarios - Nuevo";
            }

            if (Metodos.Control_F == 'M')
            {

                this.Text = "Usuarios - Actualizar";

                MySqlDataReader Lector = Metodos.LectorConsulta(String.Format("SELECT * FROM Usuarios WHERE CODIGO = '{0}'", Metodos.Control_CS));

                if (Lector.HasRows)
                {
                    while (Lector.Read())
                    {
                        txtCodigo.Text = Lector.GetString(0);
                        txtNombre.Text = Lector.GetString(1);
                        txtUsuario.Text = Lector.GetString(2);
                        txtContra.Text = Lector.GetString(3);
                        cboNivel.Text = Lector.GetString(4);
                        cboActivo.Text = Lector.GetString(5);

                    }
                }
            }
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (Metodos.Validar(gpbDatosUsuarios)) return;

            MySqlParameter[] Parametros = new MySqlParameter[]
            {
                new MySqlParameter("@COD", txtCodigo.Text),
                new MySqlParameter("@NOM", txtNombre.Text),
                new MySqlParameter("@USU", txtUsuario.Text),
                new MySqlParameter("@CON", txtContra.Text),
                new MySqlParameter("@NIV", cboNivel.Text),
                new MySqlParameter("@ACT", cboActivo.Text)
            };

            if (Metodos.Control_F == 'A')
            {
                Metodos.EjecutarP("Agregar_Usuarios", Parametros);

                MessageBox.Show("Registro guardado con éxito", "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (Metodos.Control_F == 'M')
            {
                Metodos.EjecutarP("Actualizar_Usuarios", Parametros);

                MessageBox.Show("Registro actualizado con éxito", "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Metodos.Limpiar(gpbDatosUsuarios);

            Close();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Metodos.Control_F = ' ';
        }
    }
}
