using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _06_RECURSIVIDAD
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
  * EJERCICIO:
  * Entiende el concepto de recursividad creando una función recursiva que imprima
  * números del 100 al 0.
  *
  * DIFICULTAD EXTRA (opcional):
  * Utiliza el concepto de recursividad para:
  * - Calcular el factorial de un número concreto (la función recibe ese número).
  * - Calcular el valor de un elemento concreto (según su posición) en la 
  *   sucesión de Fibonacci (la función recibe la posición).
  */

            numeros(100);

            int numero = 5;
            long resultado = Factorial(numero);
            Console.WriteLine($"\nFactorial de {numero} es {resultado}");

            int posicion = 10; // Cambia este valor para obtener el Fibonacci de otra posición
            long resultado2 = Fibonacci(posicion);
            Console.WriteLine($"Fibonacci de la posicion {posicion} es {resultado2}");

        }

        // FUNCION RECURSIVA QUE IMPRIMA LOS NUMEROS DEL 100 AL 0

        static void numeros(int n)
        {
            if (n < 0)
            {
                return; // Caso base: si n es menor que 0, termina la recursión
            }
            else
            {
                Console.WriteLine(n); // Imprime el número actual
                numeros(n - 1); // Llamada recursiva con n - 1
            }
        }

        static long Factorial(int n)
        {
            if (n == 0)
            {
                return 1; // Caso base
            }
            else
            {
                return n * Factorial(n - 1); // Llamada recursiva
            }
        }

        static long Fibonacci(int n)
        {
            if (n <= 0)
            {
                return 0; // Caso base: Fibonacci(0) = 0
            }
            else if (n == 1)
            {
                return 1; // Caso base: Fibonacci(1) = 1
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2); // Llamada recursiva
            }
        }

    }
}

