using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using vAutoChallenge.Models;

namespace vAutoChallenge.Managers
{
    public class StringManager : IStringManager
    {
        public string StringModifier(string input)
        {
            var stringList = new List<string>();

            const string pattern = "([^a-zA-Z])";
            var rgx = new Regex(pattern);

            var inputArr = Regex.Split(input.Trim(), pattern);

            foreach (var item in inputArr)
            {
                if (rgx.IsMatch(item))
                {
                    if (!string.IsNullOrWhiteSpace(item))
                    {
                        stringList.Add(item);
                    }
                }
                else
                {
                    var newString = CreateStringItems(item);

                    if (!string.IsNullOrWhiteSpace(newString))
                    {
                        stringList.Add(newString);
                    }
                }
            }
            var result = FinalResultStringBuilder(stringList);
            return result;
        }

        private static string CreateStringItems(string word)
        {
            if (word.Length > 0)
            {
                var stringObject = new StringItems
                {
                    OriginalString = word,
                    FirstLetter = word[0].ToString(),
                    LastLetter = word[word.Length - 1].ToString()
                };

                if (word.Length > 2)
                {
                    stringObject.StringLength = CalculateDistinctCharacters(word);
                }
                if (word.Length < 2)
                {
                    stringObject.StringLength = 0;
                }

                return stringObject.FirstLetter + stringObject.StringLength + stringObject.LastLetter;
            }

            return null;
        }

        private static int CalculateDistinctCharacters(string word)
        {
            var str = word.Substring(1, word.Length - 2);

            var distinctCharacters = new string(str.Distinct().ToArray());
            var distinctCharacterCount = distinctCharacters.Substring(0).Length;

            return distinctCharacterCount;
        }

        private static string FinalResultStringBuilder(List<string> stringList)
        {
            var final = new StringBuilder();
            var lastItem = stringList.Last();
            foreach (var str in stringList)
            {
                if (str.Equals(lastItem))
                {
                    final.Append(str);
                }
                else
                {
                    final.Append(str + " ");
                }
            }
            return final.ToString();
        }
    }
}
