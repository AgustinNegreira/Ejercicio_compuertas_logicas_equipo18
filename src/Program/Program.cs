
using System;
using Gates;

namespace ConsoleApplication
{
    class Program
    {
        /* aqui en el program realizamos una implementacion en consola de las 3 compuertas logicas base
        solicitadas :) */
        private static void Main()
        {
            Console.WriteLine("Elija la operación lógica (AND, OR, NOT): ");
            string operacion = Console.ReadLine().ToUpper();

            switch (operacion)
            {
                case "AND":
                    Console.WriteLine("Ingrese el valor de la primera entrada (true o false): ");
                    bool input1and = bool.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el valor de la segunda entrada (true o false): ");
                    bool input2and = bool.Parse(Console.ReadLine());

                    ILogicGate andgate = new AndGate(input1and, input2and);
                    bool resultadoAnd = andgate.Evaluate();
                    Console.WriteLine($"El resultado de {operacion} es: {resultadoAnd}");
                    break;

                case "OR":
                    Console.WriteLine("Ingrese el valor de la primera entrada (true o false): ");
                    bool input1or = bool.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el valor de la segunda entrada (true o false): ");
                    bool input2or = bool.Parse(Console.ReadLine());

                    ILogicGate orgate = new OrGate(input1or, input2or);
                    bool resultadoOr = orgate.Evaluate();
                    Console.WriteLine($"El resultado de {operacion} es: {resultadoOr}");
                    break;

                case "NOT":
                    Console.WriteLine("Ingrese el valor de la primera entrada (true o false): ");
                    bool input = bool.Parse(Console.ReadLine());
                    
                    ILogicGate notgate = new NotGate(input);
                    bool resultadoNot = notgate.Evaluate();
                    Console.WriteLine($"El resultado de NOT({input}) es: {resultadoNot}");
                    break;

                default:
                    Console.WriteLine("Operación no válida.");
                    break;
            }

            
        }
    }
}