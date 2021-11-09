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
    public partial class MunicipiosP : Form
    {
        DataTable Datos = new DataTable();
        MunicipiosAM formulario = new MunicipiosAM();

        private void RefrescarDatos()
        {
            Datos.Clear();
            Datos = Metodos.Mostrar("Select * from Municipios WHERE ACTIVO = 'S'");

            gridMunicipios.DataSource = Datos;
        }

        private void formulario_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefrescarDatos();
        }

        public MunicipiosP()
        {
            InitializeComponent();
        }

        private void MunicipiosP_Load(object sender, EventArgs e)
        {
            RefrescarDatos();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string F1, F2, SQL;

            F1 = "";
            F2 = "";

            if (rbClave.Checked) F1 = "CLAVE";
            if (rbMunicipio.Checked) F1 = "MUNICIPIO";
            if (rbOrdenarClave.Checked) F2 = "CLAVE";
            if (rbOrdenarMunicipio.Checked) F2 = "MUNICIPIO";

            SQL = String.Format("SELECT * FROM Municipios WHERE {0} LIKE '%{1}%' ORDER BY {2}", F1, txtBuscar.Text, F2);

            Datos.Clear();
            Datos = Metodos.Mostrar(SQL);

            gridMunicipios.DataSource = Datos;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Metodos.Control_F = 'A';
            formulario.FormClosed += new FormClosedEventHandler(formulario_FormClosed);
            formulario.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Metodos.Control_F = 'M';
            Metodos.Control_CS = gridMunicipios.Rows[gridMunicipios.CurrentRow.Index].Cells[0].Value.ToString();

            formulario.FormClosed += new FormClosedEventHandler(formulario_FormClosed);
            formulario.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea realmente eliminar el registro seleccionado?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string CLAVE = gridMunicipios.Rows[gridMunicipios.CurrentRow.Index].Cells[0].Value.ToString();

                MySqlParameter[] Param = new MySqlParameter[] { new MySqlParameter("@CLA", CLAVE) };

                Metodos.EjecutarP("Eliminar_Municipios", Param);

                MessageBox.Show("Registro eliminado con éxito", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                RefrescarDatos();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Rep_Ind_Municipios R = new Rep_Ind_Municipios();

            string SQL = String.Format("SELECT * FROM Municipios WHERE CLAVE = '{0}'", gridMunicipios.Rows[gridMunicipios.CurrentRow.Index].Cells[0].Value.ToString());

            Metodos.Imprimir_Reporte(SQL, "Municipios", R);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Metodos.ExportarExcel(gridMunicipios);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
