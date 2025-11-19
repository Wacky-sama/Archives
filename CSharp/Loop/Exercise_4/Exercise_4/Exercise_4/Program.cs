/*
 * Created by SharpDevelop.
 * User: Home
 * Date: 29/10/2022
 * Time: 6:08 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Exercise_4
{
	class Program
	{
		public static void Main(string[] args)
		{
			int i, j, sum=0;
			double avg;
			
			Console.Write("\n\n");
			Console.Write("Read 10 numbers and calculate sum and average:\n");
			Console.Write("------------------------------------------------");
			Console.Write("\n\n");
			
			Console.Write("Input the 10 numbers: \n");
			for (i = 1; i <= 10; i++)
			{
				Console.Write("Number-{0}: ", i);
			
				j = Convert.ToInt32(Console.ReadLine());
			sum+=j;
			}
			avg = sum / 10.0;
			Console.Write("The sum of 10 no is : {0}\nThe Average is: {1}\n", sum, avg);
			Console.ReadKey(true);
		}
	}
}