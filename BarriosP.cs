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
    public partial class BarriosP : Form
    {
        DataTable Datos = new DataTable();
        BarriosAM formulario = new BarriosAM();
        string F1, F2, SQL;
        private void RefrescarDatos()
        {
            Datos.Clear();
            Datos = Metodos.Mostrar("SELECT * FROM Barrios");

            gridBarrios.DataSource = Datos;
        }
        private void formulario_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefrescarDatos();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            F1 = "";
            F2 = "";

            if (rbBarrios.Checked) F1 = "Barrios";
            if (rbFech_Reg.Checked) F1 = "Fecha de Registro";
            if (RbOrdenarBarrios.Checked) F2 = "Barrios";
            if (RbOrdenarFech_Reg.Checked) F2 = "Fecha de Registro";

            SQL = String.Format("SELECT * FROM Barrios WHERE {0} LIKE '%{1}%' ORDER BY {2}", F1, txtBuscar.Text, F2);

            Datos.Clear();
            Datos = Metodos.Mostrar(SQL);

            gridBarrios.DataSource = Datos;
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
            Metodos.Control_CS = gridBarrios.Rows[gridBarrios.CurrentRow.Index].Cells[0].Value.ToString();

            formulario.FormClosed += new FormClosedEventHandler(formulario_FormClosed);
            formulario.ShowDialog();
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Eliminar el registro actual?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string Codigo = gridBarrios.Rows[gridBarrios.CurrentRow.Index].Cells[0].Value.ToString();

                MySqlParameter[] param = new MySqlParameter[] { new MySqlParameter("@COD", Codigo) };

                Metodos.EjecutarP("Eliminar_Barrios", param);
                MessageBox.Show("Registro Eliminado Con Exito");

                RefrescarDatos();
            }
        }

        private void cmdExportar_Click(object sender, EventArgs e)
        {
            Metodos.ExportarExcel(gridBarrios);
        }

        private void cmdImprimir_Click(object sender, EventArgs e)
        {
            Rep_Individual_Barrios R = new Rep_Individual_Barrios();
            string SQL = String.Format("SELECT * FROM Barrios WHERE COD = '{0}'", gridBarrios.Rows[gridBarrios.CurrentRow.Index].Cells[0].Value.ToString());

            Metodos.Imprimir_Reporte(SQL, "Barrios", R);
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        public BarriosP()
        {
            InitializeComponent();
        }

        private void Barrios_P_Load(object sender, EventArgs e)
        {
            RefrescarDatos();
        }
    }
}
