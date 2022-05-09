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
    public partial class ProcesarCriba : Form
    {
        public VectorEratos vector;
        public ProcesarCriba(VectorEratos vector)
        {
            InitializeComponent();
            this.vector = vector;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            vector.EliminarMultiplos();
            foreach (int numPrimo in vector.Lista)
            {
                if (numPrimo != 0)
                    listBox1.Items.Add(numPrimo);
                
            }
        }
    }
}
