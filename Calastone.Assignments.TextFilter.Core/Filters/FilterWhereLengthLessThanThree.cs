using Calastone.Assignments.TextFilter.Core.Interfaces.Filters;

namespace Calastone.Assignments.TextFilter.Core.Filters;
public class FilterWhereLengthLessThanThree : ITextFilter
{
    private const int MaxLength = 3;
    public IEnumerable<string> Filter(IEnumerable<string> words)
    {
        var removable = words.Where(i => i.Length < MaxLength);
        return words.Where(i => !removable.Contains(i));
    }
}