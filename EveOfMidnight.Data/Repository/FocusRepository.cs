using EveOfMidnight.Core.Accessors;

namespace EveOfMidnight.Data.Repository;

internal class FocusRepository : BaseRepository<Focus>, IFocusAccessor
{
    public FocusRepository(IDbContextFactory<EveofmidnightContext> contextFactory) 
        : base(contextFactory)
    {
    }

    public override IEnumerator<Focus> GetEnumerator()
    {
        using var context = ContextFactory.CreateDbContext();

        var focusEnumerator = context.Focuss.ToList().GetEnumerator();

        return focusEnumerator;
    }

    public override async Task<IEnumerable<Focus>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        await using var context = await ContextFactory.CreateDbContextAsync(cancellationToken);

        var focuses = await context.Focuss
            .OrderBy(f => f.Id)
            .ToListAsync(cancellationToken);

        return focuses;
    }
}