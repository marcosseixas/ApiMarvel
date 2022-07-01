using System;
using ApiMarvel;
using RestSharp;

class GetCharacters
{
    static void Main(string[] args)
    {
        Credentials timestamp;
        timestamp = new Credentials();

        var hash = timestamp.Hash();

        string url = "gateway.marvel.com/v1/public/characters?ts=" + timestamp.GetTimestamp() + "&apikey=" +  timestamp.public_key + "&hash=" + hash + "&limit=10";

        var client = new RestClient(url);
        //client.Timeout = -1;
        var request = new RestRequest(Method.GET);
        IRestResponse response = client.Execute(request);
        Console.WriteLine(response.Content);
    }
}