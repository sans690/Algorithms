using System;

class QuickSort
{

    public static void Run(string[] args)
    {
        List<int> numbers = new List<int> { 2, 3, 5, 6, 1 };

        int temp1 = numbers[numbers.Count - 1];
        numbers[numbers.Count - 1] = numbers[0];
        numbers[0] = temp1;

        int j = 0;

        for (int i = 0; i < numbers.Count - 1; i++)
        {
            if (numbers[i] < numbers[numbers.Count - 1])
            {
                int temp2 = numbers[j];
                numbers[j] = numbers[i];
                numbers[i] = temp2;
                j++;
            }
            // else if numbers[i] > than pivot, then do nothing and continue
        }
        int temp3 = numbers[numbers.Count - 1];
        numbers[numbers.Count - 1] = numbers[j];
        numbers[j] = temp3;
        Console.WriteLine(String.Join(",", numbers));
    }
}