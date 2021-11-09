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
    public partial class DepartamentosAM : Form
    {
        public DepartamentosAM()
        {
            InitializeComponent();
        }
    }

    if (Metodos.Control_F == 'M')
    {
        this.Text = "Departamentos = Actualizar";
        txtClave.Enabled = false;


        MySqlDataReader l = Metodos.LectorConsulta(String.Format("SELECT * FROM Departamentos WHERE Codigo ='{0}'", Metodos.Control_CS));


        if (l.HasRows)
        {
            while (l.Read())
            {
                txtClave.Text = l.GetString(0);
                gpoDepartamentos.Text = l.GetString(1);
                txtFecha_Reg.Text = l.GetString(2);
                gpoActivo.Text = l.GetString(3);


            }
        }
    }
}

private void cmdGuardar_Click(object sender, EventArgs e)
{
    if (Metodos.Validar(gpbDepartamentos)) return;


    MySqlParameter[] param = new MySqlParameter[]
    {
                new MySqlParameter("@COD",txtClave.Text),
                new MySqlParameter("@TIP", gpoDepartamentos.Text),
                new MySqlParameter("@FECH", txtFecha_Reg.Text),
                new MySqlParameter("@ACT", gpoActivo.Text),

    };

    if (Metodos.Control_F == 'A')
    {
        Metodos.EjecutarP("Agregar_Departamentos", param);
        MessageBox.Show("Registro Guardado con Exito", "Guardado");

    }
    if (Metodos.Control_F == 'M')
    {
        Metodos.EjecutarP("Actualizar_Departamentos", param);
        MessageBox.Show("Registro Actualizado con Exito", "Guardado");

    }

    Metodos.Limpiar(gpbDepartamentos);

    Close();
}

private void cmdCancelar_Click(object sender, EventArgs e)
{
    Close();
}
    }
}


