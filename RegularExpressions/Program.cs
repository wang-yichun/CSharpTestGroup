using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using Newtonsoft.Json;

namespace RegularExpressions
{
	/// <summary>
	/// 匹配 office 软件打开文档时所自动生成的临时文件 (excel)
	/// </summary>
	class MainClass
	{
		// test 1
		//		public static List<string> test_list = new List<string> {
		//			"/Users/EthanW/Documents/UnityProjects/AEX/Submodules/MathLabraryExtendForUnity/DataWorkSheet/abc~$AEXDataSheet.xlsx",
		//			"/Users/EthanW/Documents/UnityProjects/AEX/Submodules/MathLabraryExtendForUnity/DataWorkSheet/~$AEXDataSheet.xlsx",
		//			"/Users/EthanW/Documents/UnityProjects/AEX/Submodules/MathLabraryExtendForUnity/DataWorkSheet/~$等级表.xlsx",
		//			"/Users/EthanW/Documents/UnityProjects/AEX/Submodules/MathLabraryExtendForUnity/DataWorkSheet/道具相关.xlsx",
		//			"/Users/EthanW/Documents/UnityProjects/AEX/Submodules/MathLabraryExtendForUnity/DataWorkSheet/ab道具相关.xlsx",
		//			"/Users/EthanW/Documents/UnityProjects/AEX/Submodules/MathLabraryExtendForUnity/DataWorkSheet/ab.xlsx",
		//			"/Users/EthanW/Documents/UnityProjects/AEX/Submodules/MathLabraryExtendForUnity/DataWorkSheet/a_b.xlsx"
		//		};

		// test 2
		//		public static List<string> test_list_poker = new List<string> {
		//			"(DIAMOND,NV_QUEEN)",
		//			"(CLUB,NV_ACE)",
		//			"(SPADE,NV_QUEEN)"
		//		};

		// test 3
		public static List<string> test = new List<string> {
			"p0", "p1", "p2", "p 3", "  p4", "p5  ", "###"
		};

		public static void Main (string[] args)
		{
// 			test 1
//			test_list.ForEach (text => {
//				Match m = Regex.Match (text, "\\/([_a-zA-Z0-9\\u4e00-\\u9fa5]*\\.xlsx)$");
//				Console.WriteLine (text + " / " + m.Groups [1] + " / " + m.Value);
//			});

// 			test 2
//			test_list_poker.ForEach (text => {
//				Match m = Regex.Match (text, "^\\(([_A-Z0-9]+),([_A-Z0-9]+)\\)$");
//				Console.WriteLine (string.Format ("s: {0}, nv: {1}", m.Groups [1].Value, m.Groups [2].Value));
//			});

			test.ForEach (text => {
				Match m = Regex.Match (text, @"[^\d]*(\d+)");
				Console.WriteLine (string.Format ("suc:{0} 0: {1}, 1: {2}", m.Success, m.Groups [0].Value, m.Groups [1].Value));
			});
		}
	}
}
