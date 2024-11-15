using System.Diagnostics;

namespace ChapterOneIntroductionToAlgorithms
{
    public static class ChapterOneDemos 
    {
        public static void SimpleSearchDemo(int[] array, int searchItem)
        {
            // Start measuring time
            Stopwatch stopwatch = Stopwatch.StartNew();

            // Perform the search
            int resultIndex = BinarySearch.GetItemIndexUsingSimpleSearch(array, searchItem);

            // Stop measuring time
            stopwatch.Stop();

            // Display the result and the time taken
            Console.WriteLine(resultIndex != -1 ? $"Found at index {resultIndex}" : "Not found");
            Console.WriteLine($"Time taken: {stopwatch.Elapsed.TotalMilliseconds} ms");
        }

        public static void BinarySearchDemo(int[] array, int searchItem)
        {
            // Start measuring time
            Stopwatch stopwatch = Stopwatch.StartNew();

            // Perform the search
            int resultIndex = BinarySearch.GetItemIndexUsingBinarySearch(array, searchItem);
            // Stop measuring time
            stopwatch.Stop();

            // Display the result and the time taken
            Console.WriteLine(resultIndex != -1 ? $"Found at index {resultIndex}" : "Not found");
            Console.WriteLine($"Time taken: {stopwatch.Elapsed.TotalMilliseconds} ms");
        }

        public static void BinarySearchNumberOfStepsDemo(int[] array, int searchItem)
        {
            // Start measuring time
            Stopwatch stopwatch = Stopwatch.StartNew();

            // Perform the search
            int NumberOfSteps = BinarySearch.GetNumberOfStepsNeededForBinarySearch(array, searchItem);
            // Stop measuring time
            stopwatch.Stop();

            // Display the result and the time taken
            Console.WriteLine($"Number of steps needed to get the search item is {NumberOfSteps}");
        }
    }
}