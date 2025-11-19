/*
 * Created by SharpDevelop.
 * User: Home
 * Date: 29/10/2022
 * Time: 6:22 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Exercise_5
{
	class Program
	{
		public static void Main(string[] args)
		{
			int i, j;
			
			Console.Write("\n\n");
			Console.Write("Display the cube of the number:\n");
			Console.Write("---------------------------------");
			Console.Write("\n\n");
			
			Console.Write("Input number of terms: ");
			j = Convert.ToInt32(Console.ReadLine());
			for (i = 1; i <= j; i++)
			{
				Console.Write("Number is: {0} and cube of the {1} is: {2} \n", i, i, (i*i*i));
				Console.ReadKey(true);
			}
		}
	}
}