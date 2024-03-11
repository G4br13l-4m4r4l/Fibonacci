using System;

class Program
{
    static void Main(string[] args)
    {
        //Fibonacci
        Console.Write("Digite um número para verificar se pertence à sequência de Fibonacci:");
        int numero = int.Parse(Console.ReadLine());

        if (VerificarSePertenceFibonacci(numero))
        {
            Console.WriteLine($"\n{numero} pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"\n{numero} não pertence à sequência de Fibonacci.");
        }

        Console.Beep();
       
        Console.WriteLine("\n ______     ________      ___ __ __\r\n/_____/\\   /_______/\\    /__//_//_/\\\r\n\\::::_\\/_  \\__.::._\\/    \\::\\| \\| \\ \\\r\n \\:\\/___/\\    \\::\\ \\      \\:.      \\ \\\r\n  \\:::._\\/    _\\::\\ \\__    \\:.\\-/\\  \\ \\\r\n   \\:\\ \\     /__\\::\\__/\\    \\. \\  \\  \\ \\\r\n    \\_\\/     \\________\\/     \\__\\/ \\__\\/");
        Console.ReadKey();
    }

    static bool VerificarSePertenceFibonacci(int numero)
    {
        int a = 0;
        int b = 1;
        int temp;

        while (a < numero)
        {
            temp = a;
            a = b;
            b = temp + b;
        }

        return a == numero;
    }
}
