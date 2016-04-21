using System;
using System.Reactive.Linq;
using System.Reactive.Concurrency;

namespace ReactiveEx
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Observable
				.Interval (TimeSpan.FromMilliseconds (100))
				.Take (10)
				.Subscribe (i => Console.WriteLine ("i = " + i), () => Console.WriteLine ("on completed"));

			Console.ReadKey ();
		}
	}

//	public class 
}
