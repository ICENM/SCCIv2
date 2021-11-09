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
    public partial class Periodos : Form
    {
        DataTable Datos = new DataTable();
        PeriodosAM formulario = new PeriodosAM();

        private void RefrescarDatos()
        {
            Datos.Clear();
            Datos = Metodos.Mostrar("Call Consultar_Todos");

            gridperiodos.DataSource = Datos;
        }

        private void formulario_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefrescarDatos();
        }

        public Periodos()
        {
            InitializeComponent();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Periodos_Load(object sender, EventArgs e)
        {
            RefrescarDatos();
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            string F1, F2, SQL;

            F1 = "";
            F2 = "";

            if (rbperiodo.Checked) F1 = "Periodo";
            if (rbfecha_registro.Checked) F1 = "Fecha Registro";

            if (rbordenarperiodo.Checked) F2 = "Periodo";
            if (rbordenarfecha_registro.Checked) F2 = "Fecha Registro";

            SQL = String.Format("SELECT * FROM Periodos WHERE {0} LIKE '%{1}%' ORDER BY {2}", F1, txtBuscar.Text, F2);

            Datos.Clear();
            Datos = Metodos.Mostrar(SQL);

            gridperiodos.DataSource = Datos;
        }

        private void cmdagregar_Click(object sender, EventArgs e)
        {
            Metodos.Control_F = 'A';
            formulario.FormClosed += new FormClosedEventHandler(formulario_FormClosed);
            formulario.ShowDialog();
        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {
            Metodos.Control_F = 'M';
            Metodos.Control_CS = gridperiodos.Rows[gridperiodos.CurrentRow.Index].Cells[0].Value.ToString();

            formulario.FormClosed += new FormClosedEventHandler(formulario_FormClosed);
            formulario.ShowDialog();
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea realmente eliminar el registro seleccionado?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string dni = gridperiodos.Rows[gridperiodos.CurrentRow.Index].Cells[0].Value.ToString();

                MySqlParameter[] Par = new MySqlParameter[] { new MySqlParameter("@Ident", dni) };

                Metodos.EjecutarP("Eliminar", Par);

                MessageBox.Show("Registro eliminado con éxito", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                RefrescarDatos();
            }
        }

        private void cmdExportar_Click(object sender, EventArgs e)
        {
            Metodos.ExportarExcel(gridperiodos);
        }

        private void cmdImprimir_Click(object sender, EventArgs e)
        {
            Rep_Ind_Periodos R = new Rep_Ind_Periodos();

            string SQL = String.Format("SELECT * FROM Periodos WHERE Id = '{0}'", gridperiodos.Rows[gridperiodos.CurrentRow.Index].Cells[0].Value.ToString());

            Metodos.Imprimir_Reporte(SQL, "Periodos", R);
        }

        private void rbordenarperiodo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbordenarfecha_registro_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbfecha_registro_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbperiodo_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
