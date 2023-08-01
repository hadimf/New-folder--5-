using System;
using System.Collections.Generic;
using System.Linq;

namespace New_folder__5_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
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
