using System;
namespace AlertaEstoque
{
    class Program
    {
        static void Main(string[] args)
        {
            double QtdMaxima,QtdAtual,resultado;    /*variáveis; 
            QtdMaxima: Variavel especificada pelo usuario para definir parametro de capacidade maxima
            QtdAtual: variavel especificada pelo usuario para definir parametro de estado atual
            resultado: variavel que definira o resultado dos parametros, ou seja o "x"*/
            string NomeProduto; //variável especificada pelo usuario, p definir o nome do produto

            Console.Clear();
            Console.WriteLine("Especifique o nome do produto");
            NomeProduto = Console.ReadLine();
            Console.WriteLine("Especifique a quantidade atual do produto");
            QtdAtual = double.Parse(Console.ReadLine());
            Console.WriteLine("Especifique a quantidade máxima do produto");
            QtdMaxima = double.Parse(Console.ReadLine());
            resultado = (QtdAtual / QtdMaxima)*100;
            //O comando ToString ("n2") formata a saida do número que está em resultado
            //com 2 casas decimais. Ao final concatenamos com símbolo de porcentagem
            Console.WriteLine(resultado.ToString("n2")+"%");
            if(resultado <= 12)
                Console.WriteLine(" *****     Comprar com Urgência!!!     *****");
            else if(resultado<=20)
                Console.WriteLine("#### Realizar Compra! ####");
            else
                Console.WriteLine("----     Ponto de Utilização :)  ----");
        }
    }
}
