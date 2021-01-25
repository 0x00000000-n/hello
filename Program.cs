using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello
{
    class Program
    {
        static void Main(string[] args)
        {
			int b = Int32.Parse(Console.ReadLine());
			int a = Int32.Parse(Console.ReadLine());
			Console.WriteLine(a - b);
			Console.WriteLine(a + b);
			Console.WriteLine(a / b);
			Console.WriteLine(a * b);
        }
    }
}
