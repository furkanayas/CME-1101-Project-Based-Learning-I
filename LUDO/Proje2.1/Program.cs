using System;

namespace Proje2
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			char[] numbers = new char[56];
			for (int i = 0; i < numbers.Length; i++)
			{
				numbers[i] = '.';
			}

		Console.SetCursorPosition(0, 0);
			Console.WriteLine("═Player 1═              ═Player 2═     ");
			Console.WriteLine("A B C D     ╔═══════╗    E F G H       ");
			Console.WriteLine("╔═════╗     ╟       ╢    ╔═════╗       ");
			Console.WriteLine("╟     ╢     ╟   o   ╢    ╟ E F ╢       ");
			Console.WriteLine("╟     ╢     ╟   o   ╢    ╟ G H ╢       ");
			Console.WriteLine("╚═════╝     ╟   o   ╢    ╚═════╝       ");
			Console.WriteLine("            ╟   o   ╢                  ");
			Console.WriteLine("╔═══════════╝   ║   ╚═══════════╗      ");
			Console.WriteLine("╟               ║               ╢      ");
			Console.WriteLine("╟   o o o o ════╬════ o o o o   ╢      ");
			Console.WriteLine("╟               ║               ╢      ");
			Console.WriteLine("╚═══════════╗   ║   ╔═══════════╝      ");
			Console.WriteLine("            ╟   o   ╢                  ");
			Console.WriteLine("╔═════╗     ╟   o   ╢    ╔═════╗       ");
			Console.WriteLine("╟ M N ╢     ╟   o   ╢    ╟ I J ╢       ");
			Console.WriteLine("╟ O P ╢     ╟   o   ╢    ╟ K L ╢       ");
			Console.WriteLine("╚═════╝     ╟       ╢    ╚═════╝       ");
			Console.WriteLine("M N O P     ╚═══════╝    I J K L       ");
			Console.WriteLine("═Player 4═             ═Player 3═      ");

			Console.SetCursorPosition(2, 3);
			char[] player1 = { 'A', 'B', 'C', 'D' };

			for (int i = 0; i < player1.Length; i = i + 2)
			{
				Console.Write(player1[i]);
				Console.Write(" ");
				Console.Write(player1[(i + 1)]);
				Console.SetCursorPosition(2, 4);
			}


			int dice1 = 0;


			Random random = new Random();

			int reward11 = 0;int reward12 = 0;int reward13 = 0;int reward21 = 0;int reward22 = 0;int reward23 = 0;
			int penalty11 = 0;int penalty12 = 0;int penalty13 = 0;int penalty21 = 0;int penalty22 = 0;int penalty23 = 0;int penalty31 = 0;

			do
			{

				reward11 = random.Next(1, 56);
				reward12 = random.Next(1, 56);
				reward13 = random.Next(1, 56);
				reward21 = random.Next(1, 56);
				reward22 = random.Next(1, 56);
				reward23 = random.Next(1, 56);
				penalty11 = random.Next(1, 56);
				penalty12 = random.Next(1, 56);
				penalty13 = random.Next(1, 56);
				penalty21 = random.Next(1, 56);
				penalty22 = random.Next(1, 56);
				penalty23 = random.Next(1, 56);
				penalty31 = random.Next(1, 56);
			} while (!(numbers[reward11] == '.' && numbers[reward12] == '.' && numbers[reward13] == '.' &&
					 numbers[reward21] == '.' && numbers[penalty11] == '.' && numbers[penalty12] == '.' &&
					 numbers[penalty13] == '.' && numbers[penalty21] == '.' && numbers[penalty22] == '.' &&
					 numbers[penalty23] == '.' && numbers[penalty31] == '.'));



			numbers[reward11] = ')';numbers[reward12] = ')';numbers[reward13] = ')';numbers[reward21] = '>';numbers[reward22] = '>';numbers[reward23] = '>';
			numbers[penalty11] = '(';numbers[penalty12] = '(';numbers[penalty13] = '(';numbers[penalty21] = '<';numbers[penalty22] = '<';numbers[penalty23] = '<';
			numbers[penalty31] = 'X';


			for (;;)
			{
				int b = 12;int c = 13;int d = 15;int e = 21;int f = 27;int g = 34;int h = 35;int k = 42;int l = 48;int m = 54;


				for (int a = 0; a < 14; a += 2)
				{
					Console.SetCursorPosition(a + 2, 8);
					Console.Write(numbers[a / 2]);
				}
				for (int a = 2; a < 8; a++)
				{
					Console.SetCursorPosition(14, a);
					Console.Write(numbers[b]);
					b = b - 1;
				}
				for (int a = 14; a < 18; a += 2)
				{
					Console.SetCursorPosition(a + 2, 2);
					Console.Write(numbers[c]);
					c = c + 1;
				}
				for (int a = 3; a < 9; a++)
				{
					Console.SetCursorPosition(18, a);
					Console.Write(numbers[d]);
					d = d + 1;
				}
				for (int a = 18; a < 30; a += 2)
				{
					Console.SetCursorPosition(a + 2, 8);
					Console.Write(numbers[e]);
					e = e + 1;
				}
				for (int a = 9; a < 11; a++)
				{
					Console.SetCursorPosition(30, a);
					Console.Write(numbers[f]);
					f = f + 1;
				}
				for (int a = 16; a < 30; a += 2)
				{
					Console.SetCursorPosition(a + 2, 10);
					Console.Write(numbers[g]);
					g = g - 1;
				}
				for (int a = 11; a < 17; a++)
				{
					Console.SetCursorPosition(18, a);
					Console.Write(numbers[h]);
					h = h + 1;
				}
				for (int a = 12; a < 16; a += 2)
				{
					Console.SetCursorPosition(a + 2, 16);
					Console.Write(numbers[k]);
					k = k - 1;
				}
				for (int a = 10; a < 16; a++)
				{
					Console.SetCursorPosition(14, a);
					Console.Write(numbers[l]);
					l = l - 1;

				}
				for (int a = 0; a < 12; a += 2)
				{
					Console.SetCursorPosition(a + 2, 10);
					Console.Write(numbers[m]);
					m = m - 1;
				}
				Console.SetCursorPosition(2, 9);
				Console.Write(numbers[55]);


				numbers[dice1] = '.';
				Random dicerandom = new Random();
				int dice = dicerandom.Next(1, 7);
				dice1 = dice1 + dice;
				Console.SetCursorPosition(20, 20);
				Console.Write("Dice: " + dice);
				Console.SetCursorPosition(20, 21);
				Console.Write("Pawn: ");
				char pawn = Convert.ToChar(Console.Read());


				numbers[dice1] = 'A';
				Console.Read();

			}

			Console.Read();

		}
	}
}
