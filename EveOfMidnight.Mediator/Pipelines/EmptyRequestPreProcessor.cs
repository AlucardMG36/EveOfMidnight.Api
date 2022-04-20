#nullable disable
namespace EveOfMidnight.Mediator.Pipelines;
internal class EmptyRequestPreProcessor<TRequest> : IRequestPreProcessor<TRequest>
    {
        private readonly TextWriter _writer;

        public EmptyRequestPreProcessor(TextWriter writer)
        {
            _writer = writer;
        }

        public Task Process(TRequest request, CancellationToken cancellationToken)
        {
            return _writer.WriteLineAsync("- Starting Up");
        }
    }