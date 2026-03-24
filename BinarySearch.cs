using System;

class BinarySearch
{
    public static void Run(string[] args)
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
        int target = 4;
        bool isFound = false;

        int left = 0;
        int right = numbers.Count - 1;


        while (left <= right && isFound == false)
        {
            int average = (left + right) / 2;
            if (numbers[average] < target)
            {
                left = average + 1;
            }

            else if (numbers[average] > target)
            {
                right = average - 1;
            }

            else
            {
                isFound = true;
                Console.WriteLine($"Target found at {average}");
            }
        }
    }
}