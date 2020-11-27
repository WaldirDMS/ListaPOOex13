using System;
using System.Collections.Generic;
using System.Text;

namespace ListaPOOex13
{
    class Triangulo
    {
        private double A;
        private double B;
        private double C;

        public void setValor1(double p)
        {
            A = p;
        }

        public void setValor2(double p)
        {
            B = p;
        }

        public void setValor3(double p)
        {
            C = p;
        }

        public void verificarTring()
        {
            if (A * A + B * B == C * C || B * B + C * C == A * A || A * A + C * C == B * B)
            {
                Console.WriteLine("É um triangulo retangulo");
            }
            else
            {
                Console.WriteLine("Não é um triangulo retangulo");
            }
        }
    }
}
