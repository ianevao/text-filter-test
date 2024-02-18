using System.Text;
using Calastone.Assignments.TextFilter.Core.Interfaces.Filters;
using Calastone.Assignments.TextFilter.Core.Interfaces.Helpers;
using Calastone.Assignments.TextFilter.Core.Interfaces.Services;

namespace Calastone.Assignments.TextFilter.Service;

public class TextFilterService : ITextFilterService
{
    private readonly IStringHelper _stringHelper;
    
    public TextFilterService(IStringHelper stringHelper)
    {
        _stringHelper = stringHelper;
    }
    
    public string ApplyFilter(ITextFilter textFilter, string text)
    {
        // Split text into words
        var words = _stringHelper.SplitTextIntoWords(text);
        
        return _stringHelper.BuildTextFromWords(textFilter.Filter(words));
    }

    public string ApplyFilters(ITextFilter[] textFilters, string text)
    {
        // Split text into words
        var words = _stringHelper.SplitTextIntoWords(text);
        // Loop the loop
        foreach (var filter in textFilters)
        {
            words = filter.Filter(words);
        }

        return _stringHelper.BuildTextFromWords(words);
    }
}