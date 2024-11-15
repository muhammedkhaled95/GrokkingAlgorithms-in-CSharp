
namespace ChapterOneIntroductionToAlgorithms
{
    public static class ChapterOneExercises
    {
        // Exercise 1.1 and 1.2
        // 1.2 is the same as 1.1 but doubling the list size passed to the method here.
        public static double BinarySearchMaxNumberOfSteps(int listSize)
        {
            double maxNumOfSteps = Math.Log(listSize) / Math.Log(2);
            return maxNumOfSteps;
        }
    }

}