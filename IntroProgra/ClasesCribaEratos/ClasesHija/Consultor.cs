using ClasesCribaEratos.ClasesBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesCribaEratos.ClasesHija
{
    sealed class Consultor : Empleado
    {
        Object generic;
        public double PagoHora { get; set; }

        public override double CalcularSalario(int horasTrabajadas)
        {
            // boxing
            generic = new EmpleadoPlanta();
            // uboxing
            EmpleadoPlanta emplPlant = (EmpleadoPlanta)generic;
            return PagoHora * horasTrabajadas;
        }

        public override string MostrarSalario(int horasTrabajadas)
        {
            return string.Format("Soy el consultor {0} {1}, con codigo empleado {2} mi sueldo es {3}",
                Nombre, Apellido, CodigoEmpleado, CalcularSalario(horasTrabajadas));
        }

        public override string ToString()
        {
            return string.Format("Soy el consultor {0} {1}, con codigo empleado {2} mi sueldo es {3}",
                Nombre, Apellido, CodigoEmpleado, CalcularSalario(176));
        }
    }
}
