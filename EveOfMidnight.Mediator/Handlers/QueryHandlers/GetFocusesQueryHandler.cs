namespace EveOfMidnight.Mediator.Handlers.QueryHandlers;

internal class GetFocusesQueryHandler: IRequestHandler<GetFocusesQuery, IEnumerable<Focus>>
{
    private readonly IFocusAccessor _focuses;

    public GetFocusesQueryHandler(IFocusAccessor foci)
    {
        _focuses = foci ?? throw new ArgumentNullException(nameof(foci));
    }

    public Task<IEnumerable<Focus>> Handle(GetFocusesQuery request, CancellationToken cancellationToken)
    {
        var focusResult = _focuses.ToList();

        return Task.FromResult(focusResult.AsEnumerable());
    }
}
