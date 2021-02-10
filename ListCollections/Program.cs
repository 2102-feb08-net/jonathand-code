using System;
using System.Collections.Generic;

namespace ListCollections
{
    class Program
    {
        static void WorkingWithStrings()
        {
            var names = new List<string>{"Jonathan","Ana","Felipe"};
            foreach(string name in names)
            {
                Console.WriteLine($"Name: {name.ToUpper()}");
            }
            names.Add("Maria");
            names.Add("Bill");
            names.Remove("Ana");
            
            foreach(string name in names)
            {
                Console.WriteLine($"All Names: {name.ToUpper()}");
            }
            Console.WriteLine($"My name is {names[0]}");
            Console.WriteLine($"I've added {names[2]} and {names[3]} to the list");
            Console.WriteLine($"The list has {names.Count} people in it");

            var index = names.IndexOf("Felipe");
            if (index == -1)
            {
                Console.WriteLine($"When an item is not found, IndexOf returns {index}");
            }
            else
            {
                Console.WriteLine($"The name {names[index]} is at index {index}");
            }

            index = names.IndexOf("Not Found");
            if (index == -1)
            {
                    Console.WriteLine($"When an item is not found, IndexOf returns {index}");
            }
            else
            {
                Console.WriteLine($"The name {names[index]} is at index {index}");

            }
            
            names.Sort();
            foreach(string name in names)
            {
                Console.WriteLine($"Names: {name.ToUpper()}");
            }
        }

        static void Main(string[] args)
        {
            //WorkingWithStrings();
            var fibonacciNumbers = new List<int>{1,1};
            int previous1 = fibonacciNumbers[fibonacciNumbers.Count-1];
            int previous2 = fibonacciNumbers[fibonacciNumbers.Count-2];

            // fibonacciNumbers.Add(previous1 + previous2);

            // foreach(int item in fibonacciNumbers)
            // {
            //     Console.WriteLine(item);
            // }

            // Console.WriteLine(previous1);
            // Console.WriteLine(previous2);
            for(int i = 0; i < 18; i++)
            {
                int newNum = previous1 + previous2;
                // Console.WriteLine(newNum);
                previous1 = previous2;
                previous2 = newNum;
                fibonacciNumbers.Add(newNum);
            }
            foreach(int item in fibonacciNumbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
