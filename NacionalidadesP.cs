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
    public partial class NacionalidadesP : Form
    {
        DataTable Datos = new DataTable();
        NacionalidadesAM formulario = new NacionalidadesAM();

        private void RefrescarDatos()
        {
            Datos.Clear();
            Datos = Metodos.Mostrar("Select * from Nacionalidades WHERE ACTIVO = 'S'");

            gridNacionalidades.DataSource = Datos;
        }

        private void formulario_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefrescarDatos();
        }

        public NacionalidadesP()
        {
            InitializeComponent();
        }

        private void NacionalidadesP_Load(object sender, EventArgs e)
        {
            RefrescarDatos();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string F1, F2, SQL;

            F1 = "";
            F2 = "";

            if (rbNacionalidad.Checked) F1 = "NACIONALIDAD";
            if (rbClave.Checked) F1 = "CLAVE";
            if (rbOrdenarNacionalidad.Checked) F2 = "NACIONALIDAD";
            if (rbOrdenarClave.Checked) F2 = "CLAVE";

            SQL = String.Format("SELECT * FROM Nacionalidades WHERE {0} LIKE '%{1}%' ORDER BY {2}", F1, txtBuscar.Text, F2);

            Datos.Clear();
            Datos = Metodos.Mostrar(SQL);

            gridNacionalidades.DataSource = Datos;
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
            Metodos.Control_CS = gridNacionalidades.Rows[gridNacionalidades.CurrentRow.Index].Cells[0].Value.ToString();

            formulario.FormClosed += new FormClosedEventHandler(formulario_FormClosed);
            formulario.ShowDialog();
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea realmente eliminar el registro seleccionado?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string CLAVE = gridNacionalidades.Rows[gridNacionalidades.CurrentRow.Index].Cells[0].Value.ToString();

                MySqlParameter[] Param = new MySqlParameter[] { new MySqlParameter("@CLA", CLAVE) };

                Metodos.EjecutarP("Eliminar_Nacionalidades", Param);

                MessageBox.Show("Registro eliminado con éxito", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                RefrescarDatos();
            }
        }

        private void cmdExportar_Click(object sender, EventArgs e)
        {
            Metodos.ExportarExcel(gridNacionalidades);
        }

        private void cmdImprimir_Click(object sender, EventArgs e)
        {
            Rep_Ind_Alumnos R = new Rep_Ind_Alumnos();

            string SQL = String.Format("SELECT * FROM Nacionalidades WHERE CLAVE = '{0}'", gridNacionalidades.Rows[gridNacionalidades.CurrentRow.Index].Cells[0].Value.ToString());

            Metodos.Imprimir_Reporte(SQL, "Nacionalidades", R);
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
