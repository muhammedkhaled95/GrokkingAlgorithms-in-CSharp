
namespace ChapterOneIntroductionToAlgorithms
{
    public static class Helpers
    {
        public static int[] GenerateNumbers(int start, int end)
        {

            // Create the array with the calculated size
            List<int> items = new List<int>();
            
            for(int i = start; i <= end; i++)
            {
                items.Add(i);
            }

            int[] arrayOfItems = items.ToArray();
            Array.Sort(arrayOfItems);
            return arrayOfItems;
        }
    }
}