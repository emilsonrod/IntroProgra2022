using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroProgra
{
    class CarnetID
    {
        public CarnetID(
            string nombreCi, string ciudad,
            double numeroCi, int anioNacimiento)
        {
            NombreCI = nombreCi;
            Ciudad = ciudad;
            NumeroCI = numeroCi;
            AnioNacimiento = anioNacimiento;
        }

        public string NombreCI { get; set; }
        public string Ciudad { get; set; }
        public double NumeroCI { get; set; }
        public int AnioNacimiento { get; set; }
    }
}
