using ClasesCribaEratos.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManejadorEmpleados
{
    public partial class EmpleadoPlanta : Form
    {
        EmpleadoController controller;
        public EmpleadoPlanta(EmpleadoController _controller)
        {
            InitializeComponent();
            controller = _controller;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            string apellido = textBox2.Text;
            int ci = Convert.ToInt32( textBox3.Text);
            int  codigo = Convert.ToInt32(textBox4.Text);
            string asegurado = textBox5.Text;
            double sueldo = Convert.ToDouble( textBox6.Text);
            controller.AgregarEmpleadoPlanta(
                nombre, apellido, ci, codigo, asegurado, sueldo);
        }
    }
}
