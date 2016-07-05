using System;
using System.Collections;
using System.Collections.Generic;

namespace SimpleTest
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Dictionary<string, int> dic = new Dictionary<string, int> ();
			dic ["a"] = 12;
			dic ["b"] = 13;

			Console.WriteLine (dic.Count);
			Console.WriteLine (dic["a"]);
			Console.WriteLine (dic["c"]);
		}
	}
}
