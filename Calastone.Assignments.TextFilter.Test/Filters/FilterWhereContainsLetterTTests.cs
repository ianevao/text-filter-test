using Calastone.Assignments.TextFilter.Core.Filters;
using Calastone.Assignments.TextFilter.Core.Interfaces.Filters;

namespace Calastone.Assignments.TextFilter.Test.Filters;

public class FilterWhereContainsLetterTTests
{
    [Fact] // Given/When/Then
    public void Given_StringWithTLetters_WhenFiltered_ThenStringDoesNotContainTLetterWords()
    {
        // Arrange
        const int expectedWordCount = 5;
        string testString = "test should contain five words when run";
        ITextFilter textFilter = new FilterWhereContainsLetterT();

        IEnumerable<string> words = testString.Split(' ');

        // Act
        var result = textFilter.Filter(words);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(expectedWordCount, result.Count());
    }
}