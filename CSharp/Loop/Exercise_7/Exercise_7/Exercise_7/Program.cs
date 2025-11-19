/*
 * Created by SharpDevelop.
 * User: Home
 * Date: 30/10/2022
 * Time: 10:06 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Exercise_7
{
	class Program
	{
		public static void Main(string[] args)
		{
			int i, j, tableLimit;
			
			Console.Write("\n\n");
			Console.Write("Display the multiplication table vertically from 1 to n:\n");
			Console.Write("----------------------------------------------------------");
			Console.Write("\n\n");
			
			Console.Write("Input upto the table number starting from 1: ");
			tableLimit = Convert.ToInt32(Console.ReadLine());
			for (j = 1; j <= 10; j++)
			{
				for (i = 1; i <= tableLimit; i++)
				{
					if (i <= tableLimit-1)
						Console.Write("{0}x{1} = {2}," ,i , j, i*j);
				else
					Console.Write("{0}x{1} = {2}", i, j, i*j);
				
				}
				Console.Write("\n\n");
				Console.ReadKey(true);
			}
		}
	}
}