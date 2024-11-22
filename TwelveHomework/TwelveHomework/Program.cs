namespace TwelveHomework;
using System;
using System.Collections.Generic;

public class Box<T>
{
    private T value;

    public void SetValue(T value)
    {
        this.value = value;
    }

    public T GetValue()
    {
        return value;
    }
}

public static class Utility
{
    public static int GetCount<T>(List<T> list)
    {
        return list.Count;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Box<int> intBox = new Box<int>();
        intBox.SetValue(123);
        Console.WriteLine($"Box<int> value: {intBox.GetValue()}");

        Box<string> stringBox = new Box<string>();
        stringBox.SetValue("Irakli");
        Console.WriteLine($"Box<string> value: {stringBox.GetValue()}");

        Box<double> doubleBox = new Box<double>();
        doubleBox.SetValue(7.8);
        Console.WriteLine($"Box<double> value: {doubleBox.GetValue()}");


        List<int> intList = new List<int> { 1, 2, 3, 4, 5 };
        Console.WriteLine($"Number of elements in intList: {Utility.GetCount(intList)}");

        List<string> stringList = new List<string> { "BA", "DEV", "QA" };
        Console.WriteLine($"Number of elements in stringList: {Utility.GetCount(stringList)}");

        List<double> doubleList = new List<double> { 1.8, 3.7, 12.3, 32.1 };
        Console.WriteLine($"Number of elements in doubleList: {Utility.GetCount(doubleList)}");
    }
}

