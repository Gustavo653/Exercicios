using System;
using Calculadora.Entities;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Insira a operação: ( + | - | * | / )");
                string op = Console.ReadLine();
                Console.Write("Insira o primeiro valor: ");
                int n1 = int.Parse(Console.ReadLine());
                Console.Write("Insira o primeiro valor: ");
                int n2 = int.Parse(Console.ReadLine());
                Calculos calc = new Calculos(op, n1, n2);
                Console.WriteLine(calc.Calcular(op, n1, n2));
                Main(args);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Impossível dividir por zero!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Formato inválido!");
            }
            catch (Exception)
            {
                Console.WriteLine("Erro desconhecido!");
            }
        }
    }
}
