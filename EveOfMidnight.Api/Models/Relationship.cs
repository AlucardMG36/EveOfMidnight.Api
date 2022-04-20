namespace EveOfMidnight.Api.Models;

public class Relationship<T> : IViewModel<T>
{
    public T Data { get; set; }
}