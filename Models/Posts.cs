namespace Serialize_Deserialize.Models;

public readonly record struct Posts (int UserId, int Id, string Title, string Body);