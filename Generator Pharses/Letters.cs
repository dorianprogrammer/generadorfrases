using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator_Pharses
{
    public class Letters
    {
        /// <summary>
        /// The different vowels, accent marks and exception that it exists in spanish
        /// </summary>
        public string[] vowels { get; set; }
        public string[] strongVowels { get; set; }
        public string[] weakVowel { get; set; }
        public string[] consonants { get; set; }
        public string[] exceptions { get; set; }

        public Letters()
        {
            this.vowels = new string[] { "a", "e", "i", "o", "u", "á", "é", "í", "ó", "ú" };
            this.strongVowels = new string[] { "a", "e", "o", "á", "é", "í", "ó", "ú" };
            this.weakVowel = new string[] { "i", "u" };
            this.consonants = new string[] { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "n", "ñ", "p", "q", "r", "s", "t", "v", "w", "x", "y", "z" };
            this.exceptions = new string[] { "ch", "ll", "rr", "br", "cr", "dr", "gr", "fr", "pr", "kr", "tr", "tl", "bl", "cl", "gl", "fl", "kl", "pl" };
        }
    }
}
