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
    public partial class AsignaturasP : Form
    {

        DataTable Datos = new DataTable();
        AsignaturasAM formulario = new AsignaturasAM();

        private void RefrescarDatos()
        {
            Datos.Clear();
            Datos = Metodos.Mostrar("SELECT * FROM Asignaturas WHERE ACTIVO = 'S'");

            gridAsignaturasP.DataSource = Datos;
        }

        private void formulario_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefrescarDatos();
        }

        public AsignaturasP()
        {
            InitializeComponent();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string F1, F2, SQL;

            F1 = "";
            F2 = "";

            if (rbCodigo.Checked) F1 = "CODIGO";
            if (rbAsignatura.Checked) F1 = "ASIGNATURA";
            if (rbDocente.Checked) F1 = "DOCENTE";
            if (rbOrdenarCodigo.Checked) F2 = "CODIGO";
            if (rbOrdenarAsignatura.Checked) F2 = "ASIGNATURA";
            if (rbOrdenarDocente.Checked) F2 = "DOCENTE";

            SQL = String.Format("SELECT * FROM Asignaturas WHERE {0} LIKE '%{1}%' ORDER BY {2}", F1, txtBuscar.Text, F2);

            Datos.Clear();
            Datos = Metodos.Mostrar(SQL);

            gridAsignaturasP.DataSource = Datos;
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
            Metodos.Control_CS = gridAsignaturasP.Rows[gridAsignaturasP.CurrentRow.Index].Cells[0].Value.ToString();

            formulario.FormClosed += new FormClosedEventHandler(formulario_FormClosed);
            formulario.ShowDialog();
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea realmente eliminar el registro seleccionado?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string CODIGO = gridAsignaturasP.Rows[gridAsignaturasP.CurrentRow.Index].Cells[0].Value.ToString();

                MySqlParameter[] Param = new MySqlParameter[] { new MySqlParameter("@COD", CODIGO) };

                Metodos.EjecutarP("Eliminar_Asignaturas", Param);

                MessageBox.Show("Registro eliminado con éxito", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                RefrescarDatos();
            }
        }

        private void cmdExportar_Click(object sender, EventArgs e)
        {
            Metodos.ExportarExcel(gridAsignaturasP);
        }

        private void cmdImprimir_Click(object sender, EventArgs e)
        {
            Rep_Ind_NotaP R = new Rep_Ind_NotaP();

            string SQL = String.Format("SELECT * FROM Asignaturas WHERE CODIGO = '{0}'", gridAsignaturasP.Rows[gridAsignaturasP.CurrentRow.Index].Cells[0].Value.ToString());

            Metodos.Imprimir_Reporte(SQL, "Asignaturas", R);
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AsignaturasP_Load(object sender, EventArgs e)
        {
            RefrescarDatos();
        }

        private void gridAsignaturasP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
