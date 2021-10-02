using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCCI
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void docentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rep_Gen_Docentes Rep = new Rep_Gen_Docentes();

            string SQL = "SELECT * FROM Vista_Docentes";

            Metodos.Imprimir_Reporte(SQL, "Docentes_General", Rep);
        }
    }
}
