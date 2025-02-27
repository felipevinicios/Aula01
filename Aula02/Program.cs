using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            double largura, comprimento, precoMetroQuadrado, area, preco;

            Console.Write("Digite a largura: ");
            largura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture );

            Console.Write("Digite o comprimento: ");
            comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite o preco do metro quadrado: ");
            precoMetroQuadrado = double.Parse((Console.ReadLine()), CultureInfo.InvariantCulture);

            area = largura * comprimento;
            preco = area * precoMetroQuadrado;

            Console.WriteLine("area = "+ area.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("preco = " + preco.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();

        }

    }
}