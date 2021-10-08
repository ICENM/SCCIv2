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

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void matriculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MatriculaP SCCI = new MatriculaP();
            SCCI.MdiParent = this;
            SCCI.Show();
        }

        private void notasSemestreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NotaSP SCCI = new NotaSP();
            SCCI.MdiParent = this;
            SCCI.Show();
        }

        private void notasParcialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NotaPP SCCI = new NotaPP();
            SCCI.MdiParent = this;
            SCCI.Show();
        }

        private void alumnosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AlumnosP SCCI = new AlumnosP();
            SCCI.MdiParent = this;
            SCCI.Show();
        }

        private void padresEncargadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Padre_Encargado SCCI = new Padre_Encargado();
            SCCI.MdiParent = this;
            SCCI.Show();
        }

        private void perfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Perfil_AlumnoP SCCI = new Perfil_AlumnoP();
            SCCI.MdiParent = this;
            SCCI.Show();
        }

        private void evaluaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Evaluacion_P SCCI = new Evaluacion_P();
            SCCI.MdiParent = this;
            SCCI.Show();
        }

        private void periodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Periodos SCCI = new Periodos();
            SCCI.MdiParent = this;
            SCCI.Show();
        }

        private void jornadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Jornadas SCCI = new Jornadas();
            SCCI.MdiParent = this;
            SCCI.Show();
        }

        private void nacionalidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NacionalidadesP SCCI = new NacionalidadesP();
            SCCI.MdiParent = this;
            SCCI.Show();
        }

        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DepartamentosP SCCI = new DepartamentosP();
            SCCI.MdiParent = this;
            SCCI.Show();
        }

        private void barriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BarriosP SCCI = new BarriosP();
            SCCI.MdiParent = this;
            SCCI.Show();
        }

        private void municipiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MunicipiosP SCCI = new MunicipiosP();
            SCCI.MdiParent = this;
            SCCI.Show();
        }

        private void seccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Secciones_P SCCI = new Secciones_P();
            SCCI.MdiParent = this;
            SCCI.Show();
        }

        private void gradosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Grados_P SCCI = new Grados_P();
            SCCI.MdiParent = this;
            SCCI.Show();
        }

        private void carrerasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Carreras SCCI = new Carreras();
            SCCI.MdiParent = this;
            SCCI.Show();
        }

        private void asignaturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AsignaturasP SCCI = new AsignaturasP();
            SCCI.MdiParent = this;
            SCCI.Show();
        }

        private void docentesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DocentesP SCCI = new DocentesP();
            SCCI.MdiParent = this;
            SCCI.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuariosP SCCI = new UsuariosP();
            SCCI.MdiParent = this;
            SCCI.Show();
        }

        private void alumnosToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Rep_Gen_Alumnos Rep = new Rep_Gen_Alumnos();

            string SQL = "SELECT * FROM Vista_Alumnos";

            Metodos.Imprimir_Reporte(SQL, "Alumnos_General", Rep);
        }
    }
}
