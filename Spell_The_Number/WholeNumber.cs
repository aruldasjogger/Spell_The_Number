using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spell_The_Number
{
    public class WholeNumber
    {
        public static String GetWholeNumber(String Number)
        {
            string word = "";
            try
            {
                bool beginsZero = false;
                bool isDone = false;
                double dblAmt = (Convert.ToDouble(Number));
               
                if (dblAmt > 0)
                {  
                    beginsZero = Number.StartsWith("0");

                    int numDigits = Number.Length;
                    int pos = 0;
                    String place = ""; 
                    switch (numDigits)
                    {
                        case 1:

                            word = Words.GetWord(Number);
                            isDone = true;
                            break;
                        case 2:
                            word = Words.GetWord(Number);
                            isDone = true;
                            break;
                        case 3:
                            pos = (numDigits % 3) + 1;
                            place = " Hundred ";
                            break;
                        case 4: 
                        case 5:
                        case 6:
                            pos = (numDigits % 4) + 1;
                            place = " Thousand ";
                            break;
                        case 7:
                        case 8:
                        case 9:
                            pos = (numDigits % 7) + 1;
                            place = " Million ";
                            break;
                        case 10:  
                        case 11:
                        case 12:

                            pos = (numDigits % 10) + 1;
                            place = " Billion ";
                            break;                     
                        default:
                            isDone = true;
                            break;
                    }
                    if (!isDone)
                    {   
                        if (Number.Substring(0, pos) != "0" && Number.Substring(pos) != "0")
                        {
                            try
                            {
                                word = GetWholeNumber(Number.Substring(0, pos)) + place + GetWholeNumber(Number.Substring(pos));
                            }
                            catch { }
                        }
                        else
                        {
                            word = GetWholeNumber(Number.Substring(0, pos)) + GetWholeNumber(Number.Substring(pos));
                        } 
                    } 
                    if (word.Trim().Equals(place.Trim())) word = "";
                }
            }
            catch { }
            return word.Trim();
        }
    }
}
