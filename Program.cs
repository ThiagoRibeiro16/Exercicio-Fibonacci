using System;

namespace Exercicio_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            int termos;
            bool numeroValido;

            Console.WriteLine("Sequência de Fibonacci");
            Console.WriteLine("----------------------\n");

            Console.Write("Digite a quantidade de termos: ");
            numeroValido = Int32.TryParse(Console.ReadLine(), out termos);

            if (!numeroValido || termos < 2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nQuantidade de termos ({termos}) inválidas");
                Console.ResetColor();
                Environment.Exit(-1);

            }


            int num1 = 0;
            int num2 = 1;
            int num3;

            Console.WriteLine($"\nSequência de Fibonacci com {termos} termos \n");


            for (int i = 0; i < termos; i += 1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($" {num1} ");
                Console.ResetColor();

                num3 = num1 + num2;
                num1 = num2;
                num2 = num3;
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Obrigado por utilizar nosso programa");
            Console.ResetColor();






        }
    }
}
