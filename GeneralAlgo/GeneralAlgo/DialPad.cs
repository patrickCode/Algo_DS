using System;
using System.Linq;
using System.Collections.Generic;

/*
|-----|-----|-----|
|  1  | ABC | DEF |
|     |  2  |  3  | 
|-----|-----|-----|
| GHI | JKL | MNO |
|  4  |  5  |  6  | 
|-----|-----|-----|
|PQRS | TUV |WXYZ |
|  7  |  8  |  9  | 
|-----|-----|-----|
|     |     |     |
|  *  |  0  |  #  | 
|-----|-----|-----|
*/

namespace GeneralAlgo
{
    public class DialPad
    {
        private List<string> _keys = new List<string>()
        {
            "",
            "",
            "ABC",
            "DEF",
            "GHI",
            "JKL",
            "MNO",
            "PQRS",
            "TUV",
            "WXYZ"
        };

        public List<string> GenerateCombinations(int number)
        {
            int reversedNumber = int.Parse(new string(number.ToString().Reverse().ToArray()));
            List<string> combinations = new();
            GenerateCombinations(reversedNumber, "", combinations);
            return combinations;
        }

        private void GenerateCombinations(int reversedNumber, string generatedStr, List<string> combinations)
        {
            if (reversedNumber == 0)
            {
                combinations.Add(generatedStr);
                return;
            }

            int currentDigit = reversedNumber % 10;
            int remainingNumber = reversedNumber / 10;
            string characterList = _keys[currentDigit];
            foreach(char character in characterList)
            {
                string newString = generatedStr + character;
                GenerateCombinations(remainingNumber, newString, combinations);
            }
        }
    }
}
