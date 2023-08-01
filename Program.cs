using System;
using System.Collections.Generic;
using System.Linq;

namespace New_folder__5_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter list of numbers");
            var numbers = Console.ReadLine().Split(" ").Select(x => Convert.ToInt32(x)).ToList();
            List<int> finalList = new List<int>();

            finalList = numbers
                .Select((n, i) => i % 2 == 0 && i < numbers.Count - 1 ? n + numbers[i + 1] : n)
                .ToList();


            // Output the elements of finalList
            foreach (int num in finalList)
            {
                Console.Write(num + " ");
            }
        }
    }
}
