using System;
namespace Calculator;

class Program
{
	static void Main(string[] args)
	{
		// Console.Clear();
		int opcao = Menu();

		while (opcao != (int)EOperacao.Sair) {

			Console.Clear();
			

			switch (opcao)
			{
				case (int)EOperacao.Soma:
					Soma(); 
					break;
				case (int)EOperacao.Subtracao: 		
					Subtracao(); 
					break;
				case (int)EOperacao.Divisao: 		
					Divisao(); 
					break;
				case (int)EOperacao.Multiplicacao:
					Multiplicacao(); 
					break;
				default:
					Console.WriteLine("\nOpção inválida! Tente novamente.");
					break;
			}
			Console.ReadKey();

			opcao = Menu();
		}



	}

	static int Menu(){
		Console.Clear();
		Console.WriteLine("\n-----------------------------------------");
		
		Console.WriteLine("|	Digite a operação que deseja:	|");
		Console.WriteLine("|	1 - soma			|");
		Console.WriteLine("|	2 - subtração			|");
		Console.WriteLine("|	3 - divisão			|");
		Console.WriteLine("|	4 - multiplicação		|");
		Console.WriteLine("|	0 - sair			|");

		Console.WriteLine("-----------------------------------------");

		Console.Write("===> ");
		short opcao = short.Parse(Console.ReadLine());

		return opcao;
	}
	static void Soma () 
	{
		Console.Write("Digite o primeiro número: ");
		double primeiroNumero 	=  Convert.ToDouble(Console.ReadLine());

		Console.Write("Digite o segundo número: ");
		double segundoNumero	=  Convert.ToDouble(Console.ReadLine());
		Console.WriteLine($"\nO resultado da soma é {primeiroNumero + segundoNumero}");

		// Console.ReadKey();
	}

	static void Subtracao() 
	{
		Console.Write("Digite o primeiro número: ");
		double primeiroNumero 	=  Convert.ToDouble(Console.ReadLine());

		Console.Write("Digite o segundo número: ");
		double segundoNumero	=  Convert.ToDouble(Console.ReadLine());
		Console.WriteLine($"\nO resultado da subtração é {primeiroNumero - segundoNumero}");
		// Console.ReadKey();

	}

	static void Divisao() 
	{
		Console.Write("Digite o primeiro número: ");
		double primeiroNumero 	=  Convert.ToDouble(Console.ReadLine());

		Console.Write("Digite o segundo número: ");
		double segundoNumero	=  Convert.ToDouble(Console.ReadLine());
		Console.WriteLine($"\nO resultado da divisão é {primeiroNumero / segundoNumero}");
		// Console.ReadKey();
	}

	static void Multiplicacao()
	{
		Console.Write("Digite o primeiro número: ");
		double primeiroNumero 	=  Convert.ToDouble(Console.ReadLine());

		Console.Write("Digite o segundo número: ");
		double segundoNumero	=  Convert.ToDouble(Console.ReadLine());
		Console.WriteLine($"\nO resultado da multiplicação é {primeiroNumero * segundoNumero}");
		// Console.ReadKey();
	}
	enum EOperacao 
	{
		Sair 		= 0,
		Soma		= 1,
		Subtracao	= 2,
		Divisao		= 3,
		Multiplicacao	= 4
	}
}

