using System;

class Program
{
    static void Main()
    {
        // Declare and initialize an array of integers
        int[] numbers = new int[5];

        // Input: Ask user to enter 5 elements
        Console.WriteLine("Enter 5 integer values:");

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Element [{i}]: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Output: Print elements of the array
        Console.WriteLine("\nThe elements in the array are:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine($"Element at index {i}: {numbers[i]}");
        }
    }
}
