using EveOfMidnight.Core.Models;

namespace EveOfMidnight.Api.Models;

public class FocusViewModel : ViewModel<Focus>
{
    private FocusViewModel(string selfUrl, Focus data)
        : base(selfUrl, data)
    {
    }

    internal static FocusViewModel From(HttpRequest request, Focus focus)
    {
        var selfUrl = $"{request.Path}/{focus.Id}";

        var vm = new FocusViewModel(selfUrl, focus);

        return vm;
    }
}