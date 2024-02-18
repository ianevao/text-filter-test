namespace Calastone.Assignments.TextFilter.Core.Interfaces.Helpers;

public interface IStringHelper
{
    IEnumerable<string> SplitTextIntoWords(string text);
    string BuildTextFromWords(IEnumerable<string> words);
}