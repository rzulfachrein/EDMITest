using System;

namespace EDMITest
{
    class Program
    {
        static void Main(string[] args)
        {
            ITestTask testTask = new TestTask();

            var wordCounts1 = testTask.GetWordCounts(new[] { "one", "two", "two", "three", "three", "four" });

            var wordCounts2 = testTask.GetWordCounts("one,two,two,three,three,three,four");

            var bit1 = testTask.IsBitSet(9, 0);

            var bit2 = testTask.IsBitSet(9, 1);

            var bit3 = testTask.IsBitSet(9, 2);

            var bit4 = testTask.IsBitSet(9, 3);

            var bitsSet = testTask.GetBitsSet(9);

            var newValue = testTask.SetBits(9, new int[] { 2 });

            var newBitSet = testTask.GetBitsSet(newValue);

            Console.ReadKey();
        }
    }
}
