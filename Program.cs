using System;

namespace first_sharp
{
    class Program
    {
        static void Main(string[] args)
        {


			for (int x = 1; x <= 100; x++)
			{
				if (x%15==0){
					Console.WriteLine(x + "--Fizz Buzz");
				} else if (x%5==0) {
					Console.WriteLine(x + "--fizz");
				} else if ( x % 3 == 0) {
					Console.WriteLine(x + " - buzz");
				} else {
					Console.WriteLine(x);
				}
			}
        }

    }
}
