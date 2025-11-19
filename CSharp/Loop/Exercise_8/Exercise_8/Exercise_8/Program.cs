/*
 * Created by Wacky.
 */
using System;

namespace Exercise_8
{
	class Program
	{
		public static void Main(string[] args)
		{
			int i, j, sum=0;
			
			Console.Write("\n\n");
			Console.Write("Display the sum of n odd natural number:\n");
			Console.Write("------------------------------------------");
			Console.Write("\n\n");
			
			Console.Write("Input number of terms: ");
			j = Convert.ToInt32(Console.ReadLine());
			for (i = 1; i <= j; i++)
			{
				Console.Write("{0} ",2*i-1);
				sum+=2*i-1;
			}
			Console.Write("\nThe Sum of odd Natural Number upto {0} terms : {1} \n", j, sum);
			Console.ReadKey(true);
		}
	}
}