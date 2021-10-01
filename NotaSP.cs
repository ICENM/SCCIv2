﻿using System;
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
    public partial class NotaSP : Form
    {
        DataTable Datos = new DataTable();
        NotaSAM formulario = new NotaSAM();

        private void RefrescarDatos()
        {
            Datos.Clear();
            Datos = Metodos.Mostrar("SELECT * FROM NotaS");

            gridNotaS.DataSource = Datos;
        }

        private void formulario_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefrescarDatos();
        }

        public NotaSP()
        {
            InitializeComponent();
        }

        private void NotaSP_Load(object sender, EventArgs e)
        {
            RefrescarDatos();
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            string F1, F2, SQL;

            F1 = "";
            F2 = "";

            if (rbCodigo.Checked) F1 = "CODIGO";
            if (rbAlumno.Checked) F1 = "ALUMNO";
            if (rbGrado.Checked) F1 = "GRADO";
            if (rbOrdenarCodigo.Checked) F2 = "CODIGO";
            if (rbOrdenarAlumno.Checked) F2 = "ALUMNO";
            if (rbOrdenarGrado.Checked) F2 = "GRADO";

            SQL = String.Format("SELECT * FROM NotaS WHERE {0} LIKE '%{1}%' ORDER BY {2}", F1, txtBuscar.Text, F2);

            Datos.Clear();
            Datos = Metodos.Mostrar(SQL);

            gridNotaS.DataSource = Datos;
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
            Metodos.Control_CS = gridNotaS.Rows[gridNotaS.CurrentRow.Index].Cells[0].Value.ToString();

            formulario.FormClosed += new FormClosedEventHandler(formulario_FormClosed);
            formulario.ShowDialog();
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea realmente eliminar el registro seleccionado?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string CODIGO = gridNotaS.Rows[gridNotaS.CurrentRow.Index].Cells[0].Value.ToString();

                MySqlParameter[] Param = new MySqlParameter[] { new MySqlParameter("@COD", CODIGO) };

                Metodos.EjecutarP("Eliminar_NotaS", Param);

                MessageBox.Show("Registro eliminado con éxito", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                RefrescarDatos();
            }
        }

        private void cmdExportar_Click(object sender, EventArgs e)
        {
            Metodos.ExportarExcel(gridNotaS);
        }

        private void cmdImprimir_Click(object sender, EventArgs e)
        {
            Rep_Ind_NotaS R = new Rep_Ind_NotaS();

            string SQL = String.Format("SELECT * FROM NotaS WHERE CODIGO = '{0}'", gridNotaS.Rows[gridNotaS.CurrentRow.Index].Cells[0].Value.ToString());

            Metodos.Imprimir_Reporte(SQL, "NotaS", R);
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
