using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace Algorithm_BackPack
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int total_value = 100;
			List<int> frag_value_list = new List<int>{ 10, 20, 30 };
			List<int> res = CalcCount (total_value, frag_value_list);
			Console.WriteLine (JsonConvert.SerializeObject (res, Formatting.Indented));

			int real_total_value = 0;
			for (int i = 0; i < res.Count; i++) {
				int itotal = frag_value_list [res [i]];
				Console.WriteLine (itotal);
				real_total_value += itotal;
			}

			Console.WriteLine ("real_total_value = " + real_total_value);
		}

		public static List<int> CalcCount (int total_value, List<int> frag_value_list)
		{
			List<int> idx_count_list = new List<int> ();
			int remain_value = total_value;

			Random r = new Random (1);

			bool need_new_random_frag_idx = true;
			int frag_idx = 0;
			do {

				if (need_new_random_frag_idx) {
					frag_idx = r.Next (frag_value_list.Count);
				} else {
					frag_idx--;
					if (frag_idx < 0) {
						break;
					}
				}

				if (remain_value >= frag_value_list [frag_idx]) {
					remain_value -= frag_value_list [frag_idx];
					idx_count_list.Add (frag_idx);
				} else {
					need_new_random_frag_idx = false;
				}

			} while(true);

			return idx_count_list;
		}
	}
}
