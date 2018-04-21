/* Este programa foi desnvolvido com intuito de ajudar usuarios que tenham grandes inventários
ele tem por objetivo alertar o usuario se ele precisa ou não suprir o iventário, tendo três estagios:
Urgente: 12% ou menos do estoque
Remediado: de 13% a 20%
utilizavel: acima de 20%
*/


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
                Console.WriteLine(" *****     Supra com Urgência!!!     *****");
            else if(resultado<=20)
                Console.WriteLine("#### Remedie o estoque! ####");
            else
                Console.WriteLine("----     Ponto de Utilização :)  ----");
        }
    }
}
