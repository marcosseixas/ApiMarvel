using System;
using ApiMarvel;
using System.Net.Http;

class GetCharacters
{
    static void Main(string[] args)
    {
        Credentials timestamp;
        timestamp = new Credentials();

        var hash = timestamp.Hash();

        var url = new Uri("https://gateway.marvel.com/v1/public/characters?ts=" + timestamp.GetTimestamp() + "&apikey=" +  timestamp.public_key + "&hash=" + hash + "&limit=10");

        var result = GetPost(url);

        Console.WriteLine(result);
    }

    static object GetPost(Uri url)
    {
        using (var client = new HttpClient())
        {
            var result = client.GetAsync(url).Result;
            var json = result.Content.ReadAsStringAsync().Result;
            return json;
        }
    }

}