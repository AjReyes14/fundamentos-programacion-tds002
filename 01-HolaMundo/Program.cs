/*
 * Nombre: Anthony Junior Reyes Suero
 * Descripción: Programa de consola que muestra un saludo
 * y una tarjeta de presentación personal.
 */

using System;

namespace _01_HolaMundo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Muestra el encabezado de la tarjeta de presentación.
            Console.WriteLine("*-------------------------------------------------*");
            Console.WriteLine("|    TARJETA DE PRESENTACIÓN                      |");
            Console.WriteLine("*-------------------------------------------------*");

            // Muestra los datos personales del estudiante.
            Console.WriteLine("| Nombre: Anthony Junior Reyes Suero              |");
            Console.WriteLine("| Matrícula: [DEJA AQUÍ LA QUE YA PUSISTE]        |");
            Console.WriteLine("| Carrera: Tecnología en Desarrollo de Software   |");
            Console.WriteLine("| Frase: El peor intento es el que no se realiza. |");


            Console.WriteLine("|-------------------------------------------------|");

            Console.ReadKey();
        }
    }
}