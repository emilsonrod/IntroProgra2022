using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesCribaEratos.ClasesBase
{
    public abstract class Empleado : Persona
    {
        public int CodigoEmpleado { get; set; }

        abstract public double CalcularSalario(int horasTrabajadas);

        abstract public string MostrarSalario(int horasTrabajadas);
    }
}
