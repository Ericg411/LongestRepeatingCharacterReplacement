using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestRepeatingCharacterReplacement
{
    public class CharReplacer
    {
        public CharReplacer() { }
        public int CharacterReplacement(string s, int k)
        {
            int left = 0;
            Dictionary<char, int> frequencyDictionary = new Dictionary<char, int>();
            int mostLetters = 0;
            int maxString = 0;

            for (int right = 0; right < s.Length; right++)
            {
                char currentChar = s[right];
                frequencyDictionary[currentChar] = frequencyDictionary.GetValueOrDefault(currentChar) + 1;

                mostLetters = Math.Max(frequencyDictionary[currentChar], mostLetters);
                int lettersToReplace = (right - left + 1) - mostLetters;
                if (lettersToReplace > k)
                {
                    frequencyDictionary[s[left]]--;
                    left++;
                }

                maxString = Math.Max((right - left + 1), maxString);
            }



            return maxString;
        }
    }
}
