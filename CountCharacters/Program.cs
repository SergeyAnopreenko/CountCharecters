using CountCharacters;

Console.WriteLine("Enter symbols");

var userInput = Console.ReadLine();

CharacterCounter characterCounter = new CharacterCounter(userInput);

Dictionary<char, int> sorter = characterCounter.LettersSorter();

foreach (var pair in sorter)
{

    Console.WriteLine($"{pair.Key} : {pair.Value}");

}

