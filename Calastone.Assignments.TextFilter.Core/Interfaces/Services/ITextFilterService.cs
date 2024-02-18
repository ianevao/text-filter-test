using Calastone.Assignments.TextFilter.Core.Interfaces.Filters;

namespace Calastone.Assignments.TextFilter.Core.Interfaces.Services;
public interface ITextFilterService
{
    string ApplyFilter(ITextFilter textFilter, string text);

    string ApplyFilters(ITextFilter[] textFilters, string text);
}