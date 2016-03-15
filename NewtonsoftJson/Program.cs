using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace NewtonsoftJson
{
	class MainClass
	{
		public static string json_str = @"{
										  ""0"": {
										    ""enable"": true,
										    ""file_name_sk"": ""Snail_000"",
										    ""file_name_ui_shell"": ""Snail_000"",
										    ""file_name_ui_map"": ""MapSnail_000"",
										    ""file_in_game"": ""Ball_0""
										  },
										  ""1"": {
										    ""enable"": true,
										    ""file_name_sk"": ""Snail_001"",
										    ""file_name_ui_shell"": ""Snail_001"",
										    ""file_name_ui_map"": ""MapSnail_001"",
										    ""file_in_game"": ""Ball_1""
										  },
										  ""2"": {
										    ""enable"": true,
										    ""file_name_sk"": ""Snail_002"",
										    ""file_name_ui_shell"": ""Snail_002"",
										    ""file_name_ui_map"": ""MapSnail_002"",
										    ""file_in_game"": ""Ball_2""
										  },
										  ""3"": {
										    ""enable"": false,
										    ""file_name_sk"": """",
										    ""file_name_ui_shell"": """",
										    ""file_name_ui_map"": """",
										    ""file_in_game"": """"
										  }
										}";

		public static void Main (string[] args)
		{
			JObject jo = JObject.Parse (json_str);
			List<bool> jp_list = jo.AsJEnumerable ().Select (jt => {
				return (JProperty)jt.Value ["enable"].Value<bool> ();
			}).ToList ();

			Console.WriteLine (JsonConvert.SerializeObject (jp_list, Formatting.Indented));
		}
	}
}
