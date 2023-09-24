//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using Gates;

namespace ConsoleApplication
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Ingrese el valor de la primera incógnita (true o false): ");
            bool input1 = bool.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor de la segunda incógnita (true o false): ");
            bool input2 = bool.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor de la tercera incógnita (true o false): ");
            bool input3 = bool.Parse(Console.ReadLine());

            Console.WriteLine("Elija la operación lógica (AND, OR, NOT): ");
            string operacion = Console.ReadLine().ToUpper();

            switch (operacion)
            {
                case "AND":
                    bool resultadoAnd = ANDGates.Evaluar(input1, input2);
                    Console.WriteLine($"El resultado de {operacion} es: {resultadoAnd}");
                    break;

                case "OR":
                    bool resultadoOr = ORGates.Evaluar(input1, input2);
                    Console.WriteLine($"El resultado de {operacion} es: {resultadoOr}");
                    break;

                case "NOT":
                    bool resultadoNot = NOTGates.Evaluar(input1, input2);
                    Console.WriteLine($"El resultado de NOT({input1}) es: {resultadoNot}");
                    break;

                default:
                    Console.WriteLine("Operación no válida.");
                    break;
            }
        }
    }
}