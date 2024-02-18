using Calastone.Assignments.TextFilter.Core.Filters;
using Calastone.Assignments.TextFilter.Core.Interfaces.Filters;

namespace Calastone.Assignments.TextFilter.Test.Filters;

public class FilterWhereLengthLessThanThreeTests
{
    [Fact] // Given/When/Then
    public void Given_StringWithWordsLessThanThreeInLength_WhenFiltered_ThenStringDoesNotContainWordsWithLengthLessThanThree()
    {
        // Arrange
        const int expectedWordCount = 8;
        string testString = "one should not do what one does not enjoy";
        ITextFilter textFilter = new FilterWhereLengthLessThanThree();

        IEnumerable<string> words = testString.Split(' ');

        // Act
        var result = textFilter.Filter(words);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(expectedWordCount, result.Count());
    }
}