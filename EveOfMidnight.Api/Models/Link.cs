namespace EveOfMidnight.Api.Models;

/// <summary>
/// A container for the information regarding API endpoints
/// </summary>
/// <param name="Href">The address for the endpoint</param>
/// <param name="Name">The name of the endpoint</param>
public sealed record Link(String Href, String Name);