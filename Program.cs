using Serialize_Deserialize;

// await Deserialize.DeserializeJsonInOneObject("https://jsonplaceholder.typicode.com", "/posts/2");
// await Deserialize.DeserializeJsonArrayObject("https://jsonplaceholder.typicode.com", "/posts");
// await Deserialize.DeserializeJsonUsersAll("https://jsonplaceholder.typicode.com", "/users");
await Serialize.SerializeJsonInOneObject("https://jsonplaceholder.typicode.com", "/posts/2");