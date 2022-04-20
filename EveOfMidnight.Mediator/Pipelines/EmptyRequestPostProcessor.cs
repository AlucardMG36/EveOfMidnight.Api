namespace EveOfMidnight.Mediator.Pipelines;

internal class EmptyRequestPostProcessor<TRequest, TResponse> : IRequestPostProcessor<TRequest, TResponse>
    where TRequest : IRequest<TResponse>
{
    private readonly TextWriter _writer;

    public EmptyRequestPostProcessor(TextWriter writer)
    {
        _writer = writer;
    }

    public Task Process(TRequest request, TResponse response, CancellationToken cancellationToken)
    {
        return _writer.WriteLineAsync("- All Done");
    }
}