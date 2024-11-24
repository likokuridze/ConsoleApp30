// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // ArrayList
        Console.WriteLine("ArrayList");
        ArrayList arrayList = new ArrayList();
        arrayList.Add("First");
        arrayList.Add("Second");
        arrayList.Insert(1, "Inserted"); // უნიკალური მეთოდი - Insert
        Console.WriteLine("After adding elements:");
        foreach (var item in arrayList)
            Console.WriteLine(item);

        arrayList.Remove("Second");
        Console.WriteLine("After removing 'Second':");
        foreach (var item in arrayList)
            Console.WriteLine(item);

        // List
        Console.WriteLine("List");
        List<string> list = new List<string>();
        list.Add("Apple");
        list.Add("Zebra");
        list.AddRange(new[] { "Banana", "Orange" }); // უნიკალური მეთოდი - AddRange
        Console.WriteLine("Before sorting:");
        foreach (var item in list)
            Console.WriteLine(item);

        list.Sort(); // უნიკალური მეთოდი - Sort
        Console.WriteLine("After sorting:");
        foreach (var item in list)
            Console.WriteLine(item);

        // Dictionary
        Console.WriteLine("Dictionary");
        Dictionary<int, string> dict = new Dictionary<int, string>();
        dict.Add(1, "One");
        dict.Add(2, "Two");
        dict.Add(3, "Three");

        Console.WriteLine("Keys:"); // უნიკალური თვისება - Keys
        foreach (var key in dict.Keys)
            Console.WriteLine(key);

        Console.WriteLine("\nValues:"); // უნიკალური თვისება - Values
        foreach (var value in dict.Values)
            Console.WriteLine(value);

        // SortedList
        Console.WriteLine(" SortedList ");
        SortedList<int, string> sortedList = new SortedList<int, string>();
        sortedList.Add(3, "Three");
        sortedList.Add(1, "One");
        sortedList.Add(2, "Two");

        Console.WriteLine($"Value at index 1: {sortedList.Values[1]}"); // უნიკალური წვდომა - Values[index]
        sortedList.RemoveAt(0); // უნიკალური მეთოდი - RemoveAt
        Console.WriteLine("\nAfter removing first element:");
        foreach (var item in sortedList)
            Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");

        // Stack
        Console.WriteLine("\n=== Stack ===");
        Stack<int> stack = new Stack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        Console.WriteLine($"Peek at top element: {stack.Peek()}"); // უნიკალური მეთოდი - Peek
        stack.Pop();
        Console.WriteLine("\nAfter Pop:");
        foreach (var item in stack)
            Console.WriteLine(item);

        // Queue
        Console.WriteLine(" Queue ");
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);

        Console.WriteLine($"Peek at first element: {queue.Peek()}"); // უნიკალური მეთოდი - Peek
        queue.Dequeue();
        Console.WriteLine("\nAfter Dequeue:");
        foreach (var item in queue)
            Console.WriteLine(item);

        // SortedDictionary
        Console.WriteLine("\n=== SortedDictionary ===");
        SortedDictionary<string, int> sortedDict = new SortedDictionary<string, int>();
        sortedDict.Add("C", 3);
        sortedDict.Add("A", 1);
        sortedDict.Add("B", 2);

        Console.WriteLine("Automatically sorted by key:");
        foreach (var item in sortedDict)
            Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");

        // HashSet
        Console.WriteLine("=== HashSet ===");
        HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
        HashSet<int> set2 = new HashSet<int> { 3, 4, 5 };

        Console.WriteLine("Trying to add duplicate:");
        Console.WriteLine($"Added 3 again? {set1.Add(3)}"); // დუპლიკატის დამატების მცდელობა

        set1.UnionWith(set2); // უნიკალური მეთოდი - UnionWith
        Console.WriteLine("\nAfter Union with set2:");
        foreach (var item in set1)
            Console.WriteLine(item);
    }
}
