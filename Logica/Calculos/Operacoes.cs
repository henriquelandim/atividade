using System;

namespace Calculos
{
    public class Operacoes
    {
        public double numero1;
        public double numero2;
        double resultado;

        ///<summary>
        /// O metodo soma realiza a soma entre os numeros
        /// numero: n1 e n2
        /// ao final retorna o resultado
        ///<summary>
        ///<returns>retorna o resultado da soma do formatro</returns>

        public double Soma()
        {
            resultado = numero1 + numero2;
            return resultado;
             ///<summary>
        /// O metodo soma realiza a soma entre os numeros
        /// numero: n1 e n2
        /// ao final retorna o resultado
        ///<summary>
        ///<returns>retorna o resultado da soma do formatro</returns>
        }
        ///<summary>
        /// O metodo subtração realiza a subtração entre os numeros
        /// numero: n1 e n2
        /// ao final retorna o resultado
        ///<summary>
        ///<returns>retorna o resultado da subtração do formatro</returns>
        public double Subtrair()
        {
            resultado = numero1 - numero2;
            return resultado;
        }
       
    
        ///<summary>
        /// O metodo multiplicação realiza a multiplicação entre os numeros
        /// numero: n1 e n2
        /// ao final retorna o resultado
        ///<summary>
        ///<returns>retorna o resultado da multiplicação do formatro</returns>
        public double Multiplicar()
        {
            resultado = numero1 * numero2;
            return resultado;
        }

        ///<summary>
        /// O metodo divisão realiza a siviao entre os numeros
        /// numero: n1 e n2
        /// ao final retorna o resultado
        ///<summary>
        ///<returns>retorna o resultado da divisão do formatro</returns>
        public double Dividir()
        {
            resultado = numero1 / numero2;
            return resultado;
        }


    }
}
