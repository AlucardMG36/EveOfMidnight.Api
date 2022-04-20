using System.Collections.ObjectModel;

namespace EveOfMidnight.Api.Models;

/// <summary>
/// A representation of a collection of objects built to be returned via an endpoint from the API
/// </summary>
/// <typeparam name="T">The underlying type of ViewModel returned</typeparam>
public class ViewModelCollection<T>
    : ViewModel<ICollection<ViewModel<T>>>
{
    public ViewModelCollection(string selfUrl)
        : base(selfUrl, new Collection<ViewModel<T>>())
    {
    }

    public ViewModelCollection(string selfUrl, IEnumerable<ViewModel<T>> data)
        : base(selfUrl, data.ToList())
    {
    }
}
