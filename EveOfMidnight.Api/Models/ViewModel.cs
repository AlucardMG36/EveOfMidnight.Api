using EveOfMidnight.Api.Properties;

namespace EveOfMidnight.Api.Models;

public class ViewModel<T> : IViewModel<T>
{
    private const string SelfLinkName = "self";

    private MetaData _meta;

    private T _data;

    private Dictionary<string, Relationship<IViewModel>> _relationships;

    private List<Error> _errors;

    private readonly List<Link> _links;

    public ViewModel(string selfUrl)
    {
        if (selfUrl is null)
        {
            throw new ArgumentNullException(nameof(selfUrl));
        }

        _links = new List<Link>()
            {
                new Link(SelfLinkName,  selfUrl)
            };
    }

    public ViewModel(string selfUrl, T data)
        : this(selfUrl)
    {
        _data = data;
    }

    public T Data
    {
        get => _data;
        set => SetData(value);
    }

    public MetaData Meta
    {
        get => _meta;
        set => SetMetaData(value);
    }

    public IDictionary<string, Relationship<IViewModel>> Relationships => _relationships;

    public IEnumerable<Error> Errors => _errors;

    public IEnumerable<Link> Links => _links;

    public Error AddError(string message, int statusCode)
    {
        EnsureDataHasNotBeenSet();

        EnsureErrorsCollectionIsNotNull();

        var error = new Error(message, statusCode);

        _errors.Add(error);

        return error;
    }

    public Link AddLink(string name, string href)
    {
        var link = new Link(name, href);

        _links.Add(link);

        return link;
    }

    public Link GetLink(string name) => Links.SingleOrDefault(c => c.Name.Equals(name));


    public IViewModel AddRelationship<TRelation>(TRelation relationshipToAdd) where TRelation : IViewModel
    {
        EnsureErrorsHasNotBeenSet();

        EnsureRelationshipsAreNotNull();

        var relationship = new Relationship<IViewModel>()
        {
            Data = relationshipToAdd
        };

        var relationNameSpan = new ReadOnlySpan<Char>(typeof(TRelation).Name.ToCharArray());

        var startOViewModel = relationNameSpan.IndexOf('V');

        var relationName = startOViewModel != -1 ? relationNameSpan.Slice(0, startOViewModel).ToString() : relationNameSpan.ToString();

        _relationships.Add(relationName, relationship);

        return relationship.Data;
    }

    private void EnsureDataHasNotBeenSet()
    {
        if (_data != null)
        {
            throw new InvalidOperationException(Resource.ViewModelCannotAddError);
        }
    }

    private void EnsureErrorsCollectionIsNotNull()
    {
        _errors ??= new List<Error>();
    }

    private void EnsureErrorsHasNotBeenSet()
    {
        if (_errors != null)
        {
            throw new InvalidOperationException(Resource.ViewModelCannotSetDataProperty);
        }
    }

    private void EnsureRelationshipsAreNotNull()
    {
        _relationships ??= new Dictionary<string, Relationship<IViewModel>>();
    }

    private void SetData(T data)
    {
        EnsureErrorsHasNotBeenSet();

        _data = data;
    }

    private void SetMetaData(MetaData metaData)
    {
        _meta = metaData;
    }
}
