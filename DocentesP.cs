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
    public partial class DocentesP : Form
    {
        DataTable Datos = new DataTable();
        DocentesAM formulario = new DocentesAM();

        private void RefrescarDatos()
        {
            Datos.Clear();
            Datos = Metodos.Mostrar("SELECT * FROM Docentes");

            gridDocentes.DataSource = Datos;
        }

        private void formulario_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefrescarDatos();
        }

        public DocentesP()
        {
            InitializeComponent();
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            string F1, F2, SQL;

            F1 = "";
            F2 = "";

            if (rbDNI.Checked) F1 = "DNI";
            if (rbNombre.Checked) F1 = "NOMBRES";
            if (rbDireccion.Checked) F1 = "DIRECCION";
            if (rbOrdenarDNI.Checked) F2 = "DNI";
            if (rbOrdenarNombre.Checked) F2 = "NOMBRE";
            if (rbOrdenarDireccion.Checked) F2 = "DIRECCION";

            SQL = String.Format("SELECT * FROM NotaS WHERE {0} LIKE '%{1}%' ORDER BY {2}", F1, txtBuscar.Text, F2);

            Datos.Clear();
            Datos = Metodos.Mostrar(SQL);

            gridDocentes.DataSource = Datos;
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
            Metodos.Control_CS = gridDocentes.Rows[gridDocentes.CurrentRow.Index].Cells[0].Value.ToString();

            formulario.FormClosed += new FormClosedEventHandler(formulario_FormClosed);
            formulario.ShowDialog();
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea realmente eliminar el registro seleccionado?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string DNI = gridDocentes.Rows[gridDocentes.CurrentRow.Index].Cells[0].Value.ToString();

                MySqlParameter[] Param = new MySqlParameter[] { new MySqlParameter("@ID", DNI) };

                Metodos.EjecutarP("Eliminar_Docentes", Param);

                MessageBox.Show("Registro eliminado con éxito", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                RefrescarDatos();
            }
        }

        private void cmdExportar_Click(object sender, EventArgs e)
        {
            Metodos.ExportarExcel(gridDocentes);
        }

        private void cmdImprimir_Click(object sender, EventArgs e)
        {
            Rep_Ind_Docentes R = new Rep_Ind_Docentes();

            string SQL = String.Format("SELECT * FROM Docentes WHERE DNI = '{0}'", gridDocentes.Rows[gridDocentes.CurrentRow.Index].Cells[0].Value.ToString());

            Metodos.Imprimir_Reporte(SQL, "Docentes", R);
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DocentesP_Load(object sender, EventArgs e)
        {
            RefrescarDatos();
        }
    }
}
