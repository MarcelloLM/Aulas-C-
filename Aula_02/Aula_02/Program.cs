using System;

class MediaEscolar
{
    static void Main()
    {
        Console.WriteLine("Digite as notas das três avaliações:");

        // Lendo as notas das avaliações do usuário
        double po = double.Parse(Console.ReadLine());
        double pi = double.Parse(Console.ReadLine());
        double ni = double.Parse(Console.ReadLine());

        // Calculando a média
        double media = 0.20 * ni + 0.30 * pi + 0.50 * po;

        // Verificando o resultado do aluno
        if (media >= 6)
        {
            Console.WriteLine("Parabéns! Sua média foi {0:F1}. Você passou!", media);
        }
        else if (media >= 2 && media < 6)
        {
            Console.WriteLine("Sua média foi {0:F1}. Você está de exame.", media);
        }
        else
        {
            Console.WriteLine("Sua média foi {0:F1}. Você está de DP.", media);
        }
    }
}
