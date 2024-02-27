using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Creating a List of strings
        List<string> names = new List<string>();

        // Adding elements to the list
        names.Add("Alice");
        names.Add("Bob");
        names.Add("Charlie");
        names.Add("David");
        names.Add("Eve");

        // Accessing elements by index
        Console.WriteLine("\nFirst name: " + names[0]);

        // Iterating through the list
        Console.WriteLine("All names:");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        // Removing an element
        names.Remove("Charlie");

        Console.WriteLine("\nAfter removing Charlie:");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        // Checking if the list contains a certain element
        Console.WriteLine("\nDoes the list contain Bob? " + names.Contains("Bob"));

        // Clearing the list
        names.Clear();
        Console.WriteLine("\nList cleared. Count: " + names.Count);
    }
}
