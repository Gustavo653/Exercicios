using System;

namespace AnoBissexto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Anos bissextos entre 1900 e 2030.\n");
            int contador = 0;
            for (int ano = 1900; ano <= 2030; ano++)
            {
                if (DateTime.IsLeapYear(ano)) //Metodo que verifica o ano
                {
                    contador++;
                    Console.Write($"\t{ano}");
                }
            }
            Console.WriteLine($"\nTotal de {contador} anos bissextos entre 1900 e 2030.\n");
            Console.ReadLine();
        }
    }
}
