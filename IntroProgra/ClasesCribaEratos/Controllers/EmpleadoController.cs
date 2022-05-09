using ClasesCribaEratos.ClasesBase;
using ClasesCribaEratos.ClasesHija;
using ClasesCribaEratos.ClasesImplemento;
using ClasesCribaEratos.ClasesInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesCribaEratos.Controllers
{
    public class EmpleadoController
    {
        List<Empleado> listaEmpleados;
        List<IFilter> listaFiltros;

        public EmpleadoController()
        {
            listaEmpleados = new List<Empleado>();
            listaFiltros = new List<IFilter>();
            listaFiltros.Add(new FiltroApellido());
            listaFiltros.Add(new FiltroNombre());
            listaFiltros.Add(new FiltroCodigoEmpleado());
            listaFiltros.Add(new FiltroSueldo());
            //Consultor consultor1 = new Consultor();
            //EmpleadoPlanta planta1 = new EmpleadoPlanta();
            //Persona persona1 = consultor1;
            //Object object1 = persona1;
            //Object object2 = planta1;
            //if (object1 is EmpleadoPlanta)
            //{
            //    EmpleadoPlanta planta2 = (EmpleadoPlanta)object1;
            //}
            //else if (object1 is Consultor) 
            //{
            //    consultor1 = (Consultor)object1;
            //}
            //EmpleadoPlanta planta2 = object2 as EmpleadoPlanta;
            //if (planta2 == null)
            //{
            //    consultor1 = (Consultor)object2;
            //}
        }

        public List<IFilter> ListaFiltros { get { return listaFiltros; } }

        public void AgregarEmpleadoPlanta(string nombre, string apellido, int ci,
            int codigoEmpleado, string codigoAsegurado, double sueldo)
        {
            //Empleado Empleado = new Empleado();
            //Persona persona = new Persona();
            EmpleadoPlanta empleado = new EmpleadoPlanta();
            empleado.Nombre = nombre;
            empleado.Apellido = apellido;
            empleado.CI = ci;
            empleado.CodigoAsegurado = codigoAsegurado;
            empleado.CodigoEmpleado = codigoEmpleado;
            empleado.SueldoFijo = sueldo;
            AgregarEmpleado(empleado);
        }
        public void AgregarCOnsultor(string nombre, string apellido, int ci,
            int codigoEmpleado, double pagoHora)
        {
            Consultor consultor = new Consultor();
            consultor.Nombre = nombre;
            consultor.Apellido = apellido;
            consultor.CI = ci;
            consultor.CodigoEmpleado = codigoEmpleado;
            consultor.PagoHora = pagoHora;
            AgregarEmpleado(consultor);
        }
        private void AgregarEmpleado(Empleado empleado)
        {
            listaEmpleados.Add(empleado);
        }

        public List<string> VerListaEmpleados(int horas)
        {
            //Consultor consultor1 = new Consultor();
            //EmpleadoPlanta planta1 = new EmpleadoPlanta();
            //Persona persona1 = consultor1;
            //Object object1 = persona1;
            //EmpleadoPlanta planta2 = (EmpleadoPlanta)object1;

            if(horas == 0)
                return listaEmpleados.Select(empleado => empleado.ToString()).ToList();
            else
                return listaEmpleados.Select(empleado => empleado.MostrarSalario(horas)).ToList();
        }

        public List<string> FiltarPor(string parametro, IFilter filtro) 
        {
            List<string> result = new List<string>();
            foreach (Empleado empleado in listaEmpleados)
            {
                if (filtro.Filtrar(parametro, empleado))
                {
                    result.Add(empleado.ToString());
                }
            }
            return result;
        }

        public void LoadSamples()
        {
            EmpleadoPlanta planta1 = new EmpleadoPlanta();
            planta1.Nombre = "Carlos";
            planta1.Apellido = "Fernandez";
            planta1.CI = 369852;
            planta1.CodigoAsegurado = "324785";
            planta1.CodigoEmpleado = 3256982;
            planta1.SueldoFijo = 3500;
            EmpleadoPlanta planta2 = new EmpleadoPlanta();
            planta2.Nombre = "Carla";
            planta2.Apellido = "Rojas";
            planta2.CI = 98542;
            planta2.CodigoAsegurado = "3256";
            planta2.CodigoEmpleado = 32184;
            planta2.SueldoFijo = 4000;
            EmpleadoPlanta planta3 = new EmpleadoPlanta();
            planta3.Nombre = "Juan";
            planta3.Apellido = "Escobar";
            planta3.CI = 98745;
            planta3.CodigoAsegurado = "325694";
            planta3.CodigoEmpleado = 321458;
            planta3.SueldoFijo = 3500;
            EmpleadoPlanta planta4 = new EmpleadoPlanta();
            planta4.Nombre = "Carlos";
            planta4.Apellido = "Rioja";
            planta4.CI = 357412;
            planta4.CodigoAsegurado = "9856214";
            planta4.CodigoEmpleado = 3659852;
            planta4.SueldoFijo = 3500;
            EmpleadoPlanta planta5 = new EmpleadoPlanta();
            planta5.Nombre = "Esteban";
            planta5.Apellido = "Fernandez";
            planta5.CI = 32458;
            planta5.CodigoAsegurado = "8521456";
            planta5.CodigoEmpleado = 985632;
            planta5.SueldoFijo = 3500;
            EmpleadoPlanta planta6 = new EmpleadoPlanta();
            planta6.Nombre = "Carlos";
            planta6.Apellido = "Salazar";
            planta6.CI = 95412;
            planta6.CodigoAsegurado = "3214";
            planta6.CodigoEmpleado = 32569;
            planta6.SueldoFijo = 3500;

            Consultor consultor1 = new Consultor();
            consultor1.Nombre = "Carlos";
            consultor1.Apellido = "Salazar2";
            consultor1.CI = 95412;
            consultor1.CodigoEmpleado = 32569;
            consultor1.PagoHora = 30;
            Consultor consultor2 = new Consultor();
            consultor2.Nombre = "Veronica";
            consultor2.Apellido = "Aranda";
            consultor2.CI = 98563;
            consultor2.CodigoEmpleado = 3214;
            consultor2.PagoHora = 30;
            Consultor consultor3 = new Consultor();
            consultor3.Nombre = "Mateo";
            consultor3.Apellido = "Rodriguez";
            consultor3.CI = 96523;
            consultor3.CodigoEmpleado = 321457;
            consultor3.PagoHora = 25;
            Consultor consultor4 = new Consultor();
            consultor4.Nombre = "Hernan";
            consultor4.Apellido = "Fernandez";
            consultor4.CI = 95412;
            consultor4.CodigoEmpleado = 32569;
            consultor4.PagoHora = 30;
            Consultor consultor5 = new Consultor();
            consultor5.Nombre = "Carlos";
            consultor5.Apellido = "Salazar";
            consultor5.CI = 9875412;
            consultor5.CodigoEmpleado = 32410;
            consultor5.PagoHora = 30;
            listaEmpleados.Add(planta1);
            listaEmpleados.Add(consultor1);
            listaEmpleados.Add(planta2);
            listaEmpleados.Add(consultor2);
            listaEmpleados.Add(planta3);
            listaEmpleados.Add(consultor3);
            listaEmpleados.Add(planta4);
            listaEmpleados.Add(consultor4);
            listaEmpleados.Add(planta5);
            listaEmpleados.Add(consultor5);
            listaEmpleados.Add(planta6);
        }
    }
}
