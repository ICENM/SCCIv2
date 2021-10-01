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
    public partial class Secciones_P : Form
    {
        DataTable Datos = new DataTable();
        Secciones_AM formulario = new Secciones_AM();
        string F1, F2, SQL;
        private void RefrescarDatos()
        {
            Datos.Clear();
            Datos = Metodos.Mostrar("SELECT * FROM Secciones");

            dgvSecciones.DataSource = Datos;
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
            if (rbSeccion.Checked) F1 = "Seccion";
            if (rbOrdenarCodigo.Checked) F2 = "Codigo";
            if (rbOrdenarGrado.Checked) F2 = "Grado";
            if (rbOrdenarSeccion.Checked) F2 = "Seccion";

            SQL = String.Format("SELECT * FROM Secciones WHERE {0} LIKE '%{1}%' ORDER BY {2}", F1, txtBuscar.Text, F2);

            Datos.Clear();
            Datos = Metodos.Mostrar(SQL);

            dgvSecciones.DataSource = Datos;
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
            Metodos.Control_CS = dgvSecciones.Rows[dgvSecciones.CurrentRow.Index].Cells[0].Value.ToString();

            formulario.FormClosed += new FormClosedEventHandler(formulario_FormClosed);
            formulario.ShowDialog();
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Eliminar el registro actual?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string Codigo = dgvSecciones.Rows[dgvSecciones.CurrentRow.Index].Cells[0].Value.ToString();

                MySqlParameter[] param = new MySqlParameter[] { new MySqlParameter("@COD", Codigo) };

                Metodos.EjecutarP("Eliminar_Secciones", param);
                MessageBox.Show("Registro Eliminado Con Exito");

                RefrescarDatos();
            }
        }

        private void cmdExportar_Click(object sender, EventArgs e)
        {
            Metodos.ExportarExcel(dgvSecciones);
        }

        private void cmdImprimir_Click(object sender, EventArgs e)
        {
            Rep_Ind_Secciones c = new Rep_Ind_Secciones();
            string SQL = String.Format("SELECT * FROM Secciones WHERE COD = '{0}'", dgvSecciones.Rows[dgvSecciones.CurrentRow.Index].Cells[0].Value.ToString());

            Metodos.Imprimir_Reporte(SQL, "Secciones", c);
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        public Secciones_P()
        {
            InitializeComponent();
        }


        private void Secciones_P_Load(object sender, EventArgs e)
        {
            RefrescarDatos();
        }
    }
}
