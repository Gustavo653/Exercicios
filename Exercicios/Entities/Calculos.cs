using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora.Entities
{
    class Calculos
    {
        public string Op { get; set; }
        public int N1 { get; set; }
        public int N2 { get; set; }

        public Calculos(string op, int n1, int n2)
        {
            Op = op;
            N1 = n1;
            N2 = n2;
        }

        public int Calcular (string op, int n1, int n2)
        {
            if (op == "+")
            {
                int soma = n1 + n2;
                return soma;
            }
            else if (op == "-")
            {
                int sub = n1 - n2;
                return sub;
            }
            else if (op == "*")
            {
                int mult = n1 * n2;
                return mult;
            }
            else
            {
                int div = n1 / n2;
                return div;
            }
        }
    }
}
