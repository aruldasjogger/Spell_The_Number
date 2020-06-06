using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spell_The_Number
{
    public static class Words
    {
        private static Dictionary<int, string> words = new Dictionary<int, string>();
        static Words()
        {
            words.Add(1, "One");
            words.Add(2, "Two");
            words.Add(3, "Three");
            words.Add(4, "Four");
            words.Add(5, "Five");
            words.Add(6, "Six");
            words.Add(7, "Seven");
            words.Add(8, "Eight");
            words.Add(9, "Nine");
            words.Add(10, "Ten");
            words.Add(11, "Eleven");
            words.Add(12, "Twelve");
            words.Add(13, "Thirteen");
            words.Add(14, "Fourteen");
            words.Add(15, "Fifteen");
            words.Add(16, "Sixteen");
            words.Add(17, "Seventeen");
            words.Add(18, "Eighteen");
            words.Add(19, "Nineteen");
            words.Add(20, "Twenty");
            words.Add(30, "Thirty");
            words.Add(40, "Fourty");
            words.Add(50, "Fifty");
            words.Add(60, "Sixty");
            words.Add(70, "Seventy");
            words.Add(80, "Seventy");
            words.Add(90, "Ninety");
        }

        public static string GetWord(string number)
        {
            int convertedNumber = Convert.ToInt32(number);
            if(words.ContainsKey(convertedNumber))
            {
                return words[convertedNumber];
            }       
            else
            {
                return words[Convert.ToInt32(number.Substring(0, 1) + "0")] + " " + words[Convert.ToInt32(number.Substring(1))];
            }
        }
    }
}
