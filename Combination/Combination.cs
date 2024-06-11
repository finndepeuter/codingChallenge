using System.Diagnostics.Tracing;

namespace CodingChallengeLibrary
{
    public class Combination
    {
        private List<string> combinations = new List<string>();

        public List<string> FindCombinationTwoParts(string[] words, string[] componentArr)
        {
            foreach (string word in words)
            {
                for (int i = 1; i < 7; i++)
                {
                    string part1 = word.Substring(0, i);
                    string part2 = word.Substring(i);
                    string combined = part1 + "+" + part2 + "=" + word;
                    if (componentArr.Contains(part1) && componentArr.Contains(part2) && part1 + part2 == word && !combinations.Contains(combined))
                    {

                        Console.WriteLine(combined);
                        combinations.Add(combined);
                    }
                }
            }
            return combinations;
            
        }

        public IEnumerable<string> FindCombinations(string word, string remaining, string[] componentArr, int amountOfParts)
        {
            string fullWord = word;
                for (int i = 1; i < remaining.Length; i++)
                {
                    string part1 = remaining.Substring(0, i);
                    string part2 = remaining.Substring(i);
                    if (componentArr.Contains(part1))
                    {
                        if (amountOfParts == 2 && componentArr.Contains(part2))
                        {
                            yield return $"{part1} + {part2} = {fullWord}";
                        }
                        else if (amountOfParts > 2)
                        {
                            foreach (string combination in FindCombinations(word, part2, componentArr, amountOfParts - 1))
                            {
                                yield return $"{part1} + {combination}";
                            }
                        }
                    }
                }

        }

        public List<string> FindCombinationMultipleParts(string[] words, string[] componentArr, int amountOfParts)
        {
            foreach (string word in words)
            {
                foreach (string combination in FindCombinations(word, word, componentArr, amountOfParts))
                {
                    Console.WriteLine(combination);
                    combinations.Add(combination);
                }
            }

            return combinations;
        }
    }
}