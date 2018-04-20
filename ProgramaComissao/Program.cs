/*Este programa tem como objetivo, ser uma ferramenta prática 
para calculo de comissão de um departamento de vendas
Fatores importante para o desenvolvimento do programa:
- A meta o percentual de comissão e os valores de vendas são variáveis.
 */


using System;   //serve p/ não precisar fornecer nomes de type completos

namespace ProgramaComissao //serve para organização de classes
{
    class Program   //serve para definir os dados e o comportamento de um type
    {
        static void Main(string[] args) /*
        Main:O método Main é o ponto de entrada de um programa executável; 
        é onde o controle do programa começa e termina.
        
        void: é um método que não retorna nenhum valor. 
        Se fosse um método que retorna por exemplo um inteiro, teria um int no lugar do void.

        string[] args - o método main recebe como parâmetro um vetor de Strings.
        Esse vetor contém aquilo que você passa para o programa quando executa-o na linha de comando.

        static - o método main é um método estático. 
        Isso siginifica que ele é um método da classe e não dos objetos.*/
        {
            Double PerComissao, ValorComissao, ValorMeta, ValorVenda; /*Variáveis do programa de calculo.

            PerComissao: serve para armazenar os dados da porcentagem de comissão que o cliente especificar.

            ValorComissao: é o resultado final, ou seja o valor de comissao que o vendedor recebera.

            ValorMeta: serve para armazenar os dados do valor da meta que o vendedor
            precisa atingir para receber comissao 
            
            ValorVenda: serve para armazenar os dados do valor que o vendedor vendeu*/
            
                Console.Clear();    //serve para limpar a tela de console
                Console.WriteLine("Especifique o valor da meta.");  //aqui o usuario estabelecera objetivo de meta
                ValorMeta = double.Parse(Console.ReadLine());   /*aqui a variável ValorMeta fara a leitura p/
                armazenamento do valor que o vendedor precisara atingir p ter comissao*/

                Console.WriteLine("Especifique o percentual de comissão."); //aqui o usuario estabelece a porcentagem de comissão
                PerComissao = double.Parse(Console.ReadLine()); //variável PerComissao passa a armazenar a porcentagem de comissão

                Console.WriteLine("Especifique o valor da venda."); //aqui o usuario especificara o quanto o vendedor vendeu
                ValorVenda = double.Parse(Console.ReadLine());//variável ValorVenda armazenara o quanto o vendedor vendeu

                if (ValorVenda>=ValorMeta)  //aqui o programa pergunta se o ValorVenda é maior ou igual ao ValorMeta
                    ValorComissao = ValorVenda*(PerComissao/100);  /*
                    VC = ValorComissao
                    VV = ValorVenda
                    PC = PerComissao
                    VC=VV*PC/100    (ValorComissao Igual à ValorVenda multiplicado por PerComissao divido por cem)
                    */
                else ValorComissao = 0;//aqui é definido se o vendedor nao atingir a meta, ou seja ele nao tem comissao

                Console.WriteLine("O valor da comissão é: "+ValorComissao); //aqui damos o resultado final para o usuario..

                



        }
    }
}
