using System.Text;
using Calastone.Assignments.TextFilter.Core.Interfaces.Helpers;

namespace Calastone.Assignments.TextFilter.Core.Helpers;

public class StringHelper : IStringHelper
{
    public IEnumerable<string> SplitTextIntoWords(string text) => text.Split(' ');

    public string BuildTextFromWords(IEnumerable<string> words)
    {
        StringBuilder sb = new StringBuilder();
        foreach (var word in words)
        {
            sb.Append(word);
            sb.Append(' ');
        }

        return sb.ToString();
    }
}