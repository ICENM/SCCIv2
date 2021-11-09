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
    public partial class DepartamentosP : Form
    {
        DataTable Datos = new DataTable();
        DepartamentosAM formulario = new DepartamentosAM();

        private void RefrescarDatos()
        {
            Datos.Clear();
            Datos = Metodos.Mostrar("SELECT * FROM Departamentos WHERE ACTIVO = 'S'");

            gridDepartamento.DataSource = Datos;
        }

        private void formulario_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefrescarDatos();
        }

        public DepartamentosP()
        {
            InitializeComponent();
        }

        private void Departamentos_Load(object sender, EventArgs e)
        {
            RefrescarDatos();

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string F1, F2, SQL;

            F1 = "";
            F2 = "";

            if (rbClave.Checked) F1 = "CLAVE";
            if (rbOrdenarDepa.Checked) F1 = "DEPARTAMENTO";
            if (rbClave.Checked) F2 = "CLAVE";
            if (rbOrdenarDepa.Checked) F2 = "DEPARTAENTO";

            SQL = String.Format("SELECT * FROM Departamentos WHERE {0} LIKE '%{1}%' ORDER BY {2}", F1, txtBuscar.Text, F2);

            Datos.Clear();
            Datos = Metodos.Mostrar(SQL);

            gridDepartamento.DataSource = Datos;
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
            Metodos.Control_CS = gridDepartamento.Rows[gridDepartamento.CurrentRow.Index].Cells[0].Value.ToString();

            formulario.FormClosed += new FormClosedEventHandler(formulario_FormClosed);
            formulario.ShowDialog();
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea realmente eliminar el registro seleccionado?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string CLAVE = gridDepartamento.Rows[gridDepartamento.CurrentRow.Index].Cells[0].Value.ToString();

                MySqlParameter[] Param = new MySqlParameter[] { new MySqlParameter("@CLA", CLAVE) };

                Metodos.EjecutarP("Eliminar_Departamentos", Param);

                MessageBox.Show("Registro eliminado con éxito", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                RefrescarDatos();
            }
        }

        private void cmdExportar_Click(object sender, EventArgs e)
        {
            Metodos.ExportarExcel(gridDepartamento);
        }

        private void cmdImprimir_Click(object sender, EventArgs e)
        {
            Rep_Ind_NotaP R = new Rep_Ind_NotaP();

            string SQL = String.Format("SELECT * FROM Departamentos WHERE CLAVE = '{0}'", gridDepartamento.Rows[gridDepartamento.CurrentRow.Index].Cells[0].Value.ToString());

            Metodos.Imprimir_Reporte(SQL, "Departamentos", R);
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
