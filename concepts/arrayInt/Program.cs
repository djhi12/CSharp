using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating a List of integers
        List<int> numbers = new List<int>();

        // Adding elements to the list
        numbers.Add(1);
        numbers.Add(2);
        numbers.Add(3);
        numbers.Add(4);
        numbers.Add(5);

        // Accessing elements by index
        Console.WriteLine("First element: " + numbers[0]);

        // Iterating through the list
        Console.WriteLine("All elements:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }

        // Removing an element
        numbers.Remove(3);

        Console.WriteLine("After removing 3:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }

        // Checking if the list contains a certain element
        Console.WriteLine("Does the list contain 4? " + numbers.Contains(4));

        // Clearing the list
        numbers.Clear();
        Console.WriteLine("List cleared. Count: " + numbers.Count);

    }
}
