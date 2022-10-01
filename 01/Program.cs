using static AdventOfCode.File;
using static System.Console;

namespace AdventOfCode
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            File file01 = new File("01");
            int[] numbers = (int[])file01.ReadFile(FileType.TEST, false);

            int part1Ans = FindLarger(numbers);
            WriteLine("Part 1 answer: " + part1Ans);

            int part2Ans = FindLarger(SlidingSum(numbers));
            WriteLine("Part 2 answer: " + part2Ans);
        }

        public static int FindLarger(int[] input)
        {
            int largerCount = 0;
            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] < input[i + 1])
                    largerCount++;
            }
            return largerCount;
        }

        public static int[] SlidingSum(int[] input)
        {
            int[] slidingSum = new int[input.Length - 2];
            for (int i = 0; i <= input.Length - 3; i++)
            {
                slidingSum[i] = input[i] + input[i + 1] + input[i + 2];
            }
            return slidingSum;
        }
    }
}