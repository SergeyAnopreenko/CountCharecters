
namespace CountCharacters.Tests;

public static class CountLettersCaseGenerator
{
    public static IEnumerable<object[]> GetCases()
    {
        yield return [GetJustOneWordTestCase()];
        yield return [GetStringWhithOtherSymbolsTestCase()];
        yield return [GetNonAsciiLettersTestCase()];
        yield return [GetOnlyNonLeterTestCase()];
    }

    private static CountLettersCase GetNonAsciiLettersTestCase()
    {
        return new CountLettersCase
        {
            Input = "ВАнобюСвфас",
            ExpectedDictionary = new Dictionary<char, int>
            {
                ['в'] = 2,
                ['а'] = 2,
                ['с'] = 2,
                ['н'] = 1,
                ['о'] = 1,
                ['б'] = 1,
                ['ю'] = 1,
                ['ф'] = 1,
            }
        };
    }

    private static CountLettersCase GetJustOneWordTestCase()
    {
        return new CountLettersCase
        {
            Input = "Roberto",
            ExpectedDictionary = new Dictionary<char, int>
            {
                ['r'] = 2,
                ['o'] = 2,
                ['b'] = 1,
                ['e'] = 1,
                ['t'] = 1,
            }
        };
    }

    private static CountLettersCase GetStringWhithOtherSymbolsTestCase()
    {
        return new CountLettersCase
        {
            Input = "Sddg.,/ yuY",
            ExpectedDictionary = new Dictionary<char, int>
            {
                ['d'] = 2,
                ['y'] = 2,
                ['s'] = 1,
                ['g'] = 1,
                ['u'] = 1,
            }
        };
    }

    private static CountLettersCase GetOnlyNonLeterTestCase()
    {
        return new CountLettersCase
        {
            Input = "/.,/,/';",
            ExpectedDictionary = new Dictionary<char, int>()
        };
    }
}