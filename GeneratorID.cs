using System;
using System.Collections.Generic;

namespace id_generator
{
    public class GeneratorID
    {
        private List<string> listOfID = new List<string> ();

        private char[] digitsAlphabet = new char[] 
            {
                '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c',
                'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p',
                'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' 
            };

        public List<string> GetIDList()
        {
            string digitRank3;
            string digitRank2;
            string digitRank1;
            for (int i = 0; i < digitsAlphabet.Length; i++)
            {
                digitRank3 = digitsAlphabet[i].ToString(); 

                for (int j = 0; j < digitsAlphabet.Length; j++)
                {
                    digitRank2 = digitRank3;
                    digitRank2 += digitsAlphabet[j].ToString();

                    for (int k = 0; k < digitsAlphabet.Length; k++)
                    {
                        digitRank1 = digitRank2;
                        digitRank1 += digitsAlphabet[k].ToString();
                        listOfID.Add(digitRank1);
                    }
                }
            }
            return listOfID;
        }


    }
}
