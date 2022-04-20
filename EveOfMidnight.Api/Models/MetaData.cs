namespace EveOfMidnight.Api.Models;

/// <summary>
/// Contains relevant meta information for the described view model
/// </summary>
public class MetaData
{
    public int CurrentPage { get; set; }

    public bool HasNext { get; set; }

    public bool HasPrevious { get; set; }

    public int LastPage { get; set; }

    public int PageSize { get; set; }

    public int TotalCount { get; set; }

}