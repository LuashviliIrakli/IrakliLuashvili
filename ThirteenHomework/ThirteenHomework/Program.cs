namespace ThirteenHomework
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add(2);
            arrayList.Add(3);
            arrayList.Insert(1, 99);
            arrayList.Remove(2);
            Console.WriteLine("ArrayList elements:");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }


            List<int> list = new List<int>();
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.AddRange(new int[] { 7, 8, 9 });
            list.Sort();
            list.RemoveAt(2);
            Console.WriteLine("\nList elements:");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }


            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(1, "erti");
            dictionary.Add(2, "ori");
            dictionary.Add(3, "sami");
            dictionary.Remove(2);
            Console.WriteLine("\nDictionary keys and values:");
            foreach (var key in dictionary.Keys)
            {
                Console.WriteLine($"{key}: {dictionary[key]}");
            }


            SortedList<int, string> sortedList = new SortedList<int, string>();
            sortedList.Add(1, "BA");
            sortedList.Add(2, "DEV");
            sortedList.Add(3, "QA");
            sortedList.RemoveAt(1);
            Console.WriteLine("\nSortedList elements:");
            foreach (var item in sortedList)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }


            Stack<string> stack = new Stack<string>();
            stack.Push("First");
            stack.Push("Second");
            stack.Push("Third");
            Console.WriteLine("\nStack elements:");
            Console.WriteLine("Top element: " + stack.Peek());
            stack.Pop();
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }


            Queue<string> queue = new Queue<string>();
            queue.Enqueue("A");
            queue.Enqueue("B");
            queue.Enqueue("C");
            Console.WriteLine("\nQueue elements:");
            Console.WriteLine("First element: " + queue.Peek());
            queue.Dequeue();
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }


            SortedDictionary<int, string> sortedDictionary = new SortedDictionary<int, string>();
            sortedDictionary.Add(1, "Dog");
            sortedDictionary.Add(2, "Cat");
            sortedDictionary.Add(3, "Pig");
            sortedDictionary.Remove(1);
            Console.WriteLine("\nSortedDictionary keys and values:");
            foreach (var key in sortedDictionary.Keys)
            {
                Console.WriteLine($"{key}: {sortedDictionary[key]}");
            }


            HashSet<int> hashSet = new HashSet<int>();
            hashSet.Add(10);
            hashSet.Add(20);
            hashSet.Add(30);
            hashSet.Add(20);
            hashSet.UnionWith(new HashSet<int> { 40, 50 });
            Console.WriteLine("\nHashSet elements:");
            foreach (var item in hashSet)
            {
                Console.WriteLine(item);
            }
        }
    }

}
