using System;

namespace calccnpj
{
    class calccnpj
    {
        static void Main(string[] args)
        {
            string cnpj, d1, d2, vf;
            int v1=12, v2=13, rs1=0, rs2=0, resto;
            int[] m1 = new int[12] {5,4,3,2,9,8,7,6,5,4,3,2};
            int[] m2 = new int[13] {6,5,4,3,2,9,8,7,6,5,4,3,2}; 

            /*Legenda variáveis
            cnpj = é a variável que gurado o numero de cnpj a ser verificado
            d1 = é a variavel que guarda o primeiro digito do cnpj a ser verificado
            d2 = é a variável que guarda o segundo digito do cnopj a ser verificado
            vf = verificação finalizada, é a variável que guarda o resultado final da conta
            
            v1 = é a variável que guarda o valor p verificação do primeiro digito
            v2 = é a variável que guarda o valor p verificação do segundo digito
            rs1 = é a variável que guarda o resultado da verificação do digito 1 (primeiro)
            rs2 = é a variável que guarda o resultado da verificação do digito 2 (segundo)
            resto = é a variável que guarda o resto da divisão
            m1 = é a variavél definida para a multiplicação dos fatores ante digito 1
            m2 = é a variavél definida para a multiplicação dos fatores ante digito 2        
            */
            
            Console.Clear();
            Console.WriteLine("INSIRA O CNPJ A SER VERIFICADO:");
            cnpj = (Console.ReadLine());
            d1 = cnpj.Substring(0,12);

            for(int k=0; k < d1.Length;k++)
            {
                rs1 += int.Parse(d1[k].ToString())*m1[k];
                v1--;                     
            }
            resto = rs1 % 11;
            if(resto < 2)
            d2 = d1+0;
            else 
            d2 = d1+(11-resto);


            for(int j=0; j < d2.Length;j++)
            {
                rs2 += int.Parse(d2[j].ToString())*m2[j];
                v2--;                     
            }
            resto = rs2 % 11;
            if(resto < 2)
            vf = d2+0;
            else 
            vf=d2+(11-resto);

            if(vf==cnpj)
            {
                Console.Clear();
                Console.WriteLine("CNPJ VÁLIDO");
            }
            else if(vf!=cnpj)
            {
            Console.Clear();
            Console.WriteLine("CNPJ INVÁLIDO");
        }
    }
    } 
    }
