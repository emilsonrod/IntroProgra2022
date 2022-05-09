using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesCribaEratos.ClasesBase
{
    public abstract class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int CI { get; set; }
    }
}
