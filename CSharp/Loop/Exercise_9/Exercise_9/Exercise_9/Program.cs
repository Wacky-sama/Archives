/*
 * Created by SharpDevelop.
 * User: Home
 * Date: 30/10/2022
 * Time: 10:29 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Exercise_9
{
	class Program
	{
		public static void Main(string[] args)
		{
			int i, j, rows;
			
			Console.Write("\n\n");
			Console.Write("Display the pattern like right angle using asterisk:\n");
			Console.Write("------------------------------------------------------");
			Console.Write("\n\n");
			
			Console.Write("Input number of rows: ");
			rows = Convert.ToInt32(Console.ReadLine());
			for (i = 1; i <= rows; i++)
			{
				for (j = 1; j <= i; j++)
					Console.Write("*");
				Console.Write("\n");
			}
			Console.ReadKey(true);
		}
	}
}