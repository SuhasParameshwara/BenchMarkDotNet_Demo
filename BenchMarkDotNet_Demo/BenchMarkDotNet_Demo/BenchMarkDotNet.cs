using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenchMarkDotNet_Demo
{
	public class BenchMarkDotNet
	{
		[Benchmark]
		public string GetNameByFirstOrDefault()
		{
			var blogNames = new List<string>
			{
				"nullablereference",
				"efficientUser"
			};
			return blogNames.FirstOrDefault(x => x == "nullablereference");
		}

		[Benchmark]
		public string GetNameBySingleOrDefault()
		{
			var blogNames = new List<string>
			{
				"nullablereference",
				"efficientUser"
			};
			return blogNames.SingleOrDefault(x => x == "nullablereference");
		}
	}
}
