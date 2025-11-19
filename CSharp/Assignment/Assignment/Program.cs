/*
 * Created by SharpDevelop.
 * User: tabug
 * Date: 06/10/2025
 * Time: 9:06 pm
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Assignment
{
	class Program
	{
		public static void Main(string[] args)
		{
			int[] k = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
			int[] d = {1, 2, 3, 4, 5};
			
			foreach (int t in k){
				if (d[4] > t){
					Console.WriteLine("Low Values: " + t);
					if (t % 2 == 0){
						Console.WriteLine("Even: " + t);
					}
					else {
						Console.WriteLine("Odd: " + t);
					}
				}
				else if (d[4] < t){
					Console.WriteLine("High Values: " + t);
					if (t % 2 == 0){
						Console.WriteLine("Even: " + t);
					}
					else {
						Console.WriteLine("Odd: " + t);
					}
				}
			}
			Console.ReadKey(true);
		}
	}
}