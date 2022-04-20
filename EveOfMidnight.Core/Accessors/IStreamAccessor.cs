namespace EveOfMidnight.Core.Accessors;

/// <summary>
/// <para>Tells the caller to iterate over the streamed results asynchronously</para>
/// <inheritdoc cref="IAsyncEnumerable{T}"/> 
/// </summary>
/// <typeparam name="T">The underlying type to stream back</typeparam>
public interface IStreamAccessor<out T>: IAsyncEnumerable<T>
{
    /// <summary>
    /// Retrieves all entities of the type <typeparamref name="T"/> from the database
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns><see cref="IAsyncEnumerable{T}"/>: <typeparamref name="T"/></returns>
    IAsyncEnumerable<T> GetAllAsync(CancellationToken cancellationToken = default);
}