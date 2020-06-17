namespace Aula19Dojo2
{
    public class IngressoVip : Ingresso
    {
        public float ValorAdicional { get; set; }

        public void MostrarValorVip()
        {
            float resultado = Valor + ValorAdicional;
            System.Console.WriteLine($"O valor do ingresso vip é R${resultado} ");

        } 
    }
}