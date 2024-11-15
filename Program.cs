using System;
using System.Collections.Generic;
using ChapterOneIntroductionToAlgorithms;

namespace GrokkingAlgorithms
{
    public static class Demos
    {
        public static void Main(string[] args)
        {
            int[] array = Helpers.GenerateNumbers(1, 32);
            //int searchItem = 377_212_000;
            double maxNumOfSteps = ChapterOneExercises.BinarySearchMaxNumberOfSteps(array.Length);
            Console.WriteLine($" Maximum number of steps for array is {maxNumOfSteps}");
            //ChapterOneDemos.SimpleSearchDemo(array, searchItem);
            //ChapterOneDemos.BinarySearchDemo(array, searchItem);
            //ChapterOneDemos.BinarySearchNumberOfStepsDemo(array, searchItem);
        }
    }
}