using System;
using System.Collections.Generic;

class Program
{
    // -------------------------------------------
    // INTERSECTION 
    // -------------------------------------------
    public static HashSet<T> FindIntersection<T>(HashSet<T> setA, HashSet<T> setB)
    {
        var result = new HashSet<T>();

        // Checking which one is larger than other
        var smaller = setA.Count < setB.Count ? setA : setB;
        var larger = setA.Count < setB.Count ? setB : setA;

        foreach (var item in smaller)
        {
            if (larger.Contains(item))
                result.Add(item);
        }

        return result;
    }

    // -------------------------------------------
    // UNION 
    // -------------------------------------------
    public static HashSet<T> FindUnion<T>(HashSet<T> setA, HashSet<T> setB)
    {
        var result = new HashSet<T>();

        // Add items from first set
        foreach (var item in setA)
            result.Add(item);

        // Add items from second set
        foreach (var item in setB)
            result.Add(item);

        return result;
    }

    // -------------------------------------------
    //Funcion to print the test cases
    // -------------------------------------------
    public static void PrintDemo<T>(string title, HashSet<T> setA, HashSet<T> setB)
    {
        Console.WriteLine($"--- {title} ---");
        Console.WriteLine($"Set A: {{ {string.Join(", ", setA)} }}");
        Console.WriteLine($"Set B: {{ {string.Join(", ", setB)} }}");

        var intersection = FindIntersection(setA, setB);
        var union = FindUnion(setA, setB);

        Console.WriteLine($"Intersection: {{ {string.Join(", ", intersection)} }}");
        Console.WriteLine($"Union: {{ {string.Join(", ", union)} }}\n");
    }

    // -------------------------------------------
    // TEST CASES 
    // -------------------------------------------
    static void Main(string[] args)
    {
        Console.WriteLine("=== Set Operations Demo ===\n");

        PrintDemo(
            "Test Case 1: Normal Overlap",
            new HashSet<int> { 1, 2, 3 },
            new HashSet<int> { 2, 3, 4 }
        );

        PrintDemo(
            "Test Case 2: No Overlap",
            new HashSet<int> { 1, 5, 7 },
            new HashSet<int> { 2, 4, 6 }
        );

        PrintDemo(
            "Test Case 3: One Empty Set",
            new HashSet<int>(),
            new HashSet<int> { 10, 20, 30 }
        );

        PrintDemo(
            "Bonus: Identical Sets",
            new HashSet<int> { 1, 2, 3 },
            new HashSet<int> { 1, 2, 3 }
        );

        Console.WriteLine("Demo complete.");
    }
}
