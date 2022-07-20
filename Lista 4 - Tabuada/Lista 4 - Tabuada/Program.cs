using System;

namespace Lista_4___Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, resultado;

            Console.WriteLine("Olá! Digite um número para construir uma tabuada: ");
            numero = Convert.ToInt16(Console.ReadLine());

            for (int x = 0; x <= 10; x++)
            {
                resultado = numero * x;
                Console.WriteLine(numero + " X " + x + " = " + resultado);
            }

            Console.ReadLine();
                    
        }
    }
}
