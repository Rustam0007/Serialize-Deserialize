namespace Serialize_Deserialize.Models;

public readonly record struct Users(int Id, string Name, string UserName, string Email, Address Address);

public readonly record struct Address(string Street, string Suite, string City, string ZipCode, Geo Geo);

public readonly record struct Geo(string Lat, string Lng);