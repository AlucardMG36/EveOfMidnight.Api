namespace EveOfMidnight.Core.Repositories;
/// <summary>
/// Contains Create, Update, and Delete methods for the underlying entity, <typeparamref name="T"/>
/// </summary>
/// <typeparam name="T">The type that we're operating over</typeparam>
public interface IRepository<in T>
{
    /// <summary>
    /// Adds a <typeparamref name="T"/> entity to the database 
    /// </summary>
    /// <param name="entity"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task CreateAsync(T entity, CancellationToken cancellationToken = default);

    /// <summary>
    /// Updates a <typeparamref name="T"/> entity in the database
    /// </summary>
    /// <param name="entity"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task UpdateAsync(T entity, CancellationToken cancellationToken = default);

    /// <summary>
    /// Removes a <typeparamref name="T"/> entity from the database
    /// </summary>
    /// <param name="entity"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task DeleteAsync(T entity, CancellationToken cancellationToken = default);  
}

