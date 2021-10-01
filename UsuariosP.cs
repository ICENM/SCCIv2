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
    public partial class UsuariosP : Form
    {
        DataTable Datos = new DataTable();
        UsuariosAM formulario = new UsuariosAM();

        private void RefrescarDatos()
        {
            Datos.Clear();
            Datos = Metodos.Mostrar("SELECT * FROM Usuarios");

            gridLogin.DataSource = Datos;
        }

        private void formulario_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefrescarDatos();
        }

        public UsuariosP()
        {
            InitializeComponent();
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            string F1, F2, SQL;

            F1 = "";
            F2 = "";

            if (rbCodigo.Checked) F1 = "CODIGO";
            if (rbUsuario.Checked) F1 = "USUARIO";
            if (rbNivel.Checked) F1 = "NIVEL";
            if (rbOrdenarCodigo.Checked) F2 = "CODIGO";
            if (rbOrdenarUsuario.Checked) F2 = "USUARIO";
            if (rbOrdenarNivel.Checked) F2 = "NIVEL";

            SQL = String.Format("SELECT * FROM Usuarios WHERE {0} LIKE '%{1}%' ORDER BY {2}", F1, txtBuscar.Text, F2);

            Datos.Clear();
            Datos = Metodos.Mostrar(SQL);

            gridLogin.DataSource = Datos;
        }

        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            Metodos.Control_F = 'A';
            formulario.FormClosed += new FormClosedEventHandler(formulario_FormClosed);
            formulario.ShowDialog();
        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {
            Metodos.Control_F = 'M';
            Metodos.Control_CS = gridLogin.Rows[gridLogin.CurrentRow.Index].Cells[0].Value.ToString();

            formulario.FormClosed += new FormClosedEventHandler(formulario_FormClosed);
            formulario.ShowDialog();
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea realmente eliminar el registro seleccionado?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string CODIGO = gridLogin.Rows[gridLogin.CurrentRow.Index].Cells[0].Value.ToString();

                MySqlParameter[] Param = new MySqlParameter[] { new MySqlParameter("@COD", CODIGO) };

                Metodos.EjecutarP("Eliminar_Usuarios", Param);

                MessageBox.Show("Registro eliminado con éxito", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                RefrescarDatos();
            }
        }

        private void cmdExportar_Click(object sender, EventArgs e)
        {
            Metodos.ExportarExcel(gridLogin);
        }

        private void cmdImprimir_Click(object sender, EventArgs e)
        {
            Rep_Ind_Usuarios R = new Rep_Ind_Usuarios();

            string SQL = String.Format("SELECT * FROM Usuarios WHERE CODIGO = '{0}'", gridLogin.Rows[gridLogin.CurrentRow.Index].Cells[0].Value.ToString());

            Metodos.Imprimir_Reporte(SQL, "Usuarios", R);
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UsuariosP_Load(object sender, EventArgs e)
        {
            RefrescarDatos();
        }
    }
}
