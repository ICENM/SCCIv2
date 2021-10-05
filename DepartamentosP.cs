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
        string F1, F2, SQL;
        private void RefrescarDatos()
        {
            Datos.Clear();
            Datos = Metodos.Mostrar("SELECT * FROM Departamentos");

            gridDepartamentos.DataSource = Datos;
        }
        private void formulario_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefrescarDatos();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            F1 = "";
            F2 = "";

            if (rbDepartamentos.Checked) F1 = "Departamentos";
            if (rbFech_Reg.Checked) F1 = "Fecha de Registro";
            if (RbOrdenarDepartamentos.Checked) F2 = "Departamentos";
            if (RbOrdenarFech_Reg.Checked) F2 = "Fecha de Registro";

            SQL = String.Format("SELECT * FROM Departamentos WHERE {0} LIKE '%{1}%' ORDER BY {2}", F1, txtBuscar.Text, F2);

            Datos.Clear();
            Datos = Metodos.Mostrar(SQL);

            gridDepartamentos.DataSource = Datos;
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
            Metodos.Control_CS = gridDepartamentos.Rows[gridDepartamentos.CurrentRow.Index].Cells[0].Value.ToString();

            formulario.FormClosed += new FormClosedEventHandler(formulario_FormClosed);
            formulario.ShowDialog();
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Eliminar el registro actual?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string Codigo = gridDepartamentos.Rows[gridDepartamentos.CurrentRow.Index].Cells[0].Value.ToString();

                MySqlParameter[] param = new MySqlParameter[] { new MySqlParameter("@COD", Codigo) };

                Metodos.EjecutarP("Eliminar_Departamentos", param);
                MessageBox.Show("Registro Eliminado Con Exito");

                RefrescarDatos();
            }
        }

        private void cmdExportar_Click(object sender, EventArgs e)
        {
            Metodos.ExportarExcel(gridDepartamentos);
        }

        private void cmdImprimir_Click(object sender, EventArgs e)
        {
            Rep_Individual_Departamentos R = new Rep_Individual_Departamentos();
            string SQL = String.Format("SELECT * FROM Departamentos WHERE COD = '{0}'", gridDepartamentos.Rows[gridDepartamentos.CurrentRow.Index].Cells[0].Value.ToString());

            Metodos.Imprimir_Reporte(SQL, "Barrios", R);
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        public DepartamentosP()
        {
            InitializeComponent();
        }

        private void Departamentos_P_Load(object sender, EventArgs e)
        {
            RefrescarDatos();
        }
    }
}