using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaT1
{
	public class GanadorPiedraPapelTijera
	{


		public static void Main()
		{

			Random rnd = new Random();
			int maquina = rnd.Next(1, 3);
			int Jugador = 0;
			int Computador = 0;


			Console.WriteLine(":: BIENVENIDO Al JUEGO PIEDRA PAPEL O TIJERAS ::");

			Console.WriteLine(":: MENU ::");
			Console.WriteLine("");
			Console.WriteLine("1.PIEDRA");
			Console.WriteLine("2. PAPEL");
			Console.WriteLine("3. TIJERAS");
			Console.WriteLine("");
			Console.WriteLine("Ingrese opcion");
			int x = Int32.Parse(Console.ReadLine());
			Console.WriteLine("La maquina jugó" + maquina);
			switch (x)
			{
				case 1:
					if (x == maquina)
					{
						Jugador = Jugador + 0;
						Computador = Computador + 0;
						Console.WriteLine("Empate");
					}
					else if (x > maquina)
					{
						Jugador = Jugador + 1;
						Console.WriteLine("Ganó");
					}
					else
					{
						Computador = Computador + 1;
						Console.WriteLine("Perdió");
					}

					break;
				case 2:
					if (x == maquina)
					{
						Jugador = Jugador + 0;
						Computador = Computador + 0;
						Console.WriteLine("Empate");
					}
					else if (x > maquina)
					{
						Jugador = Jugador + 1;
						Console.WriteLine("Ganó");
					}
					else
					{
						Computador = Computador + 1;
						Console.WriteLine("Perdió");
					}

					break;
				case 3:
					if (x == maquina)
					{
						Jugador = Jugador + 0;
						Computador = Computador + 0;
						Console.WriteLine("Empate");
					}
					else if (x > maquina)
					{
						Jugador = Jugador + 1;
						Console.WriteLine("Ganó");
					}
					else
					{
						Computador = Computador + 1;
						Console.WriteLine("Perdió");
					}

					break;



			}
		}

	}
}

				