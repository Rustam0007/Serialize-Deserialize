using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using Serialize_Deserialize.Models;

namespace Serialize_Deserialize;

public static class Serialize
{
    public static async Task SerializeJsonInOneObject(string uri, string path)
    {
        using HttpClient client = new ();
        client.BaseAddress = new Uri(uri);

        var post = await client.GetFromJsonAsync<Posts>(path);

        var postJson = JsonSerializer.Serialize(post);
        
        // var utf8Reader = new Utf8JsonReader(postJson);
        // var deserializedPost = JsonSerializer.Deserialize<Posts>(ref utf8Reader);

        var deserializePost = JsonSerializer.Deserialize<Posts>(postJson);

        Console.WriteLine(postJson);
        Console.WriteLine(deserializePost);
    }
    
    public static void SerializeWithOptions()
    {
        var post = new Posts
        {
            Body = "Posts",
            Title = "Get Posts",
            UserId = 1
        };
        var options = new JsonSerializerOptions
        {
            WriteIndented = true,
            NumberHandling = JsonNumberHandling.AllowReadingFromString,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        };
        Console.WriteLine(JsonSerializer.Serialize(post, options));
    }
}