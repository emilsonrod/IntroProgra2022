using ClasesCribaEratos.ClasesBase;
using ClasesCribaEratos.ClasesInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesCribaEratos.ClasesImplemento
{
    public class FiltroNombre : IFilter
    {
        public bool Filtrar(string param, Empleado empleado)
        {
            return empleado.Nombre.Equals(param);
        }
        public override string ToString()
        {
            return "Nombre";
        }
    }
}
