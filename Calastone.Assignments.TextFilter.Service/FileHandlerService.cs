using Calastone.Assignments.TextFilter.Core.Interfaces.Services;
using System.IO;

namespace Calastone.Assignments.TextFilter.Service;

public class FileHandlerService : IFileHandlerService
{
    public string GetFileText(string pathToFile)
    {
        return File.ReadAllText(pathToFile);
    }
}