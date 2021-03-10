using System;
using Triangulos.Entities;

namespace Triangulos
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Informe o primeiro valor: ");
                int n1 = int.Parse(Console.ReadLine());
                Console.Write("Informe o segundo valor: ");
                int n2 = int.Parse(Console.ReadLine());
                Console.Write("Informe o terceiro valor: ");
                int n3 = int.Parse(Console.ReadLine());
                VerificarTriangulo veftri = new VerificarTriangulo(n1, n2, n3);
                Console.WriteLine(veftri.Verificacao(n1, n2, n3));
                Console.WriteLine();
                Main(args);
            }
            catch (Exception e)
            {
                Console.WriteLine();
                Console.WriteLine("Erro inesperado!");
                Console.WriteLine(e.Message);
            }
        }
    }
}
