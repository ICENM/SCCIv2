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
    public partial class NotaPP : Form
    {
        DataTable Datos = new DataTable();
        NotaPAM formulario = new NotaPAM();

        private void RefrescarDatos()
        {
            Datos.Clear();
            Datos = Metodos.Mostrar("SELECT * FROM NotaP WHERE ACTIVO = 'S'");

            gridNotapP.DataSource = Datos;
        }

        private void formulario_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefrescarDatos();
        }

        public NotaPP()
        {
            InitializeComponent();
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
            Metodos.Control_CS = gridNotapP.Rows[gridNotapP.CurrentRow.Index].Cells[0].Value.ToString();

            formulario.FormClosed += new FormClosedEventHandler(formulario_FormClosed);
            formulario.ShowDialog();
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea realmente eliminar el registro seleccionado?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string CODIGO = gridNotapP.Rows[gridNotapP.CurrentRow.Index].Cells[0].Value.ToString();

                MySqlParameter[] Param = new MySqlParameter[] { new MySqlParameter("@COD", CODIGO)};

                Metodos.EjecutarP("Eliminar_NotaP", Param);

                MessageBox.Show("Registro eliminado con éxito", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                RefrescarDatos();
            }
        }

        private void cmdExportar_Click(object sender, EventArgs e)
        {
            Metodos.ExportarExcel(gridNotapP);
        }

        private void cmdImprimir_Click(object sender, EventArgs e)
        {
            Rep_Ind_NotaP R = new Rep_Ind_NotaP();

            string SQL = String.Format("SELECT * FROM NotaP WHERE CODIGO = '{0}'", gridNotapP.Rows[gridNotapP.CurrentRow.Index].Cells[0].Value.ToString());

            Metodos.Imprimir_Reporte(SQL, "NotaP", R);
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NotaPP_Load(object sender, EventArgs e)
        {
            RefrescarDatos();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string F1, F2, SQL;

            F1 = "";
            F2 = "";

            if (rbCodigo.Checked) F1 = "CODIGO";
            if (rbMatricula.Checked) F1 = "MATRICULA";
            if (rbOrdenarCodigo.Checked) F2 = "CODIGO";
            if (rbOrdenarMatricula.Checked) F2 = "MATRICULA";

            SQL = String.Format("SELECT * FROM NotaP WHERE {0} LIKE '%{1}%' ORDER BY {2}", F1, txtBuscar.Text, F2);

            Datos.Clear();
            Datos = Metodos.Mostrar(SQL);

            gridNotapP.DataSource = Datos;
        }
    }
}
