using System;

class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("Digite um número para verificar se pertence à sequência de Fibonacci:");
		int numero = int.Parse(Console.ReadLine());

		if (VerificarSePertenceFibonacci(numero))
		{
			Console.WriteLine($"{numero} pertence à sequência de Fibonacci.");
			Console.ReadKey();
		}
		else
		{
			Console.WriteLine($"{numero} NÃO pertence à sequência de Fibonacci.");
			Console.ReadKey();
		}
	}

	static bool VerificarSePertenceFibonacci(int numero)
	{
		int a = 0;
		int b = 1;
		int soma = 0;

		while (soma < numero)
		{
			soma = a + b;
			a = b;
			b = soma;
		}

		return soma == numero;
	}
}
