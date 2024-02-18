using Calastone.Assignments.TextFilter.Core.Filters;
using Calastone.Assignments.TextFilter.Core.Interfaces.Filters;

namespace Calastone.Assignments.TextFilter.Test.Filters;

public class FilterMiddleVowelsTests
{
    // Note from Test spec A/C:
    // ("clean" middle is ‘e’, "what" middle is ‘ha’, "currently" middle is ‘e’ and should be filtered, "the", "rather"
    // should not be)
    
    [Fact] // Given/When/Then
    public void Given_StringWithMiddleVowels_WhenFiltered_ThenStringDoesNotContainWordsWithMiddleVowels()
    {
        // Arrange
        const int expectedWordCount = 1;
        string testString = "clean what currently you see on the stairs";
        ITextFilter textFilter = new FilterMiddleVowels();

        IEnumerable<string> words = testString.Split(' ');

        // Act
        var result = textFilter.Filter(words);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(expectedWordCount, result.Count());
    }
}