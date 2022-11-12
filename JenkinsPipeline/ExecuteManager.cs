using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JenkinsPipeline
{
    public static class ExecuteManager
    {
        public static int GetSummaryOfArray(int[] numbers) => numbers.Sum();

        public static int[] GetArrayOfOddIndexNumbers(int[] numbers) => numbers.Where(x => Array.IndexOf(numbers, x) % 2 != 0 ).ToArray();

        public static int[] GetArrayOfEvenIndexNumbers(int[] numbers) => numbers.Where(x => Array.IndexOf(numbers, x) % 2 == 0 && Array.IndexOf(numbers, x) != 0).ToArray();

    }
}
