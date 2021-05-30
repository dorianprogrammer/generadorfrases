using System;

namespace Generator_Pharses
{
    public class SeparatorPhrase
    {
        public string originalPhrase { get; set; }
        public string generatedPhrase { get; set; } // the final phrase or word after adding "ca"
        public int index { get; set; } // index between the arrays
        public RulesDivision rulesDivision { get; set; }

        public SeparatorPhrase(string phrase)
        {
            this.rulesDivision = new RulesDivision();
            this.originalPhrase = phrase;
            this.index = 0;
            this.generatedPhrase = null;
        }

        public string getGeneratePhrase()
        {
         while (index < originalPhrase.Length) evaluatingEachWord();  // we evaluate each word of the phrase
         return generatedPhrase;
        }

        private void evaluatingEachWord()
        {
            // We try to cover every possibility in each word
            if (originalPhrase[index].ToString().Equals(" "))
            {
                generatedPhrase += " ";
                index++;
            }
            else if ((rulesDivision.isVowel(originalPhrase[index]) || rulesDivision.isConsonat(originalPhrase[index])) && (index == 0 || isSpace(index)))
            {
                generatedPhrase += "ca" + originalPhrase[index].ToString();
                index++;
            }
            else if (rulesDivision.isVowel(originalPhrase[index]) && (rulesDivision.isVowel(originalPhrase[index - 1]) || isSpace(index)))
                checkingHiatoDiptongo(); // to know this is a "hiato" or "diptongo"
            else if (rulesDivision.isVowel(originalPhrase[index]) && (rulesDivision.isConsonat(originalPhrase[index - 1]) || isSpace(index)))
            {
                generatedPhrase += originalPhrase[index].ToString();
                index++;
            }
            else if (rulesDivision.isConsonat(originalPhrase[index]) && (rulesDivision.isVowel(originalPhrase[index - 1]) || isSpace(index)))
            {
                if (originalPhrase[index].ToString().Equals("h") && (index == (originalPhrase.Length - 1) || isSpace(index)))
                {
                    generatedPhrase += originalPhrase[index].ToString();
                    index++;
                }
                else if (originalPhrase[index].ToString().Equals("h") && (index < (originalPhrase.Length - 1) || isSpace(index)))
                    evaluatingPosibilitesWithVowel(); // we advanced to work with vowels and "h"
                else if (rulesDivision.isConsonat(originalPhrase[index]) && !(originalPhrase[index].ToString().Equals("h")) && (rulesDivision.isVowel(originalPhrase[index - 1]) || isSpace(index)))
                    evaluatingPosibilitesWithoutH(); // we work with vowels and consonants except "h"
            }
            else if (rulesDivision.isConsonat(originalPhrase[index]) && (rulesDivision.isConsonat(originalPhrase[index - 1]) || isSpace(index)))
            {
                if (rulesDivision.isException(originalPhrase[index - 1].ToString() + originalPhrase[index].ToString()))
                    generatedPhrase += originalPhrase[index].ToString();
                else if (!(rulesDivision.isException(originalPhrase[index - 1].ToString() + originalPhrase[index].ToString())))
                    generatedPhrase += "ca" + originalPhrase[index].ToString();
                index++;
            }
        }

        private void evaluatingPosibilitesWithoutH()
        {
            if (index + 1 == originalPhrase.Length || originalPhrase[index + 1].ToString().Equals(" "))
            {
                if (rulesDivision.isVowel(originalPhrase[index]))
                {
                    if (rulesDivision.isStrongVowel(originalPhrase[index]))
                        generatedPhrase += "ca" + originalPhrase[index].ToString(); 
                    else if (rulesDivision.isWeakVowel(originalPhrase[index]))
                        generatedPhrase += originalPhrase[index].ToString();
                }
                else if (rulesDivision.isConsonat(originalPhrase[index])) generatedPhrase += originalPhrase[index].ToString();
                index++;
            }
            else // this here is a litte confusing but basically we try to find letters with exceptions
            {
                index++;
                if (rulesDivision.isVowel(originalPhrase[index]))
                {
                    generatedPhrase += "ca" + originalPhrase[index - 1].ToString() + originalPhrase[index].ToString();
                    index++;
                }
                else
                {
                    if (rulesDivision.isConsonat(originalPhrase[index]))
                    {
                        if (rulesDivision.isException(originalPhrase[index - 1].ToString() + originalPhrase[index].ToString()))
                        {
                            generatedPhrase += "ca" + originalPhrase[index - 1].ToString() + originalPhrase[index].ToString();
                            index++;
                        }
                        else if (!(rulesDivision.isException(originalPhrase[index - 1].ToString() + originalPhrase[index].ToString())))
                        {
                            if (index + 1 < originalPhrase.Length && rulesDivision.isConsonat(originalPhrase[index + 1])
                                && rulesDivision.isException(originalPhrase[index].ToString() + originalPhrase[index + 1].ToString()))
                            {
                                generatedPhrase += originalPhrase[index - 1].ToString() + "ca" + originalPhrase[index].ToString() + originalPhrase[index + 1].ToString();
                                index += 2;
                            }
                            else
                            {
                                if (index + 1 < originalPhrase.Length && rulesDivision.isConsonat(originalPhrase[index + 1]) && !(rulesDivision.isException(originalPhrase[index].ToString() + originalPhrase[index + 1].ToString())))
                                    generatedPhrase += originalPhrase[index - 1].ToString() + originalPhrase[index].ToString();
                                else if (index + 1 < originalPhrase.Length && rulesDivision.isVowel(originalPhrase[index + 1]))
                                    generatedPhrase += originalPhrase[index - 1].ToString() + "ca" + originalPhrase[index].ToString();
                                index++;
                            }
                        }
                    }
                }
            }
        }

        private void evaluatingPosibilitesWithVowel()
        {
            index++;
            if (rulesDivision.isVowel(originalPhrase[index]))
            {
                if (index < (originalPhrase.Length - 1))
                {
                    if ((rulesDivision.isStrongVowel(originalPhrase[index - 2]) && rulesDivision.isStrongVowel(originalPhrase[index])) || (rulesDivision.isWeakVowel(originalPhrase[index - 2]) && rulesDivision.isWeakVowel(originalPhrase[index])))
                        generatedPhrase += "ca" + originalPhrase[index - 1].ToString() + originalPhrase[index].ToString();
                    else if (rulesDivision.isWeakVowel(originalPhrase[index - 2]) && rulesDivision.isStrongVowel(originalPhrase[index]) || rulesDivision.isStrongVowel(originalPhrase[index - 2]) && rulesDivision.isWeakVowel(originalPhrase[index]))
                        generatedPhrase += originalPhrase[index - 1].ToString() + originalPhrase[index].ToString();
                    index++;
                }
                else if (rulesDivision.isHiatoOrDiptongo(originalPhrase[index], originalPhrase[index + 1]))generatedPhrase += "ca" + originalPhrase[index].ToString();
                else generatedPhrase += "ca" + originalPhrase[index - 1].ToString() + originalPhrase[index].ToString();
                index++;
            }
        }

        public void checkingHiatoDiptongo()
        {
            if (rulesDivision.isHiatoOrDiptongo(originalPhrase[index], originalPhrase[index - 1])) generatedPhrase += "ca" + originalPhrase[index].ToString();
            else generatedPhrase += originalPhrase[index].ToString();
            index++;
        }

        public Boolean isSpace(int index) // space in the previous index 
        {
            return originalPhrase[index - 1].ToString().Equals(" ");
        }
    }
}
