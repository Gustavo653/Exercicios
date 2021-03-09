using System;

namespace ExibeUsuarioNaTela
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira seu nome de usuário: ");
            string usuario = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Seu nome de usuário é: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(usuario);
        }
    }
}
