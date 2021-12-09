using System;
using System.Globalization;

namespace aula4
{
	class Program
	{
		static void Main(string[] args)
		{
			int N;
			string[] s;
			double[] vet;
			double soma = 0, media;

			N = int.Parse(Console.ReadLine());
			s = Console.ReadLine().Trim().Replace(',','.').Split();

			vet = new double[N];

			for (int i = 0; i < N; i++)
			{
				vet[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
				soma += vet[i];
			}

			media = soma / N;
			Console.WriteLine("");

			for (int i = 0; i < N; i++)
			{
				Console.Write($"{vet[i].ToString("F2", CultureInfo.InvariantCulture)} ");
			}

			Console.WriteLine($"\n{soma.ToString("F2", CultureInfo.InvariantCulture)}");
			Console.WriteLine($"{media.ToString("F2", CultureInfo.InvariantCulture)}");

			Console.ReadLine();
		}
	}
}
