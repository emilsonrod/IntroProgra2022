using ClasesCribaEratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroProgra.Criba
{
    class CribaEratos
    {
        VectorEratos lista;
        internal void IniciarCriba()
        {
            Console.WriteLine("Ingrese tamaño de la lista");
            int tamanio = Convert.ToInt32( Console.ReadLine());
            lista = new VectorEratos(tamanio);
            lista.IniciarLista();
        }

        public void MostrarLista()
        {
            int[] criba = lista.Lista;
            for (int index = 0; index < criba.Length; index++)
            {
                if (criba[index] != 0)
                {
                    Console.WriteLine(criba[index]);
                }
            }
        }

        internal void ProcesarCriba()
        {
            lista.EliminarMultiplos();
        }
    }
}
