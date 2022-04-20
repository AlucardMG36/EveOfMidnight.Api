namespace EveOfMidnight.Api.Models;

/// <summary>
/// View Model for an empty base request
/// </summary>
public class HomeViewModel : ViewModel<Home>
{
    public HomeViewModel(string selfUrl, Home data)
        : base(selfUrl, data)
    {
    }
}
