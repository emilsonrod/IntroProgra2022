using ClasesCribaEratos.ClasesBase;
using ClasesCribaEratos.ClasesInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesCribaEratos.ClasesImplemento
{
    public class FiltroCodigoEmpleado : IFilter
    {
        public bool Filtrar(string param, Empleado empleado)
        {
            int compare = Convert.ToInt32(param);
            return empleado.CodigoEmpleado == compare;
        }
        public override string ToString()
        {
            return "Codigo Empleado";
        }
    }
}
