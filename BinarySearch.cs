using System;

class BinarySearch
{
    public static void Run(string[] args)
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
        int target = 4;
        bool isFound = false;

        int leftIndex = 0;
        int rightIndex = numbers.Count - 1;


        while (leftIndex <= rightIndex && isFound == false)
        {
            int average = (leftIndex + rightIndex) / 2;
            if (numbers[average] < target)
            {
                leftIndex = average + 1;
            }

            else if (numbers[average] > target)
            {
                rightIndex = average - 1;
            }

            else
            {
                isFound = true;
                Console.WriteLine($"Target found at {average}");
            }
        }
    }
}