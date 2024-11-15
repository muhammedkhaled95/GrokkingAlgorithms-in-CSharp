
namespace ChapterOneIntroductionToAlgorithms
{
    public static class BinarySearch
    {
        public static int GetItemIndexUsingBinarySearch(int[] array, int item)
        {
            if (array.Length == 0) return -1;

            int arrayLength = array.Length;
            int low = 0;
            int high = arrayLength - 1;

            while (low <= high) 
            {
                int mid = (low + high) / 2;
                if (item == array[mid])
                {
                    return mid;
                } else if (item > array[mid])
                {
                    low = mid + 1;
                } else if (item < array[mid])
                {
                    high = mid - 1;
                }
            }

            return -1;

        }

        public static int GetNumberOfStepsNeededForBinarySearch(int[] array, int item)
        {
            if (array.Length == 0) return -1;

            int arrayLength = array.Length;
            int low = 0;
            int high = arrayLength - 1;
            int numberOfSteps = 0;
            while (low <= high) 
            {
                numberOfSteps++;
                int mid = (low + high) / 2;
                if (item == array[mid])
                {
                    return numberOfSteps;
                } else if (item > array[mid])
                {
                    low = mid + 1;
                } else if (item < array[mid])
                {
                    high = mid - 1;
                }
            }

            return numberOfSteps;

        }

        public static int GetItemIndexUsingSimpleSearch(int[] array, int item)
        {
            if (array.Length == 0) return -1;

            for(int i = 0; i < array.Length; i++) 
            {
                if (item == array[i]) return i;
            }

            return -1;


        }
    }

}