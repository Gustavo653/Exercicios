using CustoPassagemOnibus.Entities;
using System;

namespace CustoPassagemOnibus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter kilometer to travel: ");
            double kilometer = double.Parse(Console.ReadLine());
            Console.WriteLine("Choose your status:");
            Console.WriteLine("A. Student / Senior / PWD (20%)");
            Console.WriteLine("B. Regular");
            Console.Write("Enter choice: ");
            char choice = char.Parse(Console.ReadLine());

            CalcularCusto calcularCusto = new CalcularCusto(kilometer, choice);
            Console.WriteLine("Hello, your fare is: " + calcularCusto.Calcular(kilometer, choice));
            Main(args);
        }
    }
}
