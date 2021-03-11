using System;
using SequenciaInteirosAte1.Entities;

namespace SequenciaInteirosAte1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Insira um número: ");
                int n = int.Parse(Console.ReadLine());
                VerificaSequencia sequencia = new VerificaSequencia(n);
                Console.WriteLine(sequencia.Sequencia(n));
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro inesperado!");
                Console.WriteLine(e.Message);
            }
        }
    }
}
