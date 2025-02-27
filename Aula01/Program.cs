namespace Aula01;

public class Program
{

    public static void Main()
    {
        Console.WriteLine(" Calculadora Simples");

        Console.WriteLine("Digite o numero: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite um numero: ");
        double num2 = Convert.ToDouble(Console.ReadLine());


        Console.WriteLine("\nEscolha uma operacao: ");
        Console.WriteLine("1. adicao (+)");
        Console.WriteLine("2. subtrcao (-)");
        Console.WriteLine("3. multiplicacao (*)");
        Console.WriteLine("4. divisao (/) ");
        Console.WriteLine("Digite o numero da operacao: ");
        int operation = Convert.ToInt32(Console.ReadLine());
        double result = 0;

        if (operation == 1)
        {
            result = num1 + num2;
        }

        else if (operation == 2)
        {
            result = num1 - num2;
        }
        else if (operation == 3)
        {
            result = num2 * num1;
        }
        else if (operation == 4)
        {
            if (num2 != 0)
            {
                result = num1 / num2;
            }
            else
            {
                Console.WriteLine("Erro: nao e posivel dividir");
            }
        }
        else
        {

            Console.WriteLine("Operacao invalida");

        }
        Console.WriteLine("Resultado: " + result);
    }



}