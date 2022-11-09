using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec3_Enumerable
{
	internal class Program
	{
		static void Main(string[] args)
		{
			IEnumerable<int> source = Enumerable.Range(1, 10); 
			foreach (var item in source)
			{
				Console.WriteLine(item);
			}

			IEnumerable<int> source2 = Enumerable.Range(10, 15);
			foreach (var item in source2)
			{
				Console.WriteLine(item);
			}


		}
	}
}
