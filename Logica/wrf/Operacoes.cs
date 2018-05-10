using System;

namespace Calculos
{
    public class Operacoes
    {
        public double numero1;
        public double numero2;
        double resultado;
        public double Soma()
        {

            resultado = numero1 + numero2;
            return resultado;

        }

        public double subtrair()
        {
            resultado = numero1 - numero2;
            return resultado;
        }

        public double multiplicar()
        {
            resultado = numero1 * numero2;
            return resultado;
        }
        public double dividir()
        {
            resultado = numero1 / numero2;
            return resultado;
        }
    }
}
