using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CountCharacters
{
    public class CharacterCounter
    {
        private readonly string symbolsInput;

        public CharacterCounter(string userInput)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(userInput);

            symbolsInput = userInput.ToLower();

        }

        public Dictionary<char, int> LettersSorter()
        {
            return LettersCounter()
                .OrderByDescending(x => x.Value)
                .ToDictionary(x => x.Key, x => x.Value);
        }

        private Dictionary<char, int> LettersCounter()
        {
            Dictionary<char, int> diction = new();

            foreach (char c in symbolsInput)
            {
                if (char.IsLetter(c))

                    if (diction.TryGetValue(c, out int value))
                        diction[c] = ++value;
                    else
                        diction[c] = 1;
            }
            return diction;
        }
    }
}

