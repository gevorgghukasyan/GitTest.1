using System;

namespace GitTest._1
{
	internal class Program
	{

        static void DoubleValue(ref int number)
        {
            number *= 2;
        }
        static void CalculateSquare(int number, out int square)
        {
            square = number * number;
        }


        static void Main(string[] args)
		{
			Hayk newUser = new Hayk("Aram", "Grigoryan");
			newUser.Print();
			try
			{
				int num1 = int.Parse(Console.ReadLine());
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}

			Console.WriteLine("C#");
            VaheHomework vaheHomework = new VaheHomework();
			int num = 10;
            Console.WriteLine($"Original number: {num}");
            DoubleValue(ref num);
            Console.WriteLine($"After doubling (ref): {num}");



        }
	}
}
