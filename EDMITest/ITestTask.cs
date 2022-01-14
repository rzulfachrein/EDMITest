using System;
using System.Collections.Generic;
using System.Text;

namespace EDMITest
{
    public interface ITestTask
    {
        IEnumerable<Tuple<string, int>> GetWordCounts(string[] words);
        IEnumerable<Tuple<string, int>> GetWordCounts(string commaDelimitedWords);
        bool IsBitSet(int value, int bit);
        IEnumerable<int> GetBitsSet(int value);
        int SetBits(int value, int[] bitsToSet);
    }
}
