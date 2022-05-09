using ClasesCribaEratos.ClasesInterface;
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
    public partial class ListaEmpleados : Form
    {
        EmpleadoController controller;
        public ListaEmpleados(EmpleadoController _controller)
        {
            InitializeComponent();
            controller = _controller;
            controller.LoadSamples();
            LoadFilters();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int horas = Convert.ToInt32( textBox1.Text);
            listBox1.Items.Clear();
            foreach (string empleado in controller.VerListaEmpleados(horas))
            {
                listBox1.Items.Add(empleado);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IFilter filtro = comboBox1.SelectedItem as IFilter;
            string parametro = textBox2.Text;
            listBox1.Items.Clear();
            foreach (string item in controller.FiltarPor(parametro, filtro))
            {
                listBox1.Items.Add(item);
            }
        }

        private void LoadFilters()
        {
            foreach (IFilter item in controller.ListaFiltros)
            {
                comboBox1.Items.Add(item);
            }
        }
    }
}
