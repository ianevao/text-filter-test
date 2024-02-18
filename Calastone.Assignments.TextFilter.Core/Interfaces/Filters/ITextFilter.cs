namespace Calastone.Assignments.TextFilter.Core.Interfaces.Filters;
public interface ITextFilter
{
    IEnumerable<string> Filter(IEnumerable<string> words);
}