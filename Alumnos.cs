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
    public partial class AlumnosP : Form
    {
        DataTable Datos = new DataTable();
        AlumnoAM formulario = new AlumnoAM();

        private void RefrescarDatos()
        {
            Datos.Clear();
            Datos = Metodos.Mostrar("Select * from Alumnos WHERE ACTIVO = 'S'");

            gridAlumnos.DataSource = Datos;
        }

        private void formulario_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefrescarDatos();
        }

        public AlumnosP()
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
            Metodos.Control_CS = gridAlumnos.Rows[gridAlumnos.CurrentRow.Index].Cells[0].Value.ToString();

            formulario.FormClosed += new FormClosedEventHandler(formulario_FormClosed);
            formulario.ShowDialog();
        }

        private void cmdELiminar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Desea realmente eliminar el registro seleccionado?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string DNI = gridAlumnos.Rows[gridAlumnos.CurrentRow.Index].Cells[0].Value.ToString();

                MySqlParameter[] Param = new MySqlParameter[] { new MySqlParameter("@ID", DNI) };

                Metodos.EjecutarP("Eliminar_Alumnos", Param);

                MessageBox.Show("Registro eliminado con éxito", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                RefrescarDatos();
            }
        }

        private void cmdExportar_Click(object sender, EventArgs e)
        {
            Metodos.ExportarExcel(gridAlumnos);
        }

        private void cmdImprimir_Click(object sender, EventArgs e)
        {
            Rep_Ind_Alumnos R = new Rep_Ind_Alumnos();

            string SQL = String.Format("SELECT * FROM Alumnos WHERE DNI = '{0}'", gridAlumnos.Rows[gridAlumnos.CurrentRow.Index].Cells[0].Value.ToString());

            Metodos.Imprimir_Reporte(SQL, "Alumnos", R);
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AlumnosP_Load(object sender, EventArgs e)
        {
            RefrescarDatos();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string F1, F2, SQL;

            F1 = "";
            F2 = "";

            if (rbDNI.Checked) F1 = "DNI";
            if (rbNombre.Checked) F1 = "NOMBRE";
            if (rbDireccion.Checked) F1 = "DIRECCION";
            if (rbOrdenarDNI.Checked) F2 = "DNI";
            if (rbOrdenarNombre.Checked) F2 = "NOMBRE";
            if (rbOrdenarDireccion.Checked) F2 = "DIRECCION";

            SQL = String.Format("SELECT * FROM Alumnos WHERE {0} LIKE '%{1}%' ORDER BY {2}", F1, txtBuscar.Text, F2);

            Datos.Clear();
            Datos = Metodos.Mostrar(SQL);

            gridAlumnos.DataSource = Datos;
        }
    }
}
