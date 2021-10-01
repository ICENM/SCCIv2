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
    public partial class Grados_P : Form
    {
        DataTable Datos = new DataTable();
        Grados_AM formulario = new Grados_AM();
        string F1, F2, SQL;
        private void RefrescarDatos()
        {
            Datos.Clear();
            Datos = Metodos.Mostrar("SELECT * FROM Grados");

            dgvGrados.DataSource = Datos;
        }
        private void formulario_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefrescarDatos();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            F1 = "";
            F2 = "";

            if (rbCodigo.Checked) F1 = "Codigo";
            if (rbGrado.Checked) F1 = "Grado";
            if (rbFecha.Checked) F1 = "Fecha";
            if (rbOrdenarCodigo.Checked) F2 = "Codigo";
            if (rbOrdenarGrado.Checked) F2 = "Grado";
            if (rbOrdenarFecha.Checked) F2 = "Fecha";

            SQL = String.Format("SELECT * FROM Grados WHERE {0} LIKE '%{1}%' ORDER BY {2}", F1, txtBuscar.Text, F2);

            Datos.Clear();
            Datos = Metodos.Mostrar(SQL);

            dgvGrados.DataSource = Datos;
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            Metodos.Control_F = 'A';
            formulario.FormClosed += new FormClosedEventHandler(formulario_FormClosed);
            formulario.ShowDialog();
        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {
            Metodos.Control_F = 'M';
            Metodos.Control_CS = dgvGrados.Rows[dgvGrados.CurrentRow.Index].Cells[0].Value.ToString();

            formulario.FormClosed += new FormClosedEventHandler(formulario_FormClosed);
            formulario.ShowDialog();
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Eliminar el registro actual?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string Codigo = dgvGrados.Rows[dgvGrados.CurrentRow.Index].Cells[0].Value.ToString();

                MySqlParameter[] param = new MySqlParameter[] { new MySqlParameter("@COD", Codigo) };

                Metodos.EjecutarP("Eliminar_Grados", param);
                MessageBox.Show("Registro Eliminado Con Exito");

                RefrescarDatos();
            }
        }

        private void cmdExportar_Click(object sender, EventArgs e)
        {
            Metodos.ExportarExcel(dgvGrados);
        }

        private void cmdImprimir_Click(object sender, EventArgs e)
        {
            Rep_Ind_Grados g = new Rep_Ind_Grados();
            string SQL = String.Format("SELECT * FROM Grados WHERE COD = '{0}'", dgvGrados.Rows[dgvGrados.CurrentRow.Index].Cells[0].Value.ToString());

            Metodos.Imprimir_Reporte(SQL, "Grados", g);
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        public Grados_P()
        {
            InitializeComponent();
        }

        private void Grados_P_Load(object sender, EventArgs e)
        {
            RefrescarDatos();
        }
    }
}
