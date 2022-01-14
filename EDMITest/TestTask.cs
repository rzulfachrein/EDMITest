using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EDMITest
{
    public class TestTask : ITestTask
    {
        public IEnumerable<int> GetBitsSet(int value)
        {
            var bits = new BitArray(new int[] { value });
            var listBitIndex = bits.Cast<bool>().Select((bit, index) => new { Bit = bit, Index = index });
            var result = listBitIndex.Where(a => a.Bit.Equals(true)).Select(s => s.Index).ToList();

            return result;
        }

        public IEnumerable<Tuple<string, int>> GetWordCounts(string[] words)
        {
            var result = new List<Tuple<string, int>>();
            var groupWord = words.GroupBy(g => g)
                .Select(s => s.Key)
                .ToList();

            foreach (var word in groupWord)
            {
                var countWord = words.Count(a => a.Equals(word));
                result.Add(new Tuple<string, int>(word, countWord));
            }

            return result;
        }

        public IEnumerable<Tuple<string, int>> GetWordCounts(string commaDelimitedWords)
        {
            var splitedWords = commaDelimitedWords.Split(",");
            var result = GetWordCounts(splitedWords);

            return result;
        }

        public bool IsBitSet(int value, int bit)
        {
            var bits = new BitArray(new int[] { value });
            var result = bits[bit];

            return result;
        }

        public int SetBits(int value, int[] bitsToSet)
        {
            var bits = new BitArray(new int[] { value });
            var result = new int[1];
            
            foreach (var val in bitsToSet)
            {
                bits[val] = true;
            }

            bits.CopyTo(result, 0);

            return result[0];
        }
    }
}
