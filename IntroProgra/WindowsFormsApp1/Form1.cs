using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClasesCribaEratos;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public VectorEratos vector;
        public FormInicioCriba inicioCriba;
        public ProcesarCriba procesar;
        public Form1()
        {
            InitializeComponent();
            vector = new VectorEratos();
            inicioCriba = new FormInicioCriba(vector);
            procesar = new ProcesarCriba(vector);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
        }

        private void ChangeFormBackground(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void ChangeButton1Color(object sender, EventArgs e)
        {
            this.button1.BackColor = Color.Crimson;
        }

        private void ChangeButton1BackColor(object sender, EventArgs e)
        {
            this.button1.BackColor = Color.Yellow;
        }

        private void GoToCrearCriba(object sender, EventArgs e)
        {
            inicioCriba = new FormInicioCriba(vector);
            inicioCriba.Show();
        }
        private void GoToProcesarCriba(object sender, EventArgs e)
        {
            procesar = new ProcesarCriba(vector);
            procesar.Show();
        }

        //private void ProcesarCriba(object sender, EventArgs e)
        //{
        //    string textNumber = textBox1.Text;
        //    if (string.IsNullOrEmpty(textNumber))
        //    {
        //        MessageBox.Show("Ingrese numero valido");
        //    }
        //    else 
        //    {
        //        listBox1.Items.Clear();
        //        int tamanio = Convert.ToInt32(textNumber);
        //        vector = new VectorEratos(tamanio);
        //        vector.IniciarLista();
        //        vector.EliminarMultiplos();
        //        foreach (int numPrimo in vector.Lista)
        //        {
        //            if (numPrimo != 0)
        //                listBox1.Items.Add(numPrimo);
        //        }
        //    }
        //}
    }
}
