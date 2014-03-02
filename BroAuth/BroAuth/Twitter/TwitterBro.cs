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
		public async Task Handshake(string consumerKey, string consumerSecret)
		{
			//encode keys
			var mash = consumerKey + ":" + consumerSecret;
			var encd = Convert.ToBase64String(Encoding.Unicode.GetBytes(mash));

			//get token
			var request = (HttpWebRequest)WebRequest.Create("https://api.twitter.com/oauth2/token");
			request.Method = "POST";

			request.Headers["Authorisation"] = "Basic ";

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
