#OAuthMeBro
(Soon to be) Bunch of libs to automate doing oauth requests to twitter

###Intended Usage

```csharp

//Create a new bro
var bro = new TwitterBro();

//Handshake the bro
bro.Handshake("apiKey", "apiSecret")

//Query the bro
var results = bro.getMeTweets("query", "result_type", count);

```
__Edit (2015): Just use linqtotwitter - it's pretty great now__
