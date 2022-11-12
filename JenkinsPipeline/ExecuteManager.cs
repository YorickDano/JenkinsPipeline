namespace Executer
{
    public static class ExecuteManager
    {
        public static int GetSummaryOfArray(int[] numbers) => numbers.Sum();

        public static int[] GetArrayOfOddIndexNumbers(int[] numbers) => numbers.Where((x, index) => index % 2 != 0 ).ToArray();

        public static int[] GetArrayOfEvenIndexNumbers(int[] numbers) => numbers.Where((x, index) => index % 2 == 0 && index != 0).ToArray();

    }
}
