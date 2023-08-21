// Create a Dictionary that maps strings to strings
Dictionary<string, string> fileTypes = new()
{
    // Add some file type extensions and their descriptions
    { ".txt", "Text File" },
    { ".htm", "HTML Web Page" },
    { ".html", "HTML Web Page" },
    { ".css", "Cascading Style Sheet" },
    { ".xml", "XML Data" }
};

// TODO: How many key/value pairs are there?
Console.WriteLine($"There are {fileTypes.Count} key/value pairs");

// TODO: try adding an existing key
try
{
    fileTypes.Add(".htm", "Web Page");
}
catch (ArgumentException e)
{
    Console.WriteLine("Key already exists");
}

// TODO: try removing and then finding a key
fileTypes.Remove(".css");
Console.WriteLine($"fileTypes contains CSS: {fileTypes.ContainsKey(".css")}");
// TODO: Dump the contents of the Dictionary
Console.WriteLine("Dumping dictionary contents: ");
foreach (KeyValuePair<string, string> kvp in fileTypes)
{
    Console.WriteLine($"Key = {kvp.Key}, Value = {kvp.Value}");
}
