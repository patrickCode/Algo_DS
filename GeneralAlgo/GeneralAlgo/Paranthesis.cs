using System.Collections.Generic;
using System.Text;

namespace GeneralAlgo
{
    public static class Paranthesis
    {
        public static List<string> Generated = new();

        public static bool IsValid(string paranthesis)
        {
            int paranthesisCounter = 0;

            foreach(char p in paranthesis)
            {
                if (p == '(')
                    paranthesisCounter++;
                else
                    paranthesisCounter--;

                if (paranthesisCounter < 0)
                    return false;
            }

            return paranthesisCounter == 0;
        }

        public static List<string> Generate(int n)
        {
            Generated.Clear();
            Generate("", '(', n, 1, 0);
            return Generated;
        }

        private static void Generate(string generatedString, char paranthesis, int n, int openParanthesis, int closedParanthesis)
        {
            if (closedParanthesis > openParanthesis)
                return;

            if (openParanthesis + closedParanthesis == (n *2))
            {
                if (openParanthesis != closedParanthesis)
                    return;

                generatedString += paranthesis;
                Generated.Add(generatedString.ToString());
                return;
            }

            generatedString += paranthesis;
            Generate(generatedString, '(', n, openParanthesis + 1, closedParanthesis);
            Generate(generatedString, ')', n, openParanthesis, closedParanthesis + 1);
        }
    }
}
