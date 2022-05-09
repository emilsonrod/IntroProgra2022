using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesCribaEratos
{
    public class VectorEratos
    {
        int[] lista;
        public VectorEratos(int tamanio)
        {
            lista = new int[tamanio - 1];
        }

        public VectorEratos()
        {
        }

        public int[] Lista { get { return lista; } }

        public void IniciarLista()
        {
            for (int index = 0; index < lista.Length; index++)
            {
                lista[index] = index + 2;
            }
        }

        public void IniciarLista(int tamanio)
        {
            lista = new int[tamanio - 1];
            for (int index = 0; index < lista.Length; index++)
            {
                lista[index] = index + 2;
            }
        }

        public void EliminarMultiplos()
        {
            for (int pibot = 0; pibot < lista.Length; pibot++)
            {
                if (lista[pibot] != 0)
                {
                    for (int index = pibot + 1; index < lista.Length; index++)
                    {
                        if (lista[index] != 0 && lista[index] % lista[pibot] == 0)
                        {
                            lista[index] = 0;
                        }
                    }
                }
            }
        }
    }
}
