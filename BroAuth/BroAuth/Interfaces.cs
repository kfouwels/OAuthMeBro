using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BroAuth
{
	public interface ITwitterBro
	{
		Task Handshake(string apiKey, string apiSecret);
		string GetMeTweets(string query, string result_type, int count);
	}
}
