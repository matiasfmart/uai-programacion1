using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TpObligatorio
{
    public partial class Form1 : Form
    {
        Classlista nuevalista = new Classlista();
        public Form1()
        {
            InitializeComponent();
        }


        public void Mostrarlista()
        {
            int cantidad_alumnos = nuevalista.Cantidad;
            int i;
            string[] auxiliar = new string[cantidad_alumnos];
            auxiliar = nuevalista.DevolverCola();
            Lista.Items.Clear();
            if(cantidad_alumnos > 0)
            {
                for (i = 0; i < cantidad_alumnos; i++)
                {
                    Lista.Items.Add(auxiliar[i]);
                }
            }
            else
            {
                MessageBox.Show("No hay alumnos cargados","Error",MessageBoxButtons.OK);
            }
        }


        private void cargar_Click(object sender, EventArgs e)
        {
            if (ingreso_alumno.TextLength > 0)
            {
                Lista.Items.Clear();
                nuevalista.CargarAlumno(ingreso_alumno.Text);
                Mostrarlista();
                ingreso_alumno.Clear();
            }

        }

        private void ingreso_alumno_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lista_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void tope_Click(object sender, EventArgs e)
        {
            if(nuevalista.Cantidad == 0)
            {
                Lista.Items.Clear();
                MessageBox.Show("No hay alumnos cargados", "Error", MessageBoxButtons.OK);
            }
            else
            {
                Lista.Items.Clear();
                Lista.Items.Add(nuevalista.AlumnoTope());
            }
        }

        private void borrar_Click(object sender, EventArgs e)
        {
            Lista.Items.Clear();
            Lista.Items.Add(nuevalista.AlumnoTope());
            if (nuevalista.Cantidad == 0)
            {
                MessageBox.Show("No hay alumnos cargados", "Error", MessageBoxButtons.OK);
            }
            else
            {
                nuevalista.EliminarAlumno();
                Lista.Items.Clear();
                Mostrarlista();
            }
        }

        private void salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
