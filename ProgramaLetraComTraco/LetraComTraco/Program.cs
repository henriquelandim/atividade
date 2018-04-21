/*  Este programa tem como objetivo, criar um gerador de intersecção ao longo de um texto
Ex: J-o-ã-o-z-i-n-h-o- -f-o-i- -c-o-m-p-r-a-r- -p-ã-o-.
para desenvolver um programa com esse objetivo precisaremos aprender um pouco mais sobre estrutura
de repetiçoes: https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/for */


using System;

namespace LetraComTraco
{
    class Program
    {
        static void Main(string[] args)
        {
           string texto;    //variável de texto, para leitura do texto do usario
            Console.Clear();    //comando de limpeza de tela
            Console.WriteLine("Digite um texto");   //instrui ao usuario, para digitar um texto
            texto = Console.ReadLine(); //leitura do texto é armazenada na variável 
            
            for(int k = 0 ; k < texto.Length; k++)  /*loop de instrução, ele fara um loop 
            com base na quantidade de caracteres que for instruido na variavel texto, ou seja se você colocar
            a palavra "bicicleta" ele fara a repetição da palavra 9 vezes pois ela tem 9 letras*/
                
                Console.Write(texto[k]+"-"); /*para o loop não ocorrer como especificado acima
                e só adicionar um "-" entre as letras, foi adicionado o "[k]", ou seja a cada
                caracter adicionado na variável texto, ele adicionara o "-" (traço) entre as letras.*/
        }
    }
}
