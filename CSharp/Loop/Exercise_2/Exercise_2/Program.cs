/*
 * Created by SharpDevelop.
 * User: Home
 * Date: 29/10/2022
 * Time: 5:43 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Exercise_2
{
	class Program
	{
		public static void Main(string[] args)
		{
			int i, sum = 0;
			
			Console.Write("\n\n");
			Console.Write("Find the sum of first 10 natural numbers:\n");
			Console.Write("-------------------------------------------");
			Console.Write("\n\n");
			
			Console.Write("The first 10 natural numbers are:\n");
			for (i = 1; i <= 10; i++)
			{
			sum = sum + i;
			Console.Write("{0} ", i);
			}
			Console.Write("\nThe Sum is: {0}\n", sum);
			Console.ReadKey(true);
		}
	}
}