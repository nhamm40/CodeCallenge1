using System.Collections.Generic;
using System.Linq;
using vAutoChallenge.Models;

namespace vAutoChallenge.Managers
{
    public class StringManager : IStringManager
    {
        public List<StringItems> StringModifier(string input)
        {
            var result = new List<StringItems>();

            var inputWords = input.Split(' ').ToList();

            foreach (var word in inputWords)
            {
                var blah = new StringItems
                {
                    OriginalString = word,
                    FirstLetter = word[0].ToString(),
                    LastLetter = word[word.Length - 1].ToString()
                };

                if (word.Length > 2)
                {
                    var distinctCharacters = new string(word.Distinct().ToArray());
                    blah.StringLength = distinctCharacters.Substring(1, distinctCharacters.Length - 2).Length;
                }

                result.Add(blah);
            }

            return result;
        }
    }
}
