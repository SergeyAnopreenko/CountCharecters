
namespace CountCharacters.Tests;

public record CountLettersCase
{
    public string Input  { get; set; }
    public Dictionary<char,int> ExpectedDictionary { get; set; }
}
