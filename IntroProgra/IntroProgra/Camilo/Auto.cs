using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroProgra.Camilo
{
    class Auto
    {
        public Auto(string color, double precio, string marca,
            Caja caja)
        {
            Color = color;
            Costo = precio;
            Marca = marca;
            CajaAut = caja;
        }
        public string Color { get; set; }
        public double Costo { get; set; }
        public string Marca { get; set; }
        public Caja CajaAut { get; set; }

    }
}
