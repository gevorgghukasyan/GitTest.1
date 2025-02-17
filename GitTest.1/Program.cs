using System;

namespace GitTest._1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Hayk newUser = new Hayk("Aram", "Grigoryan");
			newUser.Print();
			try
			{
				int num = int.Parse(Console.ReadLine());
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}

			Console.WriteLine("C#");
		}
	}
}
