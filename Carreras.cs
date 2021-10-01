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
    public partial class Carreras : Form
    {
        DataTable Datos = new DataTable();
        CarrerasAM formulario = new CarrerasAM();

        private void RefrescarDatos()
        {
            Datos.Clear();
            Datos = Metodos.Mostrar("Call Consultar_Todos");

            gridcarrera.DataSource = Datos;
        }

        private void formulario_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefrescarDatos();
        }

        public Carreras()
        {
            InitializeComponent();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Carreras_Load(object sender, EventArgs e)
        {
            RefrescarDatos();
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            string F1, F2, SQL;

            F1 = "";
            F2 = "";

            if (rbcodigo.Checked) F1 = "Codigo";
            if (rbcarrera.Checked) F1 = "Carrera";

            if (rbordenarcodigo.Checked) F2 = "Codigo";
            if (rbordenarcarrera.Checked) F2 = "Carrera";

            SQL = String.Format("SELECT * FROM Carreras WHERE {0} LIKE '%{1}%' ORDER BY {2}", F1, txtBuscar.Text, F2);

            Datos.Clear();
            Datos = Metodos.Mostrar(SQL);

            gridcarrera.DataSource = Datos;
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
            Metodos.Control_CS = gridcarrera.Rows[gridcarrera.CurrentRow.Index].Cells[0].Value.ToString();

            formulario.FormClosed += new FormClosedEventHandler(formulario_FormClosed);
            formulario.ShowDialog();
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea realmente eliminar el registro seleccionado?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string dni = gridcarrera.Rows[gridcarrera.CurrentRow.Index].Cells[0].Value.ToString();

                MySqlParameter[] Par = new MySqlParameter[] { new MySqlParameter("@Ident", dni) };

                Metodos.EjecutarP("Eliminar", Par);

                MessageBox.Show("Registro eliminado con éxito", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                RefrescarDatos();
            }
        }

        private void cmdExportar_Click(object sender, EventArgs e)
        {
            Metodos.ExportarExcel(gridcarrera);
        }

        private void cmdImprimir_Click(object sender, EventArgs e)
        {
            Rep_Ind_Carreras R = new Rep_Ind_Carreras();

            string SQL = String.Format("SELECT * FROM Carreras WHERE Id = '{0}'", gridcarrera.Rows[gridcarrera.CurrentRow.Index].Cells[0].Value.ToString());

            Metodos.Imprimir_Reporte(SQL, "Carreras", R);
        }
    }
}
