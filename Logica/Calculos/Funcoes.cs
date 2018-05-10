namespace Calculos
{
    public class Funcoes
    {
        public double Soma(double[] valores)
        {
            double rs = 0;
            for (int x = 0; x < valores.Length; x++)
                rs += valores[x];

            return rs;
        }

        public double media(double[] valores)
        {

            double rs = 0;
            for (int x = 0; x < valores.Length; x++)
                rs += valores[x];

            return rs / valores.Length;
        }
        public double potencia(int bs, int ex) 
        {
                double rs = 1;
                for(int k = 1; k <= ex; k++)
                rs*=bs;
                return rs;
        }

        public double Maior(double[] valores)
        {
            double m = valores[0]; 
            for(int p =1; p < valores.Length; p++)
            {
                if(valores[p] >m)
                m = valores[p];
         }
            return m;
        }   
        
    }

}

