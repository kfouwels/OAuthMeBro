#OAuthMeBro

###Usage

//Create a new bro
var bro = new TwitterBro();

//Handshake the bro
bro.Handshake("apiKey", "apiSecret")

//Query the bro
var results = bro.getMeTweets("query", "result_type", count);
