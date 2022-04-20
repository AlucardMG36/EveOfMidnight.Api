namespace EveOfMidnight.Api.Models;
/// <summary>
/// Empty Container for View Models defined in the API layer
/// </summary>
public interface IViewModel
{

}

/// <summary>
/// Generic wrapper for an <inheritdoc cref="IViewModel"/>
/// </summary>
/// <typeparam name="T">The type we want to wrap</typeparam>
public interface IViewModel<out T> : IViewModel
{
    /// <value>
    /// The data contained within the view model, serialized
    /// </value>
    T Data { get; }
}