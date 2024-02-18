using Calastone.Assignments.TextFilter.Core.Interfaces.Services;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Calastone.Assignments.TextFilter.Service;

public class FileHandlerService : IFileHandlerService
{
    public string GetFileText(string pathToFile)
    {
        string fileText = File.ReadAllText(pathToFile);
        string cleaned = Regex.Replace( fileText, "\n", " ", RegexOptions.Multiline );
        return cleaned;
    }
}