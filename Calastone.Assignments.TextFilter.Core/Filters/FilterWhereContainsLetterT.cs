using Calastone.Assignments.TextFilter.Core.Interfaces.Filters;

namespace Calastone.Assignments.TextFilter.Core.Filters;
public class FilterWhereContainsLetterT : ITextFilter
{
    public IEnumerable<string> Filter(IEnumerable<string> words)
    {
        var removable = words.Where(i => i.Contains("t", StringComparison.CurrentCultureIgnoreCase));
        return words.Where(i => !removable.Contains(i));
    }
}