using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassByRefOrValue
{
	static class MethodDemo
	{
		public static void PassByValue(int a)
		{
			a = 11;
			Console.WriteLine("Value inside method is {0} ", a);
		}

		public static void PassByReference(int[] b)
		{
			b[0] = 11;
			Console.WriteLine("Value inside method is {0} ", b[0]);
		}

		public static void PassByValue(string s)
		{
			s = "new string";
			Console.WriteLine("Value inside method is {0} ", s);
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			int a = 3;
			int[] b = {5, 6, 7};

			string s = "start string";
			
			Console.WriteLine("a before call is {0}", a);
			MethodDemo.PassByValue(a);
			Console.WriteLine("a after call is {0}", a);

			Console.WriteLine("b[0] before call is {0}", b[0]);
			MethodDemo.PassByReference(b);
			Console.WriteLine("b[0] after call is {0}", b[0]);
			
			Console.WriteLine("s before call is {0}", s);
			MethodDemo.PassByValue(s);
			Console.WriteLine("s after call is {0}", s);

			Console.ReadLine();
		}
	}
}
