using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndrewKnechtQuadaxMasterMind
{
    public class NumberGenerator
    {
        public NumberGenerator()
        {

        }
        public int[] GetRandomFourDigitNumber()
        {
            int[] mysteryNumber = new int[4];
            Random random = new Random();
            for (int j = 0; j < 4; j++)
            {
                mysteryNumber[j] = random.Next(1, 6);
            }
            return mysteryNumber;
        }
        public string[] CompareInputVsMagicNumber(string playerGuess, int[] magicNumber)
        {
            string[] magicResults = new string[4];
            char[] digits = new char[4];
            for(int i = 0; i < playerGuess.Length; i++)
            {
                digits[i] = playerGuess[i];
            }
            for(int h = 0; h < magicResults.Length; h++)
            {
                int digitToLookFor = Int32.Parse(digits[h].ToString());
                //if (magicNumber[h] == digitToLookFor)
                //{
                //    magicResults[h] = "(+)";
                //}
                if (magicNumber.Contains(digitToLookFor))
                {
                    magicResults[h] = "(-)";
                    if (magicNumber[h] == digitToLookFor)
                    {
                        magicResults[h] = "(+)";
                    }
                }
                if (magicResults[h] == null)
                {
                    magicResults[h] = "( )";
                }
            }
            return magicResults;
        }
    }
}
