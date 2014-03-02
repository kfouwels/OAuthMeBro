using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BroAuth.Twitter
{
	public class TwitterBro : ITwitterBro
	{
		public async Task Handshake(string apiKey, string apiSecret)
		{
			//get token
			var request = (HttpWebRequest)WebRequest.Create("https://api.twitter.com/oauth2/token");
			request.Method = "POST";

			string post = "myPostID=myPostValue&myPostID2=myPostValue2";

			using (var writer = new StreamWriter(await request.GetRequestStreamAsync()))
			{
				writer.Write(post);
			}
			var response = await request.GetResponseAsync();

			throw new NotImplementedException();
		}

		public string GetMeTweets(string query, string result_type, int count)
		{
			throw new NotImplementedException();
		}
	}
}
