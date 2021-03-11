using System;
using System.Collections.Generic;
using System.Text;

namespace SequenciaInteirosAte1.Entities
{
    class VerificaSequencia
    {
        public int Numero { get; set; }

        public VerificaSequencia(int numero)
        {
            Numero = numero;
        }

        public int Sequencia(int n)
        {
            int cont = 0;
            Console.WriteLine(n);
            while (n != 1)
            {
                if (n % 2 == 0)
                {
                    n /= 2;
                    Console.WriteLine(n);
                }
                else
                {
                    n *= 3;
                    n += 1;
                    Console.WriteLine(n);
                }
                cont++;
            }
            Console.Write("A quantidade de operações foi de: ");
            return cont;
        }
    }
}
