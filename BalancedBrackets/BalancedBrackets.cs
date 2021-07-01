using System;

namespace BalancedBracketsNS
{
    public class BalancedBrackets
    {
        /**
         * The function BalancedBrackets should return true if and only if
         * the input string has a set of "balanced" brackets.
         *
         * That is, whether it consists entirely of pairs of opening/closing
         * brackets (in that order), none of which mis-nest. We consider a bracket
         * to be square-brackets: [ or ].
         *
         * The string may contain non-bracket characters as well.
         *
         * These strings have balanced brackets:
         *  "[LaunchCode]", "Launch[Code]", "[]LaunchCode", "", "[]"
         *
         * While these do not:
         *   "[LaunchCode", "Launch]Code[", "[", "]["
         *
         * parameter str - to be validated
         * returns true if balanced, false otherwise
         */
        

        //public string CleanPhrase(string Phrase)
        //{
        //    String phrase1 = "";
        //    phrase1 = phrase1.Replace(",", "");
        //    phrase1 = phrase1.Replace("\"", "");
        //    return phrase1; 
        //}
        public static bool HasBalancedBrackets(String str)
        {
            int brackets = 0;
            foreach (char ch in str.ToCharArray())
            {
                if (ch == '[')
                {
                    brackets++;
                }
                else if (ch == ']')
                {
                    brackets--;
                }
            }
            bool b = Convert.ToBoolean(brackets);
            Console.WriteLine(!b);
            return brackets == 0;
            
        }

        public class CleanPhrase
        {
            private string phrase;

            public string CleanWords(string phrase)
            {
                this.phrase = phrase;
                phrase = phrase.Replace(",", "");
                phrase = phrase.Replace("\"", "");
                return phrase;
            }
        }
    }
}
