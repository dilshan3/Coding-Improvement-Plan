using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterleavingStrings
{
    public class StringInterleaver
    {
        public bool AreStringsInterleaving(string parentString1, string parentString2, string childString)
        {
            if (parentString1.Length + parentString2.Length != childString.Length)
                return false;

            int[,] memoArray = new int[parentString1.Length, parentString2.Length];
            for (int i = 0; i < parentString1.Length; i++)
            {
                for (int j = 0; j < parentString2.Length; j++)
                {
                    memoArray[i, j] = -1;
                }
            }

            return CheckInterleaving(parentString1, 0, parentString2, 0, childString, 0, memoArray);
        }

        private bool CheckInterleaving(string parentString1, int counter1, string parentString2, int counter2, string childString, int counter3, int[,] memoArray) 
        {
            if(counter1 == parentString1.Length)
                return parentString2.Substring(counter2).Equals(childString.Substring(counter3));
            if (counter2 == parentString2.Length)
                return parentString1.Substring(counter1).Equals(childString.Substring(counter3));

            if (memoArray[counter1, counter2] >= 0)
            {
                if (memoArray[counter1, counter2] == 1)
                    return true;
                return false;
            }

            bool result = false;
            if (childString.ElementAt(counter3) == parentString1.ElementAt(counter1) && CheckInterleaving(parentString1, counter1 + 1, parentString2, counter2, childString, counter3 + 1, memoArray) ||
                childString.ElementAt(counter3) == parentString2.ElementAt(counter2) && CheckInterleaving(parentString1, counter1, parentString2, counter2 + 1, childString, counter3 + 1, memoArray))
            {
                result = true;
            }
            memoArray[counter1, counter2] = result ? 1: 0;
            return result;
        }
    }
}
