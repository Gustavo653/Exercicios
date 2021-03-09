using System;
using System.Collections.Generic;
using System.Text;

namespace ImparPar.Entities
{
    class CalcularImpPar
    {
        public int N1 { get; set; }

        public CalcularImpPar(int n1)
        {
            N1 = n1;
        }

        public string Verificar (int n1)
        {
            if (n1 % 2 == 0)
            {
                return "O valor é par.";
            }
            else
            {
                return "O valor é impar.";
            }
        }
    }
}
