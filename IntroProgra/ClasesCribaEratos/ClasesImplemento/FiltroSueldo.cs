using ClasesCribaEratos.ClasesBase;
using ClasesCribaEratos.ClasesHija;
using ClasesCribaEratos.ClasesInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesCribaEratos.ClasesImplemento
{
    public class FiltroSueldo : IFilter
    {
        public bool Filtrar(string param, Empleado empleado)
        {
            double sueldo = Convert.ToDouble(param);
            EmpleadoPlanta planta = empleado as EmpleadoPlanta;

            return planta == null ? false : planta.SueldoFijo == sueldo;
        }

        public override string ToString()
        {
            return "Sueldo";
        }
    }
}
