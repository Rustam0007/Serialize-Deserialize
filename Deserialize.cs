using System.Net.Http.Json;
using System.Text.Json;
using Serialize_Deserialize.Models;

namespace Serialize_Deserialize;

public static class Deserialize
{
    public static async Task DeserializeJsonInOneObject(string uri, string path)
    {
        using HttpClient client = new ();
        client.BaseAddress = new Uri(uri);
       
        Posts posts = await client.GetFromJsonAsync<Posts>(path);
        Console.WriteLine(posts);
    }
    public static async Task DeserializeJsonArrayObject(string uri, string path)
    {
        using HttpClient client = new ();
        client.BaseAddress = new Uri(uri);
        
        var posts = await client.GetFromJsonAsync<List<Posts>>(path);
        Console.WriteLine(posts);
    }
    public static async Task DeserializeJsonUsersAll(string uri, string path)
    {
        using HttpClient client = new ();
        client.BaseAddress = new Uri(uri);
        
        var users = await client.GetFromJsonAsync<List<Users>>(path);
        Console.WriteLine(users);
    }
}