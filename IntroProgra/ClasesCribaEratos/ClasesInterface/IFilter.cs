using ClasesCribaEratos.ClasesBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesCribaEratos.ClasesInterface
{
    public interface IFilter
    {
        bool Filtrar(string param, Empleado empleado);
    }
}
