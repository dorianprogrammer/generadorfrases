using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator_Pharses
{
    public class RulesDivision
    {


        public Letters letters { get; set; }

        public RulesDivision()
        {
            this.letters = new Letters();
        }

        // Down here we just apply the different rules with the words divison in spanish

        public Boolean isVowel(char letter)
        {
            for (int i = 0; i < letters.vowels.Length; i++)
                if (letter.ToString().Equals(letters.vowels[i].ToString())) return true;
            return false;
        }

        public Boolean isConsonat(char letter)
        {
            for (int i = 0; i < letters.consonants.Length; i++)
                if (letter.ToString().Equals(letters.consonants[i].ToString())) return true;
            return false;
        }

        public Boolean isWeakVowel(char letter)
        {
            for (int i = 0; i < letters.weakVowel.Length; i++)
                if (letter.ToString().Equals(letters.weakVowel[i].ToString())) return true;
            return false;
        }

        public Boolean isStrongVowel(char letter)
        {
            for (int i = 0; i < letters.strongVowels.Length; i++)
                if (letter.ToString().Equals(letters.strongVowels[i].ToString())) return true;
            return false;
        }

        public Boolean isHiatoOrDiptongo(char firstLetter, char secondLetter)
        {
            if (isStrongVowel(firstLetter) && isWeakVowel(secondLetter) || isStrongVowel(secondLetter) && isWeakVowel(firstLetter))
                return false;
            return true;
        }

        public Boolean isException(string letter)
        {
            for (int i = 0; i < letters.exceptions.Length; i++)
                if (letter.ToString().Equals(letters.exceptions[i].ToString())) return true;
            return false;
        }
    }
}
