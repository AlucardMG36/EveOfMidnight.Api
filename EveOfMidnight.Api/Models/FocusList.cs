using EveOfMidnight.Core.Models;

namespace EveOfMidnight.Api.Models
{
    public class FocusList: ViewModelCollection<Focus>
    {
        private FocusList(string selfUrl) : base(selfUrl)
        {
        }

        private FocusList(string selfUrl, IEnumerable<ViewModel<Focus>> data) : base(selfUrl, data)
        {
        }

        public static FocusList From(HttpRequest request, IEnumerable<Focus> focuses)
        {
            var requestPath = request.Path;

            var data = focuses.Select(x => FocusViewModel.From(request, x));

            var vm = new FocusList(requestPath.ToString(), data);

            return vm;
        }
    }
}
