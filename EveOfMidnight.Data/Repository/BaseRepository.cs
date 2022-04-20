using System.Collections;
using EveOfMidnight.Core.Accessors;
using EveOfMidnight.Core.Repositories;

namespace EveOfMidnight.Data.Repository;

public abstract class BaseRepository<T>: IAccessor<T>, IRepository<T>
{
    protected BaseRepository(IDbContextFactory<EveofmidnightContext> contextFactory)
    {
        ContextFactory = contextFactory;
    }

    public abstract IEnumerator<T> GetEnumerator();
    
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    protected IDbContextFactory<EveofmidnightContext> ContextFactory { get; }

    public abstract Task<IEnumerable<T>> GetAllAsync(CancellationToken cancellationToken = default);

    public virtual Task<T> WithIdAsync(Guid entityId, CancellationToken cancellationToken = default)
    {
        return Task.FromResult(default(T));
    }

    public virtual Task CreateAsync(T entity, CancellationToken cancellationToken = default)
    {
        return Task.CompletedTask;
    }

    public virtual Task UpdateAsync(T entity, CancellationToken cancellationToken = default)
    {
        return Task.CompletedTask;
    }

    public virtual Task DeleteAsync(T entity, CancellationToken cancellationToken = default)
    {
        return Task.CompletedTask;
    }
}
