using System;
using System.IO;

namespace Logica
{
    public class LerArquivo
    {
        public string nomearquivo;
        public string extensao;

        public object Encoding { get; private set; }

        public void ler()
        {
        /*Para ler o arquivo o usuário, vamos utilizar a classe StreamReader.
        Faremos uma condição para saber se chegamos ao final do arquivo. Caso tenha chegado ao fim do arquivo., o comando ReadLine retornará null,
        Caso contrário ele retornará a linha do arquivo. */
        StreamReader ar = new StreamReader(nomearquivo+";"+extensao,Encoding.UTF8);
        string linha="";
        while((linha=ar.ReadLine())!=null)
{
    Console.WriteLine(linha);


}
ar.Close();
        }
    }
}