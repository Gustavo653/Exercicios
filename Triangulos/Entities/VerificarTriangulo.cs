using System;
using System.Collections.Generic;
using System.Text;

namespace Triangulos.Entities
{
    class VerificarTriangulo
    {
        public int N1 { get; set; }
        public int N2 { get; set; }
        public int N3 { get; set; }

        public VerificarTriangulo(int n1, int n2, int n3)
        {
            N1 = n1;
            N2 = n2;
            N3 = n3;
        }

        public string Verificacao(int n1, int n2, int n3)
        {
            int sum1, sum2, sum3;
            sum1 = n2 + n3;
            sum2 = n1 + n3;
            sum3 = n1 + n2;
            if (n1 <= sum1 && n2 <= sum2 && n3 <= sum3)
            {
                if (n1 == n2 && n1 == n3)
                {
                    return "Triângulo Equilátero";
                }

                if (n1 == n2 && n1 != n3)
                {
                    return "Triângulo Isósceles";
                }
                else if (n1 == n3 && n1 != n3)
                {
                    return "Triângulo Isósceles";
                }

                if (n1 != n2 && n1 != n3 && n2 != n3)
                {
                    return "Triângulo Escaleno";
                }
            }
            return "Não forma triângulo";
        }
    }
}
