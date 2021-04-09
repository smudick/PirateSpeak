using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PirateSpeak
{
    public class PirateSpeakTranslator
    {
        public List<string> PirateToEnglish(string pirateSpeak, List<string> possibleWords)
        {
            var rejectedWords = new List<string>();
            var pirateLetters = pirateSpeak.ToCharArray();
            foreach (var pirateLetter in pirateLetters)
            {
                foreach (var word in possibleWords)
                {
                    if (!word.Contains(pirateLetter))
                    {
                        rejectedWords.Add(word);
                    }
                }
            }
            var results = possibleWords.Except(rejectedWords).ToList();
            return results;
        }
    }
}
