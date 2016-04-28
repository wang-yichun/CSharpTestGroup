using System;
using ProtoBuf;
using System.IO;
using System.Text;

namespace ProtoBuf
{
	[ProtoContract]
	public class A
	{
		[ProtoMember (1)]
		public string p1;

		[ProtoMember (2)]
		public int p2;

		[ProtoMember (3)]
		public float p3;
	}

	class MainClass
	{
		public static void Main (string[] args)
		{

			A a = new A () {
				p1 = "abc",
				p2 = 99,
				p3 = 3.1415f
			};

			MemoryStream stream = new MemoryStream ();

			ProtoBuf.Serializer.Serialize<A> (stream, a);

			byte[] arr = stream.ToArray ();
			Console.Out.WriteLine ("bytes: " + arr.Length);
			Console.Out.WriteLine ("UTF8: " + Encoding.UTF8.GetString (arr));
			stream = new MemoryStream (arr);
			A a2 = ProtoBuf.Serializer.Deserialize<A> (stream);

			Console.Out.WriteLine ("A.p1: " + a2.p1);
			Console.Out.WriteLine ("A.p2: " + a2.p2);
			Console.Out.WriteLine ("A.p3: " + a2.p3);

		}
	}
}
