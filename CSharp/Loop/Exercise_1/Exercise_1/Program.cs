/*
 * Created by SharpDevelop.
 * User: Home
 * Date: 29/10/2022
 * Time: 5:28 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Exercise_01
{
	class Program
	{
		public static void Main(string[] args)
		{
			int i;
			Console.Write("\n\n");
			Console.Write("Display the first 10 natural numbers:\n");
			Console.Write("----------------------------------------");
			Console.Write("\n\n");
			
			Console.WriteLine("The first 10 natural number are: ");
			
			for (i = 1; i <= 10; i++)
			{
				Console.Write("{0} ", i);
			}
			Console.Write("\n\n");
			Console.ReadKey(true);
		}
	}
}