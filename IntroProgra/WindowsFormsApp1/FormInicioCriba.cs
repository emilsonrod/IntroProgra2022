using ClasesCribaEratos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormInicioCriba : Form
    {
        public VectorEratos vector;
        public FormInicioCriba(VectorEratos vector)
        {
            InitializeComponent();
            this.vector = vector;
        }

        private void Criba_Click(object sender, EventArgs e)
        {
            string textNumber = textBox1.Text;
            if (string.IsNullOrEmpty(textNumber))
            {
                MessageBox.Show("Ingrese numero valido");
            }
            else
            {
                int tamanio = Convert.ToInt32(textNumber);
                vector.IniciarLista(tamanio);
            }
        }
    }
}
