/*
 * Created by SharpDevelop.
 * User: tabug
 * Date: 05/10/2025
 * Time: 7:04 pm
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;

namespace STUDENTS_INFORMATION_SYSTEM
{
	class Program
	{
		public static void Main(string[] args){
			int i;
			Console.WriteLine("			WELCOME TO STUDENTS INFORMATION SYSTEM			");
			for (i = 0; i < 100; i ++){
				Console.Write("Press 'ENTER' to continue, type '0' to exit: ");
				string W = Convert.ToString(Console.ReadLine());
				
				if (W == "" + ""){
					Console.Clear();
					Console.WriteLine("PLEASE ANSWER ALL THE INFORMATION NEEDED");
				    Console.Write("\n");
				    
				    try{
				    Console.Write("FULLNAME: ");
				    string A = Convert.ToString(Console.ReadLine());
				    
					Console.Write("YEAR LEVEL: ");
					int B = Convert.ToInt32(Console.ReadLine());
					
					Console.Write("SECTION: ");
					char C = Convert.ToChar(Console.ReadLine());
					
					Console.Write("COURSE: ");
					string D = Convert.ToString(Console.ReadLine());
					
					Console.Write("AGE: ");
					int E = Convert.ToInt32(Console.ReadLine());
					
					Console.Write("SEX: ");
					string F = Convert.ToString(Console.ReadLine());
					
					Console.Write("ADDRESS: ");
					string G = Convert.ToString(Console.ReadLine());
					Console.Clear();
				  
					if (F == "Male" || F == "male" || F == "M" || F == "m"){
					Console.WriteLine(A + " is a Student of CSU Gonzaga University and these are his info: ");
					}else if (F == "Female" || F == "female" || F == "F" || F == "f"){
						Console.WriteLine(A + " is a Student of CSU Gonzaga University and these are her info: ");
					}
					Console.WriteLine("FULLNAME: " + A);
					Console.WriteLine("YEAR LEVEL: " + B);
					Console.WriteLine("SECTION: " + C);
					Console.WriteLine("COURSE: " + D);
					Console.WriteLine("AGE: " + E);
					Console.WriteLine("SEX: " + F);
					Console.WriteLine("ADDRESS: " + G);
				    }
				    catch{
				    	Console.WriteLine("			[MAKE SURE YOU ENTERED THE INFORMATION NEEDED]			");
				    	Console.ReadKey();
				    	Console.Clear();
				    }
				}else if (W == "0"){
					Console.Clear();
					break;
				}else {
					Console.Clear();
					Console.WriteLine("			INVALID KEYWORD			");
				}
			}
			Console.ReadKey(true);
		}
	}
}
