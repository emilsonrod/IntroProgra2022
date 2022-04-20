using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroProgra//intro_progra
{
    class Estudiante
    {
        // attr de clase
        private string curso;
        //private int edad;
        private string codigoEst;
        private CarnetID ci;

        //Constructores
        public Estudiante(
            string _curso,
            string _codigo, CarnetID _ci)
        {
            Curso = _curso;
            //edad = _edad;
            codigoEst = _codigo;
            Ci = _ci;
        }

        public Estudiante(CarnetID ci)
        {
           Ci = ci;
        }

        //public Estudiante(CarnetID ci, int anioNacimiento)
        //{
        //    //nombre = _nombre;
        //    Ci = ci;
        //    edad = DateTime.Now.Year - anioNacimiento;
        //}
        //Propiedades
        //public string GetNombre()
        //{
        //    return nombre;
        //}
        //public void SetNombre(string nombre)
        //{
        //    this.nombre = nombre;
        //}
        //public string Nombre 
        //{
        //    get { return nombre; }
        //    set { nombre = value; }
        //}

        public string Curso 
        { //get => curso; set => curso = value; 
            get { return curso; }
            set { curso = value; }
        }

        internal CarnetID Ci { get => ci; set => ci = value; }

        //Funciones o metodos
        private int CalcularEdad()
        {
            return DateTime.Now.Year - Ci.AnioNacimiento;
        }
        public string MostrarSaludo()
        {
            return string.Format(
                "Hola mi nombre completo es {0}, y mi grado es {1} y tengo {2} años",
                Ci.NombreCI, Curso, CalcularEdad());
        }
    }
}
