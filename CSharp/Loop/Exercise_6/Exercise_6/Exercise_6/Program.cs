/*
 * Created by SharpDevelop.
 * User: Home
 * Date: 29/10/2022
 * Time: 6:30 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Exercise_6
{
	class Program
	{
		public static void Main(string[] args)
		{
			int i, j;
			
			Console.Write("\n\n");
			Console.Write("Display the multiplication table:\n");
			Console.Write("-----------------------------------");
			Console.Write("\n\n");
			
			Console.Write("Input the number (Table to be calculated): ");
			j = Convert.ToInt32(Console.ReadLine());
			for (i = 1; i <= 10; i++)
			{
				Console.Write("{0} X {1} = {2} \n", i, j, i*j);
				Console.ReadKey(true);
			}
		}
	}
}