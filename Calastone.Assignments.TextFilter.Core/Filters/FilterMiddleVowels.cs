using Calastone.Assignments.TextFilter.Core.Interfaces.Filters;

namespace Calastone.Assignments.TextFilter.Core.Filters;
public class FilterMiddleVowels : ITextFilter
{
    private IEnumerable<char> _vowels = new[] { 'a', 'e', 'i', 'o', 'u' };
    public IEnumerable<string> Filter(IEnumerable<string> words)
    {
        return words.Where(i => !ContainsVowel(i));
    }

    private bool ContainsVowel(string word)
    {
        int centerPoint = word.Length / 2;
        bool isCharVowel;
            
        // Find middle letter(s):

        if (word.Length % 2 == 0)
        {
            // Precisely splittable means we need to check in more than one place
            isCharVowel = IsCharVowel(word[centerPoint]) || IsCharVowel(word[centerPoint - 1]);
        }
        else
        {
            isCharVowel = IsCharVowel(word[centerPoint]);
        }

        return isCharVowel;
    }

    private bool IsCharVowel(char c)
    {
        var lowered = char.ToLower(c);
        return _vowels.Any(i => i == lowered);
    }
}