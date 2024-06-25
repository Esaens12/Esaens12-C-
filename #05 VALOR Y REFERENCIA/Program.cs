using System;

namespace _05_VALOR_Y_REFERENCIA
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
 * EJERCICIO:
 * - Muestra ejemplos de asignación de variables "por valor" y "por referencia", según
 *   su tipo de dato.
 * - Muestra ejemplos de funciones con variables que se les pasan "por valor" y 
 *   "por referencia", y cómo se comportan en cada caso en el momento de ser modificadas.
 * (Entender estos conceptos es algo esencial en la gran mayoría de lenguajes)
 *
 * DIFICULTAD EXTRA (opcional):
 * Crea dos programas que reciban dos parámetros (cada uno) definidos como
 * variables anteriormente.
 * - Cada programa recibe, en un caso, dos parámetros por valor, y en otro caso, por referencia.
 *   Estos parámetros los intercambia entre ellos en su interior, los retorna, y su retorno
 *   se asigna a dos variables diferentes a las originales. A continuación, imprime
 *   el valor de las variables originales y las nuevas, comprobando que se ha invertido
 *   su valor en las segundas.
 *   Comprueba también que se ha conservado el valor original en las primeras.
 */

            // Asignación por Valor
            int a = 5;
            int b = a; // b es una copia de a
            b = 10; // Cambiar b no afecta a a
            Console.WriteLine($"Asignación por Valor -> a: {a}, b: {b}"); // Salida: a: 5, b: 10

            // Asignación por Referencia
            Persona persona1 = new Persona { Nombre = "Alice" };
            Persona persona2 = persona1; // persona2 referencia al mismo objeto que persona1
            persona2.Nombre = "Bob"; // Cambiar persona2 afecta a persona1
            Console.WriteLine($"Asignación por Referencia -> persona1.Nombre: {persona1.Nombre}, persona2.Nombre: {persona2.Nombre}"); // Salida: persona1.Nombre: Bob, persona2.Nombre: Bob

            // Función con Parámetro por Valor
            int x = 5;
            CambiarValor(x);
            Console.WriteLine($"Parámetro por Valor -> x: {x}"); // Salida: x: 5

            // Función con Parámetro por Referencia
            int y = 5;
            CambiarValorRef(ref y);
            Console.WriteLine($"Parámetro por Referencia -> y: {y}"); // Salida: y: 10
            

            // Intercambio de Variables por Valor
            int m = 1, n = 2;
            int nuevoM, nuevoN;
            IntercambiarPorValor(m, n, out nuevoM, out nuevoN);
            Console.WriteLine($"Intercambio por Valor -> Originales: m = {m}, n = {n}"); // Salida: m = 1, n = 2
            Console.WriteLine($"Intercambio por Valor -> Nuevas: nuevoM = {nuevoM}, nuevoN = {nuevoN}"); // Salida: nuevoM = 2, nuevoN = 1

            // Intercambio de Variables por Referencia
            int p = 1, q = 2;
            IntercambiarPorReferencia(ref p, ref q);
            Console.WriteLine($"Intercambio por Referencia -> Intercambiados: p = {p}, q = {q}"); // Salida: p = 2, q = 1
        }


        class Persona
        {
            public string Nombre { get; set; }
        }

        static void CambiarValor(int x)
        {
            x = 10;
        }

        static void CambiarValorRef(ref int x)
        {
            x = 8;
        }

        static void IntercambiarPorValor(int x, int y, out int nuevoX, out int nuevoY)
        {
            int temp = x;
            x = y;
            y = temp;
            nuevoX = x;
            nuevoY = y;
        }

        static void IntercambiarPorReferencia(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
    }

}

