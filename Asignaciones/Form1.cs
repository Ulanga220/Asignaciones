using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asignaciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string programador_seleccionado = "";
        List<Defectos> Lista_defectos = new List<Defectos>();

        /// funcion para validar fecha
        private bool validarFecha(string f)
        {
            DateTime fecha = new DateTime();
            DateTime fechaHoy = DateTime.Now;
            TimeSpan diferencia = new TimeSpan();

            if (DateTime.TryParse(f, out fecha))
            {
                diferencia = fecha - fechaHoy;

                if (diferencia.Days >= 0 || diferencia.Hours >= 0)
                {
                    MessageBox.Show(diferencia.ToString());
                    return true;
                }
            }

            return false;


          
        }




       

        private void cmdAsignar_Click(object sender, EventArgs e)
        {
            {
                if (lstProg.SelectedIndex < 0)
                {
                    MessageBox.Show("No selecciono ningun programador");
                }
                else
                {
                    programador_seleccionado = lstProg.SelectedItem.ToString();
                    lstProg.SelectedIndex = -1;
                }
            }

           

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstProg.Items.Add("Juan Perez");
            lstProg.Items.Add("Lorena Lopez");
            lstProg.Items.Add("Juana Cramer");
            lstProg.Items.Add("Felipe Cuzzella");
        }
    }
}
