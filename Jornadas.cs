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
    public partial class Jornadas : Form
    {
        DataTable Datos = new DataTable();
        JornadasAM formulario = new JornadasAM();

        private void RefrescarDatos()
        {
            Datos.Clear();
            Datos = Metodos.Mostrar("Call Consultar_Todos");

            gridjornada.DataSource = Datos;
        }

        private void formulario_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefrescarDatos();
        }

        public Jornadas()
        {
            InitializeComponent();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Jornadas_Load(object sender, EventArgs e)
        {
            RefrescarDatos();
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            string F1, F2, SQL;

            F1 = "";
            F2 = "";

            if (rbcodigo.Checked) F1 = "Codigo";
            if (rbjornada.Checked) F1 = "Jornada";

            if (rbordenarcodigo.Checked) F2 = "Codigo";
            if (rbordenarjornada.Checked) F2 = "Jornada";

            SQL = String.Format("SELECT * FROM Jornadas WHERE {0} LIKE '%{1}%' ORDER BY {2}", F1, txtBuscar.Text, F2);

            Datos.Clear();
            Datos = Metodos.Mostrar(SQL);

            gridjornada.DataSource = Datos;
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
            Metodos.Control_CS = gridjornada.Rows[gridjornada.CurrentRow.Index].Cells[0].Value.ToString();

            formulario.FormClosed += new FormClosedEventHandler(formulario_FormClosed);
            formulario.ShowDialog();
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea realmente eliminar el registro seleccionado?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string dni = gridjornada.Rows[gridjornada.CurrentRow.Index].Cells[0].Value.ToString();

                MySqlParameter[] Par = new MySqlParameter[] { new MySqlParameter("@Ident", dni) };

                Metodos.EjecutarP("Eliminar", Par);

                MessageBox.Show("Registro eliminado con éxito", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                RefrescarDatos();
            }
        }

        private void cmdExportar_Click(object sender, EventArgs e)
        {
            Metodos.ExportarExcel(gridjornada);
        }

        private void cmdImprimir_Click(object sender, EventArgs e)
        {
            Rep_Ind_Jornadas R = new Rep_Ind_Jornadas();

            string SQL = String.Format("SELECT * FROM Jornadas WHERE Id = '{0}'", gridjornada.Rows[gridjornada.CurrentRow.Index].Cells[0].Value.ToString());

            Metodos.Imprimir_Reporte(SQL, "Jornadas", R);
        }

        private void rbjornada_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbcodigo_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
