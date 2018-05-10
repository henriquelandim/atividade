using System;
using Calculos;

namespace UsandoCalculos
{
    class Program
    {
        static void Main(string[] args)
        {
            Operacoes op = new Operacoes();
            op.numero1 = 20;
            op.numero2 = 5;
            Console.WriteLine("O resultado da soma eh:"+op.Soma());
            Console.WriteLine("O resultado da divisao eh:"+op.Dividir());
            Console.WriteLine("O resultado da multiplicacão eh:"+op.Multiplicar());
            Console.WriteLine("O resultado da subtração eh:"+op.Subtrair());
            
        }
    }
}
