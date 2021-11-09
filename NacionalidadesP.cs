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
        public NacionalidadesP()
        {
            InitializeComponent();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            F1 = "";
            F2 = "";

            if (rbNacionalidades.Checked) F1 = "Nacionalidades";
            if (rbFech_Reg.Checked) F1 = "Fecha de Registro";
            if (RbOrdenarNacionalidades.Checked) F2 = "Nacionalidades";
            if (RbOrdenarFech_Reg.Checked) F2 = "Fecha de Registro";

            SQL = String.Format("SELECT * FROM Nacionalidades WHERE {0} LIKE '%{1}%' ORDER BY {2}", F1, txtBuscar.Text, F2);

            Datos.Clear();
            Datos = Metodos.Mostrar(SQL);

            gridNacionalidades.DataSource = Datos;

        }

        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            Metodos.Control_F = 'A';
            formulario.FormClosed += new FormClosedEventHandler(NacionalidadesP_FormClosed);
            formulario.ShowDialog();

        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {
            Metodos.Control_F = 'M';
            Metodos.Control_CS = gridNacionalidades.Rows[gridNacionalidades.CurrentRow.Index].Cells[0].Value.ToString();

            formulario.FormClosed += new FormClosedEventHandler(NacionalidadesP_FormClosed);
            formulario.ShowDialog();

        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Eliminar el registro actual?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string Codigo = gridNacionalidades.Rows[gridNacionalidades.CurrentRow.Index].Cells[0].Value.ToString();

                MySqlParameter[] param = new MySqlParameter[] { new MySqlParameter("@COD", Codigo) };

                Metodos.EjecutarP("Eliminar_Nacionalidades", param);
                MessageBox.Show("Registro Eliminado Con Exito");

                RefrescarDatos();
            }
        }

        private void cmdExportar_Click(object sender, EventArgs e)
        {
                Metodos.ExportarExcel(gridNacionalidades);
            }

        private void cmdImprimir_Click(object sender, EventArgs e)
        {
            Rep_Individual_Nacionalidades R = new Rep_Individual_Nacionalidades();
            string SQL = String.Format("SELECT * FROM Nacionalidades WHERE COD = '{0}'", gridNacionalidades.Rows[gridNacionalidades.CurrentRow.Index].Cells[0].Value.ToString());

            Metodos.Imprimir_Reporte(SQL, "Nacionalidades", R);

        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NacionalidadesP_Load(object sender, EventArgs e)
        {

        }
    }
}
