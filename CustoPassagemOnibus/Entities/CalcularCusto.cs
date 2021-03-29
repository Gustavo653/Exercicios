using System;
using System.Collections.Generic;
using System.Text;

namespace CustoPassagemOnibus.Entities
{
    class CalcularCusto
    {
        public double Kilometer { get; set; }
        public char Choice { get; set; }

        public CalcularCusto(double kilometer, char choice)
        {
            Kilometer = kilometer;
            Choice = choice;
        }

        public double Calcular(double kilometer, char choice)
        {
            double fare = 9.0;
            if (kilometer == 0)
            {
                Environment.Exit(0);
            }
            else if (kilometer <= 4)
            {
                if (choice == 'A')
                {
                    fare *= 0.8;
                    return fare;
                }
                return fare;
            }
            else if (kilometer >= 5)
            {                
                if (choice == 'A')
                {
                    kilometer -= 4;
                    kilometer += fare;
                    kilometer *= 0.8;
                    return kilometer;
                }
                kilometer -= 4;
                kilometer += fare;
                return kilometer;
            }
            return 0;
        }
    }
}
