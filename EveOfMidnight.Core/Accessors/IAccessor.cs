namespace EveOfMidnight.Core.Accessors;

/// <summary>
/// <para>Contains read access methods to retrieve particular values of <typeparamref name="T"/></para>
/// <inheritdoc cref="IEnumerable{T}"/>
/// </summary>
/// <typeparam name="T">The underlying type to enumerate back to the caller</typeparam>
public interface IAccessor<T>: IEnumerable<T>
{
    /// <summary>
    /// Retrieves all entities of type <typeparamref name="T"/> from the database
    /// </summary>
    /// <returns><see cref="Task{T}"/>: <seealso cref="IEnumerable{T}"/>: <typeparamref name="T"/></returns>
    Task<IEnumerable<T>> GetAllAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieves an entity by the specified <paramref name="entityId"/> 
    /// </summary>
    /// <param name="entityId">The provided Id to search on</param>
    /// <returns><see cref="Task{T}"/>: <typeparamref name="T"/></returns>
    Task<T> WithIdAsync(Guid entityId, CancellationToken cancellationToken = default);
}
