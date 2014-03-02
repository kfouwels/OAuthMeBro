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

###Todo

1. Infrastructure == Y

2. Twitter == X
	1. HandShaking == X
		1. Prep/Base64 keys == Y
		2. Post for Token == WIP
		3. Deserialise == N
	2. GetMeTweets
		1. GET? == N
		2. Deserialise? == N

3. Facebook == X

4. LinkedIn == X
