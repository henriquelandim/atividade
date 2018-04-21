/*Este é um programa desenvolvido para mostrar quais são os anos bissexto entre 1910 e 2018 */

using System;

namespace AnoBissexto
{
    class Program
    {
        static void Main(string[] args)
        {   Console.Clear();
            
            int resultado=0;/*Essa variavel nos dara o resultado, ou seja o termo de quantos anos bissexto houve
            de 1910 a 2018, ela tem que ser mantida em 0 p funcionar como uma variavel de registro */
            for(int i=1910; i <=2018; i++){/*nessa linha é estabelecido o periodo que a variavel atuara, ou seja
            de 1910 a 2018*/
                if(i%4==0){ /*nessa linha é especificado o termo, que é 4 a igualdade estabelecida ali no "4==0"
                é porque a linguagem não permite ser só (i%4) o termo precisa ser igualado, e nesse caso como 
                queremos o resultado real, deixaremos igualado a 0 ou seja 1910+4=1914+4...E nada mais. */

                    Console.WriteLine(i + " - Este ano é bissexto");    /*nessa linha é indexado o termo processado 
                    a um frase de auxilio*/
                    
                  resultado++; /*nesta linha é obtido o resultado do numero de anos bissexto 
                  duranto o periodo especificado (1910 a 2018)*/
                }
            }
            Console.WriteLine(resultado+" anos bissexto houve no periodo especificado"); /*resultado de anos bissexto 
            indexado a uma frase de auxilio*/
        }
    }
}
