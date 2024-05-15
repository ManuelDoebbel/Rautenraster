/*
 * User: Doebbel
 * Date: 08.04.2024
 * Time: 11:57
 */
using System;

namespace Rautenraster
{
	class Program
	{
		public static void Main(string[] args)
		{
			InputForHashes();
			OutputHashes();
			
			Console.ReadKey(true);
		}
		
		private static int hoehe;
		private static int breite;
		
		private static string X = "X";
		
		private static void InputForHashes(){
			Console.Write("Bitte die Höhe eingeben: ");
			hoehe = int.Parse(Console.ReadLine());
			
			Console.Write("Bitte die Breite eingeben: ");
			breite = int.Parse(Console.ReadLine());
		}
		
		// HIER BEGINNT DAS WICHTIGE!!
		private static void OutputHashes(){
			// for-Schleife der oberen Rahmen-Reihe der Xs
			for(int k = 0; k < breite +2; k++){
				OutputXs();
			}

			Console.WriteLine();
			
			// for-Schleife der Xs am linken Rand
			for(int i = 0; i < hoehe; i++){
				OutputXs();
				//for-Schleife für die Breite der Reihe aus #
				for(int j = 0; j < breite; j++){
					Console.Write("#");
				}
				// Aufruf der Methode für rechten Rand der Xs
				OutputXsEndL();
			}
			// for-Schleife deere unteren Rahmen-Reihe der Xs
			for(int k = 0; k < breite +2; k++){
				OutputXs();
			}
		}
		
		// Ausgabe-Methode der Xs
		private static void OutputXs(){
			Console.Write(X);
		}
		// Ausgabe-Methode letzten Zeichen (Xs) pro Reihe
		private static void OutputXsEndL(){
			Console.WriteLine(X);			
		}
	}
}