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
            Datos = Metodos.Mostrar("Select * From Carreras WHERE ACTIVO = 'S'");

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
                string CODIGO = gridcarrera.Rows[gridcarrera.CurrentRow.Index].Cells[0].Value.ToString();

                MySqlParameter[] Par = new MySqlParameter[] { new MySqlParameter("@COD", CODIGO) };

                Metodos.EjecutarP("Eliminar_Carreras", Par);

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

            string SQL = String.Format("SELECT * FROM Carreras WHERE CODIGO = '{0}'", gridcarrera.Rows[gridcarrera.CurrentRow.Index].Cells[0].Value.ToString());

            Metodos.Imprimir_Reporte(SQL, "Carreras", R);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string F1, F2, SQL;

            F1 = "";
            F2 = "";

            if (rbcodigo.Checked) F1 = "CODIGO";
            if (rbcarrera.Checked) F1 = "CARRERA";
            if (rbordenarcodigo.Checked) F2 = "CODIGO";
            if (rbordenarcarrera.Checked) F2 = "CARRERA";

            SQL = String.Format("SELECT * FROM Carreras WHERE {0} LIKE '%{1}%' ORDER BY {2}", F1, txtBuscar.Text, F2);

            Datos.Clear();
            Datos = Metodos.Mostrar(SQL);

            gridcarrera.DataSource = Datos;
        }

        private void Carreras_Load_1(object sender, EventArgs e)
        {
            RefrescarDatos();
        }
    }
}
