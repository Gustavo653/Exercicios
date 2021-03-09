using System;
using ImparPar.Entities;

namespace ImparPar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um número");
            int n = int.Parse(Console.ReadLine());
            CalcularImpPar calc = new CalcularImpPar(n);
            Console.WriteLine(calc.Verificar(n));
        }
    }
}
