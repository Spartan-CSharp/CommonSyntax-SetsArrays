using System;

namespace ConsoleUI
{
	internal class Program
	{
		private static void Main()
		{
			string[] names = new string[] { "Tim", "Sue", "Bob" };

			Console.Write("Pick a number from 1 to 3: ");
			string numbertext = Console.ReadLine();

			bool isvalidnumber = int.TryParse(numbertext, out int number);

			if ( !isvalidnumber || number < 1 || number > 3 )
			{
				Console.WriteLine("That is not a valid number.");
				_ = Console.ReadLine();
				return;
			}

			Console.WriteLine($"The name in position {number} is {names[number - 1]}.");

			_ = Console.ReadLine();
		}
	}
}
