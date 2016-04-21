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
		public static string json_str = @"
		{
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

		public static string json_str_poker = @"
			{
			  ""player_count"": 2,
			  ""players"": [
			    {
			      ""playfab_id"": ""1001"",
			      ""display_name"": ""ethan"",
			      ""player_room_identity"": ""RoomMaster"",
			      ""hand_cards"": []
			    },
			    {
			      ""playfab_id"": ""1002"",
			      ""display_name"": ""dream"",
			      ""player_room_identity"": ""RoomGuest"",
			      ""hand_cards"": []
			    }
			  ],
			  ""pile_for_show"": []
			}
		";

		public static void Main (string[] args)
		{
//			JObject jo = JObject.Parse (json_str);
//			List<bool> jp_list = jo.AsJEnumerable ().Select (jt => {
//				return ((JProperty)jt).Value ["enable"].Value<bool> ();
//			}).ToList ();

			JObject jo = JObject.Parse (json_str_poker);

			var i = jo ["players"]
				.Select ((jt, _idx) => new {jt, _idx})
				.Where (kv => kv.jt ["playfab_id"].Value<string> () == "1001")
				.Select (kv => kv._idx)
				.Single ();


			Console.WriteLine ("i: " + JsonConvert.SerializeObject (i));
		}
	}
}
