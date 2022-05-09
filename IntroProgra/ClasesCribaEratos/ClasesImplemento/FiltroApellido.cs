using ClasesCribaEratos.ClasesBase;
using ClasesCribaEratos.ClasesInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesCribaEratos.ClasesImplemento
{
    public class FiltroApellido : IFilter
    {
        public bool Filtrar(string param, Empleado empleado)
        {
            return empleado.Apellido.Equals(param);
        }

        public override string ToString()
        {
            return "Apellido";
        }
    }
}
