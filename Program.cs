using System;

namespace AULA02D
{
    class Program
    {
        static void Main(string[] args)
        {
            String NomeProduto ;
            Double Preco1, Preco2, Preco3, PrecoMedio;
            Console.Write("Entre com o Nome do Produto: ");
            NomeProduto = Console.ReadLine();
            Console.Write("Entre com o Preço 1 coletado: ");
            Preco1 =Convert.ToDouble(Console.ReadLine());
            Console.Write("Entre com o Preço 2 coletado: ");
            Preco2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Entre com o Preço 3 coletado: ");
            Preco3 = Convert.ToDouble(Console.ReadLine());
            PrecoMedio = (Preco1 + Preco2 + Preco3) / 3;
            Console.Write("Preço Médio do " + NomeProduto+":");
            Console.WriteLine(Math.Round(PrecoMedio,2));
            Console.ReadLine();
        }
    }
}
