using IntroProgra.Camilo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntroProgra.Criba;

namespace IntroProgra
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.ReadLine();
            //int numero1 = 25;
            //numero1 = 100;
            //string texto = "Hello World";
            //texto = "Hola Mundo!!";
            //texto = texto + "Hola Progra!!";

            //int numero2 = 500;
            //numero2 = numero1 + numero2 * 0;
            //if (numero2 > numero1)
            //{
            //    Console.WriteLine("numero 2 es mayor");
            //}
            //else 
            //{
            //    Console.WriteLine("numero 2 es menor");
            //}

            //int numero1 = 10;
            //int numero2 = 25;
            //int numero3 = 111;
            //if (numero1 > numero2 && numero1 > numero3)
            //{
            //    if (numero2 > numero3)
            //    {

            //    }
            //    else
            //    {

            //    }
            //}
            //else if (numero2 > numero1 && numero2 > numero3)
            //{
            //    if (numero1 > numero3)
            //    {

            //    }
            //    else
            //    {

            //    }
            //}
            //else
            //{
            //    if (numero1 > numero2)
            //    {

            //    }
            //    else
            //    {

            //    }
            //}

            //char simb = '*';
            //switch (simb)
            //{
            //    case '+':
            //        Console.WriteLine("Es suma");
            //        break;
            //    case '-':
            //        Console.WriteLine("Es resta");
            //        break;
            //    case '*':
            //        Console.WriteLine("Es multi");
            //        break;
            //}

            //int[] listaNumeros = new int[10];
            //int[] listaNumeros2 = { 10, 8, 5, 3, 1, 0 };// index {0,1,2,3,4,5}
            //int primerElemento = listaNumeros2[0];
            //int ultimoElemento = listaNumeros2[listaNumeros2.Length - 1];

            //int count = 101;
            //while (count < 100)
            //{
            //    Console.WriteLine(count);
            //    count = count + 1;// count++
            //}

            //do
            //{
            //    Console.WriteLine(count);
            //    count = count + 1;// count+
            //} while (count < 100);

            //for (int index = 1; index < 100; index++)
            //{
            //    Console.WriteLine(index);
            //}

            //int numeroIn = 5623;
            //while (numeroIn > 0)
            //{
            //    Console.WriteLine(numeroIn % 10);
            //    numeroIn = numeroIn / 10;
            //}

            //string texto1 = "Hello World!!";
            //for (int index = 0; index < texto1.Length; index++)
            //{
            //    Console.WriteLine(texto1[index]);
            //}

            //int numeroTabla = 8;
            //for (int index = 1; index < 10; index++)
            //{
            //    Console.WriteLine("{0} X {1} = {2}",
            //        index, numeroTabla, numeroTabla * index);
            //}

            //string texto = "Hola Mundo!!!";//{h,o,l,a, ,M,u...}
            //foreach (char letra in texto )
            //{
            //    Console.WriteLine(letra);
            //}

            //Console.WriteLine("Ingrese un numero para factorial");
            // fact(5) = 5*4*3*2*1 = 5 * fac(4) = 5 * 4 * Fac(3)...
            //int numero = Convert.ToInt32(Console.ReadLine());
            //int resultFact = 1;
            //while (numero > 0)
            //{
            //    resultFact = resultFact * numero;
            //    numero--;// numero = numero - 1
            //}
            //Console.WriteLine("El factorial es {0}", resultFact);

            // Fibonacci calcular segun un index
            //int indexFibo = Convert.ToInt32(Console.ReadLine());
            //int n1 = 1;
            //int n2 = 1;
            //int count = 1;
            //while (count < indexFibo)
            //{
            //    int aux = n2;
            //    n2 = n1 + n2;
            //    n1 = aux;
            //    count++;
            //}

            //Console.WriteLine("El fibonacci es {0}", n2);


            //Console.WriteLine("Ingrese el numero de datos");
            //int cantidad = Convert.ToInt32(Console.ReadLine());
            //int acumulador = 0;
            //for (int count = 1; count <= cantidad; count++)
            //{
            //    int ingreso = Convert.ToInt32(Console.ReadLine());
            //    acumulador = acumulador + ingreso;
            //}

            //CalculoMatematico(5,10,'*');
            //CalculoMatematico(5, 10, '%');
            //CalculoMatematico(5, 10, '+');
            //int resultRecur = SumatoriaContador(10);
            //Console.WriteLine("La sumatoria recursiva es {0}", resultRecur);
            //int resultFactorial = Factorial(10);
            //Console.WriteLine("El factorial calculado es {0}", resultFactorial);

            // fibonacci
            //int n1 = 1;
            //int n2 = 1;
            //int count = 2;
            //int fibo = Fibonacci(10, 1, 1, 2);
            //int resultFibbo = Fibonacci(9);

            //Estudiante estudiante1 = new Estudiante(
            //    "Emilson", "1 Pri", 6, "131654654Est1", "32569Cbba");
            //Estudiante estudiante2 = new Estudiante(
            //    "Carla", "2 Univ", 18, "32568Univ", "365892Stc");
            //Estudiante estudiante3 = new Estudiante(
            //    "Fernando", "4 Sec", 16, "1619Col1", "325785Or");
            //CarnetID ci4 = new CarnetID("Veronica", "Cochabamba", 325698, 1990);
            //Estudiante estudiante4 = new Estudiante(ci4);
            //estudiante4.Curso = "2 do semestre Univ";

            //CarnetID ci5 = new CarnetID("Juan", "Cochabamba", 987654, 2018);
            //Estudiante estudiante5 = new Estudiante(ci5);
            //estudiante5.Curso = "1 ro primaria";
            //Console.WriteLine(estudiante5.GetNombre());
            //estudiante5.SetNombre("Carlos Juan");
            //Console.WriteLine(estudiante5.GetNombre());
            //Console.WriteLine(estudiante5.Nombre);
            //estudiante5.Nombre = "Carlos Edueardo";
            //Console.WriteLine(estudiante5.Nombre);
            //Console.WriteLine(estudiante5.MostrarSaludo());
            //Console.WriteLine(estudiante4.MostrarSaludo());

            //Caja cajaAut1 = new Caja();
            //cajaAut1.TipoCaja = "Mecanica";
            //cajaAut1.Trans = "Hidraulica";
            //cajaAut1.Cantidad = 5;
            //Auto auto1 = new Auto("Plateado", 16000, "Toyota", cajaAut1);

            //int numero = 25;
            //int numero2 = numero;
            //Console.WriteLine(numero);
            //Console.WriteLine(numero2);
            //numero = numero + 52;
            //Console.WriteLine(numero);
            //Console.WriteLine(numero2);

            //CarnetID carnet1 = new CarnetID("Juan", "fadfds", 258963, 2015);
            //CarnetID carnet2 = carnet1;
            //Console.WriteLine(carnet1.AnioNacimiento);
            //Console.WriteLine(carnet2.AnioNacimiento);
            //carnet1.AnioNacimiento = carnet1.AnioNacimiento + 55;
            //Console.WriteLine(carnet1.AnioNacimiento);
            //Console.WriteLine(carnet2.AnioNacimiento);
            CribaEratos criba = new CribaEratos();
            criba.IniciarCriba();
            criba.MostrarLista();
            criba.ProcesarCriba();
            criba.MostrarLista();
        }

        //public static int Fibonacci(int index)
        //{
        //    if (index == 1 || index == 2)
        //    {
        //        return 1;
        //    }
        //    else 
        //    {
        //        return Fibonacci(index - 1) + Fibonacci(index - 2);
        //    }
        //}

        //private static int Fibonacci(
        //    int limite, int numero1, int numero2, int count)
        //{
        //    if (count == limite)
        //    {
        //        return numero2;
        //    }
        //    else
        //    {
        //        int aux = numero2;
        //        numero2 = numero1 + numero2;
        //        numero1 = aux;
        //        count++;
        //        return Fibonacci(limite, numero1, numero2, count);
        //    }
        //}

        //private static int Factorial(int numero) 
        //{
        //    // primero caso base
        //    if (numero == 1)
        //    {
        //        return 1;
        //    }
        //    else 
        //    {
        //        return numero * Factorial(numero - 1);
        //    }
        //}

        //private static int SumatoriaContador(int contador)
        //{
        //    if (contador == 1)
        //    {
        //        return 1;
        //    }
        //    else 
        //    {
        //        return contador + SumatoriaContador(contador - 1);
        //    }
        //}

        //private static void CalculoMatematico(int numero1,
        //    int numero2, char simbolo)
        //{
        //    switch (simbolo)
        //    {
        //        case '+':
        //            Console.WriteLine("La sumatoria es {0}", numero1 + numero2);
        //            break;
        //        case '-':
        //            Console.WriteLine("La resta es {0}", numero1 - numero2);
        //            break;
        //        case '*':
        //            Console.WriteLine("La multiplicacion es {0}", numero1 * numero2);
        //            break;
        //        case '/':
        //            Console.WriteLine("La division es {0}", numero1 / numero2);
        //            break;
        //        case '%':
        //            Console.WriteLine("La modulo es {0}", numero1 % numero2);
        //            break;
        //    }
        //}


    }
}
