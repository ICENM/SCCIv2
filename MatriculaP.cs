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
    public partial class MatriculaP : Form
    {
        DataTable Datos = new DataTable();
        MatriculaAM formulario = new MatriculaAM();

        private void RefrescarDatos()
        {
            Datos.Clear();
            Datos = Metodos.Mostrar("SELECT * FROM MATRICULA");

            gridMatricula.DataSource = Datos;
        }

        private void formulario_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefrescarDatos();
        }

        public MatriculaP()
        {
            InitializeComponent();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string F1, F2, SQL;

            F1 = "";
            F2 = "";

            if (rbCodigo.Checked) F1 = "CODIGO";
            if (rbGrado.Checked) F1 = "GRADO";
            if (rbAlumno.Checked) F1 = "ALUMNO";
            if (rbOrdenarCodigo.Checked) F2 = "CODIGO";
            if (rbOrdenarGrado.Checked) F2 = "MATRICULA";
            if(rbOrdenarAlumno.Checked) F2 = "ALUMNO";

            SQL = String.Format("SELECT * FROM MATRICULA WHERE {0} LIKE '%{1}%' ORDER BY {2}", F1, txtBuscar.Text, F2);

            Datos.Clear();
            Datos = Metodos.Mostrar(SQL);

            gridMatricula.DataSource = Datos;
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
            Metodos.Control_CS = gridMatricula.Rows[gridMatricula.CurrentRow.Index].Cells[0].Value.ToString();

            formulario.FormClosed += new FormClosedEventHandler(formulario_FormClosed);
            formulario.ShowDialog();
        }

        private void cmdExportar_Click(object sender, EventArgs e)
        {
            Metodos.ExportarExcel(gridMatricula);
        }

        private void cmdImprimir_Click(object sender, EventArgs e)
        {
            Rep_Ind_Matricula R = new Rep_Ind_Matricula();

            string SQL = String.Format("SELECT * FROM MATRICULA WHERE CODIGO = '{0}'", gridMatricula.Rows[gridMatricula.CurrentRow.Index].Cells[0].Value.ToString());

            Metodos.Imprimir_Reporte(SQL, "MATRICULA", R);
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MatriculaP_Load(object sender, EventArgs e)
        {
            RefrescarDatos();
        }
    }
}
