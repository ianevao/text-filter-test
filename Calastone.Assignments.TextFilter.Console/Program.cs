// See https://aka.ms/new-console-template for more information

using Calastone.Assignments.TextFilter.Core.Filters;
using Calastone.Assignments.TextFilter.Core.Helpers;
using Calastone.Assignments.TextFilter.Core.Interfaces.Filters;
using Calastone.Assignments.TextFilter.Service;

Console.WriteLine("Hello and welcome to the Calastone Technical Test! Please press Enter on your keyboard to run the sample file content through the filters and output the results.");
// Console.ReadLine();

// Get file content
var fileHandlerService = new FileHandlerService();

var text = fileHandlerService.GetFileText("./Data/TextInput.txt");

var textFilterService = new TextFilterService(new StringHelper());

// Configure filters to apply
ITextFilter filterOne = new FilterMiddleVowels();
ITextFilter filterTwo = new FilterWhereLengthLessThanThree();
ITextFilter filterThree = new FilterWhereContainsLetterT();

ITextFilter[] filters = {
    filterOne,
    filterTwo,
    filterThree
};

Console.WriteLine(textFilterService.ApplyFilters(filters, text));
Console.WriteLine();
Console.WriteLine("Press Enter to Quit.");
Console.ReadLine();