using System.IO;

namespace Logica
{
    public class CriarArquivo
    {
    //Atributos da classe CriarArquivo
    public string nomearquivo;
    public string extensao;
    public int codigoproduto;
    public string nomeproduto;
    public string marcaproduto;
    public double precoproduto;

//Funcionalidade da classe, comportamento
public string salvar(){

    /*Vamos usar uma classe para nos ajudar a criar o arquivo de texto
    e escrever dentro deste arquivo
    Utilizaremos a classe StreamWriter*/

    StreamWriter ar = new StreamWriter(nomearquivo+"."+extensao,true);

//vamos escrever os dados no arquivo
ar.WriteLine(codigoproduto+";"+nomeproduto+";"+marcaproduto+";"+precoproduto);
//fechar o arquivo para salvar e tirar da memoria 
ar.Close();
    return "Salvo com sucesso!";
    
    
}


    }
}