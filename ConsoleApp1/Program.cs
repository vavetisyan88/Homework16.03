using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			//1
			string mystring1 = "Vahagn Avetisyan";
			Console.WriteLine(mystring1);
			int myint1 = 29;
			Console.WriteLine(myint1);
			//2
			int a = 7, b = 70;
			Console.WriteLine(100 * a / b);
			//3
			double pi = 3.14, r = 10;
			Console.WriteLine(pi * r * r);
			//4
			double pi2 = 3.14, r2 = 5;
			Console.WriteLine(2 * pi2 * r);
			//5
			Console.Write("n = ");
			string n = Console.ReadLine();
			int x = 1440;
			Console.WriteLine(x * int.Parse(n));
			//6
			int a2 = 12, b2 = 15;
			Console.WriteLine(a2 < b2);
			//7
			string ms1 = "Hello", ms2 = "Hi";
			Console.WriteLine(ms1.Length < ms2.Length);
			//8
			double mydouble = 44.5;
			double mydouble1 = 16.7;
			Console.WriteLine(mydouble + mydouble1);
			Console.WriteLine(Math.Round(mydouble + mydouble1));
			//9
			int c = 10, d = 20;
			Console.WriteLine(2 * (c + d));
			Console.WriteLine(c * d);

			Console.ReadLine();
		}
	}
}
