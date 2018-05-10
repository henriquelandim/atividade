using System;

namespace Logica
{
    class Program
    {
        static void Main(string[] args)
        {

        //     int codigo;
        //     string nome;
        //     string marca;
        //     double preco;

        //     //limpar a tela de console
        //     Console.Clear();
        //     Console.WriteLine ("Digite o código do produto");
        //     codigo = int.Parse(Console.ReadLine());

        //     Console.WriteLine ("Digite o nome do produto");
        //     nome = Console.ReadLine();

        //     Console.WriteLine ("Digite a marca do produto");
        //     marca = Console.ReadLine();

        //     Console.WriteLine ("Digite o preço do produto");
        //     preco = double.Parse(Console.ReadLine());
        

    

        //     //Instãncia da classe CriarArquivo
        //     CriarArquivo ca = new CriarArquivo();
        //     ca.nomearquivo = "produtosz";
        //     ca.extensao = "csv".Replace(".","");
        // if (".csv".IndexOf(".")==0)
        //         ca.extensao = ".csv";

        //     ca.codigoproduto = codigo;
        //     ca.nomeproduto = nome;
        //     ca.marcaproduto = marca;
        //     ca.precoproduto = preco;
        //     Console.WriteLine (ca.salvar());
            LerArquivo la = new LerArquivo();
            la.nomearquivo="produtos";
            la.extensao="csv";
            la.ler();


            //Console.WriteLine("Hello World!");
        }
    }
}
