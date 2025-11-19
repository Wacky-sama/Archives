/*
 * Created by SharpDevelop.
 * User: tabug
 * Date: 06/10/2025
 * Time: 9:04 pm
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ForLoop
{
	class Program
	{
		public static void Main(string[] args)
		{
			int i, j, rows;
			
			Console.Write("Input number of rows: ");
			rows = Convert.ToInt32(Console.ReadLine());
			for(i = 1; i <= rows; i++)
			{
				for(j = 1; j <= i; j++)
					Console.Write("*");
				Console.Write("\n");
			}
			Console.ReadKey();
		}
	}
}