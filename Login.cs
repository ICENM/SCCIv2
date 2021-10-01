using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCCI
{
    public partial class Login : Form
    {
        private int veces = 0;
        private const int NumeroIntentos = 3;

        public Login()
        {
            InitializeComponent();
        }

        private void cboAceptar_Click(object sender, EventArgs e)
        {
            if (Metodos.ValidarF(this)) return;

            string SQL = String.Format("SELECT COUNT(*) FROM Usuarios WHERE USUARIO = '{0}' AND CONTRA = '{1}'", txtUsuario.Text, txtContra.Text);

            try
            {
                if (Metodos.Contar(SQL) > 0)
                {
                    SQL = String.Format("SELECT * FROM Usuarios WHERE USUARIO = '{0}' AND CONTRA = '{1}'", txtUsuario.Text, txtContra.Text);

                    MySql.Data.MySqlClient.MySqlDataReader Lec = Metodos.LectorConsulta(SQL);

                    if (Lec.HasRows)
                    {
                        while (Lec.Read())
                        {
                            Metodos.Cod_Log = Lec.GetInt32(0);
                            Metodos.Nombre_Usuario = Lec.GetString(1);
                            Metodos.Usuario_Log = Lec.GetString(2);
                            Metodos.Nivel_Usuario = Lec.GetString(4);
                        }
                    }

                    MessageBox.Show(String.Format("Bienvenido(a) al Sistema: {0}", Metodos.Nombre_Usuario), "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Principal f = new Principal();
                    f.Show();

                    this.Hide();
                }
                else
                {
                    if (veces < NumeroIntentos)
                        MessageBox.Show(String.Format("Quedan {0} intentos. Usuario o Contraseña incorrectos.", (NumeroIntentos - veces)), "Intente de Nuevo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        if (veces >= NumeroIntentos)
                        {
                            MessageBox.Show("A perdido la oportunidad de Ingresar a nuestra SUPER APLICACIÓN, intente más tarde.", "Lo sentimos :-(", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            Application.Exit();
                        }
                    }

                    txtUsuario.Clear();
                    txtContra.Clear();
                    txtUsuario.Focus();

                    veces++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
