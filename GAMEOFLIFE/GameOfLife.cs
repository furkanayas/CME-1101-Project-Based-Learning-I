using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace son2
{
	class MainClass
	{
		public static string[,] arrayone = new string[16, 32];
		static string[,] rotateE(string[,] matrix)
		{
			string[,] ret = new string[3, 3];

			for (int i = 0; i < 3; ++i)
			{
				for (int j = 0; j < 3; ++j)
				{
					ret[i, j] = matrix[3 - j - 1, i];
				}
			}

			return ret;
		}



		static string[,] print(string[,] arr, int cursorx, int cursory)
		{

			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					if (arrayone[cursory - 6 + j, ((cursorx - 2) / 2) - 1 + i] == ".")
					{
						arrayone[cursory - 6 + j, ((cursorx - 2) / 2) - 1 + i] = arr[j, i];
					}
				}
			}
			return arrayone;
		}
		public static void Main(string[] args)
		{
			// Board's array.

			for (int h = 0; h < arrayone.GetLength(0); h++)
			{
				for (int j = 0; j < arrayone.GetLength(1); j++)
				{
					arrayone[h, j] = ".";
				}
			}

			/*static string[,] rotateW(string[,] matrixe)
{
	string[,] ret = new string[3, 3];

	for (int i = 0; i < 3; ++i)
	{
		for (int j = 0; j < 3; ++j)
		{
			ret[0, 0] = matrixe[0, 0] = "o";
			ret[0, 1] = matrixe[0, 1] = "o";
			ret[0, 2] = matrixe[0, 2] = ".";

			ret[1, 0] = matrixe[1, 0] = "o";
			ret[1, 1] = matrixe[1, 1] = ".";
			ret[1, 2] = matrixe[1, 2] = "o";

			ret[2, 0] = matrixe[2, 0] = "o";
			ret[2, 1] = matrixe[2, 1] = ".";
			ret[2, 2] = matrixe[2, 2] = ".";
		}
	}

	return ret;
} */




			// STEP and LIVE section.
			Console.SetCursorPosition(69, 3);
			Console.WriteLine("STEP : ");
			Console.SetCursorPosition(69, 4);
			Console.WriteLine("LIVE : ");
			// Q, W, R particles.
			// Array for Q particle
			string[,] array1 = new string[3, 3];
			Console.SetCursorPosition(69, 7);
			Console.Write("Q : ");
			Console.SetCursorPosition(73, 6);
			for (int b = 0; b < array1.GetLength(0); b++)
			{
				for (int a = 0; a < array1.GetLength(1); a++)
				{
					if (b == 1)
					{
						array1[b, a] = "o";
					}
					else
					{
						array1[b, a] = ".";
					}
					Console.Write(array1[b, a] + " ");
				}
				Console.SetCursorPosition(73, 7 + b);
			}
			// Array for W particle
			string[,] array2 = new string[3, 3];
			Console.SetCursorPosition(69, 12);
			Console.Write("W : ");
			Console.SetCursorPosition(73, 11);
			for (int b = 0; b < array2.GetLength(0); b++)
			{
				for (int a = 0; a < array2.GetLength(1); a++)
				{

					array2[0, 0] = "o";
					array2[0, 1] = "o";
					array2[0, 2] = ".";

					array2[1, 0] = "o";
					array2[1, 1] = ".";
					array2[1, 2] = "o";

					array2[2, 0] = "o";
					array2[2, 1] = ".";
					array2[2, 2] = ".";

					Console.Write(array2[b, a] + " ");
				}
				Console.SetCursorPosition(73, 12 + b);
			}

			// Array for R particle
			string[] fe = { ".", "o" };
			Random rndm = new Random();
			string[,] array3 = new string[3, 3];

			Console.SetCursorPosition(69, 17);
			Console.Write("R : ");
			Console.SetCursorPosition(73, 16);
			for (int b = 0; b < array3.GetLength(0); b++)
			{
				for (int a = 0; a < array3.GetLength(1); a++)
				{

					array3[b, a] = fe[rndm.Next(0, 2)];
					Console.Write(array3[b, a] + " ");

				}

				Console.SetCursorPosition(73, 17 + b);
			}

			Console.SetCursorPosition(69, 21);
			Console.WriteLine("E : ");
			Console.SetCursorPosition(73, 20);
			string[,] array4 = new string[3, 3];

			for (int b = 0; b < array4.GetLength(0); b++)
			{
				for (int a = 0; a < array4.GetLength(1); a++)
				{
					if (a == 1 && b == 1)

						array4[1, 1] = "o";

					else
						array4[b, a] = ".";

					Console.Write(array4[b, a] + " ");
				}
				Console.SetCursorPosition(73, 21 + b);
			}


			string[,] array5 = new string[3, 3];
			{
				for (int b = 0; b < array3.GetLength(0); b++)
				{
					for (int a = 0; a < array3.GetLength(1); a++)
					{
						array5[b, a] = ".";
					}
				}
			}



			Console.SetCursorPosition(33, 12);
			int cursorx = 32, cursory = 13;   // position of cursor
			ConsoleKeyInfo cki;               // required for readkey

			// --- Main game loop
			while (true)
			{
				if (Console.KeyAvailable)
				{       // true: there is a key in keyboard buffer
					cki = Console.ReadKey(true);       // true: do not write character 

					if (cki.Key == ConsoleKey.RightArrow && cursorx < 63)
					{   // key and boundary control
						Console.SetCursorPosition(cursorx, cursory);          // delete X (old position)

						cursorx += 2;
					}
					if (cki.Key == ConsoleKey.LeftArrow && cursorx > 2)
					{
						Console.SetCursorPosition(cursorx, cursory);
						cursorx -= 2;
					}
					if (cki.Key == ConsoleKey.UpArrow && cursory > 5)
					{
						Console.SetCursorPosition(cursorx, cursory);
						cursory--;
					}
					if (cki.Key == ConsoleKey.DownArrow && cursory < 20)
					{
						Console.SetCursorPosition(cursorx, cursory);
						cursory++;
					}
					if (cki.KeyChar >= 97 && cki.KeyChar <= 102)
					{       // keys: a-f 
						Console.SetCursorPosition(50, 5);

					}
					if (cki.Key == ConsoleKey.D1 || cki.Key == ConsoleKey.NumPad1)
					{
						array1 = rotateE(array1);
					}

					/* if (cki.Key == ConsoleKey.D2 || cki.Key == ConsoleKey.NumPad2)
					{
						array2 = rotateW(array2); } */

					if (cki.Key == ConsoleKey.Q)
					{
						print(array1, cursorx, cursory);
					}
					if (cki.Key == ConsoleKey.W)
					{
						print(array2, cursorx, cursory);
					}
					if (cki.Key == ConsoleKey.R)
					{
						print(array3, cursorx, cursory);
					}
					if (cki.Key == ConsoleKey.T)
					{
						print(array3, cursorx, cursory);
					}
					if (cki.Key == ConsoleKey.E)
					{
						print(array4, cursorx, cursory);
					}
					if (cki.Key == ConsoleKey.Spacebar)
					{
						print(array5, cursorx, cursory);
					}
				}


				Thread.Sleep(50);     // sleep 50 ms
				Console.SetCursorPosition(0, 0);
				Console.WriteLine();
				Console.WriteLine();
				// Game Title
				Console.WriteLine("#=#=#=#=#=#=#=#=#=#=#=#=#=#=# Life Sim #=#=#=#=#=#=#=#=#=#=#=#=#=#=");
				Console.WriteLine();
				// Board's edges and lines in "for loop."
				Console.Write("╔");
				for (int s = 0; s < 65; s++)
				{
					Console.Write("═");
				}
				Console.Write("╗");
				Console.WriteLine();
				for (int p = 0; p < 16; p++)
				{
					Console.Write("║ ");
					for (int z = 0; z < 32; z++)
					{
						Console.Write(arrayone[p, z] + " ");
					}
					Console.Write("║");
					Console.WriteLine();
				}
				Console.Write("╚");
				for (int s = 0; s < 65; s++)
				{
					Console.Write("═");
			}
			Console.Write("╝");
		


		
			}
		}
	}

}
