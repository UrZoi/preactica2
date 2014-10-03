/*
 * Created by SharpDevelop.
 * User: XX
 * Date: 30/09/2014
 * Time: 23:41
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace practica2
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			

			
			Console.WriteLine("Dame la cantidad de producto 1");
			int prod1=int.Parse(Console.ReadLine());
			
			Console.WriteLine("dame la descripcion");
			string desprod1=Console.ReadLine();
			
			Console.WriteLine("dame el precio unitario");
			double precprod1=double.Parse(Console.ReadLine());
			
			Console.WriteLine("Dame la cantidad de producto 2");
		         int prod2=int.Parse(Console.ReadLine());
		
		         
			Console.WriteLine("dame la descripcion");
			string desprod2=Console.ReadLine();
			
			Console.WriteLine("dame el precio unitario");
			double precprod2=double.Parse(Console.ReadLine());
			
		         
			Console.WriteLine("Dame la cantidad de producto 3");
              int prod3=int.Parse(Console.ReadLine());
              
              
			Console.WriteLine("dame la descripcion");
			string desprod3=Console.ReadLine();
			
			Console.WriteLine("dame el precio unitario");
			double precprod3=double.Parse(Console.ReadLine());
			
              
			Console.WriteLine( prod1 + "  " + desprod1 + " " + (prod1*precprod1) + "$ ");
			Console.WriteLine( prod2 + "  " + desprod2 + " " + (prod2*precprod2) + "$ ");
			Console.WriteLine( prod3 + "  " + desprod3 + " " + (prod3*precprod3) + "$ ");
			Console.WriteLine("iva"+ (precprod1+precprod2+precprod3*1.16));
			
			Console.WriteLine( prod2 + "  " + desprod2 + " " + precprod2 + "$ ");
						double precprodd3=double.Parse(Console.ReadLine());
			
		}
	}
}