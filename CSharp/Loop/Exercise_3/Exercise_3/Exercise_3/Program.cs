/*
 * Created by SharpDevelop.
 * User: Home
 * Date: 29/10/2022
 * Time: 5:57 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Exercise_3
{
	class Program
	{
		public static void Main(string[] args)
		{
			int i, j, sum = 0;
			
			Console.Write("\n\n");
			Console.Write("Display n terms of natural number and their sum:\n");
			Console.Write("--------------------------------------------------");
			Console.Write("\n\n");
			
			Console.Write("Input Value of terms: ");
			j=Convert.ToInt32(Console.ReadLine());
			Console.Write("\nThe first {0} natural number are: \n", j);
			for (i = 1; i <= j; i++)
			{
				Console.Write("{0} ", i);
			sum+=i;
			}
			Console.Write("\nThe Sum of Natural Number upto {0} terms : {1} \n", j, sum);
			Console.ReadKey(true);
		}
	}
}